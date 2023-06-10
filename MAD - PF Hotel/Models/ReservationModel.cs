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
        public string Client_Name { get; set; }
        public int Id_City { get; set; }
        public string City_Name { get; set; }
        public int Id_Hotel { get; set; }
        public string Hotel_Name { get; set; }
        public int Id_Room { get; set; }
        public int Room_Number { get; set; }
        public int People_Quantity { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }   
        public int Id_Operator { get; set; }
        public float Subtotal { get; set; }
        public float IVA { get; set; }
        public float Total_Amount { get; set; }
        public float UpFront_Pay { get; set; }
        public int Bed_Quantity { get; set; }
        public string Type_Payment { get; set; }
        public float Price_x_night { get; set; } = 0;
        public string Status_Name { get; set; } = "";

    }
}
