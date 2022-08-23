namespace OfficeManagement
{
    partial class frmInquiry
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtInquiryDate = new System.Windows.Forms.DateTimePicker();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboModalNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquotePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInquiry = new System.Windows.Forms.DataGridView();
            this.chkSuccess = new System.Windows.Forms.CheckBox();
            this.txtInquiryID = new System.Windows.Forms.TextBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.txtMarketPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mPrice6 = new System.Windows.Forms.TextBox();
            this.mPrice5 = new System.Windows.Forms.TextBox();
            this.mPrice4 = new System.Windows.Forms.TextBox();
            this.mPrice3 = new System.Windows.Forms.TextBox();
            this.mPrice2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mPrice1 = new System.Windows.Forms.TextBox();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dtInquiryDate
            // 
            this.dtInquiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInquiryDate.Location = new System.Drawing.Point(136, 27);
            this.dtInquiryDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtInquiryDate.Name = "dtInquiryDate";
            this.dtInquiryDate.Size = new System.Drawing.Size(224, 30);
            this.dtInquiryDate.TabIndex = 0;
            this.dtInquiryDate.ValueChanged += new System.EventHandler(this.dtInquiryDate_ValueChanged);
            // 
            // comboVendor
            // 
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Items.AddRange(new object[] {
            "--Select--"});
            this.comboVendor.Location = new System.Drawing.Point(136, 86);
            this.comboVendor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(224, 33);
            this.comboVendor.TabIndex = 1;
            this.comboVendor.SelectedIndexChanged += new System.EventHandler(this.comboVendor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company";
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(136, 141);
            this.comboCompany.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(224, 33);
            this.comboCompany.TabIndex = 2;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modal No";
            // 
            // comboModalNo
            // 
            this.comboModalNo.FormattingEnabled = true;
            this.comboModalNo.Location = new System.Drawing.Point(136, 199);
            this.comboModalNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboModalNo.Name = "comboModalNo";
            this.comboModalNo.Size = new System.Drawing.Size(224, 33);
            this.comboModalNo.TabIndex = 3;
            this.comboModalNo.SelectedIndexChanged += new System.EventHandler(this.comboModalNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Part Name";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BackColor = System.Drawing.Color.Blue;
            this.txtSellPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSellPrice.Location = new System.Drawing.Point(136, 358);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(224, 30);
            this.txtSellPrice.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Sell Price";
            // 
            // txtquotePrice
            // 
            this.txtquotePrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtquotePrice.Location = new System.Drawing.Point(136, 408);
            this.txtquotePrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtquotePrice.Name = "txtquotePrice";
            this.txtquotePrice.Size = new System.Drawing.Size(224, 30);
            this.txtquotePrice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quote Price";
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(488, 21);
            this.btnAddVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(118, 53);
            this.btnAddVendor.TabIndex = 10;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 597);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvInquiry
            // 
            this.dgvInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquiry.Location = new System.Drawing.Point(391, 102);
            this.dgvInquiry.Name = "dgvInquiry";
            this.dgvInquiry.Size = new System.Drawing.Size(643, 322);
            this.dgvInquiry.TabIndex = 13;
            this.dgvInquiry.SelectionChanged += new System.EventHandler(this.dgvInquiry_SelectionChanged);
            // 
            // chkSuccess
            // 
            this.chkSuccess.AutoSize = true;
            this.chkSuccess.Location = new System.Drawing.Point(137, 560);
            this.chkSuccess.Name = "chkSuccess";
            this.chkSuccess.Size = new System.Drawing.Size(173, 29);
            this.chkSuccess.TabIndex = 8;
            this.chkSuccess.Text = "Success Inquiry";
            this.chkSuccess.UseVisualStyleBackColor = true;
            // 
            // txtInquiryID
            // 
            this.txtInquiryID.Location = new System.Drawing.Point(709, 21);
            this.txtInquiryID.Name = "txtInquiryID";
            this.txtInquiryID.Size = new System.Drawing.Size(100, 30);
            this.txtInquiryID.TabIndex = 32;
            this.txtInquiryID.Visible = false;
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(661, 67);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(173, 29);
            this.chkYes.TabIndex = 11;
            this.chkYes.Text = "Success Inquiry";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(820, 67);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(169, 29);
            this.chkNo.TabIndex = 12;
            this.chkNo.Text = "Pending Inquiry";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.BackColor = System.Drawing.Color.Salmon;
            this.txtMarketPrice.Enabled = false;
            this.txtMarketPrice.Location = new System.Drawing.Point(136, 457);
            this.txtMarketPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(224, 30);
            this.txtMarketPrice.TabIndex = 7;
            this.txtMarketPrice.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Market Price";
            this.label7.Visible = false;
            // 
            // cmbPartName
            // 
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Location = new System.Drawing.Point(136, 261);
            this.cmbPartName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(224, 33);
            this.cmbPartName.TabIndex = 4;
            this.cmbPartName.SelectedIndexChanged += new System.EventHandler(this.cmbPartName_SelectedIndexChanged);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BackColor = System.Drawing.Color.Red;
            this.txtPurchasePrice.Enabled = false;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.txtPurchasePrice.Location = new System.Drawing.Point(136, 306);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(224, 30);
            this.txtPurchasePrice.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Purchase Price";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mPrice6);
            this.groupBox6.Controls.Add(this.mPrice5);
            this.groupBox6.Controls.Add(this.mPrice4);
            this.groupBox6.Controls.Add(this.mPrice3);
            this.groupBox6.Controls.Add(this.mPrice2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.mPrice1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(391, 446);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(450, 175);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Market Price";
            // 
            // mPrice6
            // 
            this.mPrice6.Enabled = false;
            this.mPrice6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice6.Location = new System.Drawing.Point(231, 129);
            this.mPrice6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice6.Name = "mPrice6";
            this.mPrice6.Size = new System.Drawing.Size(180, 26);
            this.mPrice6.TabIndex = 8;
            // 
            // mPrice5
            // 
            this.mPrice5.Enabled = false;
            this.mPrice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice5.Location = new System.Drawing.Point(231, 83);
            this.mPrice5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice5.Name = "mPrice5";
            this.mPrice5.Size = new System.Drawing.Size(180, 26);
            this.mPrice5.TabIndex = 7;
            // 
            // mPrice4
            // 
            this.mPrice4.Enabled = false;
            this.mPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice4.Location = new System.Drawing.Point(231, 37);
            this.mPrice4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice4.Name = "mPrice4";
            this.mPrice4.Size = new System.Drawing.Size(180, 26);
            this.mPrice4.TabIndex = 6;
            // 
            // mPrice3
            // 
            this.mPrice3.Enabled = false;
            this.mPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice3.Location = new System.Drawing.Point(19, 129);
            this.mPrice3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice3.Name = "mPrice3";
            this.mPrice3.Size = new System.Drawing.Size(180, 26);
            this.mPrice3.TabIndex = 5;
            // 
            // mPrice2
            // 
            this.mPrice2.Enabled = false;
            this.mPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice2.Location = new System.Drawing.Point(19, 83);
            this.mPrice2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice2.Name = "mPrice2";
            this.mPrice2.Size = new System.Drawing.Size(180, 26);
            this.mPrice2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(567, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // mPrice1
            // 
            this.mPrice1.Enabled = false;
            this.mPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrice1.Location = new System.Drawing.Point(19, 37);
            this.mPrice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPrice1.Name = "mPrice1";
            this.mPrice1.Size = new System.Drawing.Size(180, 26);
            this.mPrice1.TabIndex = 1;
            // 
            // txtTracking
            // 
            this.txtTracking.Enabled = false;
            this.txtTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTracking.Location = new System.Drawing.Point(137, 497);
            this.txtTracking.Margin = new System.Windows.Forms.Padding(4);
            this.txtTracking.Multiline = true;
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(223, 52);
            this.txtTracking.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 515);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 41;
            this.label13.Text = "Tracking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(849, 446);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // frmInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 723);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTracking);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.cmbPartName);
            this.Controls.Add(this.txtMarketPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.txtInquiryID);
            this.Controls.Add(this.chkSuccess);
            this.Controls.Add(this.dgvInquiry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.txtquotePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboModalNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.dtInquiryDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmInquiry";
            this.Text = "frmInquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInquiryDate;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboModalNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquotePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvInquiry;
        private System.Windows.Forms.CheckBox chkSuccess;
        private System.Windows.Forms.TextBox txtInquiryID;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.TextBox txtMarketPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPartName;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox mPrice6;
        private System.Windows.Forms.TextBox mPrice5;
        private System.Windows.Forms.TextBox mPrice4;
        private System.Windows.Forms.TextBox mPrice3;
        private System.Windows.Forms.TextBox mPrice2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox mPrice1;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}