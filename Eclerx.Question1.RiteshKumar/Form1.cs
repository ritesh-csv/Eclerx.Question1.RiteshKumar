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

namespace Eclerx.Question1.RiteshKumar
{
    public partial class GridEmployeeDetails : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public GridEmployeeDetails()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void ClearText()
        {
            TxtEmployeeNo.Text = "";
            TxtEmployeeName.Clear();
            TxtSalary.Clear();
            TxtEmployeeNo.Focus();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterCon"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Employee", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Employee");


                    //Create new row in the dataset


                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["vEmployeeNo"] = TxtEmployeeNo.Text;
                    dr["vEmployeeName"] = TxtEmployeeName.Text;
                    dr["mSalary"] = TxtSalary.Text;
                 //   dr["cEmployeeType"] = .Text;
                    //Add data row to dataset
                    ds.Tables["Employee"].Rows.Add(dr);
                    //Updating Dataset to Database
                    adapter.Update(ds, "Employee");
                }
            }
        }
    }
}
