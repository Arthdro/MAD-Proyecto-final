using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using MAD___PF_Hotel.Ventanas;
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
    public partial class AdminForm : Form
    {
        #region Attributes
        private Form activeForm = null;
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        #endregion

        public AdminForm()
        {
            InitializeComponent();
            customizeDesing();
        }
        
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        #region Hide_&_Show_Menus
        private void customizeDesing()
        {
            pnlSubMenuSR.Visible = false; //Hide submenu of System Reports
            pnlSubMenuHotelM.Visible = false; //Hide submenu of Hotel Management
            pnlSubMenuEmployee.Visible = false; //Hide submenu of Employee Management
            pnlSubMenuReservation.Visible = false;
        }
        
        private void hideSubmenu() 
        {
            if (pnlSubMenuSR.Visible == true)
                pnlSubMenuSR.Visible = false;
            if (pnlSubMenuHotelM.Visible == true)
                pnlSubMenuHotelM.Visible = false;
            if (pnlSubMenuEmployee.Visible == true)
                pnlSubMenuEmployee.Visible = false;
            if (pnlSubMenuReservation.Visible == true)
                pnlSubMenuReservation.Visible = false;
        }
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region System_Report
        private void btnSR_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuSR);
        }

        #region System_ReportSM
        /*private void button2_Click(object sender, EventArgs e)
        {
            //Don´t forget to place the next method in every button from the app
            hideSubmenu();
        }*/

        private void btnSubSR_Click(object sender, EventArgs e)
        {
            openChildSR(new ReportForSalesForm());
            hideSubmenu();
        }

        private void btnSubCR_Click(object sender, EventArgs e)
        {           
            hideSubmenu();
        }
        private void btnSubHOR_Click(object sender, EventArgs e)
        {
            ReportHotelOccupancy reportHotelOcc = new ReportHotelOccupancy();
            openChildSR(reportHotelOcc);
            //reportHotelOcc.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }
        #endregion

        #endregion

        #region Cancel_Reservation
        private void btnReservations_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuReservation);
        }
        #endregion

        #region Hotel_Managment
        private void btnHM_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuHotelM);
        }
        #endregion

        #region User_Managment
        private void btnUM_Click(object sender, EventArgs e)
        {
       
        }
        #endregion
        private void pnlSRChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openChildSR(Form newForm)
        {
            if (activeForm!=null) 
                activeForm.Close();

                activeForm = newForm;
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;
                pnlSRChild.Controls.Add(newForm);
                pnlSRChild.Tag = newForm;
                newForm.BringToFront();
                newForm.Show();
            
        }
        #region Hotel
        private void btnSubAddHotel_Click(object sender, EventArgs e)
        {
            AddHotelForm addHotel = new AddHotelForm();
            openChildSR(addHotel);
            addHotel.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }

        private void btnSubUpdateHotel_Click(object sender, EventArgs e)
        {
            UpdateHotel updateHotel = new UpdateHotel();
            updateHotel.Get_Current_Session(current_session.Email);
            openChildSR(updateHotel);
            hideSubmenu();
        }

        private void btnSMAddToR_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoom = new AddRoomForm();
            addRoom.Get_Current_Session(current_session.Email);
            openChildSR(addRoom);
            hideSubmenu(); 
        }
        #endregion

        #region Employee Management
        private void btnEmployeeManagment_Click(object sender, EventArgs e)
        {
            //openChildSR(new AddTypeOfRoomForm());
            showSubMenu(pnlSubMenuEmployee);
            //hideSubmenu();
        }
        private void btnSMAddEmployee_Click(object sender, EventArgs e)
        {
            AddOperator addOperator = new AddOperator();
            openChildSR(addOperator);
            addOperator.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }

        private void btnSMEditEmployee_Click(object sender, EventArgs e)
        {
            UpdateOperator updateOperator = new UpdateOperator();
            openChildSR(updateOperator);
            updateOperator.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }
        #endregion

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {

        }
    }
}
