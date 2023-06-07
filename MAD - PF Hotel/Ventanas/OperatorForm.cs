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
    public partial class OperatorForm : Form
    {
        #region Attributes
        private Form activeForm = null;
        Conexion sqlConexion = new Conexion();
        UserModel current_session = new UserModel();
        #endregion
        public OperatorForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

        }

        #region Hide_&_Show_Menus
        private void customizeDesing()
        {
            pnlSubMenuClient.Visible = false; //Hide submenu of System Reports
            pnlSubMenuReservation.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pnlSubMenuClient.Visible == true)
                pnlSubMenuClient.Visible = false;
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

        private void openChildSR(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            pnlOperatorSystemChild.Controls.Add(newForm);
            pnlOperatorSystemChild.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuClient);
        }

        public void Get_Current_Session(string aux_user)
        {
            current_session = sqlConexion.GetUserData(aux_user, null);
            return;
        }
        private void btnSubAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Get_Current_Session(current_session.Email);
            openChildSR(addClientForm);
        }

        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient updateClientForm = new UpdateClient();
            updateClientForm.Get_Current_Session(current_session.Email);
            openChildSR(updateClientForm);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuReservation);
        }

        private void btnSubMenuMakeR_Click(object sender, EventArgs e)
        {
            ReservationSystemForm reservationForm = new ReservationSystemForm();
            reservationForm.Get_Current_Session(current_session.Email);
            openChildSR(reservationForm);
            hideSubmenu();
        }

        private void btnSubMenuSearchR_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            openChildSR(checkInForm);
            checkInForm.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }

        private void btnSubMenuCheckout_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            openChildSR(checkOutForm);
            checkOutForm.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }

        private void btnSubMenuExtention_Click(object sender, EventArgs e)
        {
            ExtendReservationForm extendReserv = new ExtendReservationForm();
            openChildSR(extendReserv);
            extendReserv.Get_Current_Session(current_session.Email);
            hideSubmenu();
        }
    }
}
