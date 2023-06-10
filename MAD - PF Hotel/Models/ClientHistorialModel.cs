using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class ClientHistorialModel
    {
        public string client_name { get; set; }
        public string city_name { get; set; }
        public string hotel_name { get; set; }
        public string room_type { get; set; }
        public int room_number { get; set; }
        public int people_quantity { get; set; }
        public string id_reservation { get; set; }
        public DateTime reserv_date { get; set; }
        public DateTime check_in { get; set; }
        public DateTime check_out { get; set; }
        public string nombre_estatus { get; set; }
        public float pago_anticipo { get; set; }
        public float monto_hospedaje { get; set; }

        //public string client_name { get; set; }
        public float total_factura { get; set; }

    }
}
