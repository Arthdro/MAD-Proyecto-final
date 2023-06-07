using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD___PF_Hotel
{
    public partial class AddHotelForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        public AddHotelForm()
        {
            InitializeComponent();
            cBoxState.Enabled = false;
            cBoxCity.Enabled = false;
            cBoxCountry.DataSource = sqlConexion.FillCountriesBox();
            cBoxCountry.DisplayMember = "COUNTRY_NAME";
            cBoxCountry.ValueMember = "ID_COUNTRY";  
        }

        private void HODForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            HotelModel new_hotel = new HotelModel();
            AddressModel new_address = new AddressModel();
            LocationModel new_location = new LocationModel();
            AmenityModel new_amenity = new AmenityModel();

            new_hotel.Hotel_Name = txtboxHotelName.Text;            
            new_hotel.Number_Rooms = Blank_Space_Validation(txtboxNumberOfRooms.Text);
            new_hotel.Number_Floors = Blank_Space_Validation(txtboxNumberOfFloors.Text);
            new_hotel.Begin_Operations = dtpBeginOperations.Value;

            new_address.Street_Name = txtboxHotelStreet.Text;
            new_address.House_Number = txtboxHotelNumber.Text;
            new_address.Suburb_Name = txtboxHotelSuburb.Text;
            new_address.Zip_Code = txtboxHotelZipCode.Text;

            new_location.ID_Country = Blank_Space((string)cBoxCountry.SelectedValue);
            new_location.ID_State = Blank_Space((string)cBoxState.SelectedValue);
            new_location.ID_City = Blank_Space((string)cBoxCity.SelectedValue);

            new_amenity.Gym = ValidateCheckedBox(checkGym);
            new_amenity.Wifi = ValidateCheckedBox(checkWiFi);
            new_amenity.Room_Service = ValidateCheckedBox(checkRoomServ);
            new_amenity.Event_Room = ValidateCheckedBox(checkEventRoom);
            new_amenity.Swimming_Pool = ValidateCheckedBox(checkSwimPool);
            new_amenity.Massage = ValidateCheckedBox(checkMassage);
            new_amenity.Restaurant = ValidateCheckedBox(checkRestaurant);
            new_amenity.Taxi_Service = ValidateCheckedBox(checkTaxiService);


            if (Blank_Space_Validation(new_hotel) || Blank_Space_Validation(new_address) || Blank_Space_Validation(new_location))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else
            {
                bool resultHotel = sqlConexion.SetHotel(new_hotel, new_address, new_location, new_amenity, current_session);

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


        private bool Blank_Space_Validation(HotelModel aux_model)
        {
            if (aux_model.Hotel_Name == null || aux_model.Number_Floors == 0 || aux_model.Number_Rooms == 0 || aux_model.Begin_Operations == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Blank_Space_Validation(AddressModel aux_model)
        {
            if (aux_model.Street_Name == null || aux_model.House_Number == null || aux_model.Suburb_Name == null || aux_model.Zip_Code == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Blank_Space_Validation(LocationModel aux_model)
        {
            if (aux_model.ID_Country == 0 || aux_model.ID_State == 0 || aux_model.ID_City == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private byte Blank_Space_Validation(string aux) 
        {
            if (aux == "")
            {
                return 0; ;
            }
            else
            {
                return byte.Parse(aux);
            }
        }

        private int Blank_Space(string aux)
        {
            if (aux == "" || aux ==  null)
            {
                return 0; ;
            }
            else
            {
                return int.Parse(aux);
            }
        }
        private void cBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            int index = cBoxCountry.SelectedIndex;
            if (index == 0)
            {
                cBoxState.Enabled = false;
                cBoxCity.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cBoxCountry.SelectedValue;
                cBoxState.DataSource = sqlConexion.FillStatesBox(int.Parse(selectedValue) );
                cBoxState.DisplayMember = "STATE_NAME";
                cBoxState.ValueMember = "ID_STATE";
                cBoxState.Enabled = true;
            }
            return;
        }

        private void cBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            int index = cBoxState.SelectedIndex;
            if (index == 0)
            {
                cBoxCity.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cBoxState.SelectedValue;               
                cBoxCity.DataSource = sqlConexion.FillCitiesBox(int.Parse(selectedValue));
                cBoxCity.DisplayMember = "FULL_CITY_NAME";
                cBoxCity.ValueMember = "ID_CITY";
                cBoxCity.Enabled = true;
            }
            return;
        }

        private byte ValidateCheckedBox(CheckBox aux)
        {
            if (aux.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

    }
}
