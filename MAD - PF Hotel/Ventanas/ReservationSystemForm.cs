using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD___PF_Hotel
{
    public partial class ReservationSystemForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        int aux_id_client = 0;
        int aux_id_hotel = 0;
        int aux_id_room = 0;
        float aux_subtotal = 0f;
        float aux_impuesto = 0f;
        float total_amount = 0f;
        float iva = 0.16f;
        float subtotal = 0;
        float impuesto = 0;
        float total = 0;
        DateTime Begin_Operations;
        DateTime Current_date;
        public ReservationSystemForm()
        {
            InitializeComponent();
            cmboxSearchCity.DataSource = sqlConexion.FillCitiesBox(null);
            cmboxSearchCity.DisplayMember = "FULL_CITY_NAME";
            cmboxSearchCity.ValueMember = "ID_CITY";
            cmboxSearchCity.Enabled = false;
            dtpCheckIn.Enabled = false;
            dtpCheckOut.Enabled = false;
            btnSaveReserv.Enabled = false;
            btnCancelOperation.Enabled = false;
            btnCheckAvailability.Enabled = false;
            cBoxPaymentMethod.Enabled = false;
            UpDownPeople.Enabled = false;
            cBoxPaymentMethod.DisplayMember = "Text";
            cBoxPaymentMethod.ValueMember = "Value";

            cBoxPaymentMethod.Items.Add(new { Text = "Credit Card", Value = "0" });
            cBoxPaymentMethod.Items.Add(new { Text = "Debit Card", Value = "1" });
            cBoxPaymentMethod.Items.Add(new { Text = "SPEI Transfer", Value = "2" });
            //cmboxClientInfo.Enabled = false;

            //cmboxHotel.Enabled = false;

            //dgvSelectHotel.DataSource = sqlConexion.GetHotels();
        }

        private void CancelReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            ReservationModel new_reservation = new ReservationModel();


            Guid guid = Guid.NewGuid();
            new_reservation.Id_Reservation = guid.ToString();
            new_reservation.Id_Client = int.Parse(cmboxClientInfo.SelectedValue.ToString());
            new_reservation.Id_Room = aux_id_room;
            new_reservation.Id_City = int.Parse((string)cmboxSearchCity.SelectedValue);
            new_reservation.Id_Hotel = aux_id_hotel;
            new_reservation.Check_In = dtpCheckIn.Value;
            new_reservation.Check_Out = dtpCheckOut.Value;
            new_reservation.People_Quantity = Convert.ToInt32(UpDownPeople.Value);
            new_reservation.Subtotal = subtotal;
            new_reservation.IVA = impuesto;
            new_reservation.Total_Amount = total;
            new_reservation.UpFront_Pay = total/2;
            new_reservation.Type_Payment = cBoxPaymentMethod.Text;
            new_reservation.Check_In.ToString("dd/MM/yyyy");
            new_reservation.Check_Out.ToString("dd/MM/yyyy");

            
            int disponibilidad = sqlConexion.CheckDisponibility(new_reservation);

            if (disponibilidad == 0 || DateVerification() != 0)
            {
                int resultUser = sqlConexion.SetReservation(new_reservation, current_session);
                this.Close();
                MessageBox.Show("The reservation was added. The reservation code is:" + guid);
            }
            else
            {
                MessageBox.Show("The room is already reserved on those days" );
            }
        }

        private void cmboxSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmboxSearchCity.SelectedIndex;
            if (index == 0)
            {
                return;
            }
            else
            {
                string selectedValue = (string)cmboxSearchCity.SelectedValue;
                dgvSelectHotel.DataSource = sqlConexion.GetHotels(selectedValue);
                dgvSelectHotel.Columns["ID_HOTEL"].Visible = false;
                dgvSelectHotel.Columns["ID_CITY"].Visible = false;
            }
            return;
        }

        private void dgvSelectHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSelectHotel.Rows[e.RowIndex];
                value = row.Cells["ID_HOTEL"].Value.ToString();
                Begin_Operations = sqlConexion.GetBeginOperations(int.Parse(value));
                Current_date = sqlConexion.GetCurrentDate();
                dgvSelectRoom.DataSource = sqlConexion.GetRoomTypes(value);
                if (dgvSelectRoom.DataSource == null)
                {
                    MessageBox.Show("Theres no rooms on this hotel.");
                }
                else
                {
                    dgvSelectRoom.Columns["ID_ROOM"].Visible = false;
                    aux_id_hotel = int.Parse(value);
                    return;
                }            
                
            }
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
                lblUpfrontPay.Text = "$ " + (full_amount/2).ToString("0.00");
                cBoxPaymentMethod.Enabled = true;
                UpDownPeople.Maximum = selected_room.People_Quantity;
                UpDownPeople.Minimum = 1;
                UpDownPeople.Enabled = true;
                UpDownPeople.Value = selected_room.People_Quantity;
                btnCheckAvailability.Enabled = true;

                return;
            }
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (rbtnByName.Checked == true)
            {
                string texted_client = cmboxClientInfo.Text;
                List<ClientModel> searched_client = new List<ClientModel>();
                searched_client = sqlConexion.GetClientData(texted_client);
                if (searched_client.Count == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    return;
                }
                else
                {
                    cmboxClientInfo.DataSource = searched_client;
                    cmboxClientInfo.ValueMember = "ID_CLIENT";
                    cmboxClientInfo.DisplayMember = "FULL_NAME";
                    //aux_id_client = searched_client.Id_Client;
                    cmboxSearchCity.Enabled = true;
                    dtpCheckIn.Enabled = true;
                    dtpCheckOut.Enabled = true;
                    //noUDQuantity.Enabled = true;
                    btnSaveReserv.Enabled = true;
                    btnCancelOperation.Enabled = true;
                    return;
                }
            }
            else if (rbtnByEmail.Checked == true)
            {
                string texted_client = cmboxClientInfo.Text;
                ClientModel searched_client = new ClientModel();
                searched_client = sqlConexion.GetClientData(null, texted_client, null);
                if (searched_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    dtpCheckIn.Enabled = false;
                    dtpCheckOut.Enabled = false;
                    btnSaveReserv.Enabled = false;
                    btnCancelOperation.Enabled = false;
                    return;
                }
                else
                {
                    cmboxClientInfo.ValueMember = searched_client.Id_Client.ToString();
                    cmboxClientInfo.DisplayMember = searched_client.Names;
                    aux_id_client = searched_client.Id_Client;
                    cmboxSearchCity.Enabled = true;
                    dtpCheckIn.Enabled = true;
                    dtpCheckOut.Enabled = true;
                    //noUDQuantity.Enabled = true;
                    btnSaveReserv.Enabled = true;
                    btnCancelOperation.Enabled = true;
                    return;
                }
            }
            else if (rbtnByRFC.Checked == true)
            {
                string texted_client = cmboxClientInfo.Text;
                ClientModel searched_client = new ClientModel();
                searched_client = sqlConexion.GetClientData(null, null, texted_client);
                if (searched_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    dtpCheckIn.Enabled = false;
                    dtpCheckOut.Enabled = false;
                    btnSaveReserv.Enabled = false;
                    btnCancelOperation.Enabled = false;
                    return;
                }
                else
                {
                    cmboxClientInfo.ValueMember = searched_client.Id_Client.ToString();
                    cmboxClientInfo.DisplayMember = searched_client.Names;
                    aux_id_client = searched_client.Id_Client;
                    cmboxSearchCity.Enabled = true;
                    dtpCheckIn.Enabled = true;
                    dtpCheckOut.Enabled = true;
                   // noUDQuantity.Enabled = true;
                    btnSaveReserv.Enabled = true;
                    btnCancelOperation.Enabled = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select something");
                return;
            }
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        //private void noUDQuantity_ValueChanged(object sender, EventArgs e)
        //{
        //   //// int room = Convert.ToInt32(noUDQuantity.Value);
        //   // subtotal = aux_subtotal * room;
        //   // impuesto = subtotal * iva;       
        //   // total = subtotal + impuesto;

        //   // lblSubtotal.Text = "$ " + subtotal;
        //   // lblIVAprice.Text = "$ " + impuesto;
        //   // lblTotalAmount.Text = "$ " + total;
        //   // return;
        //}

        //private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime checkIn = dtpCheckIn.Value;
        //    DateTime checkOut = dtpCheckOut.Value;
        //    //TimeSpan difFechas = checkOut - checkIn;
        //    //int días = difFechas.Days;

        //}

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;
            TimeSpan difFechas = checkOut.Date - checkIn.Date;
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

        private void cmboxClientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
