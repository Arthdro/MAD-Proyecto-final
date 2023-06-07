using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class ReservationModel
    {
        public string Id_Reservation { get; set; }
        public int Id_Client { get; set; }
        public int Id_City { get; set; }
        public int Id_Hotel { get; set; }
        public int Id_Room { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public int Room_Number { get; set; }
        public int Id_Operator { get; set; }
        public float Subtotal { get; set; }
        public float IVA { get; set; }
        public float Total_Amount { get; set; }
        public float UpFront_Pay { get; set; }

    }
}
