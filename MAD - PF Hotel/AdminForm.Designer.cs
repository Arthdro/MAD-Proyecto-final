﻿namespace MAD___PF_Hotel
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSRChild = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnSR = new System.Windows.Forms.Button();
            this.pnlSubMenuSR = new System.Windows.Forms.Panel();
            this.btnSubHOR = new System.Windows.Forms.Button();
            this.btnSubCR = new System.Windows.Forms.Button();
            this.btnSubSR = new System.Windows.Forms.Button();
            this.btnHM = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenuEmployee = new System.Windows.Forms.Panel();
            this.btnSMAddEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeManagment = new System.Windows.Forms.Button();
            this.pnlSubMenuHotelM = new System.Windows.Forms.Panel();
            this.btnSMAddToR = new System.Windows.Forms.Button();
            this.btnSubAddHotel = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlSubMenuReservation = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.pnlSubMenuSR.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlSubMenuEmployee.SuspendLayout();
            this.pnlSubMenuHotelM.SuspendLayout();
            this.pnlSubMenuReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSRChild
            // 
            this.pnlSRChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlSRChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSRChild.Location = new System.Drawing.Point(200, 0);
            this.pnlSRChild.Name = "pnlSRChild";
            this.pnlSRChild.Size = new System.Drawing.Size(982, 653);
            this.pnlSRChild.TabIndex = 1;
            this.pnlSRChild.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSRChild_Paint);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(179, 131);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnSR
            // 
            this.btnSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSR.FlatAppearance.BorderSize = 0;
            this.btnSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSR.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnSR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSR.Location = new System.Drawing.Point(0, 131);
            this.btnSR.Name = "btnSR";
            this.btnSR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSR.Size = new System.Drawing.Size(179, 44);
            this.btnSR.TabIndex = 1;
            this.btnSR.Text = "System Report";
            this.btnSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSR.UseVisualStyleBackColor = true;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // pnlSubMenuSR
            // 
            this.pnlSubMenuSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuSR.Controls.Add(this.btnSubHOR);
            this.pnlSubMenuSR.Controls.Add(this.btnSubCR);
            this.pnlSubMenuSR.Controls.Add(this.btnSubSR);
            this.pnlSubMenuSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSR.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuSR.Location = new System.Drawing.Point(0, 175);
            this.pnlSubMenuSR.Name = "pnlSubMenuSR";
            this.pnlSubMenuSR.Size = new System.Drawing.Size(179, 182);
            this.pnlSubMenuSR.TabIndex = 2;
            // 
            // btnSubHOR
            // 
            this.btnSubHOR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHOR.FlatAppearance.BorderSize = 0;
            this.btnSubHOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubHOR.Location = new System.Drawing.Point(0, 109);
            this.btnSubHOR.Name = "btnSubHOR";
            this.btnSubHOR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubHOR.Size = new System.Drawing.Size(179, 64);
            this.btnSubHOR.TabIndex = 3;
            this.btnSubHOR.Text = "Hotel occupancy report";
            this.btnSubHOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHOR.UseVisualStyleBackColor = true;
            this.btnSubHOR.Click += new System.EventHandler(this.btnSubHOR_Click);
            // 
            // btnSubCR
            // 
            this.btnSubCR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCR.FlatAppearance.BorderSize = 0;
            this.btnSubCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubCR.Location = new System.Drawing.Point(0, 43);
            this.btnSubCR.Name = "btnSubCR";
            this.btnSubCR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubCR.Size = new System.Drawing.Size(179, 66);
            this.btnSubCR.TabIndex = 2;
            this.btnSubCR.Text = "Customer record";
            this.btnSubCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCR.UseVisualStyleBackColor = true;
            this.btnSubCR.Click += new System.EventHandler(this.btnSubCR_Click);
            // 
            // btnSubSR
            // 
            this.btnSubSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubSR.FlatAppearance.BorderSize = 0;
            this.btnSubSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubSR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubSR.Location = new System.Drawing.Point(0, 0);
            this.btnSubSR.Name = "btnSubSR";
            this.btnSubSR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubSR.Size = new System.Drawing.Size(179, 43);
            this.btnSubSR.TabIndex = 1;
            this.btnSubSR.Text = "Sales Report";
            this.btnSubSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSR.UseVisualStyleBackColor = true;
            this.btnSubSR.Click += new System.EventHandler(this.btnSubSR_Click);
            // 
            // btnHM
            // 
            this.btnHM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHM.FlatAppearance.BorderSize = 0;
            this.btnHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHM.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnHM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHM.Location = new System.Drawing.Point(0, 357);
            this.btnHM.Name = "btnHM";
            this.btnHM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHM.Size = new System.Drawing.Size(179, 38);
            this.btnHM.TabIndex = 4;
            this.btnHM.Text = "Hotel managment";
            this.btnHM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHM.UseVisualStyleBackColor = true;
            this.btnHM.Click += new System.EventHandler(this.btnHM_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.AutoScroll = true;
            this.pnlMainMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMainMenu.Controls.Add(this.pnlSubMenuReservation);
            this.pnlMainMenu.Controls.Add(this.btnReservations);
            this.pnlMainMenu.Controls.Add(this.pnlSubMenuEmployee);
            this.pnlMainMenu.Controls.Add(this.btnEmployeeManagment);
            this.pnlMainMenu.Controls.Add(this.pnlSubMenuHotelM);
            this.pnlMainMenu.Controls.Add(this.btnHM);
            this.pnlMainMenu.Controls.Add(this.pnlSubMenuSR);
            this.pnlMainMenu.Controls.Add(this.btnSR);
            this.pnlMainMenu.Controls.Add(this.pnlLogo);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 653);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // pnlSubMenuEmployee
            // 
            this.pnlSubMenuEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuEmployee.Controls.Add(this.btnSMAddEmployee);
            this.pnlSubMenuEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEmployee.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuEmployee.Location = new System.Drawing.Point(0, 575);
            this.pnlSubMenuEmployee.Name = "pnlSubMenuEmployee";
            this.pnlSubMenuEmployee.Size = new System.Drawing.Size(179, 77);
            this.pnlSubMenuEmployee.TabIndex = 7;
            // 
            // btnSMAddEmployee
            // 
            this.btnSMAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnSMAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnSMAddEmployee.Name = "btnSMAddEmployee";
            this.btnSMAddEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAddEmployee.Size = new System.Drawing.Size(179, 69);
            this.btnSMAddEmployee.TabIndex = 1;
            this.btnSMAddEmployee.Text = "Add employee";
            this.btnSMAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAddEmployee.UseVisualStyleBackColor = true;
            this.btnSMAddEmployee.Click += new System.EventHandler(this.btnSMAddEmployee_Click);
            // 
            // btnEmployeeManagment
            // 
            this.btnEmployeeManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeManagment.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagment.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnEmployeeManagment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeManagment.Location = new System.Drawing.Point(0, 509);
            this.btnEmployeeManagment.Name = "btnEmployeeManagment";
            this.btnEmployeeManagment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployeeManagment.Size = new System.Drawing.Size(179, 66);
            this.btnEmployeeManagment.TabIndex = 6;
            this.btnEmployeeManagment.Text = "Employee Managment";
            this.btnEmployeeManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagment.UseVisualStyleBackColor = true;
            this.btnEmployeeManagment.Click += new System.EventHandler(this.btnEmployeeManagment_Click);
            // 
            // pnlSubMenuHotelM
            // 
            this.pnlSubMenuHotelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuHotelM.Controls.Add(this.btnSMAddToR);
            this.pnlSubMenuHotelM.Controls.Add(this.btnSubAddHotel);
            this.pnlSubMenuHotelM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuHotelM.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuHotelM.Location = new System.Drawing.Point(0, 395);
            this.pnlSubMenuHotelM.Name = "pnlSubMenuHotelM";
            this.pnlSubMenuHotelM.Size = new System.Drawing.Size(179, 114);
            this.pnlSubMenuHotelM.TabIndex = 5;
            // 
            // btnSMAddToR
            // 
            this.btnSMAddToR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAddToR.FlatAppearance.BorderSize = 0;
            this.btnSMAddToR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAddToR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMAddToR.Location = new System.Drawing.Point(0, 42);
            this.btnSMAddToR.Name = "btnSMAddToR";
            this.btnSMAddToR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAddToR.Size = new System.Drawing.Size(179, 64);
            this.btnSMAddToR.TabIndex = 2;
            this.btnSMAddToR.Text = "Add type of room";
            this.btnSMAddToR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAddToR.UseVisualStyleBackColor = true;
            this.btnSMAddToR.Click += new System.EventHandler(this.btnSMAddToR_Click);
            // 
            // btnSubAddHotel
            // 
            this.btnSubAddHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAddHotel.FlatAppearance.BorderSize = 0;
            this.btnSubAddHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAddHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubAddHotel.Location = new System.Drawing.Point(0, 0);
            this.btnSubAddHotel.Name = "btnSubAddHotel";
            this.btnSubAddHotel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubAddHotel.Size = new System.Drawing.Size(179, 42);
            this.btnSubAddHotel.TabIndex = 1;
            this.btnSubAddHotel.Text = "Add Hotel";
            this.btnSubAddHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAddHotel.UseVisualStyleBackColor = true;
            this.btnSubAddHotel.Click += new System.EventHandler(this.btnSubAddHotel_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservations.Location = new System.Drawing.Point(0, 652);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(179, 42);
            this.btnReservations.TabIndex = 8;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // pnlSubMenuReservation
            // 
            this.pnlSubMenuReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuReservation.Controls.Add(this.btnCancelReservation);
            this.pnlSubMenuReservation.Controls.Add(this.btnCheckOut);
            this.pnlSubMenuReservation.Controls.Add(this.btnCheckIn);
            this.pnlSubMenuReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuReservation.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuReservation.Location = new System.Drawing.Point(0, 694);
            this.pnlSubMenuReservation.Name = "pnlSubMenuReservation";
            this.pnlSubMenuReservation.Size = new System.Drawing.Size(179, 152);
            this.pnlSubMenuReservation.TabIndex = 9;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckIn.Location = new System.Drawing.Point(0, 0);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCheckIn.Size = new System.Drawing.Size(179, 45);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Location = new System.Drawing.Point(0, 45);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCheckOut.Size = new System.Drawing.Size(179, 40);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelReservation.FlatAppearance.BorderSize = 0;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelReservation.Location = new System.Drawing.Point(0, 85);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCancelReservation.Size = new System.Drawing.Size(179, 66);
            this.btnCancelReservation.TabIndex = 3;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlSRChild);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminForm";
            this.Text = "Quetzal Travels - Administrator Menu";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlSubMenuSR.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlSubMenuEmployee.ResumeLayout(false);
            this.pnlSubMenuHotelM.ResumeLayout(false);
            this.pnlSubMenuReservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSRChild;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.Panel pnlSubMenuSR;
        private System.Windows.Forms.Button btnSubHOR;
        private System.Windows.Forms.Button btnSubCR;
        private System.Windows.Forms.Button btnSubSR;
        private System.Windows.Forms.Button btnHM;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlSubMenuHotelM;
        private System.Windows.Forms.Button btnSMAddToR;
        private System.Windows.Forms.Button btnSubAddHotel;
        private System.Windows.Forms.Panel pnlSubMenuEmployee;
        private System.Windows.Forms.Button btnSMAddEmployee;
        private System.Windows.Forms.Button btnEmployeeManagment;
        private System.Windows.Forms.Panel pnlSubMenuReservation;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnCheckOut;
    }
}