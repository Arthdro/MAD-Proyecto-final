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

namespace MAD___PF_Hotel.Ventanas
{
    public partial class UpdateOperator : Form
    {
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        UserModel updated_user = new UserModel();
        AddressModel updated_address = new AddressModel();
        PhoneModel updated_phone = new PhoneModel();
        public UpdateOperator()
        {
            InitializeComponent();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

            if (rbtnByEmail.Checked == true)
            {
                string texted_client = txtboxUser.Text;

                updated_user = sqlConexion.GetUserData(texted_client, null);
                if (updated_user.Id_User == null)
                {
                    MessageBox.Show("There´s no user with that email.");
                    return;
                }
                else
                {
                    txtboxFirstNameOp.Text = updated_user.Names;
                    txtboxLastName1.Text = updated_user.Last_Name_One;
                    txtboxLastName2.Text = updated_user.Last_Name_Two;
                    txtboxPayrollNum.Text = updated_user.Payroll_No.ToString();
                    datetpDOB.Value = updated_user.Date_Birth;
                    txtboxEmailOp.Text = updated_user.Email;

                    updated_address = sqlConexion.GetAddresstDataForUsers(updated_user.Id_User);

                    updated_phone = sqlConexion.GetPhoneDataForUsers(updated_user.Id_User);

                    txtboxStreetOp.Text = updated_address.Street_Name;
                    txtboxHouseNoOp.Text = updated_address.House_Number;
                    txtboxSuburbOp.Text = updated_address.Suburb_Name;
                    txtboxZipCodeOp.Text = updated_address.Zip_Code;

                    txtboxHomePhoneOp.Text = updated_phone.Phone_Number;
                    txtboxCellPhoneOp.Text = updated_phone.Cellphone_Number;
                    return;
                }
            }
            else if (rbtnByPaymentRoll.Checked == true)
            {
                int texted_client = int.Parse(txtboxUser.Text);

                updated_user = sqlConexion.GetUserData(null, texted_client);
                if (updated_user.Id_User == null)
                {
                    MessageBox.Show("There´s no user with that payroll number.");
                    return;
                }
                else
                {
                    txtboxFirstNameOp.Text = updated_user.Names;
                    txtboxLastName1.Text = updated_user.Last_Name_One;
                    txtboxLastName2.Text = updated_user.Last_Name_Two;
                    txtboxPayrollNum.Text = updated_user.Payroll_No.ToString();
                    datetpDOB.Value = updated_user.Date_Birth;
                    txtboxEmailOp.Text = updated_user.Email;

                    updated_address = sqlConexion.GetAddresstDataForUsers(updated_user.Id_User);

                    updated_phone = sqlConexion.GetPhoneDataForUsers(updated_user.Id_User);

                    txtboxStreetOp.Text = updated_address.Street_Name;
                    txtboxHouseNoOp.Text = updated_address.House_Number;
                    txtboxSuburbOp.Text = updated_address.Suburb_Name;
                    txtboxZipCodeOp.Text = updated_address.Zip_Code;

                    txtboxHomePhoneOp.Text = updated_phone.Phone_Number;
                    txtboxCellPhoneOp.Text = updated_phone.Cellphone_Number;
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

        private void btnUpdateOp_Click(object sender, EventArgs e)
        {
            updated_user.Full_Name = txtboxFirstNameOp.Text + ' ' + txtboxLastName1.Text + ' ' + txtboxLastName2.Text;
            updated_user.Names = txtboxFirstNameOp.Text;
            updated_user.Last_Name_One = txtboxLastName1.Text;
            updated_user.Last_Name_Two = txtboxLastName2.Text;
            updated_user.Payroll_No = int.Parse(txtboxPayrollNum.Text);
            updated_user.Date_Birth = datetpDOB.Value;
            updated_user.Email = txtboxEmailOp.Text;

            updated_address.Street_Name=  txtboxStreetOp.Text;
            updated_address.House_Number = txtboxHouseNoOp.Text;
            updated_address.Suburb_Name = txtboxSuburbOp.Text;
            updated_address.Zip_Code = txtboxZipCodeOp.Text;

            updated_phone.Phone_Number = txtboxHomePhoneOp.Text;
            updated_phone.Cellphone_Number = txtboxCellPhoneOp.Text;

            if (ClientValidation(updated_user) || AddressValidation(updated_address) || PhoneValidation(updated_phone))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else if (!EmailValidation(updated_user.Email))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 carácteres, mayúsculas, minúsculas y números.");
            }
            else
            {
                bool resultHotel = sqlConexion.SetUser(updated_user, updated_address, updated_phone, current_session);

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

        private bool ClientValidation(UserModel aux_model)
        {
            if (aux_model.Full_Name == null || aux_model.Names == null || aux_model.Last_Name_One == null || 
                aux_model.Last_Name_Two == null || aux_model.Payroll_No == 0 || aux_model.Email == null || aux_model.Date_Birth == null)
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

        private void txtboxFirstNameOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLastName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxLastName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxStreetOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxSuburbOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxPayrollNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHouseNoOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxZipCodeOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxHomePhoneOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtboxCellPhoneOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
