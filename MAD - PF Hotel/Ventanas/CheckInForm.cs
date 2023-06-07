using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD___PF_Hotel.Ventanas
{
    public partial class CheckInForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        CheckInformationModel current_reserv = new CheckInformationModel();

        public CheckInForm()
        {
            InitializeComponent();
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            string reservation_value = txtboxResvervationID.Text;
            CheckInformationModel reservationInfo = new CheckInformationModel();
            reservationInfo = sqlConexion.GetReservationData(reservation_value);
            lblIDReserv.Text = reservationInfo.Id_Reservation.ToString();
            lblClientName.Text = reservationInfo.Client_Name;
            lblHotelName.Text = reservationInfo.Hotel_Name;
            lblLocation.Text = reservationInfo.Full_City_Name;
            lblRoomName.Text = reservationInfo.Room_Name;
            lblQuantityRooms.Text = reservationInfo.Room_Number.ToString();
            lblBedQuantity.Text = reservationInfo.Bed_Quantity.ToString();
            lblPeopleQuantity.Text = reservationInfo.People_Quantity.ToString();
            lblPricePerNight.Text = reservationInfo.Price_x_night.ToString();
            lblCheckIn.Text = reservationInfo.Check_In.ToString("dd/MM/yyyy");
            lblCheckOut.Text = reservationInfo.Check_Out.ToString("dd/MM/yyyy");
            lblSubtotal.Text = reservationInfo.Subtotal.ToString();
            lblIVA.Text = reservationInfo.IVA_cost.ToString();
            lblTotalAmount.Text = reservationInfo.Total_Amount.ToString();
            lblReservationStatus.Text = reservationInfo.Status_Name;
            current_reserv = reservationInfo;
            return;
        }

        private void btnCheckInRe_Click(object sender, EventArgs e)
        {
            //if (sqlConexion.GetReservationForCheckIn(current_reserv.Id_Reservation))
            //{
                
            //}
            //else
            //{

            //}
        }
    }
}
