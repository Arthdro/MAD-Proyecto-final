namespace MAD___PF_Hotel
{
    partial class AddHotelForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.checkTaxiService = new System.Windows.Forms.CheckBox();
            this.checkRestaurant = new System.Windows.Forms.CheckBox();
            this.checkMassage = new System.Windows.Forms.CheckBox();
            this.checkSwimPool = new System.Windows.Forms.CheckBox();
            this.checkEventRoom = new System.Windows.Forms.CheckBox();
            this.checkRoomServ = new System.Windows.Forms.CheckBox();
            this.checkWiFi = new System.Windows.Forms.CheckBox();
            this.checkGym = new System.Windows.Forms.CheckBox();
            this.dtpBeginOperations = new System.Windows.Forms.DateTimePicker();
            this.lblCity = new System.Windows.Forms.Label();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cBoxCountry = new System.Windows.Forms.ComboBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtboxHotelSuburb = new System.Windows.Forms.TextBox();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.txtboxHotelNumber = new System.Windows.Forms.TextBox();
            this.lblBeginOperations = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblNumberOfRooms = new System.Windows.Forms.Label();
            this.lblNumberOfFloors = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtboxNumberOfRooms = new System.Windows.Forms.TextBox();
            this.txtboxNumberOfFloors = new System.Windows.Forms.TextBox();
            this.txtboxHotelZipCode = new System.Windows.Forms.TextBox();
            this.txtboxHotelName = new System.Windows.Forms.TextBox();
            this.txtboxHotelStreet = new System.Windows.Forms.TextBox();
            this.cBoxCity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.cBoxCity);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddHotel);
            this.panel1.Controls.Add(this.checkTaxiService);
            this.panel1.Controls.Add(this.checkRestaurant);
            this.panel1.Controls.Add(this.checkMassage);
            this.panel1.Controls.Add(this.checkSwimPool);
            this.panel1.Controls.Add(this.checkEventRoom);
            this.panel1.Controls.Add(this.checkRoomServ);
            this.panel1.Controls.Add(this.checkWiFi);
            this.panel1.Controls.Add(this.checkGym);
            this.panel1.Controls.Add(this.dtpBeginOperations);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.cBoxState);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.cBoxCountry);
            this.panel1.Controls.Add(this.lblSuburb);
            this.panel1.Controls.Add(this.txtboxHotelSuburb);
            this.panel1.Controls.Add(this.lblHouseNumber);
            this.panel1.Controls.Add(this.txtboxHotelNumber);
            this.panel1.Controls.Add(this.lblBeginOperations);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblNumberOfRooms);
            this.panel1.Controls.Add(this.lblNumberOfFloors);
            this.panel1.Controls.Add(this.lblZipCode);
            this.panel1.Controls.Add(this.lblHotelName);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Controls.Add(this.txtboxNumberOfRooms);
            this.panel1.Controls.Add(this.txtboxNumberOfFloors);
            this.panel1.Controls.Add(this.txtboxHotelZipCode);
            this.panel1.Controls.Add(this.txtboxHotelName);
            this.panel1.Controls.Add(this.txtboxHotelStreet);
            this.panel1.Location = new System.Drawing.Point(108, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 525);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(665, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 36);
            this.btnCancel.TabIndex = 154;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHotel.Location = new System.Drawing.Point(665, 407);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(138, 36);
            this.btnAddHotel.TabIndex = 153;
            this.btnAddHotel.Text = "Add Hotel";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // checkTaxiService
            // 
            this.checkTaxiService.AutoSize = true;
            this.checkTaxiService.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkTaxiService.Location = new System.Drawing.Point(668, 330);
            this.checkTaxiService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTaxiService.Name = "checkTaxiService";
            this.checkTaxiService.Size = new System.Drawing.Size(134, 32);
            this.checkTaxiService.TabIndex = 152;
            this.checkTaxiService.Text = "Taxi Service";
            this.checkTaxiService.UseVisualStyleBackColor = true;
            // 
            // checkRestaurant
            // 
            this.checkRestaurant.AutoSize = true;
            this.checkRestaurant.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkRestaurant.Location = new System.Drawing.Point(668, 288);
            this.checkRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRestaurant.Name = "checkRestaurant";
            this.checkRestaurant.Size = new System.Drawing.Size(126, 32);
            this.checkRestaurant.TabIndex = 151;
            this.checkRestaurant.Text = "Restaurant";
            this.checkRestaurant.UseVisualStyleBackColor = true;
            // 
            // checkMassage
            // 
            this.checkMassage.AutoSize = true;
            this.checkMassage.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkMassage.Location = new System.Drawing.Point(668, 248);
            this.checkMassage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMassage.Name = "checkMassage";
            this.checkMassage.Size = new System.Drawing.Size(110, 32);
            this.checkMassage.TabIndex = 150;
            this.checkMassage.Text = "Massage";
            this.checkMassage.UseVisualStyleBackColor = true;
            // 
            // checkSwimPool
            // 
            this.checkSwimPool.AutoSize = true;
            this.checkSwimPool.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkSwimPool.Location = new System.Drawing.Point(668, 207);
            this.checkSwimPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSwimPool.Name = "checkSwimPool";
            this.checkSwimPool.Size = new System.Drawing.Size(172, 32);
            this.checkSwimPool.TabIndex = 149;
            this.checkSwimPool.Text = "Swimming pool";
            this.checkSwimPool.UseVisualStyleBackColor = true;
            // 
            // checkEventRoom
            // 
            this.checkEventRoom.AutoSize = true;
            this.checkEventRoom.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkEventRoom.Location = new System.Drawing.Point(668, 167);
            this.checkEventRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEventRoom.Name = "checkEventRoom";
            this.checkEventRoom.Size = new System.Drawing.Size(135, 32);
            this.checkEventRoom.TabIndex = 148;
            this.checkEventRoom.Text = "Event room";
            this.checkEventRoom.UseVisualStyleBackColor = true;
            // 
            // checkRoomServ
            // 
            this.checkRoomServ.AutoSize = true;
            this.checkRoomServ.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkRoomServ.Location = new System.Drawing.Point(668, 125);
            this.checkRoomServ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRoomServ.Name = "checkRoomServ";
            this.checkRoomServ.Size = new System.Drawing.Size(154, 32);
            this.checkRoomServ.TabIndex = 147;
            this.checkRoomServ.Text = "Room Service";
            this.checkRoomServ.UseVisualStyleBackColor = true;
            // 
            // checkWiFi
            // 
            this.checkWiFi.AutoSize = true;
            this.checkWiFi.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkWiFi.Location = new System.Drawing.Point(668, 84);
            this.checkWiFi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWiFi.Name = "checkWiFi";
            this.checkWiFi.Size = new System.Drawing.Size(73, 32);
            this.checkWiFi.TabIndex = 146;
            this.checkWiFi.Text = "WiFi";
            this.checkWiFi.UseVisualStyleBackColor = true;
            // 
            // checkGym
            // 
            this.checkGym.AutoSize = true;
            this.checkGym.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.checkGym.Location = new System.Drawing.Point(668, 43);
            this.checkGym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkGym.Name = "checkGym";
            this.checkGym.Size = new System.Drawing.Size(75, 32);
            this.checkGym.TabIndex = 145;
            this.checkGym.Text = "Gym";
            this.checkGym.UseVisualStyleBackColor = true;
            // 
            // dtpBeginOperations
            // 
            this.dtpBeginOperations.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.dtpBeginOperations.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginOperations.Location = new System.Drawing.Point(304, 457);
            this.dtpBeginOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBeginOperations.Name = "dtpBeginOperations";
            this.dtpBeginOperations.Size = new System.Drawing.Size(313, 34);
            this.dtpBeginOperations.TabIndex = 144;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblCity.Location = new System.Drawing.Point(224, 415);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 28);
            this.lblCity.TabIndex = 142;
            this.lblCity.Text = "City:";
            // 
            // cBoxState
            // 
            this.cBoxState.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Location = new System.Drawing.Point(304, 371);
            this.cBoxState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(313, 36);
            this.cBoxState.TabIndex = 141;
            this.cBoxState.SelectedIndexChanged += new System.EventHandler(this.cBoxState_SelectedIndexChanged_1);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblState.Location = new System.Drawing.Point(214, 372);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 28);
            this.lblState.TabIndex = 140;
            this.lblState.Text = "State:";
            // 
            // cBoxCountry
            // 
            this.cBoxCountry.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cBoxCountry.FormattingEnabled = true;
            this.cBoxCountry.Location = new System.Drawing.Point(304, 328);
            this.cBoxCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCountry.Name = "cBoxCountry";
            this.cBoxCountry.Size = new System.Drawing.Size(313, 36);
            this.cBoxCountry.TabIndex = 139;
            this.cBoxCountry.SelectedIndexChanged += new System.EventHandler(this.cBoxCountry_SelectedIndexChanged_1);
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblSuburb.Location = new System.Drawing.Point(194, 165);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(80, 28);
            this.lblSuburb.TabIndex = 138;
            this.lblSuburb.Text = "Suburb:";
            // 
            // txtboxHotelSuburb
            // 
            this.txtboxHotelSuburb.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxHotelSuburb.Location = new System.Drawing.Point(304, 164);
            this.txtboxHotelSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHotelSuburb.Name = "txtboxHotelSuburb";
            this.txtboxHotelSuburb.Size = new System.Drawing.Size(313, 34);
            this.txtboxHotelSuburb.TabIndex = 137;
            this.txtboxHotelSuburb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHotelSuburb_KeyPress);
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblHouseNumber.Location = new System.Drawing.Point(129, 126);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(145, 28);
            this.lblHouseNumber.TabIndex = 136;
            this.lblHouseNumber.Text = "House number:";
            // 
            // txtboxHotelNumber
            // 
            this.txtboxHotelNumber.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxHotelNumber.Location = new System.Drawing.Point(304, 123);
            this.txtboxHotelNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHotelNumber.Name = "txtboxHotelNumber";
            this.txtboxHotelNumber.Size = new System.Drawing.Size(313, 34);
            this.txtboxHotelNumber.TabIndex = 135;
            this.txtboxHotelNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHotelNumber_KeyPress);
            // 
            // lblBeginOperations
            // 
            this.lblBeginOperations.AutoSize = true;
            this.lblBeginOperations.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblBeginOperations.Location = new System.Drawing.Point(48, 458);
            this.lblBeginOperations.Name = "lblBeginOperations";
            this.lblBeginOperations.Size = new System.Drawing.Size(226, 28);
            this.lblBeginOperations.TabIndex = 134;
            this.lblBeginOperations.Text = "Beginning of operations:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblCountry.Location = new System.Drawing.Point(186, 331);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 28);
            this.lblCountry.TabIndex = 133;
            this.lblCountry.Text = "Country:";
            // 
            // lblNumberOfRooms
            // 
            this.lblNumberOfRooms.AutoSize = true;
            this.lblNumberOfRooms.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblNumberOfRooms.Location = new System.Drawing.Point(102, 288);
            this.lblNumberOfRooms.Name = "lblNumberOfRooms";
            this.lblNumberOfRooms.Size = new System.Drawing.Size(172, 28);
            this.lblNumberOfRooms.TabIndex = 132;
            this.lblNumberOfRooms.Text = "Number of rooms:";
            // 
            // lblNumberOfFloors
            // 
            this.lblNumberOfFloors.AutoSize = true;
            this.lblNumberOfFloors.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblNumberOfFloors.Location = new System.Drawing.Point(108, 247);
            this.lblNumberOfFloors.Name = "lblNumberOfFloors";
            this.lblNumberOfFloors.Size = new System.Drawing.Size(166, 28);
            this.lblNumberOfFloors.TabIndex = 131;
            this.lblNumberOfFloors.Text = "Number of floors:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblZipCode.Location = new System.Drawing.Point(178, 208);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(95, 28);
            this.lblZipCode.TabIndex = 130;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblHotelName.Location = new System.Drawing.Point(157, 42);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(117, 28);
            this.lblHotelName.TabIndex = 129;
            this.lblHotelName.Text = "Hotel name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblStreet.Location = new System.Drawing.Point(154, 83);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(120, 28);
            this.lblStreet.TabIndex = 128;
            this.lblStreet.Text = "Street name:";
            // 
            // txtboxNumberOfRooms
            // 
            this.txtboxNumberOfRooms.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxNumberOfRooms.Location = new System.Drawing.Point(304, 287);
            this.txtboxNumberOfRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxNumberOfRooms.Name = "txtboxNumberOfRooms";
            this.txtboxNumberOfRooms.Size = new System.Drawing.Size(313, 34);
            this.txtboxNumberOfRooms.TabIndex = 127;
            this.txtboxNumberOfRooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNumberOfRooms_KeyPress);
            // 
            // txtboxNumberOfFloors
            // 
            this.txtboxNumberOfFloors.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxNumberOfFloors.Location = new System.Drawing.Point(304, 247);
            this.txtboxNumberOfFloors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxNumberOfFloors.Name = "txtboxNumberOfFloors";
            this.txtboxNumberOfFloors.Size = new System.Drawing.Size(313, 34);
            this.txtboxNumberOfFloors.TabIndex = 126;
            this.txtboxNumberOfFloors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNumberOfFloors_KeyPress);
            // 
            // txtboxHotelZipCode
            // 
            this.txtboxHotelZipCode.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxHotelZipCode.Location = new System.Drawing.Point(304, 205);
            this.txtboxHotelZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHotelZipCode.Name = "txtboxHotelZipCode";
            this.txtboxHotelZipCode.Size = new System.Drawing.Size(313, 34);
            this.txtboxHotelZipCode.TabIndex = 125;
            this.txtboxHotelZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHotelZipCode_KeyPress);
            // 
            // txtboxHotelName
            // 
            this.txtboxHotelName.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxHotelName.Location = new System.Drawing.Point(304, 41);
            this.txtboxHotelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHotelName.Name = "txtboxHotelName";
            this.txtboxHotelName.Size = new System.Drawing.Size(313, 34);
            this.txtboxHotelName.TabIndex = 124;
            this.txtboxHotelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHotelName_KeyPress);
            // 
            // txtboxHotelStreet
            // 
            this.txtboxHotelStreet.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxHotelStreet.Location = new System.Drawing.Point(304, 82);
            this.txtboxHotelStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHotelStreet.Name = "txtboxHotelStreet";
            this.txtboxHotelStreet.Size = new System.Drawing.Size(313, 34);
            this.txtboxHotelStreet.TabIndex = 123;
            this.txtboxHotelStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxHotelStreet_KeyPress);
            // 
            // cBoxCity
            // 
            this.cBoxCity.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cBoxCity.FormattingEnabled = true;
            this.cBoxCity.Location = new System.Drawing.Point(304, 414);
            this.cBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCity.Name = "cBoxCity";
            this.cBoxCity.Size = new System.Drawing.Size(313, 36);
            this.cBoxCity.TabIndex = 155;
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1317, 808);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddHotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Report";
            this.Load += new System.EventHandler(this.HODForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.CheckBox checkTaxiService;
        private System.Windows.Forms.CheckBox checkRestaurant;
        private System.Windows.Forms.CheckBox checkMassage;
        private System.Windows.Forms.CheckBox checkSwimPool;
        private System.Windows.Forms.CheckBox checkEventRoom;
        private System.Windows.Forms.CheckBox checkRoomServ;
        private System.Windows.Forms.CheckBox checkWiFi;
        private System.Windows.Forms.CheckBox checkGym;
        private System.Windows.Forms.DateTimePicker dtpBeginOperations;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cBoxCountry;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtboxHotelSuburb;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox txtboxHotelNumber;
        private System.Windows.Forms.Label lblBeginOperations;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblNumberOfRooms;
        private System.Windows.Forms.Label lblNumberOfFloors;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtboxNumberOfRooms;
        private System.Windows.Forms.TextBox txtboxNumberOfFloors;
        private System.Windows.Forms.TextBox txtboxHotelZipCode;
        private System.Windows.Forms.TextBox txtboxHotelName;
        private System.Windows.Forms.TextBox txtboxHotelStreet;
        private System.Windows.Forms.ComboBox cBoxCity;
    }
}