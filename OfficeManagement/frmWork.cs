using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeManagement
{
    public partial class frmWork : Form
    {
        public frmWork()
        {
            InitializeComponent();
        }
        MyLib objlib = MyLib.GetInstance();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Pease enter Name");
                return;
            }
            if (txtWork.Text == "")
            {
                MessageBox.Show("Pease enter Work");
                return;
            }

            try
            {
                string suceess = "";
                if (chkSuccess.Checked == true)
                {
                    suceess = "Yes";
                }
                if (txtWorkId.Text == string.Empty)
                {
                    string str = "insert into tblWork(workDate,workerName,workDetails,workDone)values" +
                        "('" + dtWorkDate.Text + "','"
                         + txtName.Text + "','"
                         + txtWork.Text + "','"
                         + suceess + "')";
                    objlib.ExecuteCommand(str);
                    MessageBox.Show("Saved Successfully.");
                    Clear();
                    BindWorkGrid();
                }
                else
                {
                    string update = "update tblWork set" +
                                    " workDate='" + dtWorkDate.Text + "'," +
                                    " workerName='" + txtWork.Text + "'," +
                                    " workDetails='" + txtWork.Text + "'," +
                                    " workDone='" + suceess + "'" +
                                    " where workId=" + txtWorkId.Text;
                    objlib.ExecuteCommand(update);
                    MessageBox.Show("Saved Successfully.");
                    Clear();
                    BindWorkGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            dtWorkDate.Value = DateTime.Today.Date;
            txtName.Text = string.Empty;
            txtWork.Text = string.Empty;
            chkSuccess.Checked = false;
        }

        public void BindWorkGrid()
        {
            DateTime dtFrom = Convert.ToDateTime(dtWorkDate.Text);
            //string str = "select workId As WID,workDate as WorkDate,workerName as WorkerName,workDetails as WorkDetails,workDone as Done from tblWork where workDate='" + dtWorkDate.Value.ToShortDateString() + "' order by workId desc";
            string str = "select workId As WID,workDate as WorkDate,workerName as WorkerName,workDetails as WorkDetails,iif(done,DateDiff('d',workDate,date())) As PendingDays,workDone as Done from tblWork where workDone<>'Yes' order by workId desc";
            DataSet ds = new DataSet();
            ds = objlib.getdata(str);            
            dgvWork.DataSource = ds.Tables[0];
        }

        private void frmWork_Load(object sender, EventArgs e)
        {
            BindWorkGrid();
            BindPartyNameSearch();
        }

        private void dgvWork_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvWork.SelectedRows[0];
                txtWorkId.Text = row.Cells["WID"].Value.ToString();
                dtWorkDate.Text = row.Cells["WorkDate"].Value.ToString();
                txtName.Text = row.Cells["WorkerName"].Value.ToString();
                txtWork.Text = row.Cells["WorkDetails"].Value.ToString();
                if (row.Cells["Done"].Value.ToString() == "Yes")
                {
                    chkSuccess.Checked = true;
                }
                else
                {
                    chkSuccess.Checked = false;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        private void dtWorkDate_ValueChanged(object sender, EventArgs e)
        {
            BindWorkGrid();
        }

        private void dgvWork_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (this.dgvWork.Columns[e.ColumnIndex].Name == "Done")
            //{
            //    if (e.Value != null)
            //    {
            //         e.CellStyle.BackColor = Color.Pink;
            //    }
            //}
        }

        private void dgvWork_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (dgvWork["Done", e.RowIndex].Value.ToString() != "Yes" && dgvWork["WID", e.RowIndex].Value.ToString() != "")
                {
                    dgvWork.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    //dgvWork.Rows[e.RowIndex].DefaultCellStyle.Font.Bold = true;
                }
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:

                    return base.ProcessDialogKey(Keys.Tab);
            }
            return base.ProcessDialogKey(keyData);
        }

        public void BindPartyNameSearch()
        {
            try
            {
                string str = "select distinct workerName from tblWork";
                OleDbDataReader dr = objlib.GetDataReader(str);

                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtName.AutoCompleteCustomSource = MyCollection;
                txtName.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
