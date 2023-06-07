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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD___PF_Hotel
{
    public partial class AddOperator : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        public AddOperator()
        {
            InitializeComponent();
            cboxTypeOfUser.DisplayMember = "Text";
            cboxTypeOfUser.ValueMember = "Value";

            cboxTypeOfUser.Items.Add(new { Text = "Operator", Value = "0" });
            cboxTypeOfUser.Items.Add(new { Text = "Administrator", Value = "1" });

        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public ComboboxItem(string texto, double valor)
            {
                this.Text = texto;
                this.Value = valor;
            }
        }
        private void AddOperator_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            UserModel new_user = new UserModel();
            AddressModel new_address = new AddressModel();
            PhoneModel new_phone = new PhoneModel();

            string algo = null;

            new_user.Full_Name = txtboxFirstNameOp.Text + " " + txtboxLastName1.Text + " " + txtboxLastName2.Text;
            new_user.Names = txtboxFirstNameOp.Text;
            new_user.Last_Name_One = txtboxLastName1.Text;
            new_user.Last_Name_Two = txtboxLastName2.Text;
            new_user.Date_Birth = datetpDOB.Value;
            new_user.Payroll_No = Blank_Space_Validation(txtboxPayrollNum.Text);
            new_user.Email = txtboxEmailOp.Text;
            new_user.User_Password = txtboxPasswordOp.Text;           
            new_user.User_Type = type_Of_User(cboxTypeOfUser.Text);

            new_address.Street_Name = txtboxStreetOp.Text;
            new_address.House_Number = txtboxHouseNoOp.Text;
            new_address.Suburb_Name = txtboxSuburbOp.Text;
            new_address.Zip_Code = txtboxZipCodeOp.Text;

            new_phone.Phone_Number = txtboxHomePhoneOp.Text;
            new_phone.Cellphone_Number = txtboxCellPhoneOp.Text;



            bool resultUser = sqlConexion.SetUser(new_user, new_address, new_phone, current_session);

            if (resultUser)
            {
                this.Hide();
                MessageBox.Show("The operator fue agregado a la base de datos.");
            }
            else
            {
                MessageBox.Show("The email or password are invalid");
            }
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }
        private int Blank_Space_Validation(string aux)
        {
            if (aux == "")
            {
                return 0; ;
            }
            else
            {
                return int.Parse(aux);
            }
        }
        private int type_Of_User(string aux)
        {
            if (aux == "Administrator")
            {
                return 1; ;
            }
            else if (aux == "Operator")
            {
                return 0;
            }
            else
            {
                return 2;
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

