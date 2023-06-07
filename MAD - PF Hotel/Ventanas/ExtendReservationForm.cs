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
    public partial class ExtendReservationForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        int aux_id_room = 0;
        DateTime aux_checkOut;
        float aux_subtotal = 0f;
        float aux_impuesto = 0f;
        float total_amount = 0f;
        float iva = 0.16f;
        float subtotal = 0;
        float impuesto = 0;
        float total = 0;
        public ExtendReservationForm()
        {
            InitializeComponent();
            dtpCheckIn.Enabled = false;
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void btnSearchReserv_Click(object sender, EventArgs e)
        {
            string reserv_code = txtboxReservation.Text;
            CheckInformationModel reserv_searched = new CheckInformationModel();
            reserv_searched = sqlConexion.GetReservationData(reserv_code);

            lblHotelName.Text = reserv_searched.Hotel_Name;
            lblClientName.Text = reserv_searched.Client_Name;
            lblRoomName.Text = reserv_searched.Room_Name;
            dtpCheckIn.Value = reserv_searched.Check_In;
            dtpCheckOut.Value = reserv_searched.Check_Out;
            aux_checkOut = reserv_searched.Check_Out;

            dgvSelectRoom.DataSource = sqlConexion.GetRoomTypes(reserv_searched.Id_Hotel.ToString());
            dgvSelectRoom.Columns["ID_ROOM"].Visible = false;

            return;
        }

        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            ReservationModel updated_reser = new ReservationModel();
            updated_reser.Id_Reservation = txtboxReservation.Text;
            updated_reser.Id_Room = aux_id_room;
            updated_reser.Check_Out = dtpCheckOut.Value;
            //updated_reser.Room_number = "";
            updated_reser.Subtotal = float.Parse(lblSubtotal.Text);
            updated_reser.IVA = float.Parse(lblIVAprice.Text);
            updated_reser.Total_Amount = float.Parse(lblTotalAmount.Text);

            int disponibilidad = sqlConexion.CheckDisponibility(updated_reser);

            if (disponibilidad == 0)
            {
                int resultUser = sqlConexion.SetReservation(updated_reser, current_session);
                this.Close();
                MessageBox.Show("The reservation was added.");
            }
            else
            {
                MessageBox.Show("The email or password are invalid");
            }
            //updated_reser.Id_Room = 
        }

        private void dgvSelectRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";
            double full_amount = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSelectRoom.Rows[e.RowIndex];
                value = row.Cells["ID_ROOM"].Value.ToString();
                aux_id_room = int.Parse(value);
                RoomModel selected_room = new RoomModel();
                selected_room = sqlConexion.GetSelectedRoom(value);
                lblSubtotal.Text = "$ " + selected_room.Price_Night.ToString("0.00");
                aux_subtotal = selected_room.Price_Night;
                full_amount = selected_room.Price_Night * iva;
                lblIVAprice.Text = "$ " + (full_amount).ToString("0.00");
                aux_impuesto = (float)full_amount;
                full_amount = full_amount + selected_room.Price_Night;
                total_amount = (float)full_amount;
                lblTotalAmount.Text = "$ " + (full_amount).ToString("0.00");
                lblAmountOfPeople.Text = selected_room.People_Quantity.ToString();
                lblAmountOfBeds.Text = selected_room.Bed_Quantity.ToString();
                lblUpfrontPay.Text = "$ " + (full_amount / 2).ToString("0.00");
                cBoxPaymentMethod.Enabled = true;
                lblRoomNumber.Text = selected_room.Room_Number.ToString();
                return;
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            DateTime checkOut = dtpCheckOut.Value;
            TimeSpan difFechas = checkOut.Date - aux_checkOut.Date;
            int días = difFechas.Days;

            subtotal = aux_subtotal * días;
            impuesto = subtotal * iva;
            total = subtotal + impuesto;

            lblSubtotal.Text = "$ " + subtotal.ToString("0.00");
            lblIVAprice.Text = "$ " + impuesto.ToString("0.00");
            lblTotalAmount.Text = "$ " + total.ToString("0.00");
            lblUpfrontPay.Text = "$ " + (total / 2).ToString("0.00");
            return;
        }
    }
}
