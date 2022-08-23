using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Configuration;

namespace OfficeManagement
{
    public class MyLib
    {

        private static MyLib instance = null;

        public static MyLib GetInstance()
        {
            if (instance == null)
                instance = new MyLib();
            return instance;
        }
        //string conString= 
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|.\Office.mdb");
        public DataSet getdata(string s)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|.\RK.mdb");
                OleDbDataAdapter da = new OleDbDataAdapter(s, con);
                //DataSet ds = new DataSet();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Boolean Insert(string s)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public OleDbDataReader GetDataReader(string s)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                OleDbCommand cmd = new OleDbCommand(s, con);
                OleDbDataReader dr = cmd.ExecuteReader();
                //con.Close();
                return dr;
            }
            catch(Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public Int32 ExecuteScaler(string s)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(s, con);
                int AveargeRate = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return AveargeRate;
            }
            catch
            {
                con.Close();
                return 0;
            }
        }

        public void ExecuteCommand(string str)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(str, con);
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                throw;
            }
        }
    }
}
