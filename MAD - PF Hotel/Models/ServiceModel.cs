using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class ServiceModel
    {
        public int Id_Service { get; set; } = 0;
        public string Service_name { get; set; } = "";
        public string Service_descrtiption { get; set; } = "";
        public float Service_price { get; set; } = 0;
    }
}
