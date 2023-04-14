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
    public partial class AddClientForm : Form
    {
        Conexion sqlConexion = new Conexion();
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientModel new_client = new ClientModel();
            AddressModel new_address = new AddressModel();
            PhoneModel new_phone = new PhoneModel();

            new_client.Names = txtboxFN.Text;
            new_client.Last_Name_One = txtboxLNO.Text;
            new_client.Last_Name_Two = txtboxLNT.Text;
            new_client.Email = txtboxEmailClient.Text;
            new_client.RFC = byte.Parse(txtboxRFC.Text);
            new_client.Marital_Status = txtboxMaritalStatus.Text;
            new_client.Date_Birth = dtpDateBirthC.Value;

            new_address.Street_Name = txtboxStreetClient.Text;
            new_address.House_Number = txtboxHouseNClient.Text;
            new_address.Suburb_Name = txtboxSuburbClient.Text;
            new_address.Zip_Code = txtboxZipCodeClient.Text;

            new_phone.Phone_Number = txtboxHousePhoneClient.Text;
            new_phone.Cellphone_Number = txtboxCellPhoneClient.Text;


            bool resultHotel = sqlConexion.AddClient(new_client, new_address, new_phone);

            if (resultHotel)
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
}
