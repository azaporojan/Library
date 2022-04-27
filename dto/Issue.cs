using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.dto
{
    public class Issue
    {
        private int idSubcr;
        private DateTime issueDate;
        private int idBook;
        private string imageIssuedBookEncoded;

        public Issue(int idSubcr, DateTime issueDate, int idBook, string imageIssuedBookEncoded)
        {
            this.IdSubcr = idSubcr;
            this.IssueDate = issueDate;
            this.IdBook = idBook;
            this.ImageIssuedBookEncoded = imageIssuedBookEncoded;
        }

        public int IdSubcr { get => idSubcr; set => idSubcr = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public string ImageIssuedBookEncoded { get => imageIssuedBookEncoded; set => imageIssuedBookEncoded = value; }
    }
}
