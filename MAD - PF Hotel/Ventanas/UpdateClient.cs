﻿using MAD___PF_Hotel.ConexionDB;
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

namespace MAD___PF_Hotel
{
    public partial class UpdateClient : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
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
                string texted_client = txtboxClient.Text;
                //ClientModel searched_client = new ClientModel();
                updated_client = sqlConexion.GetClientData(texted_client, null, null);
                if (updated_client.Id_Client == null)
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
            else if (rbtnByEmail.Checked == true)
            {
                string texted_client = txtboxClient.Text;
                //ClientModel searched_client = new ClientModel();
                updated_client = sqlConexion.GetClientData(null, texted_client, null);
                if (updated_client.Id_Client == null)
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
                string texted_client = txtboxClient.Text;
                //ClientModel searched_client = new ClientModel();
                updated_client = sqlConexion.GetClientData(null, null, texted_client);
                if (updated_client.Id_Client == null)
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

    }
}
