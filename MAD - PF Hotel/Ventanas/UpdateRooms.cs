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
    public partial class UpdateRooms : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        HotelModel selected_hotel = new HotelModel();
        RoomModel selected_room = new RoomModel();
        AmenityRoomModel selected_amenityroom = new AmenityRoomModel();
        int max_room_number = 0;
        int room_quantity_add = 0;
        int available_add_rooms = 0;
        public UpdateRooms()
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

            //NUDQuantityRooms.Minimum = 1;
            NUDAmounPeople.Minimum = 1;
            NUDQuantityBeds.Minimum = 1;
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            RoomModel new_room = new RoomModel();
            AmenityRoomModel new_amenityroom = new AmenityRoomModel();
            int resultRoom = 0;

            new_room.Room_Name = cmboxRooms.Text;
            new_room.Id_Hotel = Blank_Space((string)cmboxHotel.SelectedValue);
            new_room.Id_BedType = Blank_Space((string)cmboxTypeBed.SelectedValue);
            new_room.People_Quantity = Convert.ToInt32(NUDAmounPeople.Value);
            new_room.Bed_Quantity = Convert.ToInt32(NUDQuantityBeds.Value);
            new_room.Id_Room_Level = Blank_Space((string)cmboxRoomLevel.SelectedValue);
            new_room.Room_Number = Blank_Space((string)txtboxRoomNumber.Text);
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
            //else if (sqlConexion.GetRoomQuantity(new_room.Id_Hotel, selected_hotel))
            //{
            //    MessageBox.Show("La cantidad de nuevas habitaciones es mayor a las habitaciones disponibles.");
            //}
            else
            {

                resultRoom = sqlConexion.SetRooms(new_room, new_amenityroom, current_session);

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

        private void btnDeleteRoom_Click(object sender, EventArgs e)
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
                    if (sqlConexion.DeleteRoom(selected_room.Id_Room, current_session) == 1)
                    {
                        MessageBox.Show("El oeprador fue borrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //private void txtboxRoomName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
        //    {
        //        MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //        return;
        //    }
        //}

        private void txtboxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxPriceNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                int id_hotel = Convert.ToInt32(cmboxHotel.SelectedValue.ToString());
                cmboxRooms.DataSource = sqlConexion.GetRoomByHotelID(id_hotel);
                cmboxRooms.DisplayMember = "ROOM";
                cmboxRooms.ValueMember = "ID_ROOM";
                return;
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

        private void cmboxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = 0;
            int index = cmboxRooms.SelectedIndex;
            if (index == 0)
            {
                cmboxHotel.Enabled = false;
                return;
            }
            else
            {
                string selectedValue = (string)cmboxRooms.SelectedValue;
                selected_room = sqlConexion.GetRoomData(int.Parse(selectedValue));
                selected_amenityroom = sqlConexion.GetRoomAmenity(selected_room.Id_Room);
                NUDAmounPeople.Value = selected_room.People_Quantity;
                NUDQuantityBeds.Value = selected_room.Bed_Quantity;
                txtboxRoomNumber.Text = selected_room.Room_Number.ToString();
                txtboxSize.Text = selected_room.Size.ToString("0.00");
                txtboxPriceNight.Text = selected_room.Price_Night.ToString("0.00");

                cBoxWifi.Checked = SendValueCheckbox(selected_amenityroom.Wifi);
                cBoxTVService.Checked = SendValueCheckbox(selected_amenityroom.Tv_Service);
                cBoxAcousticInsolation.Checked = SendValueCheckbox(selected_amenityroom.Acoustic_insolataion);
                cBoxCofeeMachine.Checked = SendValueCheckbox(selected_amenityroom.Cofee_Machine);
                cBoxAirCoinditioning.Checked = SendValueCheckbox(selected_amenityroom.Air_Coinditioning);
                cBoxToiletries.Checked = SendValueCheckbox(selected_amenityroom.Toiletries);
                cBoxFullBathroom.Checked = SendValueCheckbox(selected_amenityroom.Full_Bathroom);
                cBoxNoSmokingRoom.Checked = SendValueCheckbox(selected_amenityroom.No_Smoking_Room);
                cBoxMiniBar.Checked = SendValueCheckbox(selected_amenityroom.Mini_Bar);

            }
            return;
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
