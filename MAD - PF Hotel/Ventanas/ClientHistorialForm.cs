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
    public partial class ClientHistorialForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        public ClientHistorialForm()
        {
            InitializeComponent();
            cmBoxYear.Enabled = false;
            btnShowHistorial.Enabled = false;
            cmBoxYear.DisplayMember = "Text";
            cmBoxYear.ValueMember = "Value";

            cmBoxYear.Items.Add(new {Text = "Choose a year", Value = "0" });
            for (int i = 2000; i <= 2023; i++)
            {
                cmBoxYear.Items.Add(new {Text = i.ToString(), Value = i.ToString()});
            }

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (rbtnByName.Checked == true)
            {
                string texted_client = cmBoxClientHistory.Text;
                List<ClientModel> searched_client = new List<ClientModel>();
                searched_client = sqlConexion.GetClientData(texted_client);
                if (searched_client.First() == null)
                {
                    MessageBox.Show("There´s no client with that name.");
                    cmBoxYear.Enabled = false;
                    btnShowHistorial.Enabled = false;
                    return;
                }
                else
                {
                    cmBoxClientHistory.DataSource = searched_client;
                    cmBoxClientHistory.ValueMember = "ID_CLIENT";
                    cmBoxClientHistory.DisplayMember = "FULL_NAME";
                    cmBoxYear.Enabled = true;
                    btnShowHistorial.Enabled = true;
                    ////aux_id_client = searched_client.Id_Client;
                    //cmboxSearchCity.Enabled = true;
                    return;
                }
            }
            else if (rbtnByEmail.Checked == true)
            {
                string texted_client = cmBoxClientHistory.Text;
                ClientModel searched_client = new ClientModel();
                searched_client = sqlConexion.GetClientData(null, texted_client, null);
                if (searched_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that email.");
                    cmBoxYear.Enabled = false;
                    btnShowHistorial.Enabled = false;
                    return;
                }
                else
                {
                    //cmBoxClientHistory.ValueMember = searched_client.Id_Client.ToString();
                    //cmBoxClientHistory.DisplayMember = searched_client.Names;
                    cmBoxYear.Enabled = true;
                    btnShowHistorial.Enabled = true;
                    //aux_id_client = searched_client.Id_Client;
                    //cmboxSearchCity.Enabled = true;
                    return;
                }
            }
            else if (rbtnByRFC.Checked == true)
            {
                string texted_client = cmBoxClientHistory.Text;
                ClientModel searched_client = new ClientModel();
                searched_client = sqlConexion.GetClientData(null, null, texted_client);
                if (searched_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that email.");
                    cmBoxYear.Enabled = false;
                    btnShowHistorial.Enabled = false;
                    return;
                }
                else
                {
                    //cmBoxClientHistory.ValueMember = searched_client.Id_Client.ToString();
                    //cmBoxClientHistory.DisplayMember = searched_client.Names;
                    cmBoxYear.Enabled = true;
                    btnShowHistorial.Enabled = true;
                    //aux_id_client = searched_client.Id_Client;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHistorial_Click(object sender, EventArgs e)
        {
            string client_data = cmBoxClientHistory.SelectedValue.ToString();
            string year = cmBoxYear.Text;
            string year_begin = SetDatesForQuery(year, 1);
            string year_close = SetDatesForQuery(year, 2);
            List<ClientHistorialModel> historial = new List<ClientHistorialModel>();
            historial = sqlConexion.GetClientHistorial(client_data, year_begin, year_close);

            if (historial.Count() == 0)
            {
                MessageBox.Show("This customer has not historial yet.");
            }
            else
            {
                foreach (var item in historial)
                {
                    dgwClientHitorial.DataSource = historial;
                }
            }


        }

        private string SetDatesForQuery(string aux, int aux_number)
        {
            if (aux_number == 1)
            {
                return (aux + "/01/01");
            }
            else
            {
                return (aux + "/12/31");
            }
        }
    }
}
