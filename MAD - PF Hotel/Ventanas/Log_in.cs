using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;

namespace MAD___PF_Hotel
{
   
    public partial class Log_in : Form
    {
        Conexion sqlConexion = new Conexion(); 
        public Log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var result = sqlConexion.Login(txtEmail.Text, txtPassword.Text);
            if (result == 0) {
                UserModel login_account = new UserModel();
                login_account = sqlConexion.GetUserData(txtEmail.Text, null);
                if (login_account.User_Type == 0)
                {                                        
                    OperatorForm OperatForm = new OperatorForm();
                    OperatForm.Get_Current_Session(txtEmail.Text);
                    this.Hide();
                    OperatForm.Show();
                }
                else 
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Get_Current_Session(txtEmail.Text);
                    this.Hide();
                    adminForm.Show();
                }
            }
            else if(result == 1)
            {
                MessageBox.Show("The email or password are invalid");
            }
            //else if (result == 1)
            //{
            //    OperatorForm operatorForm = new OperatorForm();
            //    this.Hide();
            //    operatorForm.Show();
            //}
            //else if (result == 2){
            //    MessageBox.Show("The email or password are invalid");
            //}
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
