namespace MAD___PF_Hotel
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
            this.pnlSubMenuReservation = new System.Windows.Forms.Panel();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlSubMenuEmployee = new System.Windows.Forms.Panel();
            this.btnSMEditEmployee = new System.Windows.Forms.Button();
            this.btnSMAddEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeManagment = new System.Windows.Forms.Button();
            this.pnlSubMenuHotelM = new System.Windows.Forms.Panel();
            this.btnSMAddToR = new System.Windows.Forms.Button();
            this.btnSubUpdateHotel = new System.Windows.Forms.Button();
            this.btnSubAddHotel = new System.Windows.Forms.Button();
            this.btnSMUpdateRoom = new System.Windows.Forms.Button();
            this.btnSMAddS = new System.Windows.Forms.Button();
            this.pnlSubMenuSR.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlSubMenuReservation.SuspendLayout();
            this.pnlSubMenuEmployee.SuspendLayout();
            this.pnlSubMenuHotelM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSRChild
            // 
            this.pnlSRChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlSRChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSRChild.Location = new System.Drawing.Point(200, 0);
            this.pnlSRChild.Name = "pnlSRChild";
            this.pnlSRChild.Size = new System.Drawing.Size(1117, 808);
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
            this.btnHM.Size = new System.Drawing.Size(179, 40);
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
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 808);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // pnlSubMenuReservation
            // 
            this.pnlSubMenuReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuReservation.Controls.Add(this.btnCancelReservation);
            this.pnlSubMenuReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuReservation.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuReservation.Location = new System.Drawing.Point(0, 831);
            this.pnlSubMenuReservation.Name = "pnlSubMenuReservation";
            this.pnlSubMenuReservation.Size = new System.Drawing.Size(179, 152);
            this.pnlSubMenuReservation.TabIndex = 9;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelReservation.FlatAppearance.BorderSize = 0;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelReservation.Location = new System.Drawing.Point(0, 0);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCancelReservation.Size = new System.Drawing.Size(179, 74);
            this.btnCancelReservation.TabIndex = 3;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservations.Location = new System.Drawing.Point(0, 789);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(179, 42);
            this.btnReservations.TabIndex = 8;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // pnlSubMenuEmployee
            // 
            this.pnlSubMenuEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuEmployee.Controls.Add(this.btnSMEditEmployee);
            this.pnlSubMenuEmployee.Controls.Add(this.btnSMAddEmployee);
            this.pnlSubMenuEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEmployee.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuEmployee.Location = new System.Drawing.Point(0, 645);
            this.pnlSubMenuEmployee.Name = "pnlSubMenuEmployee";
            this.pnlSubMenuEmployee.Size = new System.Drawing.Size(179, 144);
            this.pnlSubMenuEmployee.TabIndex = 7;
            // 
            // btnSMEditEmployee
            // 
            this.btnSMEditEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEditEmployee.FlatAppearance.BorderSize = 0;
            this.btnSMEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEditEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMEditEmployee.Location = new System.Drawing.Point(0, 69);
            this.btnSMEditEmployee.Name = "btnSMEditEmployee";
            this.btnSMEditEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMEditEmployee.Size = new System.Drawing.Size(179, 69);
            this.btnSMEditEmployee.TabIndex = 2;
            this.btnSMEditEmployee.Text = "Edit employee";
            this.btnSMEditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEditEmployee.UseVisualStyleBackColor = true;
            this.btnSMEditEmployee.Click += new System.EventHandler(this.btnSMEditEmployee_Click);
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
            this.btnEmployeeManagment.Location = new System.Drawing.Point(0, 579);
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
            this.pnlSubMenuHotelM.Controls.Add(this.btnSMAddS);
            this.pnlSubMenuHotelM.Controls.Add(this.btnSMUpdateRoom);
            this.pnlSubMenuHotelM.Controls.Add(this.btnSMAddToR);
            this.pnlSubMenuHotelM.Controls.Add(this.btnSubUpdateHotel);
            this.pnlSubMenuHotelM.Controls.Add(this.btnSubAddHotel);
            this.pnlSubMenuHotelM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuHotelM.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.pnlSubMenuHotelM.Location = new System.Drawing.Point(0, 397);
            this.pnlSubMenuHotelM.Name = "pnlSubMenuHotelM";
            this.pnlSubMenuHotelM.Size = new System.Drawing.Size(179, 182);
            this.pnlSubMenuHotelM.TabIndex = 5;
            // 
            // btnSMAddToR
            // 
            this.btnSMAddToR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAddToR.FlatAppearance.BorderSize = 0;
            this.btnSMAddToR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAddToR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMAddToR.Location = new System.Drawing.Point(0, 70);
            this.btnSMAddToR.Name = "btnSMAddToR";
            this.btnSMAddToR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAddToR.Size = new System.Drawing.Size(179, 35);
            this.btnSMAddToR.TabIndex = 4;
            this.btnSMAddToR.Text = "Add rooms";
            this.btnSMAddToR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAddToR.UseVisualStyleBackColor = true;
            this.btnSMAddToR.Click += new System.EventHandler(this.btnSMAddToR_Click);
            // 
            // btnSubUpdateHotel
            // 
            this.btnSubUpdateHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUpdateHotel.FlatAppearance.BorderSize = 0;
            this.btnSubUpdateHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUpdateHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubUpdateHotel.Location = new System.Drawing.Point(0, 35);
            this.btnSubUpdateHotel.Name = "btnSubUpdateHotel";
            this.btnSubUpdateHotel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubUpdateHotel.Size = new System.Drawing.Size(179, 35);
            this.btnSubUpdateHotel.TabIndex = 3;
            this.btnSubUpdateHotel.Text = "Update Hotel";
            this.btnSubUpdateHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUpdateHotel.UseVisualStyleBackColor = true;
            this.btnSubUpdateHotel.Click += new System.EventHandler(this.btnSubUpdateHotel_Click);
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
            this.btnSubAddHotel.Size = new System.Drawing.Size(179, 35);
            this.btnSubAddHotel.TabIndex = 1;
            this.btnSubAddHotel.Text = "Add Hotel";
            this.btnSubAddHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAddHotel.UseVisualStyleBackColor = true;
            this.btnSubAddHotel.Click += new System.EventHandler(this.btnSubAddHotel_Click);
            // 
            // btnSMUpdateRoom
            // 
            this.btnSMUpdateRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnSMUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMUpdateRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMUpdateRoom.Location = new System.Drawing.Point(0, 105);
            this.btnSMUpdateRoom.Name = "btnSMUpdateRoom";
            this.btnSMUpdateRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMUpdateRoom.Size = new System.Drawing.Size(179, 35);
            this.btnSMUpdateRoom.TabIndex = 6;
            this.btnSMUpdateRoom.Text = "Update room";
            this.btnSMUpdateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMUpdateRoom.UseVisualStyleBackColor = true;
            this.btnSMUpdateRoom.Click += new System.EventHandler(this.btnSMUpdateRoom_Click);
            // 
            // btnSMAddS
            // 
            this.btnSMAddS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAddS.FlatAppearance.BorderSize = 0;
            this.btnSMAddS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAddS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSMAddS.Location = new System.Drawing.Point(0, 140);
            this.btnSMAddS.Name = "btnSMAddS";
            this.btnSMAddS.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAddS.Size = new System.Drawing.Size(179, 35);
            this.btnSMAddS.TabIndex = 7;
            this.btnSMAddS.Text = "Add Service";
            this.btnSMAddS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAddS.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 808);
            this.Controls.Add(this.pnlSRChild);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quetzal Travels - Administrator Menu";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlSubMenuSR.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlSubMenuReservation.ResumeLayout(false);
            this.pnlSubMenuEmployee.ResumeLayout(false);
            this.pnlSubMenuHotelM.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSubAddHotel;
        private System.Windows.Forms.Panel pnlSubMenuEmployee;
        private System.Windows.Forms.Button btnSMAddEmployee;
        private System.Windows.Forms.Button btnEmployeeManagment;
        private System.Windows.Forms.Panel pnlSubMenuReservation;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnSMEditEmployee;
        private System.Windows.Forms.Button btnSMAddToR;
        private System.Windows.Forms.Button btnSubUpdateHotel;
        private System.Windows.Forms.Button btnSMAddS;
        private System.Windows.Forms.Button btnSMUpdateRoom;
    }
}