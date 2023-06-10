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

namespace MAD___PF_Hotel
{
    public partial class AddRoomForm : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        HotelModel selected_hotel = new HotelModel();
        int max_room_number = 0;
        int room_quantity_add = 0;
        int available_add_rooms = 0;
        public AddRoomForm()
        {
            InitializeComponent();
            cmboxCity.DataSource = sqlConexion.FillCitiesBox(null);
            cmboxCity.DisplayMember = "FULL_CITY_NAME";
            cmboxCity.ValueMember = "ID_CITY";
            cmboxHotel.Enabled = false;

            cmboxTypeBed.DataSource = sqlConexion.GetBedTypes();
            cmboxTypeBed.DisplayMember = "BEDTYPE_NAME";
            cmboxTypeBed.ValueMember = "ID_BEDTYPE";

            cmboxRoomLevel.DataSource = sqlConexion.GetRoomLevels();
            cmboxRoomLevel.DisplayMember = "ROOM_LEVEL_NAME";
            cmboxRoomLevel.ValueMember = "ID_ROOMLEVEL";

            NUDQuantityRooms.Minimum = 1;
            NUDAmounPeople.Minimum = 1;
            NUDQuantityBeds.Minimum = 1;
        }

        private void CRForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTypeOfRoom_Click(object sender, EventArgs e)
        {
            
            RoomModel new_room = new RoomModel();
            AmenityRoomModel new_amenityroom = new AmenityRoomModel();
            int resultRoom = 0;

            new_room.Room_Name = txtboxRoomName.Text;
            new_room.Id_Hotel = Blank_Space((string)cmboxHotel.SelectedValue);
            new_room.Id_BedType = Blank_Space((string)cmboxTypeBed.SelectedValue);
            new_room.People_Quantity = Convert.ToInt32(NUDAmounPeople.Value);
            new_room.Bed_Quantity = Convert.ToInt32(NUDQuantityBeds.Value);            
            new_room.Id_Room_Level = Blank_Space((string)cmboxRoomLevel.SelectedValue);
            new_room.Price_Night = Blank_Space_float((string)txtboxPriceNight.Text);
            new_room.Size = Blank_Space_float((string)txtboxSize.Text);

            new_amenityroom.Wifi = ValidateCheckedBox(cBoxWifi);
            new_amenityroom.Tv_Service = ValidateCheckedBox(cBoxTVService);
            new_amenityroom.Acoustic_insolataion = ValidateCheckedBox(cBoxAcousticInsolation);
            new_amenityroom.Cofee_Machine = ValidateCheckedBox(cBoxCofeeMachine);
            new_amenityroom.Air_Coinditioning = ValidateCheckedBox(cBoxAirCoinditioning);
            new_amenityroom.Toiletries = ValidateCheckedBox(cBoxToiletries);
            new_amenityroom.Full_Bathroom = ValidateCheckedBox(cBoxFullBathroom);
            new_amenityroom.No_Smoking_Room = ValidateCheckedBox(cBoxNoSmokingRoom);
            new_amenityroom.Mini_Bar = ValidateCheckedBox(cBoxMiniBar);

            if (RoomValidation(new_room))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else if (sqlConexion.GetRoomQuantity(new_room.Id_Hotel, selected_hotel))
            {
                MessageBox.Show("La cantidad de nuevas habitaciones es mayor a las habitaciones disponibles.");
            }
            else
            {
                for (int i = 1; i <= Convert.ToInt32(NUDQuantityRooms.Value) && i <= available_add_rooms; i++)
                {
                    new_room.Room_Number = max_room_number + i;
                    resultRoom = sqlConexion.SetRooms(new_room, new_amenityroom, current_session);
                }
                
                if (resultRoom == 1)
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

        private bool RoomValidation(RoomModel aux_model)
        {
            if (aux_model.Room_Name == null || aux_model.Id_Hotel == 0 ||
                aux_model.Id_BedType == 0 || aux_model.People_Quantity == 0 ||
                aux_model.Bed_Quantity == 0 || aux_model.Id_Room_Level == 0 ||
                aux_model.Price_Night == 0 || aux_model.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Blank_Space(string aux)
        {
            if (aux == "" || aux == null)
            {
                return 0; ;
            }
            else
            {
                return int.Parse(aux);
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
        private float Blank_Space_float(string aux)
        {
            if (aux == "" || aux == null)
            {
                return 0f; ;
            }
            else
            {
                return float.Parse(aux);
            }
        }

        private void cmboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            int index = cmboxCity.SelectedIndex;
            if (index == 0)
            {
                cmboxHotel.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cmboxCity.SelectedValue;
                cmboxHotel.DataSource = sqlConexion.FillHotelsBox(int.Parse(selectedValue));
                cmboxHotel.DisplayMember = "HOTEL_NAME";
                cmboxHotel.ValueMember = "ID_HOTEL";
                cmboxHotel.Enabled = true;
            }
            return;
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxRoomName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtboxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxPriceNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmboxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmboxHotel.SelectedIndex;
            if (index == 0)
            {
                return;
            }
            else
            {
                int id_hotel = Blank_Space((string)cmboxHotel.SelectedValue);
                max_room_number = sqlConexion.GetHotelLastRoom(id_hotel);
                room_quantity_add = sqlConexion.GetHotelRoomsQuantity(id_hotel);               
                selected_hotel = sqlConexion.GetHotelData(id_hotel);
                available_add_rooms = (selected_hotel.Number_Rooms - room_quantity_add);
                return;
            }
     
        }
    }
}
