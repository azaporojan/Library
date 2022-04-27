using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.dto
{
    public class Book
    {
        private int idBook;
        private string name;
        private string author;
        private DateTime yearPub;
        private Conditions condition;
        private decimal price;
        private short quantity;
        private string imageEncoded;

        public Book()
        {
        }

        public Book(int idBook, string name, string author, DateTime yearPub, string idCondition, decimal price, short quantity, string imageEncoded)
        {
            this.IdBook = idBook;
            this.Name = name;
            this.Author = author;
            this.YearPub = yearPub;
            this.Conditions = resolveCondition(idCondition);
            this.Price = price;
            this.Quantity = quantity;
            this.ImageEncoded = imageEncoded;
        }

        public static Conditions resolveCondition(string idCondition)
        {
            switch (idCondition)
            {
                case "sost1": return Conditions.Excelent;
                case "sost2": return Conditions.Good;
                case "sost3": return Conditions.Satisfactory;
                case "sost4": return Conditions.Unsuitable;

                default: throw new ArgumentException("Provided condition is not valid!");
            }
        }
        public int IdBook { get => idBook; set => idBook = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public DateTime YearPub { get => yearPub; set => yearPub = value; }
        public Conditions Conditions { get => condition; set => condition = value; }
        public decimal Price { get => price; set => price = value; }
        public short Quantity { get => quantity; set => quantity = value; }
        public string ImageEncoded { get => imageEncoded; set => imageEncoded = value; }

        public string getString()
        {
            return String.Format("\n{0}, \n{1},\n{2}.{3}.{4},\n{5},\n{6},\n\nQuantity {7}, ", Name, author, YearPub.Day, YearPub.Month, YearPub.Year, Conditions, price, quantity);
        }
    }
}
