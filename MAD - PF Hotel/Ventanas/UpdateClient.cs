using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD___PF_Hotel
{
    public partial class UpdateClient : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        List<ClientModel> client_list = new List<ClientModel>();
        ClientModel updated_client = new ClientModel();     
        AddressModel updated_address = new AddressModel();
        PhoneModel updated_phone = new PhoneModel();
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            updated_client.Full_Name = txtboxFN.Text + ' ' + txtboxLNO.Text + ' ' + txtboxLNT.Text;
            updated_client.Names = txtboxFN.Text;
            updated_client.Last_Name_One = txtboxLNO.Text;
            updated_client.Last_Name_Two = txtboxLNT.Text;
            updated_client.RFC = txtboxRFC.Text;
            updated_client.Marital_Status = txtboxMaritalStatus.Text;
            updated_client.Date_Birth = dtpDateBirthC.Value;
            updated_client.Email = txtboxEmailClient.Text;
            updated_client.Reference = txtboxReferenceClient.Text;

            updated_address.Street_Name = txtboxStreetClient.Text;
            updated_address.House_Number = txtboxHouseNClient.Text;
            updated_address.Suburb_Name = txtboxSuburbClient.Text;
            updated_address.Zip_Code = txtboxZipCodeClient.Text;

            updated_phone.Phone_Number = txtboxHousePhoneClient.Text;
            updated_phone.Cellphone_Number = txtboxCellPhoneClient.Text;

            if (ClientValidation(updated_client) || AddressValidation(updated_address) || PhoneValidation(updated_phone))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else if (!EmailValidation(updated_client.Email))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 carácteres, mayúsculas, minúsculas y números.");
            }
            else
            {
                int resultHotel = sqlConexion.SetClient(updated_client, updated_address, updated_phone, current_session);

                if (resultHotel == 1)
                {
                    this.Hide();
                    MessageBox.Show("The operator fue agregado a la base de datos.");
                }
                else
                {
                    MessageBox.Show("The email or password are invalid");
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var message = "Yes or No?";
            var title = "Hey!";
            var result = MessageBox.Show(
                message,                  // the message to show
                title,                    // the title for the dialog box
                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                MessageBoxIcon.Question); // show a question mark icon

            // the following can be handled as if/else statements as well
            switch (result)
            {
                case DialogResult.Yes:   // Yes button pressed
                    if (sqlConexion.DeleteClient(updated_client.Id_Client, current_session) == 1)
                    {
                        MessageBox.Show("El hotel fue borrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la acción.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case DialogResult.No:    // No button pressed
                    //MessageBox.Show("You pressed No!");
                    break;
                default:                 // Neither Yes nor No pressed (just in case)
                    //MessageBox.Show("What did you press?");
                    break;
            }
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (rbtnByName.Checked == true)
            {
                string texted_client = cmboxClient.Text;
                cmboxClient.DataSource = sqlConexion.GetClientsData(texted_client);
                if (cmboxClient.DataSource == null)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    return;
                }
                else
                {
                    //cmboxClient.DataSource = client_list;
                    cmboxClient.DisplayMember = "FULL_NAME";
                    cmboxClient.ValueMember = "ID_CLIENT";
                    //cmboxClient.Items.Insert(0, "--- Select ---");
                    return;
                }
            }
            else if (rbtnByEmail.Checked == true)
            {
                string texted_client = cmboxClient.Text;
                updated_client = sqlConexion.GetClientData(null, texted_client, null);
                if (updated_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    return;
                }
                else
                {
                    txtboxFN.Text = updated_client.Names;
                    txtboxLNO.Text = updated_client.Last_Name_One;
                    txtboxLNT.Text = updated_client.Last_Name_Two;
                    txtboxRFC.Text = updated_client.RFC;
                    txtboxMaritalStatus.Text = updated_client.Marital_Status;
                    dtpDateBirthC.Value = updated_client.Date_Birth;
                    txtboxEmailClient.Text = updated_client.Email;
                    txtboxReferenceClient.Text = updated_client.Reference;
                    //AddressModel searched_address = new AddressModel();
                    updated_address = sqlConexion.GetAddresstData(updated_client.Id_Client);
                    //PhoneModel searched_phone = new PhoneModel();
                    updated_phone = sqlConexion.GetPhoneData(updated_client.Id_Client);

                    txtboxStreetClient.Text = updated_address.Street_Name;
                    txtboxHouseNClient.Text = updated_address.House_Number;
                    txtboxSuburbClient.Text = updated_address.Suburb_Name;
                    txtboxZipCodeClient.Text = updated_address.Zip_Code;

                    txtboxHousePhoneClient.Text = updated_phone.Phone_Number;
                    txtboxCellPhoneClient.Text = updated_phone.Cellphone_Number;
                    return;
                }
            }
            else if (rbtnByRFC.Checked == true)
            {
                string texted_client = cmboxClient.Text;
                updated_client = sqlConexion.GetClientData(null, null, texted_client);
                if (updated_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    return;
                }
                else
                {
                    txtboxFN.Text = updated_client.Names;
                    txtboxLNO.Text = updated_client.Last_Name_One;
                    txtboxLNT.Text = updated_client.Last_Name_Two;
                    txtboxRFC.Text = updated_client.RFC;
                    txtboxMaritalStatus.Text = updated_client.Marital_Status;
                    dtpDateBirthC.Value = updated_client.Date_Birth;
                    txtboxEmailClient.Text = updated_client.Email;
                    txtboxReferenceClient.Text = updated_client.Reference;
                    //AddressModel searched_address = new AddressModel();
                    updated_address = sqlConexion.GetAddresstData(updated_client.Id_Client);
                    //PhoneModel searched_phone = new PhoneModel();
                    updated_phone = sqlConexion.GetPhoneData(updated_client.Id_Client);

                    txtboxStreetClient.Text = updated_address.Street_Name;
                    txtboxHouseNClient.Text = updated_address.House_Number;
                    txtboxSuburbClient.Text = updated_address.Suburb_Name;
                    txtboxZipCodeClient.Text = updated_address.Zip_Code;

                    txtboxHousePhoneClient.Text = updated_phone.Phone_Number;
                    txtboxCellPhoneClient.Text = updated_phone.Cellphone_Number;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select something");
                return;
            }
        }

        private bool ClientValidation(ClientModel aux_model)
        {
            if (aux_model.Names == null || aux_model.RFC == null || aux_model.Email == null ||
                aux_model.Date_Birth == null || aux_model.Marital_Status == null || aux_model.Reference == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool AddressValidation(AddressModel aux_model)
        {
            if (aux_model.Street_Name == null || aux_model.House_Number == null ||
                aux_model.Suburb_Name == null || aux_model.Zip_Code == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PhoneValidation(PhoneModel aux_model)
        {
            if (aux_model.Phone_Number == null || aux_model.Cellphone_Number == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EmailValidation(string aux_user)
        {
            var emailFormat = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            bool isValidated = emailFormat.IsMatch(aux_user);
            return isValidated;
        }

        private void txtboxFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxMaritalStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxStreetClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxSuburbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 57 && e.KeyChar <= 64) ||
                (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Formato no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHouseNClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 57 && e.KeyChar <= 64) ||
               (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Formato no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxZipCodeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHousePhoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxCellPhoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmboxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmboxClient.SelectedIndex;
            if (index == 0)
            {
                return;
            }
            else
            {
                int id_client = int.Parse(cmboxClient.SelectedValue.ToString());
                //string texted_client = cmboxClient.Text;
                updated_client = sqlConexion.GetClientData(id_client, null, null);
                if (updated_client.Id_Client == 0)
                {
                    MessageBox.Show("There´s no client with that RFC.");
                    return;
                }
                else
                {
                    txtboxFN.Text = updated_client.Names;
                    txtboxLNO.Text = updated_client.Last_Name_One;
                    txtboxLNT.Text = updated_client.Last_Name_Two;
                    txtboxRFC.Text = updated_client.RFC;
                    txtboxMaritalStatus.Text = updated_client.Marital_Status;
                    dtpDateBirthC.Value = updated_client.Date_Birth;
                    txtboxEmailClient.Text = updated_client.Email;
                    txtboxReferenceClient.Text = updated_client.Reference;
                    //AddressModel searched_address = new AddressModel();
                    updated_address = sqlConexion.GetAddresstData(updated_client.Id_Client);
                    //PhoneModel searched_phone = new PhoneModel();
                    updated_phone = sqlConexion.GetPhoneData(updated_client.Id_Client);

                    txtboxStreetClient.Text = updated_address.Street_Name;
                    txtboxHouseNClient.Text = updated_address.House_Number;
                    txtboxSuburbClient.Text = updated_address.Suburb_Name;
                    txtboxZipCodeClient.Text = updated_address.Zip_Code;

                    txtboxHousePhoneClient.Text = updated_phone.Phone_Number;
                    txtboxCellPhoneClient.Text = updated_phone.Cellphone_Number;
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
