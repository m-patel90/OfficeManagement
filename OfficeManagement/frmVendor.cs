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
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }
        MyLib objLib = new MyLib();
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string strInsert = "insert into tblVendors(VendorName,Address,VendorCode,MobileNo,GstNo)values('" + txtVendorName.Text + "','" +
                            txtAddress.Text + "','" + txtVendorCode.Text + "','" + txtMobileNo.Text + "','" + txtGSTNO.Text + "')";

                objLib.ExecuteCommand(strInsert);
                MessageBox.Show("Saved Successfully.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtVendorName.Text = "";
            txtAddress.Text = "";
            txtVendorCode.Text = "";
            txtMobileNo.Text = "";
            txtGSTNO.Text = "";
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
            try
            {
                string str = "select VendorName from tblVendors";
                OleDbDataReader dr = objLib.GetDataReader(str);
                if (dr == null)
                    return;
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtVendorName.AutoCompleteCustomSource = MyCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
