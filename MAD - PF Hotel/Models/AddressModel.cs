using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class AddressModel
    {
        public int Id_Address { get; set; }
        public string Street_Name { get; set; } = "";
        public string House_Number { get; set; } = "";
        public string Suburb_Name { get; set; } = "";
        public string Zip_Code { get; set; } = "";
    }
}
