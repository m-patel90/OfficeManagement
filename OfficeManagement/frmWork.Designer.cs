namespace OfficeManagement
{
    partial class frmWork
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
            this.txtWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSuccess = new System.Windows.Forms.CheckBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWork
            // 
            this.txtWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWork.Location = new System.Drawing.Point(194, 118);
            this.txtWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWork.Multiline = true;
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(377, 91);
            this.txtWork.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Work";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(194, 67);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 26);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // dtWorkDate
            // 
            this.dtWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWorkDate.Location = new System.Drawing.Point(194, 18);
            this.dtWorkDate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dtWorkDate.Name = "dtWorkDate";
            this.dtWorkDate.Size = new System.Drawing.Size(297, 26);
            this.dtWorkDate.TabIndex = 0;
            this.dtWorkDate.ValueChanged += new System.EventHandler(this.dtWorkDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 277);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSuccess
            // 
            this.chkSuccess.AutoSize = true;
            this.chkSuccess.Location = new System.Drawing.Point(194, 227);
            this.chkSuccess.Name = "chkSuccess";
            this.chkSuccess.Size = new System.Drawing.Size(64, 21);
            this.chkSuccess.TabIndex = 3;
            this.chkSuccess.Text = "Done";
            this.chkSuccess.UseVisualStyleBackColor = true;
            // 
            // dgvWork
            // 
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(102, 349);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.Size = new System.Drawing.Size(844, 355);
            this.dgvWork.TabIndex = 5;
            this.dgvWork.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWork_CellFormatting);
            this.dgvWork.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvWork_RowPrePaint);
            this.dgvWork.SelectionChanged += new System.EventHandler(this.dgvWork_SelectionChanged);
            // 
            // txtWorkId
            // 
            this.txtWorkId.Location = new System.Drawing.Point(801, 32);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.Size = new System.Drawing.Size(100, 22);
            this.txtWorkId.TabIndex = 33;
            this.txtWorkId.Visible = false;
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 745);
            this.Controls.Add(this.txtWorkId);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.chkSuccess);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtWorkDate);
            this.Controls.Add(this.label1);
            this.Name = "frmWork";
            this.Text = "frmWork";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtWorkDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSuccess;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.TextBox txtWorkId;
    }
}