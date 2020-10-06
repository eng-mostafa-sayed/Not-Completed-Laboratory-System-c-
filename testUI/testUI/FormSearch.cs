using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace testUI
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            PatientList.DataSource = GetPatientList();
        }
        private DataTable GetPatientList() 
        {
            DataTable DtPAtients = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString)) 
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM patients", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtPAtients.Load(reader);
                }

            }

                return DtPAtients;
        }
    }
}
