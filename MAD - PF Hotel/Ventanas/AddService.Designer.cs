namespace MAD___PF_Hotel.Ventanas
{
    partial class AddServicetoHotel
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxServiceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.cmboxCity = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxServiceDescrp = new System.Windows.Forms.TextBox();
            this.dgvHotelInfo = new System.Windows.Forms.DataGridView();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label8.Location = new System.Drawing.Point(365, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 28);
            this.label8.TabIndex = 174;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label7.Location = new System.Drawing.Point(216, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 173;
            this.label7.Text = "Service name:";
            // 
            // txtboxServiceName
            // 
            this.txtboxServiceName.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxServiceName.Location = new System.Drawing.Point(363, 367);
            this.txtboxServiceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxServiceName.Name = "txtboxServiceName";
            this.txtboxServiceName.Size = new System.Drawing.Size(331, 34);
            this.txtboxServiceName.TabIndex = 172;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.Location = new System.Drawing.Point(301, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 171;
            this.label6.Text = "Price:";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxPrice.Location = new System.Drawing.Point(394, 461);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(97, 34);
            this.txtboxPrice.TabIndex = 170;
            // 
            // cmboxCity
            // 
            this.cmboxCity.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cmboxCity.FormattingEnabled = true;
            this.cmboxCity.Location = new System.Drawing.Point(363, 34);
            this.cmboxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxCity.Name = "cmboxCity";
            this.cmboxCity.Size = new System.Drawing.Size(331, 36);
            this.cmboxCity.TabIndex = 146;
            this.cmboxCity.SelectedIndexChanged += new System.EventHandler(this.cmboxCity_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label15.Location = new System.Drawing.Point(253, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 28);
            this.label15.TabIndex = 145;
            this.label15.Text = "Select city:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.Location = new System.Drawing.Point(166, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 176;
            this.label1.Text = "Service description:";
            // 
            // txtboxServiceDescrp
            // 
            this.txtboxServiceDescrp.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtboxServiceDescrp.Location = new System.Drawing.Point(363, 414);
            this.txtboxServiceDescrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxServiceDescrp.Name = "txtboxServiceDescrp";
            this.txtboxServiceDescrp.Size = new System.Drawing.Size(331, 34);
            this.txtboxServiceDescrp.TabIndex = 175;
            // 
            // dgvHotelInfo
            // 
            this.dgvHotelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelInfo.Location = new System.Drawing.Point(27, 95);
            this.dgvHotelInfo.Name = "dgvHotelInfo";
            this.dgvHotelInfo.RowHeadersWidth = 51;
            this.dgvHotelInfo.RowTemplate.Height = 24;
            this.dgvHotelInfo.Size = new System.Drawing.Size(911, 246);
            this.dgvHotelInfo.TabIndex = 177;
            this.dgvHotelInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotelInfo_CellContentClick);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(416, 574);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(141, 37);
            this.btnAddService.TabIndex = 178;
            this.btnAddService.Text = "button1";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.Location = new System.Drawing.Point(499, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 179;
            this.label2.Text = "MXM";
            // 
            // AddServicetoHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 706);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dgvHotelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxServiceDescrp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxServiceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.cmboxCity);
            this.Controls.Add(this.label15);
            this.Name = "AddServicetoHotel";
            this.Text = "Add a service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxServiceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.ComboBox cmboxCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxServiceDescrp;
        private System.Windows.Forms.DataGridView dgvHotelInfo;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label2;
    }
}