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
    public partial class SetServiceReservForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        CheckInformationModel current_reserv = new CheckInformationModel();
        CheckInformationModel reservationInfo = new CheckInformationModel();
        List<ServiceModel> added_service = new List<ServiceModel>();
        double subtotal = 0;
        double IVA = 0.16;
        double total_amount = 0;
        string selectedValue = "";
        public SetServiceReservForm()
        {
            InitializeComponent();
            serviceQuantity.Enabled = false;
            serviceQuantity.Minimum = 1;
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            string reservation_value = txtboxResvervationID.Text;

            reservationInfo = sqlConexion.GetReservationData(reservation_value);
            if (reservationInfo.Id_Reservation == null)
            {
                MessageBox.Show("The reservation code not match.");
            }
            else
            {
                lblIDReserv.Text = reservationInfo.Id_Reservation.ToString();
                lblClientName.Text = reservationInfo.Client_Name;
                added_service = sqlConexion.GetServiceData(reservationInfo.Id_Hotel);
                foreach (var item in added_service)
                {
                    cmboxServices.DisplayMember = "SERVICE_N";
                    cmboxServices.ValueMember = "ID_SERVICE";
                    cmboxServices.DataSource = added_service;
                }
               
                return;
            }
           
            
        }

        private void SetServiceReservForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSerivece_Click(object sender, EventArgs e)
        {
            SellModel new_sell = new SellModel();
            new_sell.Service_Use = Convert.ToInt32(serviceQuantity.Value);
            new_sell.Id_Reservation = txtboxResvervationID.Text;


        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void cmboxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmboxServices.SelectedIndex;
            ServiceModel added_service = new ServiceModel();
            if (index == 0)
            {
                return;
            }
            else
            {
                string selectedValue = cmboxServices.SelectedValue.ToString();
                added_service = sqlConexion.GetServiceData(selectedValue);
                serviceQuantity.Value = 1;
                lblPrice.Text = "$ " + added_service.Service_price;
                total_amount = added_service.Service_price;
                lblDescription.Text = added_service.Service_descrtiption;
                serviceQuantity.Enabled = true;
                //subtotal = added_service.Service_price;
                //total_amount = IVA * subtotal;

            }
            return;
        }

        private void serviceQuantity_ValueChanged(object sender, EventArgs e)
        {
            double precio_aprox = total_amount * (double)(serviceQuantity.Value);
            lblPrice.Text = "$ " + precio_aprox.ToString("0.##");
            return;
        }
    }
}
