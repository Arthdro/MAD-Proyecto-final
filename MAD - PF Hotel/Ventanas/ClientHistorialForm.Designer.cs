namespace MAD___PF_Hotel.Ventanas
{
    partial class ClientHistorialForm
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
            this.rbtnByRFC = new System.Windows.Forms.RadioButton();
            this.rbtnByEmail = new System.Windows.Forms.RadioButton();
            this.rbtnByName = new System.Windows.Forms.RadioButton();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxYear = new System.Windows.Forms.ComboBox();
            this.dgwClientHitorial = new System.Windows.Forms.DataGridView();
            this.cmBoxClientHistory = new System.Windows.Forms.ComboBox();
            this.btnShowHistorial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientHitorial)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnByRFC
            // 
            this.rbtnByRFC.AutoSize = true;
            this.rbtnByRFC.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByRFC.Location = new System.Drawing.Point(802, 23);
            this.rbtnByRFC.Name = "rbtnByRFC";
            this.rbtnByRFC.Size = new System.Drawing.Size(93, 32);
            this.rbtnByRFC.TabIndex = 150;
            this.rbtnByRFC.TabStop = true;
            this.rbtnByRFC.Text = "By RFC";
            this.rbtnByRFC.UseVisualStyleBackColor = true;
            // 
            // rbtnByEmail
            // 
            this.rbtnByEmail.AutoSize = true;
            this.rbtnByEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByEmail.Location = new System.Drawing.Point(688, 62);
            this.rbtnByEmail.Name = "rbtnByEmail";
            this.rbtnByEmail.Size = new System.Drawing.Size(106, 32);
            this.rbtnByEmail.TabIndex = 149;
            this.rbtnByEmail.TabStop = true;
            this.rbtnByEmail.Text = "By email";
            this.rbtnByEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnByName
            // 
            this.rbtnByName.AutoSize = true;
            this.rbtnByName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnByName.Location = new System.Drawing.Point(687, 22);
            this.rbtnByName.Name = "rbtnByName";
            this.rbtnByName.Size = new System.Drawing.Size(107, 32);
            this.rbtnByName.TabIndex = 148;
            this.rbtnByName.TabStop = true;
            this.rbtnByName.Text = "By name";
            this.rbtnByName.UseVisualStyleBackColor = true;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnSearchClient.Location = new System.Drawing.Point(524, 47);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(134, 40);
            this.btnSearchClient.TabIndex = 147;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label11.Location = new System.Drawing.Point(37, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 28);
            this.label11.TabIndex = 145;
            this.label11.Text = "Search client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 152;
            this.label2.Text = "Year:";
            // 
            // cmBoxYear
            // 
            this.cmBoxYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxYear.FormattingEnabled = true;
            this.cmBoxYear.Location = new System.Drawing.Point(177, 100);
            this.cmBoxYear.Name = "cmBoxYear";
            this.cmBoxYear.Size = new System.Drawing.Size(211, 36);
            this.cmBoxYear.TabIndex = 151;
            // 
            // dgwClientHitorial
            // 
            this.dgwClientHitorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientHitorial.Location = new System.Drawing.Point(42, 170);
            this.dgwClientHitorial.Name = "dgwClientHitorial";
            this.dgwClientHitorial.RowHeadersWidth = 51;
            this.dgwClientHitorial.RowTemplate.Height = 24;
            this.dgwClientHitorial.Size = new System.Drawing.Size(876, 329);
            this.dgwClientHitorial.TabIndex = 153;
            // 
            // cmBoxClientHistory
            // 
            this.cmBoxClientHistory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxClientHistory.FormattingEnabled = true;
            this.cmBoxClientHistory.Location = new System.Drawing.Point(177, 49);
            this.cmBoxClientHistory.Name = "cmBoxClientHistory";
            this.cmBoxClientHistory.Size = new System.Drawing.Size(329, 36);
            this.cmBoxClientHistory.TabIndex = 154;
            // 
            // btnShowHistorial
            // 
            this.btnShowHistorial.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnShowHistorial.Location = new System.Drawing.Point(394, 124);
            this.btnShowHistorial.Name = "btnShowHistorial";
            this.btnShowHistorial.Size = new System.Drawing.Size(191, 40);
            this.btnShowHistorial.TabIndex = 155;
            this.btnShowHistorial.Text = "Show historial";
            this.btnShowHistorial.UseVisualStyleBackColor = true;
            this.btnShowHistorial.Click += new System.EventHandler(this.btnShowHistorial_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button2.Location = new System.Drawing.Point(394, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 40);
            this.button2.TabIndex = 156;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowHistorial);
            this.Controls.Add(this.cmBoxClientHistory);
            this.Controls.Add(this.dgwClientHitorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxYear);
            this.Controls.Add(this.rbtnByRFC);
            this.Controls.Add(this.rbtnByEmail);
            this.Controls.Add(this.rbtnByName);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.label11);
            this.Name = "ClientHistorialForm";
            this.Text = "ClientHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientHitorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnByRFC;
        private System.Windows.Forms.RadioButton rbtnByEmail;
        private System.Windows.Forms.RadioButton rbtnByName;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBoxYear;
        private System.Windows.Forms.DataGridView dgwClientHitorial;
        private System.Windows.Forms.ComboBox cmBoxClientHistory;
        private System.Windows.Forms.Button btnShowHistorial;
        private System.Windows.Forms.Button button2;
    }
}