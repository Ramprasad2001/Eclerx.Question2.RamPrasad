using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclerx.Question2.RamPrasad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection objconnection = null;
        private SqlCommand objcommand = null;
        private SqlDataReader objReader = null;

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (objcommand = new SqlCommand("cus_GetCustomerbyCity", objconnection))
                {
                    objcommand.CommandType = CommandType.StoredProcedure;
                    objcommand.Parameters.AddWithValue("@City", TxtByCity.Text);
                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }
                    objReader = objcommand.ExecuteReader();
                    if (objReader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(objReader);
                        GridShow.DataSource = dt;
                    }
                }
            }

        }

        private void ComboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (objconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (objcommand = new SqlCommand("cus_GetCustomerbyCreditLimitLowtoHigh", objconnection))
                {
                    objcommand.CommandType = CommandType.StoredProcedure;
                    objcommand.Parameters.AddWithValue("@CreditLimit",ComboSort.SelectedIndex=0);
                    if (objconnection.State == ConnectionState.Closed)
                    {
                        objconnection.Open();
                    }
                    objReader = objcommand.ExecuteReader();
                    if (objReader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(objReader);
                        GridShow.DataSource = dt;
                    }
                }
            }
        }
    }
}
