using Library.dto;
using Library.helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.database
{
    public class DatabaseManager
    {
        private static string connectionString = @"Data Source=EN410884\SQLEXPRESS;Initial Catalog=Library;User ID=appReader;Password=password_1234";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void testConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Book> readAllfromBook()
        {
            SqlCommand command = new SqlCommand("Select * from Book", connection);
            try
            {
                connection.Open();
                return Adapter.convertToListOfBooks(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books", ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<Book> readByTitleFromBook(String condition)
        {
            SqlCommand command = new SqlCommand(String.Format("Select * from Book where name_book like N'%{0}%'", condition), connection);
            try
            {
                connection.Open();
                return Adapter.convertToListOfBooks(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books", ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public static List<Book> readByIdFromBook(String condition)
        {
            SqlCommand command = new SqlCommand(String.Format("Select * from Book where id_book like N'%{0}%'", condition), connection);
            try
            {
                connection.Open();
                return Adapter.convertToListOfBooks(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books", ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<Book> readByTitleWithOrderFromBook(String condition, String order)
        {
            SqlCommand command = new SqlCommand(String.Format("Select * from Book where name_book like N'%{0}%' {1}", condition, order), connection);
            try
            {
                connection.Open();

                return Adapter.convertToListOfBooks(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books", ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static List<Book> readTop3MostSaledBooks(String ascOrDesc)
        {
            SqlCommand command = new SqlCommand(String.Format("Select TOP 3 Count(*) as quantity, id_book " +
                "from Issue " +
                "Group By id_book " +
                " Order by quantity {0}",ascOrDesc), connection);

            List<Book> books = new List<Book>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<String> result = new List<String>();
                using (reader)
                {
                    while (reader.Read())
                    {

                      result.Add(reader.GetInt32(1).ToString());

                    }
                }
                connection.Close();
               foreach(String res in result)
                {
                    books.Add(readByIdFromBook(res)[0]);
                }
                return books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books", ex.Message);
                throw ex;
            }
            finally
            {
               
            }

        }

        public static String getIncomeForTime(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand(String.Format(
                "select Sum(price) as income "+
                " from issue join book on issue.id_book = Book.id_book " +
                "where issue_date > '{0}-{1}-{2} 00:00:00.000'" +
                " and issue_date < '{3}-{4}-{5} 00:00:00.000'",start.Year,start.Month,start.Day, end.Year, end.Month, end.Day), connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        return reader.GetDecimal(0).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving books.\nOr no Income was found for specified period", ex.Message);
            
            }
            finally
            {
                connection.Close();
            }
            return "0";
        }
    }
}
