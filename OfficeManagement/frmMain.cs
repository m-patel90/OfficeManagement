using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeManagement.Models;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.IO;

namespace OfficeManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        MyLib objLib = MyLib.GetInstance();
        string con = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|.\Office.mdb";
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralModel objGen = new GeneralModel();

                if (txtCompanyName.Text.Length == 0)
                {
                    MessageBox.Show("Enter Compnay Name");
                    return;
                }

                if (txtModalNo.Text.Length == 0)
                {
                    MessageBox.Show("Enter Modal Number");
                    return;
                }

                if (txtPartName.Text.Length == 0)
                {
                    MessageBox.Show("Enter PartName");
                    return;
                }

                if (txtPartNo.Text.Length == 0)
                {
                    MessageBox.Show("Enter PartNo Name");
                    return;
                }
                objGen.CompanyName = txtCompanyName.Text;
                objGen.ModalNo = txtModalNo.Text;
                objGen.PartName = txtPartName.Text;
                objGen.PartNo = txtPartNo.Text;
                objGen.MarketPrice = txtMarketPrice.Text;

                //if (txtNormalSellPrice.Text.Length > 0)
                objGen.SellNormalPrice = txtNormalSellPrice.Text;
                //if (txtQuantityPrice.Text.Length > 0)
                objGen.SellQuantityPrice = txtQuantityPrice.Text;
                objGen.Tracking = txtTracking.Text;

                //Image Save
                string path = "";
                if (txtImagePath.Text != "")
                {
                    string imageName = objGen.CompanyName + "_" + objGen.ModalNo + "_" + objGen.PartName + "_" + DateTime.Now.Ticks + ".jpg";
                    path = Application.StartupPath + "\\Images\\" + imageName;


                    //if (File.Exists(path))
                    //{
                    //    File.Delete(path);
                    //}
                    Bitmap newBitmap = new Bitmap(pictureBox1.Image);
                    //pictureBox1.Dispose();
                    //pictureBox1.Image = null;
                    newBitmap.Save(path, ImageFormat.Jpeg);
                }
                int generalID = -1;
                if (txtGeneralID.Text == "")
                {
                    string str = "Insert into tblGeneralDetails(CompanyName,ModalNo,PartName,PartNo,SellNormalPrice,SellQuantityPrice,Tracking,ImagePath,MarketPrice)" +
                                "Values('" + objGen.CompanyName + "','" + objGen.ModalNo + "','" + objGen.PartName + "','"
                                + objGen.PartNo + "','" + objGen.SellNormalPrice + "','" + objGen.SellQuantityPrice + "','" + objGen.Tracking + "','" + path + "','" + objGen.MarketPrice + "')";


                    string query2 = "Select @@Identity";
                    using (OleDbConnection conn = new OleDbConnection(con))
                    {
                        using (OleDbCommand cmd = new OleDbCommand(str, conn))
                        {

                            //cmd.Parameters.AddWithValue("", Category.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = query2;
                            generalID = (int)cmd.ExecuteScalar();
                        }
                    }

                    //objLib.ExecuteCommand(str);
                    //int q= objLib.ExecuteScaler(str);

                    InsertRecords(generalID);
                    //string str1 = "select Max(GeneralDetailsID) as genID from tblGeneralDetails";
                    //int generalID = -1;
                    //OleDbDataReader dr1 = objLib.GetDataReader(str1);

                    //while (dr1.Read())
                    //{
                    //    generalID = Convert.ToInt32(dr1["genID"].ToString());
                    //}
                    ////MessageBox.Show(generalID.ToString());

                    //List<string> listOtherModal = new List<string>();
                    //foreach (var a in listOther.Items)
                    //{
                    //    listOtherModal.Add(a.ToString());
                    //}
                    ////Save Other Modal Details
                    //for (int i = 0; i < listOtherModal.Count(); i++)
                    //{
                    //    string str2 = "insert into tblOtherModals(GeneralDetailsID,ModalName)" +
                    //                "values(" + generalID + ",'" + listOtherModal[i] + "')";
                    //    objLib.ExecuteCommand(str2);
                    //}

                    ////Save Purchase Details
                    //PurchaseModel objPur = new PurchaseModel();
                    //objPur.GeneralDetailsID = generalID;
                    //objPur.PurchaseDate = !string.IsNullOrEmpty(dtPurchaseDate.Text) ? Convert.ToDateTime(dtPurchaseDate.Text) : DateTime.MinValue;
                    //objPur.VendorName = txtVednorName.Text;
                    //objPur.PurchasePrice = Convert.ToInt32(txtPrice.Text);
                    //if (txtMarketPrice.Text.Length > 0)
                    //    objPur.MarketPrice = txtLastPurchasePrice.Text;
                    //else
                    //    objPur.MarketPrice = string.Empty;
                    //string str3 = "insert into tblPurchase(GeneralDetailsID,PurchaseDate,VendorName,PurchasePrice,MarketPrice)" +
                    //            "values(" + generalID + ",'" + objPur.PurchaseDate + "','" + objPur.VendorName + "'," + objPur.PurchasePrice + ",'"+ objPur.MarketPrice + "')";
                    //objLib.ExecuteCommand(str3);
                }
                else
                {
                    //Update Selling Details
                    string strUpt = "update tblGeneralDetails set SellNormalPrice=" + objGen.SellNormalPrice + ",SellQuantityPrice=" + objGen.SellQuantityPrice + ",Tracking='" + objGen.Tracking + "',ImagePath='" + path + "' where GeneralDetailsID=" + txtGeneralID.Text;
                    objLib.ExecuteCommand(strUpt);

                    //Delete & insert Other Modal
                    int generalId = Convert.ToInt32(txtGeneralID.Text);
                    string strdlt = "delete from tblOtherModals where GeneralDetailsID=" + generalId;
                    objLib.ExecuteCommand(strdlt);

                    List<string> listOtherModal = new List<string>();
                    foreach (var a in listOther.Items)
                    {
                        listOtherModal.Add(a.ToString());
                    }
                    //Save Other Modal Details
                    for (int i = 0; i < listOtherModal.Count(); i++)
                    {
                        string str2 = "insert into tblOtherModals(GeneralDetailsID,ModalName)" +
                                    "values(" + generalId + ",'" + listOtherModal[i] + "')";
                        objLib.ExecuteCommand(str2);
                    }


                    PurchaseModel objPur = new PurchaseModel();
                    objPur.GeneralDetailsID = generalId;
                    objPur.PurchaseDate = !string.IsNullOrEmpty(dtPurchaseDate.Text) ? Convert.ToDateTime(dtPurchaseDate.Text) : DateTime.MinValue;
                    objPur.VendorName = txtVednorName.Text;
                    if (txtPrice.Text != "")
                        objPur.PurchasePrice = txtPrice.Text;
                    else
                        objPur.PurchasePrice = String.Empty;

                    if (txtMarketPrice.Text.Length > 0)
                        objPur.MarketPrice = txtLastPurchasePrice.Text;
                    else
                        objPur.MarketPrice = string.Empty;

                    if (objPur.VendorName != "" && objPur.PurchasePrice != "")
                    {
                        string str3 = "insert into tblPurchase(GeneralDetailsID,PurchaseDate,VendorName,PurchasePrice)" +
                                    "values(" + generalId + ",'" + objPur.PurchaseDate + "','" + objPur.VendorName + "','" + objPur.PurchasePrice + "')";
                        objLib.ExecuteCommand(str3);
                    }

                    //Update Market Price details
                    string strmPriceUpt = "update MarketPrice set mPrice1='" + mPrice1.Text + "',mPrice2='" + mPrice2.Text + "',mPrice3='" + mPrice3.Text + "',mPrice4='" + mPrice4.Text + "',mPrice5='" + mPrice5.Text + "',mPrice6='" + mPrice6.Text + "' where GeneralDetailsID=" + txtGeneralID.Text;
                    objLib.ExecuteCommand(strmPriceUpt);
                }


                MessageBox.Show("Saved SuccessFully !!");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertRecords(int generalID)
        {
            //string str1 = "select Max(GeneralDetailsID) as genID from tblGeneralDetails";
            //int generalID = -1;
            //OleDbDataReader dr1 = objLib.GetDataReader(str1);

            //while (dr1.Read())
            //{
            //    generalID = Convert.ToInt32(dr1["genID"].ToString());
            //}
            //MessageBox.Show(generalID.ToString());

            List<string> listOtherModal = new List<string>();
            foreach (var a in listOther.Items)
            {
                listOtherModal.Add(a.ToString());
            }
            //Save Other Modal Details
            for (int i = 0; i < listOtherModal.Count(); i++)
            {
                string str2 = "insert into tblOtherModals(GeneralDetailsID,ModalName)" +
                            "values(" + generalID + ",'" + listOtherModal[i] + "')";
                objLib.ExecuteCommand(str2);
            }

            //Save Purchase Details
            PurchaseModel objPur = new PurchaseModel();
            objPur.GeneralDetailsID = generalID;
            objPur.PurchaseDate = !string.IsNullOrEmpty(dtPurchaseDate.Text) ? Convert.ToDateTime(dtPurchaseDate.Text) : DateTime.MinValue;
            objPur.VendorName = txtVednorName.Text;
            objPur.PurchasePrice = txtPrice.Text;
            if (txtMarketPrice.Text.Length > 0)
                objPur.MarketPrice = txtMarketPrice.Text;
            else
                objPur.MarketPrice = string.Empty;
            string str3 = "insert into tblPurchase(GeneralDetailsID,PurchaseDate,VendorName,PurchasePrice,MarketPrice)" +
                        "values(" + generalID + ",'" + objPur.PurchaseDate + "','" + objPur.VendorName + "','" + objPur.PurchasePrice + "','" + objPur.MarketPrice + "')";
            objLib.ExecuteCommand(str3);

            //Save Market details
            string str4 = "insert into MarketPrice(GeneralDetailsID,mPrice1,mPrice2,mPrice3,mPrice4,mPrice5,mPrice6)" +
                        "values(" + generalID + ",'" + mPrice1.Text + "','" + mPrice2.Text + "','" + mPrice3.Text + "','" + mPrice4.Text + "','" +  mPrice5.Text + "','" + mPrice6.Text + "')";
            objLib.ExecuteCommand(str4);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listOther.Items.Add(txtOther.Text);

            txtOther.Text = "";
            txtOther.Focus();


        }

        private void txtModalNo_Leave(object sender, EventArgs e)
        {

            BindPartNameOfModalNo();
        }

        private void listOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (Keys.Delete == e.KeyCode)
                {
                    listOther.Items.RemoveAt(listOther.SelectedIndex);
                }

            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();
                }
            }
        }

        private void txtModalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtCompanyName.Focus();
            BindAutoCompany();
            BindAutoModalNo();
        }

        public void BindAutoCompany()
        {
            try
            {
                string str = "select distinct CompanyName from tblGeneralDetails";
                OleDbDataReader dr = objLib.GetDataReader(str);

                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtCompanyName.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void BindAutoModalNo()
        {
            try
            {
                string str = "select distinct ModalNo from tblGeneralDetails";
                OleDbDataReader dr = objLib.GetDataReader(str);

                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtModalNo.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void BindPartNameOfModalNo()
        {
            try
            {
                string str = "select distinct PartName from tblGeneralDetails where ModalNo='" + txtModalNo.Text + "'";
                OleDbDataReader dr = objLib.GetDataReader(str);

                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtPartName.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            //openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "Image Files(*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
            openFileDialog1.FilterIndex = 2;

            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;

            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtImagePath.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
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

        private void txtPartName_Leave(object sender, EventArgs e)
        {
            try
            {
                string modalNo = txtModalNo.Text;
                if (!string.IsNullOrEmpty(modalNo))
                {
                    string str = "select * from tblGeneralDetails where ModalNo='" + modalNo + "' and PartName='" + txtPartName.Text + "'";
                    OleDbDataReader dr1 = objLib.GetDataReader(str);
                    int generalID = -1;
                    while (dr1.Read())
                    {
                        generalID = Convert.ToInt32(dr1["GeneralDetailsID"].ToString());
                        txtGeneralID.Text = dr1["GeneralDetailsID"].ToString();
                        txtCompanyName.Text = dr1["CompanyName"].ToString();
                        txtPartName.Text = dr1["PartName"].ToString();
                        txtPartNo.Text = dr1["PartNo"].ToString();

                        txtCompanyName.Enabled = false;
                        txtPartName.Enabled = false;
                        txtPartNo.Enabled = false;

                        txtNormalSellPrice.Text = dr1["SellNormalPrice"].ToString();
                        txtQuantityPrice.Text = dr1["SellQuantityPrice"].ToString();
                        txtTracking.Text = dr1["Tracking"].ToString();

                        txtImagePath.Text = dr1["ImagePath"].ToString();
                    }
                    if (txtImagePath.Text != "")
                        pictureBox1.Image = Image.FromFile(txtImagePath.Text);

                    string str1 = "select top 1 * from tblPurchase where GeneralDetailsID=" + generalID + " order by PurchaseID desc";
                    OleDbDataReader dr2 = objLib.GetDataReader(str1);

                    while (dr2.Read())
                    {

                        dtLastPurchaseDate.Text = dr2["PurchaseDate"].ToString();
                        txtLastVendorName.Text = dr2["VendorName"].ToString();
                        txtLastPurchasePrice.Text = dr2["PurchasePrice"].ToString();
                        txtLastPurMarketPrice.Text = dr2["MarketPrice"].ToString();
                    }

                    listOther.Items.Clear();
                    string str2 = "select * from tblOtherModals where GeneralDetailsID=" + generalID + "";
                    OleDbDataReader dr3 = objLib.GetDataReader(str2);

                    while (dr3.Read())
                    {

                        listOther.Items.Add(dr3["ModalName"].ToString());
                    }

                    string str3 = "select * from MarketPrice where GeneralDetailsID=" + generalID + "";
                    OleDbDataReader dr4 = objLib.GetDataReader(str3);

                    while (dr4.Read())
                    {

                        mPrice1.Text = dr4["mPrice1"].ToString();
                        mPrice2.Text = dr4["mPrice2"].ToString();
                        mPrice3.Text = dr4["mPrice3"].ToString();
                        mPrice4.Text = dr4["mPrice4"].ToString();
                        mPrice5.Text = dr4["mPrice5"].ToString();
                        mPrice6.Text = dr4["mPrice6"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtGeneralID.Text = "";

            txtCompanyName.Text = "";
            txtModalNo.Text = "";
            txtPartName.Text = "";
            txtPartNo.Text = "";

            listOther.Items.Clear();

            dtPurchaseDate.Text = DateTime.Now.Date.ToShortDateString();
            txtVednorName.Text = "";
            txtPrice.Text = "";
            txtMarketPrice.Text = "";

            txtNormalSellPrice.Text = "";
            txtQuantityPrice.Text = "";
            txtTracking.Text = "";

            dtLastPurchaseDate.Text = DateTime.Now.Date.ToShortDateString();
            txtLastVendorName.Text = "";
            txtLastPurchasePrice.Text = "";
            //txtMarketPrice.Text = "";

            pictureBox1.Image = null;

            txtImagePath.Text = "";

            txtCompanyName.Enabled = true;
            txtPartName.Enabled = true;
            txtPartNo.Enabled = true;

            txtCompanyName.Focus();

            mPrice1.Text = "";
            mPrice2.Text = "";
            mPrice3.Text = "";
            mPrice4.Text = "";
            mPrice5.Text = "";
            mPrice6.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
