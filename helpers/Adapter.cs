using Library.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.helpers
{
    public class Adapter
    {
        public static List<Book> convertToListOfBooks(SqlDataReader reader)
        {
            List<Book> listOfBooks = new List<Book>();
            using (reader)
            {
                while (reader.Read())
                {

                    Book book = new Book();
                    book.IdBook = reader.GetInt32(0);
                    book.Name = reader.GetString(1);
                    book.Author = reader.GetString(2);
                    book.YearPub = reader.GetDateTime(3);
                    book.Conditions = Book.resolveCondition(reader.GetString(4));
                    book.Price = reader.GetDecimal(5);
                    book.Quantity = reader.GetInt16(6);
                    book.ImageEncoded = reader.GetString(7);
                    listOfBooks.Add(book);
                }
            }
            return listOfBooks;
        }

        public static Image decodeImage(String encoded)
        {
            byte[] bytes = Convert.FromBase64String(encoded);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }
    }
}
