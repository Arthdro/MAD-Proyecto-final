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
    public partial class AddServicetoHotel : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        string value = "";
        string selectedValue = "";
        public AddServicetoHotel()
        {
            InitializeComponent();
            cmboxCity.DataSource = sqlConexion.FillCitiesBox(null);
            cmboxCity.DisplayMember = "FULL_CITY_NAME";
            cmboxCity.ValueMember = "ID_CITY";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (sqlConexion.SetService(null, txtboxServiceName.Text, txtboxServiceDescrp.Text, 
                float.Parse(txtboxPrice.Text), int.Parse(value), current_session))
            {
                MessageBox.Show("Servicio agregado exitosamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El servicio no pudo ser agregado.");
            }
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void cmboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            int index = cmboxCity.SelectedIndex;
            if (index == 0)
            {
                return;
            }
            else
            {
                selectedValue = (string)cmboxCity.SelectedValue;
                dgvHotelInfo.DataSource = sqlConexion.GetHotels(selectedValue);

                if (dgvHotelInfo.Rows.Count == 0)
                {
                    MessageBox.Show("This city doesn't have hotels.");
                    return;
                }
                else
                {
                    dgvHotelInfo.Columns["ID_HOTEL"].Visible = false;
                    dgvHotelInfo.Columns["ID_CITY"].Visible = false;
                    return;
                }
            }
            return;
        }

        private void dgvHotelInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvHotelInfo.Rows[e.RowIndex];
                value = row.Cells["ID_HOTEL"].Value.ToString();
                return;
            }
        }
    }
}
