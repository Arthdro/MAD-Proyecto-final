namespace MAD___PF_Hotel
{
    partial class AddRoomForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.cmboxCity = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmboxHotel = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmboxTypeBed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPriceNight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxRoomLevel = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTypeOfRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDQuantityBeds = new System.Windows.Forms.NumericUpDown();
            this.NUDQuantityRooms = new System.Windows.Forms.NumericUpDown();
            this.NUDAmounPeople = new System.Windows.Forms.NumericUpDown();
            this.cBoxWifi = new System.Windows.Forms.CheckBox();
            this.cBoxFullBathroom = new System.Windows.Forms.CheckBox();
            this.cBoxTVService = new System.Windows.Forms.CheckBox();
            this.cBoxAirCoinditioning = new System.Windows.Forms.CheckBox();
            this.cBoxNoSmokingRoom = new System.Windows.Forms.CheckBox();
            this.cBoxCofeeMachine = new System.Windows.Forms.CheckBox();
            this.cBoxAcousticInsolation = new System.Windows.Forms.CheckBox();
            this.cBoxToiletries = new System.Windows.Forms.CheckBox();
            this.cBoxMiniBar = new System.Windows.Forms.CheckBox();
            this.txtboxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxRoomName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantityBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantityRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmounPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label15.Location = new System.Drawing.Point(358, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 28);
            this.label15.TabIndex = 71;
            this.label15.Text = "Select city:";
            // 
            // cmboxCity
            // 
            this.cmboxCity.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxCity.FormattingEnabled = true;
            this.cmboxCity.Location = new System.Drawing.Point(468, 116);
            this.cmboxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxCity.Name = "cmboxCity";
            this.cmboxCity.Size = new System.Drawing.Size(331, 36);
            this.cmboxCity.TabIndex = 72;
            this.cmboxCity.SelectedIndexChanged += new System.EventHandler(this.cmboxCity_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label16.Location = new System.Drawing.Point(584, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 28);
            this.label16.TabIndex = 74;
            this.label16.Text = "Select hotel:";
            // 
            // cmboxHotel
            // 
            this.cmboxHotel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxHotel.FormattingEnabled = true;
            this.cmboxHotel.Location = new System.Drawing.Point(706, 196);
            this.cmboxHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxHotel.Name = "cmboxHotel";
            this.cmboxHotel.Size = new System.Drawing.Size(331, 36);
            this.cmboxHotel.TabIndex = 75;
            this.cmboxHotel.SelectedIndexChanged += new System.EventHandler(this.cmboxHotel_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label18.Location = new System.Drawing.Point(578, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 28);
            this.label18.TabIndex = 78;
            this.label18.Text = "Type of bed:";
            // 
            // cmboxTypeBed
            // 
            this.cmboxTypeBed.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxTypeBed.FormattingEnabled = true;
            this.cmboxTypeBed.Location = new System.Drawing.Point(706, 255);
            this.cmboxTypeBed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxTypeBed.Name = "cmboxTypeBed";
            this.cmboxTypeBed.Size = new System.Drawing.Size(331, 36);
            this.cmboxTypeBed.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.Location = new System.Drawing.Point(464, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Quantity of beds:";
            // 
            // txtboxPriceNight
            // 
            this.txtboxPriceNight.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxPriceNight.Location = new System.Drawing.Point(917, 431);
            this.txtboxPriceNight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPriceNight.Name = "txtboxPriceNight";
            this.txtboxPriceNight.Size = new System.Drawing.Size(97, 34);
            this.txtboxPriceNight.TabIndex = 81;
            this.txtboxPriceNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPriceNight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.Location = new System.Drawing.Point(740, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Price per night:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.Location = new System.Drawing.Point(209, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 84;
            this.label3.Text = "Amount of people:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label4.Location = new System.Drawing.Point(113, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 85;
            this.label4.Text = "Room level:";
            // 
            // cmboxRoomLevel
            // 
            this.cmboxRoomLevel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxRoomLevel.FormattingEnabled = true;
            this.cmboxRoomLevel.Location = new System.Drawing.Point(242, 255);
            this.cmboxRoomLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxRoomLevel.Name = "cmboxRoomLevel";
            this.cmboxRoomLevel.Size = new System.Drawing.Size(331, 36);
            this.cmboxRoomLevel.TabIndex = 86;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(760, 529);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 37);
            this.btnCancel.TabIndex = 87;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddTypeOfRoom
            // 
            this.btnAddTypeOfRoom.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnAddTypeOfRoom.Location = new System.Drawing.Point(540, 529);
            this.btnAddTypeOfRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTypeOfRoom.Name = "btnAddTypeOfRoom";
            this.btnAddTypeOfRoom.Size = new System.Drawing.Size(152, 37);
            this.btnAddTypeOfRoom.TabIndex = 88;
            this.btnAddTypeOfRoom.Text = " Add room";
            this.btnAddTypeOfRoom.UseVisualStyleBackColor = true;
            this.btnAddTypeOfRoom.Click += new System.EventHandler(this.btnAddTypeOfRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label5.Location = new System.Drawing.Point(705, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 90;
            this.label5.Text = "Quantity room:";
            // 
            // NUDQuantityBeds
            // 
            this.NUDQuantityBeds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDQuantityBeds.Location = new System.Drawing.Point(632, 319);
            this.NUDQuantityBeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDQuantityBeds.Name = "NUDQuantityBeds";
            this.NUDQuantityBeds.Size = new System.Drawing.Size(53, 34);
            this.NUDQuantityBeds.TabIndex = 126;
            // 
            // NUDQuantityRooms
            // 
            this.NUDQuantityRooms.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDQuantityRooms.Location = new System.Drawing.Point(856, 319);
            this.NUDQuantityRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDQuantityRooms.Name = "NUDQuantityRooms";
            this.NUDQuantityRooms.Size = new System.Drawing.Size(57, 34);
            this.NUDQuantityRooms.TabIndex = 127;
            // 
            // NUDAmounPeople
            // 
            this.NUDAmounPeople.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAmounPeople.Location = new System.Drawing.Point(393, 319);
            this.NUDAmounPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDAmounPeople.Name = "NUDAmounPeople";
            this.NUDAmounPeople.Size = new System.Drawing.Size(57, 34);
            this.NUDAmounPeople.TabIndex = 128;
            // 
            // cBoxWifi
            // 
            this.cBoxWifi.AutoSize = true;
            this.cBoxWifi.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWifi.Location = new System.Drawing.Point(128, 383);
            this.cBoxWifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxWifi.Name = "cBoxWifi";
            this.cBoxWifi.Size = new System.Drawing.Size(73, 32);
            this.cBoxWifi.TabIndex = 129;
            this.cBoxWifi.Text = "WiFi";
            this.cBoxWifi.UseVisualStyleBackColor = true;
            // 
            // cBoxFullBathroom
            // 
            this.cBoxFullBathroom.AutoSize = true;
            this.cBoxFullBathroom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFullBathroom.Location = new System.Drawing.Point(128, 459);
            this.cBoxFullBathroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxFullBathroom.Name = "cBoxFullBathroom";
            this.cBoxFullBathroom.Size = new System.Drawing.Size(158, 32);
            this.cBoxFullBathroom.TabIndex = 130;
            this.cBoxFullBathroom.Text = "Full bathroom";
            this.cBoxFullBathroom.UseVisualStyleBackColor = true;
            // 
            // cBoxTVService
            // 
            this.cBoxTVService.AutoSize = true;
            this.cBoxTVService.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTVService.Location = new System.Drawing.Point(305, 383);
            this.cBoxTVService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxTVService.Name = "cBoxTVService";
            this.cBoxTVService.Size = new System.Drawing.Size(126, 32);
            this.cBoxTVService.TabIndex = 131;
            this.cBoxTVService.Text = "T.V Service";
            this.cBoxTVService.UseVisualStyleBackColor = true;
            // 
            // cBoxAirCoinditioning
            // 
            this.cBoxAirCoinditioning.AutoSize = true;
            this.cBoxAirCoinditioning.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAirCoinditioning.Location = new System.Drawing.Point(305, 421);
            this.cBoxAirCoinditioning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAirCoinditioning.Name = "cBoxAirCoinditioning";
            this.cBoxAirCoinditioning.Size = new System.Drawing.Size(194, 32);
            this.cBoxAirCoinditioning.TabIndex = 132;
            this.cBoxAirCoinditioning.Text = "Air - coinditioning";
            this.cBoxAirCoinditioning.UseVisualStyleBackColor = true;
            // 
            // cBoxNoSmokingRoom
            // 
            this.cBoxNoSmokingRoom.AutoSize = true;
            this.cBoxNoSmokingRoom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNoSmokingRoom.Location = new System.Drawing.Point(305, 459);
            this.cBoxNoSmokingRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxNoSmokingRoom.Name = "cBoxNoSmokingRoom";
            this.cBoxNoSmokingRoom.Size = new System.Drawing.Size(202, 32);
            this.cBoxNoSmokingRoom.TabIndex = 133;
            this.cBoxNoSmokingRoom.Text = "No smoking rooms";
            this.cBoxNoSmokingRoom.UseVisualStyleBackColor = true;
            // 
            // cBoxCofeeMachine
            // 
            this.cBoxCofeeMachine.AutoSize = true;
            this.cBoxCofeeMachine.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCofeeMachine.Location = new System.Drawing.Point(128, 421);
            this.cBoxCofeeMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCofeeMachine.Name = "cBoxCofeeMachine";
            this.cBoxCofeeMachine.Size = new System.Drawing.Size(158, 32);
            this.cBoxCofeeMachine.TabIndex = 134;
            this.cBoxCofeeMachine.Text = "Coffe machine";
            this.cBoxCofeeMachine.UseVisualStyleBackColor = true;
            // 
            // cBoxAcousticInsolation
            // 
            this.cBoxAcousticInsolation.AutoSize = true;
            this.cBoxAcousticInsolation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAcousticInsolation.Location = new System.Drawing.Point(525, 383);
            this.cBoxAcousticInsolation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxAcousticInsolation.Name = "cBoxAcousticInsolation";
            this.cBoxAcousticInsolation.Size = new System.Drawing.Size(188, 32);
            this.cBoxAcousticInsolation.TabIndex = 135;
            this.cBoxAcousticInsolation.Text = "Acoustic isolation";
            this.cBoxAcousticInsolation.UseVisualStyleBackColor = true;
            // 
            // cBoxToiletries
            // 
            this.cBoxToiletries.AutoSize = true;
            this.cBoxToiletries.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxToiletries.Location = new System.Drawing.Point(525, 421);
            this.cBoxToiletries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxToiletries.Name = "cBoxToiletries";
            this.cBoxToiletries.Size = new System.Drawing.Size(111, 32);
            this.cBoxToiletries.TabIndex = 136;
            this.cBoxToiletries.Text = "Toiletries";
            this.cBoxToiletries.UseVisualStyleBackColor = true;
            // 
            // cBoxMiniBar
            // 
            this.cBoxMiniBar.AutoSize = true;
            this.cBoxMiniBar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMiniBar.Location = new System.Drawing.Point(525, 459);
            this.cBoxMiniBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxMiniBar.Name = "cBoxMiniBar";
            this.cBoxMiniBar.Size = new System.Drawing.Size(106, 32);
            this.cBoxMiniBar.TabIndex = 137;
            this.cBoxMiniBar.Text = "Mini Bar";
            this.cBoxMiniBar.UseVisualStyleBackColor = true;
            // 
            // txtboxSize
            // 
            this.txtboxSize.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxSize.Location = new System.Drawing.Point(917, 381);
            this.txtboxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxSize.Name = "txtboxSize";
            this.txtboxSize.Size = new System.Drawing.Size(71, 34);
            this.txtboxSize.TabIndex = 140;
            this.txtboxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxSize_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.Location = new System.Drawing.Point(786, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 141;
            this.label6.Text = "Room size:";
            // 
            // txtboxRoomName
            // 
            this.txtboxRoomName.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxRoomName.Location = new System.Drawing.Point(242, 196);
            this.txtboxRoomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxRoomName.Name = "txtboxRoomName";
            this.txtboxRoomName.Size = new System.Drawing.Size(331, 34);
            this.txtboxRoomName.TabIndex = 142;
            this.txtboxRoomName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRoomName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label7.Location = new System.Drawing.Point(106, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 143;
            this.label7.Text = "Room name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label8.Location = new System.Drawing.Point(888, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 28);
            this.label8.TabIndex = 144;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label9.Location = new System.Drawing.Point(993, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 28);
            this.label9.TabIndex = 145;
            this.label9.Text = "m²";
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 808);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxRoomName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxSize);
            this.Controls.Add(this.cBoxMiniBar);
            this.Controls.Add(this.cBoxToiletries);
            this.Controls.Add(this.cBoxAcousticInsolation);
            this.Controls.Add(this.cBoxCofeeMachine);
            this.Controls.Add(this.cBoxNoSmokingRoom);
            this.Controls.Add(this.cBoxAirCoinditioning);
            this.Controls.Add(this.cBoxTVService);
            this.Controls.Add(this.cBoxFullBathroom);
            this.Controls.Add(this.cBoxWifi);
            this.Controls.Add(this.NUDAmounPeople);
            this.Controls.Add(this.NUDQuantityRooms);
            this.Controls.Add(this.NUDQuantityBeds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddTypeOfRoom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmboxRoomLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPriceNight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxTypeBed);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmboxHotel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmboxCity);
            this.Controls.Add(this.label15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add type of room";
            this.Load += new System.EventHandler(this.CRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantityBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantityRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmounPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmboxCity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmboxHotel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmboxTypeBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPriceNight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxRoomLevel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTypeOfRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDQuantityBeds;
        private System.Windows.Forms.NumericUpDown NUDQuantityRooms;
        private System.Windows.Forms.NumericUpDown NUDAmounPeople;
        private System.Windows.Forms.CheckBox cBoxWifi;
        private System.Windows.Forms.CheckBox cBoxFullBathroom;
        private System.Windows.Forms.CheckBox cBoxTVService;
        private System.Windows.Forms.CheckBox cBoxAirCoinditioning;
        private System.Windows.Forms.CheckBox cBoxNoSmokingRoom;
        private System.Windows.Forms.CheckBox cBoxCofeeMachine;
        private System.Windows.Forms.CheckBox cBoxAcousticInsolation;
        private System.Windows.Forms.CheckBox cBoxToiletries;
        private System.Windows.Forms.CheckBox cBoxMiniBar;
        private System.Windows.Forms.TextBox txtboxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxRoomName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}