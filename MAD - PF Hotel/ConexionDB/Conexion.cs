using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAD___PF_Hotel.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD___PF_Hotel.ConexionDB
{
    internal class Conexion
    {
        private SqlConnection con = new SqlConnection();

        static string Server = "DESKTOP-BEGKO7S";
        static string DataBase = "BOOKING_SYSTEM_DB";
        //static string UserName = "sa";
        //static string Password = "hola12345";
        //static string Port = "1433";

        string Connection = "Server = " + Server + ";" + "database = " + DataBase + ";" + "integrated security = true";
    
        public SqlConnection StartConnection ()
        {
            try 
            {
                con.ConnectionString = Connection;
                con.Open();
            }
            catch (SqlException e) 
            {
                MessageBox.Show("No se logró conectar a la base de datos: " + e.ToString());
            }

            return con;
        }

        public int Login(string email, string password) 
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                
                SqlCommand cmd = new SqlCommand("spLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_email", email);
                cmd.Parameters.AddWithValue("p_password", password);

               // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //if (dr.GetInt32(11) == 0) {
                    //    return 0;
                    //}
                    //else if (dr.GetInt32(11) == 1)
                    //{ 
                    //    return 1;
                    //}
                    //else {
                    //    return 2;
                    //}
                    //return dr.GetInt32(0);
                    return 0;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Los datos ingresados no coinciden." + e.ToString());
                return 1;
            }
            finally 
            { 
                con.Close();
            }
            return 1;
        }

        public bool SetUser(UserModel added_User, AddressModel added_address, PhoneModel added_phone, UserModel current_session)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_u = new SqlCommand("spSetUser", con);
                cmd_u.CommandType = CommandType.StoredProcedure;
                cmd_u.Parameters.AddWithValue("@p_current_user", current_session.Id_User);

                cmd_u.Parameters.AddWithValue("@p_id_user", added_User.Id_User);
                cmd_u.Parameters.AddWithValue("@p_full_name", added_User.Full_Name);
                cmd_u.Parameters.AddWithValue("@p_names", added_User.Names);
                cmd_u.Parameters.AddWithValue("@p_last_name_one", added_User.Last_Name_One);
                cmd_u.Parameters.AddWithValue("@p_last_name_two", added_User.Last_Name_Two);
                cmd_u.Parameters.AddWithValue("@p_payroll_no", added_User.Payroll_No);
                cmd_u.Parameters.AddWithValue("@p_date_birth", added_User.Date_Birth);
                cmd_u.Parameters.AddWithValue("@p_email", added_User.Email);
                cmd_u.Parameters.AddWithValue("@p_user_password", added_User.User_Password);
                cmd_u.Parameters.AddWithValue("@p_user_type", added_User.User_Type);

                cmd_u.Parameters.AddWithValue("@p_id_address", added_address.Id_Address);
                cmd_u.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_u.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_u.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_u.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                cmd_u.Parameters.AddWithValue("@p_id_phone", added_phone.Id_Phone);
                cmd_u.Parameters.AddWithValue("@p_house_phone", added_phone.Phone_Number);
                cmd_u.Parameters.AddWithValue("@p_cell_phone", added_phone.Cellphone_Number);


                SqlDataReader dr = cmd_u.ExecuteReader();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool SetHotel(HotelModel added_Hotel, AddressModel added_address, LocationModel added_location, AmenityModel added_amenity, UserModel current_session)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_h = new SqlCommand("spSetHotel", con);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@p_id_user", current_session.Id_User);

                cmd_h.Parameters.AddWithValue("@p_id_hotel", added_Hotel.Id_Hotel);
                cmd_h.Parameters.AddWithValue("@p_hotel_name", added_Hotel.Hotel_Name);
                cmd_h.Parameters.AddWithValue("@p_number_floors", added_Hotel.Number_Floors);
                cmd_h.Parameters.AddWithValue("@p_number_rooms", added_Hotel.Number_Rooms);
                cmd_h.Parameters.AddWithValue("@p_begin_operations", added_Hotel.Begin_Operations);

                cmd_h.Parameters.AddWithValue("@p_id_address", added_address.Id_Address);
                cmd_h.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_h.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_h.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_h.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                cmd_h.Parameters.AddWithValue("@p_id_country", added_location.ID_Country);
                cmd_h.Parameters.AddWithValue("@p_id_state", added_location.ID_State);
                cmd_h.Parameters.AddWithValue("@p_id_city", added_location.ID_City);

                cmd_h.Parameters.AddWithValue("@p_id_amenity", added_amenity.Id_Amenity);
                cmd_h.Parameters.AddWithValue("@p_gym", added_amenity.Gym);
                cmd_h.Parameters.AddWithValue("@p_wifi", added_amenity.Wifi);
                cmd_h.Parameters.AddWithValue("@p_room_service", added_amenity.Room_Service);
                cmd_h.Parameters.AddWithValue("@p_event_room", added_amenity.Event_Room);
                cmd_h.Parameters.AddWithValue("@p_swimming_pool", added_amenity.Swimming_Pool);
                cmd_h.Parameters.AddWithValue("@p_massage", added_amenity.Massage);
                cmd_h.Parameters.AddWithValue("@p_restaurant", added_amenity.Restaurant);
                cmd_h.Parameters.AddWithValue("@p_taxi_service", added_amenity.Taxi_Service);


                SqlDataReader dr = cmd_h.ExecuteReader();

                return true;

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public int SetClient(ClientModel added_client, AddressModel added_address, PhoneModel added_phone, UserModel current_session)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_c = new SqlCommand("spSetClient", con);
                cmd_c.CommandType = CommandType.StoredProcedure;
                cmd_c.Parameters.AddWithValue("@p_current_user", current_session.Id_User);
                cmd_c.Parameters.AddWithValue("@p_id_client", added_client.Id_Client);
                cmd_c.Parameters.AddWithValue("@p_full_name", added_client.Full_Name);
                cmd_c.Parameters.AddWithValue("@p_first_names", added_client.Names);
                cmd_c.Parameters.AddWithValue("@p_last_name_one", added_client.Last_Name_One);
                cmd_c.Parameters.AddWithValue("@p_last_name_two", added_client.Last_Name_Two);
                cmd_c.Parameters.AddWithValue("@p_rfc", added_client.RFC);
                cmd_c.Parameters.AddWithValue("@p_date_birth", added_client.Date_Birth);
                cmd_c.Parameters.AddWithValue("@p_email", added_client.Email);
                cmd_c.Parameters.AddWithValue("@p_reference", added_client.Reference);
                cmd_c.Parameters.AddWithValue("@p_marital_status", added_client.Marital_Status);

                cmd_c.Parameters.AddWithValue("@p_id_address", added_address.Id_Address);
                cmd_c.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_c.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_c.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_c.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                cmd_c.Parameters.AddWithValue("@p_id_phone", added_phone.Id_Phone);
                cmd_c.Parameters.AddWithValue("@p_house_phone", added_phone.Phone_Number);
                cmd_c.Parameters.AddWithValue("@p_cell_phone", added_phone.Cellphone_Number);

                SqlDataReader dr = cmd_c.ExecuteReader();

                if (dr.Read())
                {
                    return 1;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return 1;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }

        public int SetReservation(ReservationModel added_reservation, UserModel current_user)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_c = new SqlCommand("spSetReservation", con);
                cmd_c.CommandType = CommandType.StoredProcedure;
                cmd_c.Parameters.AddWithValue("@p_id_user", current_user.Id_User);

                cmd_c.Parameters.AddWithValue("@p_id_reservation", added_reservation.Id_Reservation);
                cmd_c.Parameters.AddWithValue("@p_id_client", added_reservation.Id_Client);
                cmd_c.Parameters.AddWithValue("@p_id_city", added_reservation.Id_City);
                cmd_c.Parameters.AddWithValue("@p_id_hotel", added_reservation.Id_Hotel);
                cmd_c.Parameters.AddWithValue("@p_id_room", added_reservation.Id_Room);
                cmd_c.Parameters.AddWithValue("@p_check_in", added_reservation.Check_In);
                cmd_c.Parameters.AddWithValue("@p_check_out", added_reservation.Check_Out);
                cmd_c.Parameters.AddWithValue("@p_room_number", added_reservation.Room_Number);
                cmd_c.Parameters.AddWithValue("@p_subtotal", added_reservation.Subtotal);
                cmd_c.Parameters.AddWithValue("@p_iva_cost", added_reservation.IVA);
                cmd_c.Parameters.AddWithValue("@p_total_amount", added_reservation.Total_Amount);
                cmd_c.Parameters.AddWithValue("@p_upfront_pay", added_reservation.UpFront_Pay);

                SqlDataReader dr = cmd_c.ExecuteReader();

                if (dr.Read())
                {
                    return 1;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return 1;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }

        public int CheckDisponibility(ReservationModel added_reservation)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_c = new SqlCommand("spCheckDisponibility", con);
                cmd_c.CommandType = CommandType.StoredProcedure;
                cmd_c.Parameters.AddWithValue("@p_id_room", added_reservation.Id_Room);
                cmd_c.Parameters.AddWithValue("@p_check_in", added_reservation.Check_In);
                cmd_c.Parameters.AddWithValue("@p_check_out", added_reservation.Check_Out);

                SqlDataReader dr = cmd_c.ExecuteReader();

                if (dr.Read())
                {
                    int request_spQuery = int.Parse(dr["AVAILABILITY_ROOM"].ToString());
                    return request_spQuery;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
        public int SetRooms(RoomModel added_room, AmenityRoomModel added_amenityroom, UserModel current_session)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_c = new SqlCommand("spSetRoom", con);
                cmd_c.CommandType = CommandType.StoredProcedure;
                cmd_c.Parameters.AddWithValue("@p_id_user", current_session.Id_User);

                cmd_c.Parameters.AddWithValue("@p_id_room", added_room.Id_Room);
                cmd_c.Parameters.AddWithValue("@p_room_name", added_room.Room_Name);
                cmd_c.Parameters.AddWithValue("@p_people_quantity", added_room.People_Quantity);
                cmd_c.Parameters.AddWithValue("@p_bed_quantity", added_room.Bed_Quantity);
                cmd_c.Parameters.AddWithValue("@p_room_number", added_room.Room_Number);
                cmd_c.Parameters.AddWithValue("@p_price_night", added_room.Price_Night);
                cmd_c.Parameters.AddWithValue("@p_size", added_room.Size);
                cmd_c.Parameters.AddWithValue("@p_id_hotel", added_room.Id_Hotel);
                cmd_c.Parameters.AddWithValue("@p_id_bedtype", added_room.Id_BedType);
                cmd_c.Parameters.AddWithValue("@p_id_room_level", added_room.Id_Room_Level);

                cmd_c.Parameters.AddWithValue("@p_id_amenityroom", added_amenityroom.Id_AmenityRoom);
                cmd_c.Parameters.AddWithValue("@p_wifi", added_amenityroom.Wifi);
                cmd_c.Parameters.AddWithValue("@p_tv_service", added_amenityroom.Tv_Service);
                cmd_c.Parameters.AddWithValue("@p_acoustic_insolation", added_amenityroom.Acoustic_insolataion);
                cmd_c.Parameters.AddWithValue("@p_cofee_machine", added_amenityroom.Cofee_Machine);
                cmd_c.Parameters.AddWithValue("@p_air_coinditioning", added_amenityroom.Air_Coinditioning);
                cmd_c.Parameters.AddWithValue("@p_toiletries", added_amenityroom.Toiletries);
                cmd_c.Parameters.AddWithValue("@p_full_bathroom", added_amenityroom.Full_Bathroom);
                cmd_c.Parameters.AddWithValue("@p_no_smoking", added_amenityroom.No_Smoking_Room);
                cmd_c.Parameters.AddWithValue("@p_mini_bar", added_amenityroom.Mini_Bar);

                SqlDataReader dr = cmd_c.ExecuteReader();

                if (dr.Read())
                {
                    return 1;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return 1;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }

        public UserModel GetUserData(string parameter_1, int? parameter_2)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetUserData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_email", parameter_1);
                cmd.Parameters.AddWithValue("@p_payroll_no", parameter_2);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                UserModel logged_user = new UserModel();

               while (dr.Read())
                {
                    logged_user.Id_User = Convert.ToInt32(dr["ID_USER"]);
                    logged_user.Full_Name = dr["FULL_NAME"].ToString();
                    logged_user.Names = dr["NAMES"].ToString();
                    logged_user.Last_Name_One = dr["LAST_NAME_ONE"].ToString();
                    logged_user.Last_Name_Two = dr["LAST_NAME_TWO"].ToString();
                    logged_user.Date_Birth = Convert.ToDateTime(dr["DATE_BIRTH"]);
                    logged_user.Payroll_No = Convert.ToInt32(dr["PAYROLL_NO"]);
                    logged_user.Email = dr["EMAIL"].ToString();
                    logged_user.User_Type = Convert.ToInt32(dr["USER_TYPE"]);
                    logged_user.Id_Address = Convert.ToInt32(dr["ID_ADDRESS"]);
                    logged_user.Id_Phone = Convert.ToInt32(dr["ID_PHONE"]);
                }
                return logged_user;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }
  
        public DataTable FillCountriesBox() 
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetCountries", con);
                da.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("COUNTRY_NAME");
                dt.Columns.Add("ID_COUNTRY");
                DataRow _ravi = dt.NewRow();
                _ravi["COUNTRY_NAME"] = "--- Select ---";
                _ravi["ID_COUNTRY"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }           
        }

        public DataTable FillStatesBox(int id_state)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetStates", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@p_id_country", id_state);
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("STATE_NAME");
                dt.Columns.Add("ID_STATE");
                DataRow _ravi = dt.NewRow();
                _ravi["STATE_NAME"] = "--- Select ---";
                _ravi["ID_STATE"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable FillCitiesBox(int? id_state)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetCities", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@p_id_state", id_state);
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("FULL_CITY_NAME");
                dt.Columns.Add("ID_CITY");
                DataRow _ravi = dt.NewRow();
                _ravi["FULL_CITY_NAME"] = "--- Select ---";
                _ravi["ID_CITY"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable FillHotelsBox(int id_city)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetHotels", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@p_id_city", id_city);
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("HOTEL_NAME");
                dt.Columns.Add("ID_HOTEL");
                DataRow _ravi = dt.NewRow();
                _ravi["HOTEL_NAME"] = "--- Select ---";
                _ravi["ID_HOTEL"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetBedTypes()
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetBedType", con);
                da.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("BEDTYPE_NAME");
                dt.Columns.Add("ID_BEDTYPE");
                DataRow _ravi = dt.NewRow();
                _ravi["BEDTYPE_NAME"] = "--- Select ---";
                _ravi["ID_BEDTYPE"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetRoomLevels()
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                SqlCommand da = new SqlCommand("spGetRoomLevel", con);
                da.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable() { CaseSensitive = true };

                dt.Clear();
                dt.Columns.Add("ROOM_LEVEL_NAME");
                dt.Columns.Add("ID_ROOMLEVEL");
                DataRow _ravi = dt.NewRow();
                _ravi["ROOM_LEVEL_NAME"] = "--- Select ---";
                _ravi["ID_ROOMLEVEL"] = 0;
                dt.Rows.Add(_ravi);

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetHotels(string aux_value)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                //string consulta = "SELECT * FROM HOTELS_SYSTEM.HOTEL_DATA;";

                SqlCommand da = new SqlCommand("spGetHotelsbyCity", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@p_id_city", aux_value);
                DataTable dt = new DataTable() { CaseSensitive = true };

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);
                
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public HotelModel GetHotelData(int aux_value)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                //string consulta = "SELECT * FROM HOTELS_SYSTEM.HOTEL_DATA;";

                SqlCommand cmd = new SqlCommand("spGetHotelData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_hotel", aux_value);

                SqlDataReader dr = cmd.ExecuteReader();
                HotelModel updated_user = new HotelModel();

                while (dr.Read())
                {
                    updated_user.Id_Hotel = Convert.ToInt32(dr["ID_HOTEL"]);
                    updated_user.Hotel_Name = dr["HOTEL_NAME"].ToString();
                    updated_user.Number_Floors = byte.Parse(dr["FLOORS"].ToString());
                    updated_user.Number_Rooms = short.Parse(dr["ROOMS"].ToString());
                    updated_user.Available_Rooms = short.Parse(dr["AVAILABLE_ROOMS"].ToString());
                    updated_user.Begin_Operations = DateTime.Parse(dr["BEGIN_OPERATIONS"].ToString());
 
                }
                return updated_user;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public AddressModel GetHotelAddress(int aux_value)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetHotelAddress", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_hotel", aux_value);

                SqlDataReader dr = cmd.ExecuteReader();
                AddressModel selected_address = new AddressModel();

                while (dr.Read())
                {
                    selected_address.Id_Address = Convert.ToInt32(dr["ID_ADDRESS"]);
                    selected_address.Street_Name = dr["STREET_NAME"].ToString();
                    selected_address.House_Number = dr["HOUSE_NUMBER"].ToString();
                    selected_address.Suburb_Name = dr["SUBURB_NAME"].ToString();
                    selected_address.Zip_Code = dr["ZIP_CODE"].ToString();
                }
                return selected_address;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public AmenityModel GetHotelAmenity(int aux_value)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetHotelAmenity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_hotel", aux_value);

                SqlDataReader dr = cmd.ExecuteReader();
                AmenityModel selected_amenity = new AmenityModel();
                bool aux_bool = false;

                while (dr.Read())
                {
                    selected_amenity.Id_Amenity = Convert.ToInt32(dr["ID_AMENITY"]);
                    selected_amenity.Gym = trasnsform_boolean(bool.Parse(dr["GYM"].ToString()));
                    selected_amenity.Wifi = trasnsform_boolean(bool.Parse(dr["WIFI"].ToString()));
                    selected_amenity.Room_Service = trasnsform_boolean(bool.Parse(dr["ROOM_SERVICE"].ToString()));
                    selected_amenity.Event_Room = trasnsform_boolean(bool.Parse(dr["EVENT_ROOM"].ToString()));
                    selected_amenity.Swimming_Pool = trasnsform_boolean(bool.Parse(dr["SWIMMING_POOL"].ToString()));
                    selected_amenity.Massage = trasnsform_boolean(bool.Parse(dr["MASSAGE"].ToString()));
                    selected_amenity.Restaurant = trasnsform_boolean(bool.Parse(dr["RESTAURANT"].ToString()));
                    selected_amenity.Taxi_Service = trasnsform_boolean(bool.Parse(dr["TAXI_SERVICE"].ToString()));
                }
                return selected_amenity;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetRoomTypes(string value)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();
                //List<RoomModel> room_founded = new List<RoomModel>();
                //RoomModel room = null;
                SqlCommand da = new SqlCommand("spGetRooms", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@p_id_hotel", value);
                DataTable dt = new DataTable() { CaseSensitive = true };

                SqlDataReader dr = da.ExecuteReader();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public RoomModel GetSelectedRoom(string value) {

            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetSelectedRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_room", value);

                SqlDataReader dr = cmd.ExecuteReader();
                RoomModel searched_room = new RoomModel();


                while (dr.Read())
                {
                    searched_room.Room_Name = dr["ROOM_NAME"].ToString();
                    searched_room.People_Quantity = Convert.ToInt32(dr["PEOPLE_QUANTITY"]);
                    searched_room.Bed_Quantity = Convert.ToInt32(dr["BED_QUANTITY"]);
                    searched_room.Room_Number = Convert.ToInt32(dr["ROOM_NUMBER"]);
                    searched_room.Price_Night = float.Parse(dr["PRICE_PER_NIGHT"].ToString());
                    searched_room.Discount = Convert.ToInt32(dr["DISCOUNT"]);
                    searched_room.Size = float.Parse(dr["SIZE"].ToString());
                }
                return searched_room;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public ClientModel GetClientData(string parameter_1, string parameter_2, string parameter_3)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_full_name", parameter_1);
                cmd.Parameters.AddWithValue("@p_email", parameter_2);
                cmd.Parameters.AddWithValue("@p_rfc", parameter_3);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                ClientModel logged_user = new ClientModel();

                while (dr.Read())
                {
                    logged_user.Id_Client = Convert.ToInt32(dr["ID_CLIENT"]);
                    logged_user.Full_Name = dr["FULL_NAME"].ToString();
                    logged_user.Names = dr["FIRST_NAMES"].ToString();
                    logged_user.Last_Name_One = dr["LAST_NAME_ONE"].ToString();
                    logged_user.Last_Name_Two = dr["LAST_NAME_TWO"].ToString();
                    logged_user.Date_Birth = DateTime.Parse(dr["DATE_BIRTH"].ToString());
                    logged_user.RFC = dr["RFC"].ToString();
                    logged_user.Email = dr["EMAIL"].ToString();
                    logged_user.Reference = dr["REFERENCE"].ToString();
                    logged_user.Marital_Status = dr["MARITAL_STATUS"].ToString();
                }
                return logged_user;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public AddressModel GetAddresstData(int parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetAddress", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_client", parameter_1);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                AddressModel searched_address = new AddressModel();

                while (dr.Read())
                {
                    searched_address.Id_Address = Convert.ToInt32(dr["ID_ADDRESS"]);
                    searched_address.Street_Name = dr["STREET_NAME"].ToString();
                    searched_address.House_Number = dr["HOUSE_NUMBER"].ToString();
                    searched_address.Suburb_Name = dr["SUBURB_NAME"].ToString();
                    searched_address.Zip_Code = dr["ZIP_CODE"].ToString();
                }
                return searched_address;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public AddressModel GetAddresstDataForUsers(int parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetAddressForUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_user", parameter_1);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                AddressModel searched_address = new AddressModel();

                while (dr.Read())
                {
                    searched_address.Id_Address = Convert.ToInt32(dr["ID_ADDRESS"]);
                    searched_address.Street_Name = dr["STREET_NAME"].ToString();
                    searched_address.House_Number = dr["HOUSE_NUMBER"].ToString();
                    searched_address.Suburb_Name = dr["SUBURB_NAME"].ToString();
                    searched_address.Zip_Code = dr["ZIP_CODE"].ToString();
                }
                return searched_address;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public PhoneModel GetPhoneData(int parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetPhone", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_client", parameter_1);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                PhoneModel searched_phone = new PhoneModel();

                while (dr.Read())
                {
                    searched_phone.Id_Phone = Convert.ToInt32(dr["ID_PHONE"]);
                    searched_phone.Phone_Number = dr["PHONE_NUMBER"].ToString();
                    searched_phone.Cellphone_Number = dr["CELLPHONE_NUMBER"].ToString();
                }
                return searched_phone;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public PhoneModel GetPhoneDataForUsers(int parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetPhoneForUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id_user", parameter_1);

                // SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();
                PhoneModel searched_phone = new PhoneModel();

                while (dr.Read())
                {
                    searched_phone.Id_Phone = Convert.ToInt32(dr["ID_PHONE"]);
                    searched_phone.Phone_Number = dr["PHONE_NUMBER"].ToString();
                    searched_phone.Cellphone_Number = dr["CELLPHONE_NUMBER"].ToString();
                }
                return searched_phone;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public byte trasnsform_boolean(bool aux)
        {
            if (aux)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool GetRoomQuantity(int aux, HotelModel aux_hotel)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                int sum = 0;
                var total_rooms = 0;
                SqlCommand cmd = new SqlCommand("spGetHotelRooms", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_hotel", aux);

                SqlDataReader dr = cmd.ExecuteReader();
                
                //List<RoomModel> hotel_rooms = new List<RoomModel>();
                //HotelModel hotel = new HotelModel();
                if (dr.Read())
                {
                    total_rooms = int.Parse(dr["TOTAL_ROOMS"].ToString());
                }

                if (aux_hotel.Number_Rooms < (total_rooms))
                    return true;
                else
                    return false;           
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        //public int GetRoomQuantity(int aux, int rooms_aux)
        //{
        //    try
        //    {
        //        con.ConnectionString = Connection;
        //        con.Open();

        //        int sum = 0;
        //        var total_rooms = 0;
        //        SqlCommand cmd = new SqlCommand("spGetHotelRooms", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@p_id_hotel", aux);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        List<RoomModel> hotel_rooms = new List<RoomModel>();
        //        HotelModel hotel = new HotelModel();

        //        if (dr.Read())
        //        {
        //            total_rooms = int.Parse(dr["TOTAL_ROOMS"].ToString());
        //        }
        //        if (hotel.Number_Rooms < (total_rooms + rooms_aux))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //}
        public CheckInformationModel GetReservationData(string parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spGetReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_reservation", parameter_1);

                SqlDataReader dr = cmd.ExecuteReader();
                CheckInformationModel searched_reservation = new CheckInformationModel();

                while (dr.Read())
                {
                    searched_reservation.Id_Reservation = dr["ID_RESERVATION"].ToString();
                    searched_reservation.Client_Name = dr["NAMES"].ToString();
                    searched_reservation.Id_Room = int.Parse(dr["ID_ROOM"].ToString());
                    searched_reservation.Room_Name = dr["ROOM_NAME"].ToString();
                    searched_reservation.People_Quantity = Convert.ToInt32(dr["PEOPLE_QUANTITY"]);
                    searched_reservation.Bed_Quantity = int.Parse(dr["BED_QUANTITY"].ToString());
                    searched_reservation.Price_x_night = float.Parse(dr["PRICE_PER_NIGHT"].ToString());
                    searched_reservation.Full_City_Name = dr["FULL_CITY_NAME"].ToString();
                    searched_reservation.Id_Hotel = int.Parse(dr["ID_HOTEL"].ToString());
                    searched_reservation.Hotel_Name = dr["HOTEL_NAME"].ToString();
                    searched_reservation.Check_In = DateTime.Parse(dr["CHECK_IN"].ToString());
                    searched_reservation.Check_Out = DateTime.Parse(dr["CHECK_OUT"].ToString());
                    searched_reservation.Room_Number = int.Parse(dr["ROOM_NUMBER"].ToString());
                    searched_reservation.Subtotal = float.Parse(dr["SUBTOTAL"].ToString());
                    searched_reservation.IVA_cost = float.Parse(dr["IVA_COST"].ToString());
                    searched_reservation.Total_Amount = float.Parse(dr["TOTAL_AMOUNT"].ToString());
                    searched_reservation.Upfront_Pay = float.Parse(dr["UPFRONT_PAY"].ToString());
                    searched_reservation.Status_Name = dr["STATUS_NAME"].ToString();
                }
                return searched_reservation;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public bool GetReservationForCheckIn(int parameter_1)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spSetCheckIn", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_reservation", parameter_1);

                SqlDataReader dr = cmd.ExecuteReader();
                //CheckInformationModel searched_reservation = new CheckInformationModel();

                if (dr.Read())
                {
                    MessageBox.Show("The status has been changed.");
                }
                else
                {
                    MessageBox.Show("The status is already changed.");
                }
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hubo un error al retornar los datos." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
