namespace MAD___PF_Hotel
{
    partial class ReservationSystemForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboxSearchCity = new System.Windows.Forms.ComboBox();
            this.dgvSelectHotel = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveReserv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSelectRoom = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIVAprice = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAmountOfPeople = new System.Windows.Forms.Label();
            this.lblAmountOfBeds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnByRFC = new System.Windows.Forms.RadioButton();
            this.rbtnByEmail = new System.Windows.Forms.RadioButton();
            this.rbtnByName = new System.Windows.Forms.RadioButton();
            this.cmboxClientInfo = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblUpfrontPay = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Reservation information";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelOperation.Location = new System.Drawing.Point(708, 629);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(201, 42);
            this.btnCancelOperation.TabIndex = 84;
            this.btnCancelOperation.Text = "Cancel operation";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 92;
            this.label2.Text = "Check In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 91;
            this.label3.Text = "Check Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 90;
            this.label5.Text = "Select Hotel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 28);
            this.label6.TabIndex = 89;
            this.label6.Text = "Search city to visit:";
            // 
            // cmboxSearchCity
            // 
            this.cmboxSearchCity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxSearchCity.FormattingEnabled = true;
            this.cmboxSearchCity.Location = new System.Drawing.Point(224, 109);
            this.cmboxSearchCity.Name = "cmboxSearchCity";
            this.cmboxSearchCity.Size = new System.Drawing.Size(319, 36);
            this.cmboxSearchCity.TabIndex = 104;
            this.cmboxSearchCity.SelectedIndexChanged += new System.EventHandler(this.cmboxSearchCity_SelectedIndexChanged);
            // 
            // dgvSelectHotel
            // 
            this.dgvSelectHotel.AllowUserToAddRows = false;
            this.dgvSelectHotel.AllowUserToDeleteRows = false;
            this.dgvSelectHotel.AllowUserToOrderColumns = true;
            this.dgvSelectHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectHotel.Location = new System.Drawing.Point(35, 154);
            this.dgvSelectHotel.Name = "dgvSelectHotel";
            this.dgvSelectHotel.ReadOnly = true;
            this.dgvSelectHotel.RowHeadersWidth = 51;
            this.dgvSelectHotel.RowTemplate.Height = 24;
            this.dgvSelectHotel.Size = new System.Drawing.Size(874, 186);
            this.dgvSelectHotel.TabIndex = 105;
            this.dgvSelectHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectHotel_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 28);
            this.label9.TabIndex = 107;
            this.label9.Text = "Client:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(127, 529);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(176, 34);
            this.dtpCheckIn.TabIndex = 108;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(434, 529);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 34);
            this.dtpCheckOut.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 111;
            this.label7.Text = "Amount of people:";
            // 
            // btnSaveReserv
            // 
            this.btnSaveReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveReserv.Location = new System.Drawing.Point(707, 577);
            this.btnSaveReserv.Name = "btnSaveReserv";
            this.btnSaveReserv.Size = new System.Drawing.Size(202, 42);
            this.btnSaveReserv.TabIndex = 113;
            this.btnSaveReserv.Text = "Save reservation";
            this.btnSaveReserv.UseVisualStyleBackColor = true;
            this.btnSaveReserv.Click += new System.EventHandler(this.btnSaveReserv_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(742, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 28);
            this.label10.TabIndex = 118;
            this.label10.Text = "Total amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 28);
            this.label11.TabIndex = 115;
            this.label11.Text = "Amount of beds:";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(464, 50);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(170, 38);
            this.btnSearchClient.TabIndex = 73;
            this.btnSearchClient.Text = "Search Client";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(782, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 28);
            this.label13.TabIndex = 127;
            this.label13.Text = "Subtotal:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(828, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 28);
            this.label14.TabIndex = 129;
            this.label14.Text = "IVA:";
            // 
            // dgvSelectRoom
            // 
            this.dgvSelectRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectRoom.Location = new System.Drawing.Point(35, 379);
            this.dgvSelectRoom.Name = "dgvSelectRoom";
            this.dgvSelectRoom.RowHeadersWidth = 51;
            this.dgvSelectRoom.RowTemplate.Height = 24;
            this.dgvSelectRoom.Size = new System.Drawing.Size(737, 95);
            this.dgvSelectRoom.TabIndex = 132;
            this.dgvSelectRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectRoom_CellContentClick);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(881, 382);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 28);
            this.lblSubtotal.TabIndex = 133;
            // 
            // lblIVAprice
            // 
            this.lblIVAprice.AutoSize = true;
            this.lblIVAprice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVAprice.Location = new System.Drawing.Point(881, 431);
            this.lblIVAprice.Name = "lblIVAprice";
            this.lblIVAprice.Size = new System.Drawing.Size(0, 28);
            this.lblIVAprice.TabIndex = 134;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(881, 483);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 28);
            this.lblTotalAmount.TabIndex = 135;
            // 
            // lblAmountOfPeople
            // 
            this.lblAmountOfPeople.AutoSize = true;
            this.lblAmountOfPeople.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfPeople.Location = new System.Drawing.Point(226, 480);
            this.lblAmountOfPeople.Name = "lblAmountOfPeople";
            this.lblAmountOfPeople.Size = new System.Drawing.Size(0, 28);
            this.lblAmountOfPeople.TabIndex = 136;
            // 
            // lblAmountOfBeds
            // 
            this.lblAmountOfBeds.AutoSize = true;
            this.lblAmountOfBeds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfBeds.Location = new System.Drawing.Point(447, 481);
            this.lblAmountOfBeds.Name = "lblAmountOfBeds";
            this.lblAmountOfBeds.Size = new System.Drawing.Size(0, 28);
            this.lblAmountOfBeds.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 138;
            this.label1.Text = "Select Room:";
            // 
            // rbtnByRFC
            // 
            this.rbtnByRFC.AutoSize = true;
            this.rbtnByRFC.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByRFC.Location = new System.Drawing.Point(666, 96);
            this.rbtnByRFC.Name = "rbtnByRFC";
            this.rbtnByRFC.Size = new System.Drawing.Size(93, 32);
            this.rbtnByRFC.TabIndex = 141;
            this.rbtnByRFC.TabStop = true;
            this.rbtnByRFC.Text = "By RFC";
            this.rbtnByRFC.UseVisualStyleBackColor = true;
            // 
            // rbtnByEmail
            // 
            this.rbtnByEmail.AutoSize = true;
            this.rbtnByEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByEmail.Location = new System.Drawing.Point(666, 56);
            this.rbtnByEmail.Name = "rbtnByEmail";
            this.rbtnByEmail.Size = new System.Drawing.Size(106, 32);
            this.rbtnByEmail.TabIndex = 140;
            this.rbtnByEmail.TabStop = true;
            this.rbtnByEmail.Text = "By email";
            this.rbtnByEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnByName
            // 
            this.rbtnByName.AutoSize = true;
            this.rbtnByName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByName.Location = new System.Drawing.Point(665, 16);
            this.rbtnByName.Name = "rbtnByName";
            this.rbtnByName.Size = new System.Drawing.Size(107, 32);
            this.rbtnByName.TabIndex = 139;
            this.rbtnByName.TabStop = true;
            this.rbtnByName.Text = "By name";
            this.rbtnByName.UseVisualStyleBackColor = true;
            // 
            // cmboxClientInfo
            // 
            this.cmboxClientInfo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxClientInfo.FormattingEnabled = true;
            this.cmboxClientInfo.Location = new System.Drawing.Point(128, 52);
            this.cmboxClientInfo.Name = "cmboxClientInfo";
            this.cmboxClientInfo.Size = new System.Drawing.Size(319, 36);
            this.cmboxClientInfo.TabIndex = 142;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckAvailability.Location = new System.Drawing.Point(707, 526);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(202, 42);
            this.btnCheckAvailability.TabIndex = 143;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 28);
            this.label8.TabIndex = 149;
            this.label8.Text = "Payment method:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 577);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 28);
            this.label12.TabIndex = 150;
            this.label12.Text = "Upfront payment:";
            // 
            // cBoxPaymentMethod
            // 
            this.cBoxPaymentMethod.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPaymentMethod.FormattingEnabled = true;
            this.cBoxPaymentMethod.Location = new System.Drawing.Point(48, 610);
            this.cBoxPaymentMethod.Name = "cBoxPaymentMethod";
            this.cBoxPaymentMethod.Size = new System.Drawing.Size(319, 36);
            this.cBoxPaymentMethod.TabIndex = 153;
            // 
            // lblUpfrontPay
            // 
            this.lblUpfrontPay.AutoSize = true;
            this.lblUpfrontPay.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpfrontPay.Location = new System.Drawing.Point(504, 615);
            this.lblUpfrontPay.Name = "lblUpfrontPay";
            this.lblUpfrontPay.Size = new System.Drawing.Size(0, 28);
            this.lblUpfrontPay.TabIndex = 157;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(652, 480);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 28);
            this.lblRoomNumber.TabIndex = 159;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(504, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 28);
            this.label16.TabIndex = 158;
            this.label16.Text = "Room number:";
            // 
            // ReservationSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 763);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblUpfrontPay);
            this.Controls.Add(this.cBoxPaymentMethod);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.cmboxClientInfo);
            this.Controls.Add(this.rbtnByRFC);
            this.Controls.Add(this.rbtnByEmail);
            this.Controls.Add(this.rbtnByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAmountOfBeds);
            this.Controls.Add(this.lblAmountOfPeople);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblIVAprice);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dgvSelectRoom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveReserv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvSelectHotel);
            this.Controls.Add(this.cmboxSearchCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchClient);
            this.Name = "ReservationSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation system";
            this.Load += new System.EventHandler(this.CancelReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboxSearchCity;
        private System.Windows.Forms.DataGridView dgvSelectHotel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveReserv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSelectRoom;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIVAprice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAmountOfPeople;
        private System.Windows.Forms.Label lblAmountOfBeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnByRFC;
        private System.Windows.Forms.RadioButton rbtnByEmail;
        private System.Windows.Forms.RadioButton rbtnByName;
        private System.Windows.Forms.ComboBox cmboxClientInfo;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBoxPaymentMethod;
        private System.Windows.Forms.Label lblUpfrontPay;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label label16;
    }
}