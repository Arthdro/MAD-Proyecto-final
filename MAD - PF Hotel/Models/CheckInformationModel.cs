using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class CheckInformationModel
    {
        public string Id_Reservation { get; set; }
        public string Client_Name { get; set; } = "";
        public int Id_Room { get; set; }
        public string Room_Name { get; set; } = "";
        public int People_Quantity { get; set; }
        public int Bed_Quantity { get; set; }
        public float Price_x_night { get; set; } = 0;
        public string Full_City_Name { get; set; } = "";
        public int Id_Hotel { get; set; }
        public string Hotel_Name { get; set; } = "";
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public int Room_Number { get; set; }
        public float Subtotal { get; set; } = 0;
        public float IVA_cost { get; set; } = 0;
        public float Total_Amount { get; set; } = 0;
        public float Upfront_Pay { get; set; } = 0;
        public string Status_Name { get; set; } = "";
    }
}
