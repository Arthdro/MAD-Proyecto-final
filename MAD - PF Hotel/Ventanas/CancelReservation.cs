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
    public partial class CancelReservation : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        CheckInformationModel current_reserv = new CheckInformationModel();
        CheckInformationModel reservationInfo = new CheckInformationModel();
        public CancelReservation()
        {
            InitializeComponent();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {

                string reservation_value = txtboxResvervationID.Text;
                reservationInfo = sqlConexion.GetReservationData(reservation_value);
                lblIDReserv.Text = reservationInfo.Id_Reservation.ToString();
                lblClientName.Text = reservationInfo.Client_Name;
                lblHotelName.Text = reservationInfo.Hotel_Name;
                lblLocation.Text = reservationInfo.Full_City_Name;
                lblRoomName.Text = reservationInfo.Room_Name;
                lblRoomNumber.Text = reservationInfo.Room_Number.ToString();
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
        }
           

        private void btnC_Click(object sender, EventArgs e)
        {
            if (reservationInfo.Status_Name == "Canceled")
            {
                MessageBox.Show("La reservación ya fue cancelada.");
            }
            else
            {
                if (sqlConexion.SetReservationForCancelation(txtboxResvervationID.Text) == 1)
                {
                    MessageBox.Show("Cancelación exitosa.");
                    reservationInfo.Status_Name = "Canceled";
                }
                else
                {
                    MessageBox.Show("Hubo un error al cancelar la reservación.");
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }
    }
}
