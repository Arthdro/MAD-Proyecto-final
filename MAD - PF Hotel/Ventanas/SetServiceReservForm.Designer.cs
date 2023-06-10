namespace MAD___PF_Hotel.Ventanas
{
    partial class SetServiceReservForm
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
            this.label19 = new System.Windows.Forms.Label();
            this.txtboxResvervationID = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblIDReserv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxServices = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.serviceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddSerivece = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(127, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 28);
            this.label19.TabIndex = 120;
            this.label19.Text = "Search reservation:";
            // 
            // txtboxResvervationID
            // 
            this.txtboxResvervationID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxResvervationID.Location = new System.Drawing.Point(318, 104);
            this.txtboxResvervationID.Name = "txtboxResvervationID";
            this.txtboxResvervationID.Size = new System.Drawing.Size(319, 34);
            this.txtboxResvervationID.TabIndex = 119;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(654, 101);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(194, 38);
            this.btnSearchClient.TabIndex = 118;
            this.btnSearchClient.Text = "Search reservation";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(344, 202);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 28);
            this.lblClientName.TabIndex = 117;
            // 
            // lblIDReserv
            // 
            this.lblIDReserv.AutoSize = true;
            this.lblIDReserv.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDReserv.Location = new System.Drawing.Point(344, 164);
            this.lblIDReserv.Name = "lblIDReserv";
            this.lblIDReserv.Size = new System.Drawing.Size(0, 28);
            this.lblIDReserv.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 115;
            this.label2.Text = "Client name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 114;
            this.label1.Text = "ID Reservation: ";
            // 
            // cmboxServices
            // 
            this.cmboxServices.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxServices.FormattingEnabled = true;
            this.cmboxServices.Location = new System.Drawing.Point(318, 247);
            this.cmboxServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxServices.Name = "cmboxServices";
            this.cmboxServices.Size = new System.Drawing.Size(319, 36);
            this.cmboxServices.TabIndex = 148;
            this.cmboxServices.SelectedIndexChanged += new System.EventHandler(this.cmboxServices_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label15.Location = new System.Drawing.Point(179, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 28);
            this.label15.TabIndex = 147;
            this.label15.Text = "Select service:";
            // 
            // serviceQuantity
            // 
            this.serviceQuantity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceQuantity.Location = new System.Drawing.Point(318, 382);
            this.serviceQuantity.Name = "serviceQuantity";
            this.serviceQuantity.Size = new System.Drawing.Size(64, 34);
            this.serviceQuantity.TabIndex = 149;
            this.serviceQuantity.ValueChanged += new System.EventHandler(this.serviceQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.Location = new System.Drawing.Point(220, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 150;
            this.label3.Text = "Quantity:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(337, 337);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 28);
            this.lblDescription.TabIndex = 154;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(337, 299);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 28);
            this.lblPrice.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 152;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 151;
            this.label7.Text = "Price:";
            // 
            // btnAddSerivece
            // 
            this.btnAddSerivece.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSerivece.Location = new System.Drawing.Point(225, 493);
            this.btnAddSerivece.Name = "btnAddSerivece";
            this.btnAddSerivece.Size = new System.Drawing.Size(194, 38);
            this.btnAddSerivece.TabIndex = 155;
            this.btnAddSerivece.Text = "Add";
            this.btnAddSerivece.UseVisualStyleBackColor = true;
            this.btnAddSerivece.Click += new System.EventHandler(this.btnAddSerivece_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(540, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(194, 38);
            this.btnClose.TabIndex = 156;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SetServiceReservForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 706);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSerivece);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceQuantity);
            this.Controls.Add(this.cmboxServices);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtboxResvervationID);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblIDReserv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetServiceReservForm";
            this.Text = "SetServiceReservForm";
            this.Load += new System.EventHandler(this.SetServiceReservForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtboxResvervationID;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblIDReserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxServices;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown serviceQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddSerivece;
        private System.Windows.Forms.Button btnClose;
    }
}