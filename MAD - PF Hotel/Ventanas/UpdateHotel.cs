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
    public partial class UpdateHotel : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        HotelModel selected_hotel = new HotelModel();
        AddressModel selected_address = new AddressModel();
        AmenityModel selected_amenity = new AmenityModel();
        public UpdateHotel()
        {
            InitializeComponent();
            cBoxCity.DataSource = sqlConexion.FillCitiesBox(null);
            cBoxCity.DisplayMember = "FULL_CITY_NAME";
            cBoxCity.ValueMember = "ID_CITY";
            //cmboxHotel.Enabled = false;
        }

        private void btnUpdateHotel_Click(object sender, EventArgs e)
        {
            LocationModel location_null = new LocationModel();
            selected_address.Street_Name = txtboxHotelStreet.Text;
            selected_address.House_Number = txtboxHotelNumber.Text;
            selected_address.Suburb_Name = txtboxHotelSuburb.Text;
            selected_address.Zip_Code = txtboxHotelZipCode.Text;

            selected_hotel.Number_Floors = byte.Parse(txtboxNumberOfFloors.Text);
            selected_hotel.Number_Rooms = short.Parse(txtboxNumberOfRooms.Text);
            selected_hotel.Begin_Operations = dtpBeginOperations.Value;

            selected_amenity.Gym = ValidateCheckedBox(checkGym);
            selected_amenity.Wifi = ValidateCheckedBox(checkWiFi);
            selected_amenity.Room_Service = ValidateCheckedBox(checkRoomServ);
            selected_amenity.Event_Room = ValidateCheckedBox(checkEventRoom);
            selected_amenity.Swimming_Pool = ValidateCheckedBox(checkSwimPool);
            selected_amenity.Massage = ValidateCheckedBox(checkMassage);
            selected_amenity.Restaurant = ValidateCheckedBox(checkRestaurant);
            selected_amenity.Taxi_Service = ValidateCheckedBox(checkTaxiService);

            if (Blank_Space_Validation(selected_hotel) || Blank_Space_Validation(selected_address))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else
            {
                bool resultHotel = sqlConexion.SetHotel(selected_hotel, selected_address, location_null, selected_amenity, current_session);

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

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
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
        private void cBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cBoxCity.SelectedIndex;
            if (index == 0)
            {
                cmboxHotel.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cBoxCity.SelectedValue;
                cmboxHotel.DataSource = sqlConexion.FillHotelsBox(int.Parse(selectedValue));
                cmboxHotel.DisplayMember = "HOTEL_NAME";
                cmboxHotel.ValueMember = "ID_HOTEL";
                cmboxHotel.Enabled = true;
            }
            return;
        }

        private void cmboxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmboxHotel.SelectedIndex;
            if (index == 0)
            {
                //cmboxHotel.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cmboxHotel.SelectedValue;
                selected_hotel = sqlConexion.GetHotelData(int.Parse(selectedValue));
                selected_address = sqlConexion.GetHotelAddress(int.Parse(selectedValue));
                selected_amenity = sqlConexion.GetHotelAmenity(int.Parse(selectedValue));

                txtboxHotelStreet.Text = selected_address.Street_Name;
                txtboxHotelNumber.Text = selected_address.House_Number;
                txtboxHotelSuburb.Text = selected_address.Suburb_Name;
                txtboxHotelZipCode.Text = selected_address.Zip_Code;

                txtboxNumberOfFloors.Text = selected_hotel.Number_Floors.ToString();
                txtboxNumberOfRooms.Text = selected_hotel.Number_Rooms.ToString();
                dtpBeginOperations.Value = selected_hotel.Begin_Operations;

                checkGym.Checked = SendValueCheckbox(selected_amenity.Gym);
                checkWiFi.Checked = SendValueCheckbox(selected_amenity.Wifi);
                checkRoomServ.Checked = SendValueCheckbox(selected_amenity.Room_Service);
                checkEventRoom.Checked = SendValueCheckbox(selected_amenity.Event_Room);
                checkSwimPool.Checked = SendValueCheckbox(selected_amenity.Swimming_Pool);
                checkMassage.Checked = SendValueCheckbox(selected_amenity.Massage);
                checkRestaurant.Checked = SendValueCheckbox(selected_amenity.Restaurant);
                checkTaxiService.Checked = SendValueCheckbox(selected_amenity.Taxi_Service);
                return;
            }        
        }

        private bool SendValueCheckbox(byte aux)
        {
            if (aux == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
    }
}
