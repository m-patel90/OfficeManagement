using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagement
{
    public partial class frmInquiry : Form
    {
        public frmInquiry()
        {
            InitializeComponent();
        }
        MyLib objlib = MyLib.GetInstance();
        private void frmInquiry_Load(object sender, EventArgs e)
        {
            BindCompanyName();
            BindVendorName();
            BindInquiryDataGrid();
        }

        public void BindCompanyName()
        {
            try
            {
                string str = "select distinct CompanyName from tblGeneralDetails";
                DataSet dsCompnay = new DataSet();
                dsCompnay = objlib.getdata(str);

                DataTable dtComp = new DataTable();
                if (dsCompnay != null)
                {
                    dtComp = dsCompnay.Tables[0];
                    DataRow row = dtComp.NewRow();
                    row[0] = "Please select";
                    dtComp.Rows.InsertAt(row, 0);


                    comboCompany.DataSource = dtComp;
                    comboCompany.ValueMember = "CompanyName";
                }
                //DataRow dtrow = new DataRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindModalNo()
        {
            try
            {
                string str = "select distinct ModalNo from tblGeneralDetails where CompanyName='" + comboCompany.SelectedValue + "'";
                DataSet dtCompnay = new DataSet();
                dtCompnay = objlib.getdata(str);

                DataTable dtModalNo = new DataTable();
                dtModalNo = dtCompnay.Tables[0];
                DataRow row = dtModalNo.NewRow();
                row[0] = "Please select";
                dtModalNo.Rows.InsertAt(row, 0);
                comboModalNo.DataSource = dtModalNo;
                comboModalNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboModalNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboModalNo.ValueMember = "ModalNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindVendorName()
        {
            try
            {
                string str = "select distinct VendorName,VendorID from tblVendors Order by VendorID";
                DataSet dtCompnay = new DataSet();
                dtCompnay = objlib.getdata(str);
                if (dtCompnay.Tables[0].Rows.Count > 0)
                {

                    DataTable dtComp = new DataTable();
                    dtComp = dtCompnay.Tables[0];
                    DataRow row = dtComp.NewRow();
                    row[0] = "Please select";
                    dtComp.Rows.InsertAt(row, 0);

                    comboVendor.DataSource = null;
                    comboVendor.DataSource = dtComp;
                    comboVendor.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboVendor.AutoCompleteSource = AutoCompleteSource.ListItems;
                    comboVendor.DisplayMember = "VendorName";
                    comboVendor.ValueMember = "VendorID";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindModalNo();
        }

        private void comboModalNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModalNo.SelectedValue.ToString() == "Please select")
                return;

            string str = "select PartName from tblGeneralDetails where ModalNo='" + comboModalNo.SelectedValue + "'";

            //string str = "select distinct VendorName,VendorID from tblVendors Order by VendorID";
            DataSet dtCompnay = new DataSet();
            dtCompnay = objlib.getdata(str);
            if (dtCompnay.Tables[0].Rows.Count > 0)
            {

                DataTable dtComp = new DataTable();
                dtComp = dtCompnay.Tables[0];
                DataRow row = dtComp.NewRow();
                row[0] = "Please select";
                dtComp.Rows.InsertAt(row, 0);

                //cmbPartName.DataSource = null;
                cmbPartName.DataSource = dtComp;

                //comboModalNo.DisplayMember = "PartName";
                cmbPartName.ValueMember = "PartName";

            }
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            frmVendor frmV = new frmVendor();
            frmV.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboVendor.Text == "Select")
            {
                MessageBox.Show("Please select Vendor");
                return;
            }
            //else if (comboCompany.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Please select Company Name");
            //    return;
            //}
            //else if ()
            //{

            //}
            string suceess = "";
            if (chkSuccess.Checked == true)
            {
                suceess = "Yes";
            }

            try
            {
                if (txtInquiryID.Text == string.Empty)
                {
                    string str = "insert into tblInquiry(InquiryDate,VendorName,VendorID,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,SuccessInquiry)values" +
                        "('" + dtInquiryDate.Text + "','"
                        + comboVendor.Text + "','"
                         + comboVendor.SelectedValue + "','"
                         + comboCompany.Text + "','"
                         + comboModalNo.Text + "','"
                         + cmbPartName.Text + "','"
                         + txtSellPrice.Text + "','"
                         + txtquotePrice.Text + "','"
                         + suceess + "')";
                    objlib.ExecuteCommand(str);
                    MessageBox.Show("Saved Successfully.");
                    Clear();
                }
                else
                {
                    string update = "update tblInquiry set" +
                                    " InquiryDate='" + dtInquiryDate.Text + "'," +
                                    " VendorName='" + comboVendor.Text + "'," +
                                    " VendorID='" + comboVendor.SelectedValue + "'," +
                                    " CompanyName='" + comboCompany.Text + "'," +
                                    " ModalNo='" + comboModalNo.Text + "'," +
                                    " PartName='" + cmbPartName.Text + "'," +
                                    " SellPrice='" + txtSellPrice.Text + "'," +
                                    " QuotePrice='" + txtquotePrice.Text + "'," +
                                    " SuccessInquiry='" + suceess + "'" +
                                    " where InquiryID=" + txtInquiryID.Text;
                    objlib.ExecuteCommand(update);
                    MessageBox.Show("Saved Successfully.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboVendor.SelectedIndex > 0)
                {


                    string str = "select i.InquiryID as InqId,i.InquiryDate as InqDate,VendorName,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,SuccessInquiry,VendorID from tblInquiry i where VendorID=" + comboVendor.SelectedValue + " order by InquiryID desc";
                    DataSet ds = new DataSet();
                    ds = objlib.getdata(str);
                    dgvInquiry.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void Clear()
        {
            comboVendor.SelectedIndex = 0;
            comboCompany.SelectedIndex = 0;
            comboModalNo.SelectedIndex = 0;
            cmbPartName.SelectedIndex = 0;
            txtPurchasePrice.Text = string.Empty;
            txtquotePrice.Text = string.Empty;
            txtSellPrice.Text = string.Empty;
            txtMarketPrice.Text = string.Empty;
            txtInquiryID.Text = string.Empty;

            mPrice1.Text = string.Empty;
            mPrice2.Text = string.Empty;
            mPrice3.Text = string.Empty;
            mPrice4.Text = string.Empty;
            mPrice5.Text = string.Empty;
            mPrice6.Text = string.Empty;
            txtTracking.Text = string.Empty;
        }

        private void dgvInquiry_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvInquiry.SelectedRows[0];
                //DataGridViewRow row = this.dgvList.Rows[e.RowIndex];
                comboVendor.SelectedValue = row.Cells["VendorID"].Value.ToString();
                comboCompany.SelectedValue = row.Cells["CompanyName"].Value.ToString();
                comboModalNo.SelectedValue = row.Cells["ModalNo"].Value.ToString();
                cmbPartName.Text = row.Cells["PartName"].Value.ToString();
                txtSellPrice.Text = row.Cells["SellPrice"].Value.ToString();
                txtquotePrice.Text = row.Cells["QuotePrice"].Value.ToString();

                txtInquiryID.Text = row.Cells["InqId"].Value.ToString();

                if (row.Cells["SuccessInquiry"].Value.ToString() == "Yes")
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


            }
        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboVendor.SelectedIndex > 0)
                {

                    if (chkYes.Checked == true)
                    {
                        string str = "select InquiryDate,VendorName,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,VendorID,InquiryID,SuccessInquiry from tblInquiry where VendorID=" + comboVendor.SelectedValue + " and SuccessInquiry='Yes'";
                        DataSet ds = new DataSet();
                        ds = objlib.getdata(str);
                        if (ds != null)
                            dgvInquiry.DataSource = ds.Tables[0];
                        else
                            dgvInquiry.DataSource = ds;
                    }
                    else
                    {
                        string str = "select InquiryDate,VendorName,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,VendorID,InquiryID,SuccessInquiry from tblInquiry where VendorID=" + comboVendor.SelectedValue;
                        DataSet ds = new DataSet();
                        ds = objlib.getdata(str);
                        if (ds != null)
                            dgvInquiry.DataSource = ds.Tables[0];
                        else
                            dgvInquiry.DataSource = ds;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkNo.Checked == true)
                {
                    string str = "select InquiryDate,VendorName,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,VendorID,InquiryID,SuccessInquiry from tblInquiry where VendorID=" + comboVendor.SelectedValue + " and SuccessInquiry <>'Yes'";
                    DataSet ds = new DataSet();
                    ds = objlib.getdata(str);
                    if (ds != null)
                        dgvInquiry.DataSource = ds.Tables[0];
                    else
                        dgvInquiry.DataSource = ds;
                }
                else
                {
                    string str = "select InquiryDate,VendorName,CompanyName,ModalNo,PartName,SellPrice,QuotePrice,VendorID,InquiryID,SuccessInquiry from tblInquiry where VendorID=" + comboVendor.SelectedValue;
                    DataSet ds = new DataSet();
                    ds = objlib.getdata(str);
                    if (ds != null)
                        dgvInquiry.DataSource = ds.Tables[0];
                    else
                        dgvInquiry.DataSource = ds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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

        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "select a.PartName,a.SellNormalPrice,a.MarketPrice,b.PurchasePrice,a.Tracking,a.ImagePath FROM tblGeneralDetails a inner join tblPurchase b on a.GeneralDetailsID = b.GeneralDetailsID " +
                    "WHERE a.ModalNo='" + comboModalNo.SelectedValue + "' and a.PartName='" + cmbPartName.SelectedValue + "'";

                pictureBox1.Image = null;
                OleDbDataReader dr1 = objlib.GetDataReader(str);
                while (dr1.Read())
                {
                    txtSellPrice.Text = dr1["SellNormalPrice"].ToString();
                    txtMarketPrice.Text = dr1["MarketPrice"].ToString();
                    txtPurchasePrice.Text = dr1["PurchasePrice"].ToString();
                    txtTracking.Text = dr1["Tracking"].ToString();
                    if (dr1["ImagePath"].ToString() != "")
                        pictureBox1.Image = Image.FromFile(dr1["ImagePath"].ToString());
                    else
                        pictureBox1.Image = null;
                }

                string strmPrice = "select b.mPrice1,b.mPrice2,b.mPrice3,b.mPrice4,b.mPrice5,b.mPrice6 from tblGeneralDetails a inner join MarketPrice b on a.GeneralDetailsID = b.GeneralDetailsID " +
                                   "WHERE a.ModalNo='" + comboModalNo.SelectedValue + "' and a.PartName='" + cmbPartName.SelectedValue + "'";
                OleDbDataReader dr2 = objlib.GetDataReader(strmPrice);
                while (dr2.Read())
                {
                    mPrice1.Text = dr2["mPrice1"].ToString();
                    mPrice2.Text = dr2["mPrice2"].ToString();
                    mPrice3.Text = dr2["mPrice3"].ToString();
                    mPrice4.Text = dr2["mPrice4"].ToString();
                    mPrice5.Text = dr2["mPrice5"].ToString();
                    mPrice6.Text = dr2["mPrice6"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtInquiryDate_ValueChanged(object sender, EventArgs e)
        {
            BindInquiryDataGrid();
        }

        public void BindInquiryDataGrid()
        {
            //string str = "select i.InquiryID as InqId,i.InquiryDate as InqDate,i.VendorName,i.CompanyName,i.ModalNo,i.PartName,i.SellPrice,i.QuotePrice,i.SuccessInquiry as Success,i.VendorID from tblInquiry i where InquiryDate='" + dtInquiryDate.Value.ToShortDateString() + "' order by InquiryID desc";
            string str = "select i.InquiryID as InqId,i.InquiryDate as InqDate,i.VendorName,i.CompanyName,i.ModalNo,i.PartName,i.SellPrice,i.QuotePrice,i.SuccessInquiry as Success,i.VendorID from tblInquiry i where SuccessInquiry <> 'Yes' order by InquiryID desc";
            DataSet ds = new DataSet();
            ds = objlib.getdata(str);
            dgvInquiry.DataSource = ds.Tables[0];
        }
    }
}
