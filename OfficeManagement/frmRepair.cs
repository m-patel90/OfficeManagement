using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeManagement.Models;
using System.Data.OleDb;

namespace OfficeManagement
{
    public partial class frmRepair : Form
    {
        public frmRepair()
        {
            InitializeComponent();
        }
        MyLib objLib = MyLib.GetInstance();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RepairModel rmodel = new RepairModel();
                rmodel.InwardDate = Convert.ToDateTime(dtInwardDate.Text);
                rmodel.ModalNo = txtModalNo.Text;
                if (rmodel.ModalNo.Length == 0)
                {
                    MessageBox.Show("Enter modal no");
                    return;
                }
                rmodel.PartyName = txtPartyName.Text;
                if (rmodel.PartyName.Length == 0)
                {
                    MessageBox.Show("Enter Party Name");
                    return;
                }
                rmodel.Estimate = txtEstimate.Text;
                rmodel.Complain = txtComplain.Text;
                rmodel.DeliveryDate = Convert.ToDateTime(dtDeliveryDate.Text);
                rmodel.BillNo = txtBillNo.Text;
                rmodel.ReplacePart = txtReplacePart.Text;
                
                string suceess = "";
                if (chkSuccess.Checked == true)
                {
                    suceess = "Yes";
                }

                if (txtInwardNo.Text.Length == 0)
                {
                    string str = "insert into tblRepairing(InwardDate,ModalNo,PartyName,Estimate,Complain,DeliveryDate,BillNo,ReplacePart,Done)values" +
                                "('" + rmodel.InwardDate.ToShortDateString() + "','"
                                   + rmodel.ModalNo + "','"
                                   + rmodel.PartyName + "','"
                                   + rmodel.Estimate + "','"
                                   + rmodel.Complain + "','"
                                   + rmodel.DeliveryDate + "','"
                                   + rmodel.BillNo + "','"
                                   + rmodel.ReplacePart + "','"
                                   + suceess + "')";

                    objLib.ExecuteCommand(str);
                    MessageBox.Show("Saved Successfully");
                    Clear();
                    BindRepairGrid();
                }
                else
                {
                    string str = "update tblRepairing set InwardDate='" + rmodel.InwardDate.ToShortDateString()
                                    + "',ModalNo='" + rmodel.ModalNo + "',"
                                    + "PartyName='" + rmodel.PartyName + "',"
                                    + "Estimate='" + rmodel.Estimate + "',"
                                    + "Complain='" + rmodel.Complain + "',"
                                    + "DeliveryDate='" + rmodel.DeliveryDate.ToShortDateString() + "',"
                                    + "BillNo='" + rmodel.BillNo + "',"
                                    + "ReplacePart='"+rmodel.ReplacePart + "',"
                                    +" Done='" + suceess + "'" 
                                    + " where InwardID=" + txtInwardNo.Text;
                    objLib.ExecuteCommand(str);
                    MessageBox.Show("Saved Successfully");
                    Clear();
                    BindRepairGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Clear()
        {
            txtModalNo.Text = "";
            txtPartyName.Text = "";
            txtEstimate.Text = "";
            txtComplain.Text = "";
            dtDeliveryDate.Text = DateTime.Now.ToString();
            txtBillNo.Text = "";
            txtReplacePart.Text = "";
            chkSuccess.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            if (txtSearchInwardNo.Text.Length > 0 && txtSearchPartyName.Text.Length > 0)
            {
                str = "select * from tblRepairing where PartyName like '%" + txtSearchPartyName.Text + "%' and InwardID =" + txtSearchInwardNo.Text + " order by InwardID desc";
            }
            else if (txtSearchPartyName.Text.Length > 0)
            {
                str = "select * from tblRepairing where PartyName like '%" + txtSearchPartyName.Text + "%' order by InwardID desc";
            }
            else if (txtSearchInwardNo.Text.Length > 0)
            {
                str = "select * from tblRepairing where InwardID =" + txtSearchInwardNo.Text + " order by InwardID desc";
            }
            else
            {
                str = "select * from tblRepairing where InwardDate= '" + dtInwardDate.Value.ToShortDateString() + "' order by InwardID desc";
            }

            DataSet ds = new DataSet();
            ds = objLib.getdata(str);
            dgvRepair.DataSource = ds.Tables[0];
        }

        public void BindRepairGrid()
        {
            DateTime dtFrom = Convert.ToDateTime(dtInwardDate.Text);
            string str = "select r.InwardID,r.InwardDate,r.PartyName,r.ModalNo,r.Complain,r.Estimate,r.DeliveryDate,iif(done,DateDiff('d',InwardDate,date())) As PendingDays,r.BillNo,r.ReplacePart  from tblRepairing r where Done<>'Yes' order by InwardID desc";
            //string str = "SELECT tblRepairing.InwardDate, *" +
            //            " FROM tblRepairing" +
            //            " WHERE(((tblRepairing.InwardDate) =#"+ DateTime.ParseExact(dtInwardDate.Text,"dd/mm/yyyy",null) +"#));";
            DataSet ds = new DataSet();
            ds = objLib.getdata(str);
            dgvRepair.DataSource = ds.Tables[0];
        }

        public void BindRepairGridOnDateChange()
        {
            DateTime dtFrom = Convert.ToDateTime(dtInwardDate.Text);
            string str = "select *,iif(done,DateDiff('d',InwardDate,date())) As PendingDays  from tblRepairing where InwardDate='" + dtInwardDate.Value.ToShortDateString() + "' order by InwardID desc";
            //string str = "SELECT tblRepairing.InwardDate, *" +
            //            " FROM tblRepairing" +
            //            " WHERE(((tblRepairing.InwardDate) =#"+ DateTime.ParseExact(dtInwardDate.Text,"dd/mm/yyyy",null) +"#));";
            DataSet ds = new DataSet();
            ds = objLib.getdata(str);
            dgvRepair.DataSource = ds.Tables[0];
        }

        private void frmRepair_Load(object sender, EventArgs e)
        {
            BindRepairGrid();
            BindPartyNameSearch();
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

        private void dgvRepair_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvRepair.SelectedRows[0];
                txtInwardNo.Text = row.Cells["InwardID"].Value.ToString();
                dtInwardDate.Text = row.Cells["InwardDate"].Value.ToString();
                txtModalNo.Text = row.Cells["ModalNo"].Value.ToString();
                txtPartyName.Text = row.Cells["PartyName"].Value.ToString();
                txtEstimate.Text = row.Cells["Estimate"].Value.ToString();
                txtComplain.Text = row.Cells["Complain"].Value.ToString();
                dtDeliveryDate.Text = row.Cells["DeliveryDate"].Value.ToString();
                txtBillNo.Text = row.Cells["BillNo"].Value.ToString();
                txtReplacePart.Text = row.Cells["ReplacePart"].Value.ToString();
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

        private void dtInwardDate_ValueChanged(object sender, EventArgs e)
        {
            BindRepairGrid();
            //BindRepairGridOnDateChange();
        }

        public void BindPartyNameSearch()
        {
            try
            {
                string str = "select distinct PartyName from tblRepairing";
                OleDbDataReader dr = objLib.GetDataReader(str);

                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtSearchPartyName.AutoCompleteCustomSource = MyCollection;
                txtPartyName.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
