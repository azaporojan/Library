using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.dto
{
    public class Subcription
    {
        private int idSubcription;
        private string IDNP;
        private string firstName;
        private string lastName;
        private string address;
        private string tel;
        public Subcription(int idSubcription, string iDNP, string firstName, string lastName, string address, string tel)
        {
            this.IdSubcription = idSubcription;
            IDNP1 = iDNP;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Tel = tel;
        }

        public int IdSubcription { get => idSubcription; set => idSubcription = value; }
        public string IDNP1 { get => IDNP; set => IDNP = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
