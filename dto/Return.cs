using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.dto
{
    public class Return
    {
        private int idSubcr;
        private DateTime dateReturn;
        private int idBook;
        private string imageReturnBook;

        public Return(int idSubcr, DateTime dateReturn, int idBook, string imageReturnBook)
        {
            this.IdSubcr = idSubcr;
            this.DateReturn = dateReturn;
            this.IdBook = idBook;
            this.ImageReturnBook = imageReturnBook;
        }

        public int IdSubcr { get => idSubcr; set => idSubcr = value; }
        public DateTime DateReturn { get => dateReturn; set => dateReturn = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public string ImageReturnBook { get => imageReturnBook; set => imageReturnBook = value; }
    }
}
