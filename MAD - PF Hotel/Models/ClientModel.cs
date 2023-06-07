using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class ClientModel
    {
        public int Id_Client { get; set; }
        public string Full_Name { get; set; }
        public string Names { get; set; }
        public string Last_Name_One { get; set; }
        public string Last_Name_Two { get; set; }
        public string RFC { get; set; }
        public DateTime Date_Birth { get; set; }
        public string Marital_Status { get; set; }
        public string Email { get; set; }
        public string Reference { get; set; }

    }
}
