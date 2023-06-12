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
        int aux_id_hotel = 0;
        DateTime aux_checkOut;
        float aux_subtotal = 0f;
        float aux_impuesto = 0f;
        float total_amount = 0f;
        float reser_subtotal = 0f;
        float reser_impuesto = 0f;
        float reser_total_amount = 0f;
        float iva = 0.16f;
        float subtotal = 0;
        float impuesto = 0;
        float total = 0;
        DateTime Begin_Operations;
        DateTime Current_date;

        RoomModel selected_room = new RoomModel();
        public ExtendReservationForm()
        {
            InitializeComponent();
            Current_date = sqlConexion.GetCurrentDate();
            dtpCheckIn.Enabled = false;
            cBoxPaymentMethod.DisplayMember = "Text";
            cBoxPaymentMethod.ValueMember = "Value";

            cBoxPaymentMethod.Items.Add(new { Text = "Credit Card", Value = "0" });
            cBoxPaymentMethod.Items.Add(new { Text = "Debit Card", Value = "1" });
            cBoxPaymentMethod.Items.Add(new { Text = "SPEI Transfer", Value = "2" });
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

            if (reserv_searched.Id_Reservation == null || reserv_searched.Status_Name == "Active")
            {
                MessageBox.Show("Reservation not founded.");
                return;
            }
            else
            {
                lblHotelName.Text = reserv_searched.Hotel_Name;
                lblClientName.Text = reserv_searched.Client_Name;
                lblRoomName.Text = reserv_searched.Room_Name;
                dtpCheckIn.Value = reserv_searched.Check_In;
                dtpCheckOut.Value = reserv_searched.Check_Out;
                aux_checkOut = reserv_searched.Check_Out;
                lblSubtotal.Text = "$ " + (reserv_searched.Subtotal / 2).ToString("0.00");
                reser_subtotal = reserv_searched.Subtotal / 2;
                lblIVAprice.Text = "$ " + (reserv_searched.IVA_cost / 2).ToString("0.00");
                reser_impuesto = reserv_searched.IVA_cost / 2;
                lblTotalAmount.Text = "$ " + (reserv_searched.Total_Amount / 2).ToString("0.00");
                reser_total_amount = reserv_searched.Total_Amount / 2;
                //lblUpfrontPay.Text = "$ " + (total / 2).ToString("0.00");


                dgvSelectRoom.DataSource = sqlConexion.GetRoomTypes(reserv_searched.Id_Hotel.ToString());
                dgvSelectRoom.Columns["ID_ROOM"].Visible = false;
                dgvSelectRoom.Columns["ID_HOTEL"].Visible = false;
                dgvSelectRoom.Columns["ID_BEDTYPE"].Visible = false;
                dgvSelectRoom.Columns["ID_ROOMLEVEL"].Visible = false;
                dgvSelectRoom.Columns["ID_AMENITYROOM"].Visible = false;
                Begin_Operations = sqlConexion.GetBeginOperations(reserv_searched.Id_Hotel);
                return;
            }
           
           
        }

        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            ReservationModel updated_reser = new ReservationModel();
            updated_reser.Id_Reservation = txtboxReservation.Text;
            updated_reser.Id_Room = aux_id_room;
            updated_reser.Check_Out = dtpCheckOut.Value;
            updated_reser.Room_Number = selected_room.Room_Number;
            updated_reser.Subtotal = subtotal;
            updated_reser.IVA = subtotal * iva;
            updated_reser.Total_Amount = total_amount;
            updated_reser.Type_Payment = cBoxPaymentMethod.Text;

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
                
                selected_room = sqlConexion.GetSelectedRoom(value);
                lblSubtotal.Text = "$ " + selected_room.Price_Night.ToString("0.00");
                aux_subtotal = selected_room.Price_Night;
                full_amount = selected_room.Price_Night * iva;
                lblIVAprice.Text = "$ " + (full_amount).ToString("0.00");
                impuesto = (float)full_amount;
                full_amount = full_amount + selected_room.Price_Night;
                total = (float)full_amount;
                lblTotalAmount.Text = "$ " + (full_amount).ToString("0.00");
                lblAmountOfPeople.Text = selected_room.People_Quantity.ToString();
                lblAmountOfBeds.Text = selected_room.Bed_Quantity.ToString();
                lblUpfrontPay.Text = "$ " + (full_amount).ToString("0.00");
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

            subtotal = (aux_subtotal * días) + reser_subtotal;
            impuesto = (aux_subtotal * iva) + reser_impuesto;
            total = impuesto + reser_total_amount;

            lblSubtotal.Text = "$ " + subtotal.ToString("0.00");
            lblIVAprice.Text = "$ " + impuesto.ToString("0.00");
            lblTotalAmount.Text = "$ " + total.ToString("0.00");
            lblUpfrontPay.Text = "$ " + (total / 2).ToString("0.00");
            return;
        }

        private int DateVerification()
        {
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;
            if (checkIn.Date < Begin_Operations.Date || checkOut.Date < Begin_Operations.Date
                || checkIn.Date > checkOut.Date || checkOut.Date < checkIn.Date ||
                checkIn.Date < Current_date.Date || checkOut.Date < Current_date.Date)
            {

                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
