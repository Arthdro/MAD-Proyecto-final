using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class RoomModel
    {
        //public int Id_City { get; set; }
        public int Id_Room{ get; set; }
        public string Room_Name { get; set; }
        public int Id_BedType { get; set; }
        public int People_Quantity { get; set; }
        public int Bed_Quantity { get; set; }
        public int Room_Number { get; set; }
        public int Id_Room_Level { get; set; }
        public float Price_Night { get; set; }  
        public float Discount { get; set; }
        public float Size { get; set; }
        public int Id_Hotel { get; set; }


    }
}
