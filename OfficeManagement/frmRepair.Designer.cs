namespace OfficeManagement
{
    partial class frmRepair
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
            this.dtInwardDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModalNo = new System.Windows.Forms.TextBox();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstimate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRepair = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchPartyName = new System.Windows.Forms.TextBox();
            this.txtSearchInwardNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInwardNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReplacePart = new System.Windows.Forms.TextBox();
            this.chkSuccess = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInwardDate
            // 
            this.dtInwardDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInwardDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInwardDate.Location = new System.Drawing.Point(169, 30);
            this.dtInwardDate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dtInwardDate.Name = "dtInwardDate";
            this.dtInwardDate.Size = new System.Drawing.Size(297, 26);
            this.dtInwardDate.TabIndex = 0;
            this.dtInwardDate.ValueChanged += new System.EventHandler(this.dtInwardDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inward Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modal No";
            // 
            // txtModalNo
            // 
            this.txtModalNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModalNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtModalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalNo.Location = new System.Drawing.Point(169, 149);
            this.txtModalNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModalNo.Name = "txtModalNo";
            this.txtModalNo.Size = new System.Drawing.Size(180, 26);
            this.txtModalNo.TabIndex = 2;
            // 
            // txtPartyName
            // 
            this.txtPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(169, 87);
            this.txtPartyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(297, 26);
            this.txtPartyName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Party Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estimate";
            // 
            // txtEstimate
            // 
            this.txtEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimate.Location = new System.Drawing.Point(165, 422);
            this.txtEstimate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstimate.Name = "txtEstimate";
            this.txtEstimate.Size = new System.Drawing.Size(180, 26);
            this.txtEstimate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Complain";
            // 
            // txtComplain
            // 
            this.txtComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplain.Location = new System.Drawing.Point(169, 196);
            this.txtComplain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComplain.Multiline = true;
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.Size = new System.Drawing.Size(348, 95);
            this.txtComplain.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(169, 559);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(165, 367);
            this.dtDeliveryDate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(297, 26);
            this.dtDeliveryDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Delivery Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Bill No";
            // 
            // txtBillNo
            // 
            this.txtBillNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(165, 467);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(180, 26);
            this.txtBillNo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvRepair);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSearchPartyName);
            this.groupBox1.Controls.Add(this.txtSearchInwardNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(553, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(787, 623);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(316, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 54);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRepair
            // 
            this.dgvRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepair.Location = new System.Drawing.Point(8, 181);
            this.dgvRepair.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRepair.Name = "dgvRepair";
            this.dgvRepair.Size = new System.Drawing.Size(779, 417);
            this.dgvRepair.TabIndex = 37;
            this.dgvRepair.SelectionChanged += new System.EventHandler(this.dgvRepair_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "InwardNo No";
            // 
            // txtSearchPartyName
            // 
            this.txtSearchPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPartyName.Location = new System.Drawing.Point(261, 38);
            this.txtSearchPartyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchPartyName.Name = "txtSearchPartyName";
            this.txtSearchPartyName.Size = new System.Drawing.Size(349, 26);
            this.txtSearchPartyName.TabIndex = 0;
            // 
            // txtSearchInwardNo
            // 
            this.txtSearchInwardNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchInwardNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchInwardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInwardNo.Location = new System.Drawing.Point(261, 82);
            this.txtSearchInwardNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchInwardNo.Name = "txtSearchInwardNo";
            this.txtSearchInwardNo.Size = new System.Drawing.Size(180, 26);
            this.txtSearchInwardNo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Party Name";
            // 
            // txtInwardNo
            // 
            this.txtInwardNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInwardNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInwardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInwardNo.Location = new System.Drawing.Point(392, 149);
            this.txtInwardNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInwardNo.Name = "txtInwardNo";
            this.txtInwardNo.Size = new System.Drawing.Size(125, 26);
            this.txtInwardNo.TabIndex = 35;
            this.txtInwardNo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 311);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Replace Part";
            // 
            // txtReplacePart
            // 
            this.txtReplacePart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReplacePart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReplacePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplacePart.Location = new System.Drawing.Point(169, 311);
            this.txtReplacePart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReplacePart.Multiline = true;
            this.txtReplacePart.Name = "txtReplacePart";
            this.txtReplacePart.Size = new System.Drawing.Size(348, 35);
            this.txtReplacePart.TabIndex = 4;
            // 
            // chkSuccess
            // 
            this.chkSuccess.AutoSize = true;
            this.chkSuccess.Location = new System.Drawing.Point(169, 520);
            this.chkSuccess.Name = "chkSuccess";
            this.chkSuccess.Size = new System.Drawing.Size(64, 21);
            this.chkSuccess.TabIndex = 8;
            this.chkSuccess.Text = "Done";
            this.chkSuccess.UseVisualStyleBackColor = true;
            // 
            // frmRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 700);
            this.Controls.Add(this.chkSuccess);
            this.Controls.Add(this.txtReplacePart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInwardNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.dtDeliveryDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComplain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstimate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModalNo);
            this.Controls.Add(this.txtPartyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtInwardDate);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepair";
            this.Text = "frmRepair";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRepair_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInwardDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModalNo;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstimate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRepair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchPartyName;
        private System.Windows.Forms.TextBox txtSearchInwardNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInwardNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReplacePart;
        private System.Windows.Forms.CheckBox chkSuccess;
    }
}