using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class ShowGroupProjects : Form
    {
        private static ShowGroupProjects l = null;
        public ShowGroupProjects()
        {
            InitializeComponent();
        }
        public static ShowGroupProjects getInstance()
        {
            if (l == null)
            {
                l = new ShowGroupProjects();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void GetStudentRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
            //SqlCommand cmd = new SqlCommand("Select * from Person", con);
            SqlCommand cmd = new SqlCommand("SELECT Project.Description,Project.Title,GroupProject.GroupId from Project INNER JOIN GroupProject on Project.Id=GroupProject.ProjectId INNER JOIN  ", con);


            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        private void ShowGroupProjects_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }
    }
}
