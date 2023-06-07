using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class AmenityModel
    {
        public int Id_Amenity { get; set; }
        public byte Gym { get; set; }
        public byte Wifi { get; set; }
        public byte Room_Service { get; set; }
        public byte Event_Room { get; set; }
        public byte Swimming_Pool { get; set; }
        public byte Massage { get; set; }
        public byte Restaurant { get; set; }
        public byte Taxi_Service { get; set; }
        //public int Id_hotel { get; set; }
    }
}
