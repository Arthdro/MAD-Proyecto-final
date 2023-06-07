namespace MAD___PF_Hotel.Ventanas
{
    partial class ExtendReservationForm
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
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUpfrontPay = new System.Windows.Forms.Label();
            this.cBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmountOfBeds = new System.Windows.Forms.Label();
            this.lblAmountOfPeople = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblIVAprice = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvSelectRoom = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveReserv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtboxReservation = new System.Windows.Forms.TextBox();
            this.btnSearchReserv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(654, 405);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 28);
            this.lblRoomNumber.TabIndex = 195;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(506, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 28);
            this.label16.TabIndex = 194;
            this.label16.Text = "Room number:";
            // 
            // lblUpfrontPay
            // 
            this.lblUpfrontPay.AutoSize = true;
            this.lblUpfrontPay.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpfrontPay.Location = new System.Drawing.Point(513, 538);
            this.lblUpfrontPay.Name = "lblUpfrontPay";
            this.lblUpfrontPay.Size = new System.Drawing.Size(0, 28);
            this.lblUpfrontPay.TabIndex = 193;
            // 
            // cBoxPaymentMethod
            // 
            this.cBoxPaymentMethod.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPaymentMethod.FormattingEnabled = true;
            this.cBoxPaymentMethod.Location = new System.Drawing.Point(57, 535);
            this.cBoxPaymentMethod.Name = "cBoxPaymentMethod";
            this.cBoxPaymentMethod.Size = new System.Drawing.Size(319, 36);
            this.cBoxPaymentMethod.TabIndex = 192;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(469, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 28);
            this.label12.TabIndex = 191;
            this.label12.Text = "Upfront payment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 28);
            this.label8.TabIndex = 190;
            this.label8.Text = "Payment method:";
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckAvailability.Location = new System.Drawing.Point(709, 451);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(202, 42);
            this.btnCheckAvailability.TabIndex = 188;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 183;
            this.label1.Text = "Select Room:";
            // 
            // lblAmountOfBeds
            // 
            this.lblAmountOfBeds.AutoSize = true;
            this.lblAmountOfBeds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfBeds.Location = new System.Drawing.Point(449, 406);
            this.lblAmountOfBeds.Name = "lblAmountOfBeds";
            this.lblAmountOfBeds.Size = new System.Drawing.Size(0, 28);
            this.lblAmountOfBeds.TabIndex = 182;
            // 
            // lblAmountOfPeople
            // 
            this.lblAmountOfPeople.AutoSize = true;
            this.lblAmountOfPeople.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfPeople.Location = new System.Drawing.Point(228, 405);
            this.lblAmountOfPeople.Name = "lblAmountOfPeople";
            this.lblAmountOfPeople.Size = new System.Drawing.Size(0, 28);
            this.lblAmountOfPeople.TabIndex = 181;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(803, 601);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 28);
            this.lblTotalAmount.TabIndex = 180;
            // 
            // lblIVAprice
            // 
            this.lblIVAprice.AutoSize = true;
            this.lblIVAprice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVAprice.Location = new System.Drawing.Point(803, 549);
            this.lblIVAprice.Name = "lblIVAprice";
            this.lblIVAprice.Size = new System.Drawing.Size(0, 28);
            this.lblIVAprice.TabIndex = 179;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(803, 500);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 28);
            this.lblSubtotal.TabIndex = 178;
            // 
            // dgvSelectRoom
            // 
            this.dgvSelectRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectRoom.Location = new System.Drawing.Point(37, 261);
            this.dgvSelectRoom.Name = "dgvSelectRoom";
            this.dgvSelectRoom.RowHeadersWidth = 51;
            this.dgvSelectRoom.RowTemplate.Height = 24;
            this.dgvSelectRoom.Size = new System.Drawing.Size(874, 126);
            this.dgvSelectRoom.TabIndex = 177;
            this.dgvSelectRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectRoom_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(752, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 28);
            this.label14.TabIndex = 176;
            this.label14.Text = "IVA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(706, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 28);
            this.label13.TabIndex = 175;
            this.label13.Text = "Subtotal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(666, 601);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 28);
            this.label10.TabIndex = 174;
            this.label10.Text = "Total amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 28);
            this.label11.TabIndex = 173;
            this.label11.Text = "Amount of beds:";
            // 
            // btnSaveReserv
            // 
            this.btnSaveReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveReserv.Location = new System.Drawing.Point(87, 605);
            this.btnSaveReserv.Name = "btnSaveReserv";
            this.btnSaveReserv.Size = new System.Drawing.Size(202, 42);
            this.btnSaveReserv.TabIndex = 172;
            this.btnSaveReserv.Text = "Save reservation";
            this.btnSaveReserv.UseVisualStyleBackColor = true;
            this.btnSaveReserv.Click += new System.EventHandler(this.btnSaveReserv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 171;
            this.label7.Text = "Amount of people:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(436, 454);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 34);
            this.dtpCheckOut.TabIndex = 189;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(129, 454);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(176, 34);
            this.dtpCheckIn.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 166;
            this.label2.Text = "Check In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 165;
            this.label3.Text = "Check Out:";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelOperation.Location = new System.Drawing.Point(312, 605);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(201, 42);
            this.btnCancelOperation.TabIndex = 162;
            this.btnCancelOperation.Text = "Cancel operation";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 28);
            this.label4.TabIndex = 161;
            this.label4.Text = "Reservation information";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(230, 192);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(0, 28);
            this.lblRoomName.TabIndex = 201;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.Location = new System.Drawing.Point(230, 116);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(0, 28);
            this.lblHotelName.TabIndex = 199;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 198;
            this.label5.Text = "Hotel name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 196;
            this.label9.Text = "Room name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 28);
            this.label15.TabIndex = 203;
            this.label15.Text = "Reservation code:";
            // 
            // txtboxReservation
            // 
            this.txtboxReservation.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxReservation.Location = new System.Drawing.Point(222, 62);
            this.txtboxReservation.Name = "txtboxReservation";
            this.txtboxReservation.Size = new System.Drawing.Size(581, 34);
            this.txtboxReservation.TabIndex = 202;
            // 
            // btnSearchReserv
            // 
            this.btnSearchReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchReserv.Location = new System.Drawing.Point(809, 59);
            this.btnSearchReserv.Name = "btnSearchReserv";
            this.btnSearchReserv.Size = new System.Drawing.Size(105, 42);
            this.btnSearchReserv.TabIndex = 204;
            this.btnSearchReserv.Text = "Search";
            this.btnSearchReserv.UseVisualStyleBackColor = true;
            this.btnSearchReserv.Click += new System.EventHandler(this.btnSearchReserv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 197;
            this.label6.Text = "Client name:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(230, 154);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 28);
            this.lblClientName.TabIndex = 200;
            // 
            // ExtendReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 706);
            this.Controls.Add(this.btnSearchReserv);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtboxReservation);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblUpfrontPay);
            this.Controls.Add(this.cBoxPaymentMethod);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCheckAvailability);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.label4);
            this.Name = "ExtendReservationForm";
            this.Text = "ExtendReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblUpfrontPay;
        private System.Windows.Forms.ComboBox cBoxPaymentMethod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountOfBeds;
        private System.Windows.Forms.Label lblAmountOfPeople;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblIVAprice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.DataGridView dgvSelectRoom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveReserv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtboxReservation;
        private System.Windows.Forms.Button btnSearchReserv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClientName;
    }
}