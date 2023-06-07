using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class HotelModel
    {
        public int Id_Hotel { get; set; } = 0;
        public string Hotel_Name { get; set; } = "";
        public byte Number_Floors { get; set; } = 0;
        public short Number_Rooms { get; set; } = 0;
        public short Available_Rooms { get; set; } = 0;
        public DateTime Begin_Operations { get; set; }
    }
}
