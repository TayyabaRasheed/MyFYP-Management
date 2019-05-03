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
    public partial class UpdateDeleteProject : Form
    {
        private static UpdateDeleteProject l = null;
        public UpdateDeleteProject()
        {
            InitializeComponent();
        }

        
        

        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public static UpdateDeleteProject getInstance()
        {
            if (l == null)
            {
                l = new UpdateDeleteProject();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void UpdateDeleteProject_Load(object sender, EventArgs e)
        {
            GetProjectRecord();
        }
        private void GetProjectRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Project", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdProjectRecord.DataSource = dt;
        }
        public int stdID { get; set; }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Project SET @Id=Id,Description= @Description,Title=@Title where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.stdID);
                cmd.Parameters.AddWithValue("@Description", txtDes.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProjectRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select Project for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
             private void ClearTextBoxs()
        {
            stdID = 0;
            txtDes.Clear();
            txtTitle.Clear();
            

        }

        private void gdProjectRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(gdProjectRecord.SelectedRows[0].Cells[0].Value);
            txtDes.Text = gdProjectRecord.SelectedRows[0].Cells[1].Value.ToString();
            txtTitle.Text = gdProjectRecord.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Delete Project where Id=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.stdID);
                cd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Delete GroupProject where ProjectId=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.ExecuteNonQuery();
                
                

                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetProjectRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select an Advisor to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDeleteProjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup l = DeleteGroup.getInstance();
            l.Show();
            this.Hide();
        }

        private void editGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEvaluation l = EditEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupsWithProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGroupProjects l = ShowGroupProjects.getInstance();
            l.Show();
            this.Hide();
        }

        private void advisorsWithGroupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksSheet l = MarksSheet.getInstance();
            l.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsRecord l = StudentsRecord.getInstance();
            l.Show();
            this.Hide();
        }

        private void editStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent l = UpdateDeleteStudent.getInstance();
            l.Show();
            this.Hide();
        }

        private void addAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Advisor l = Advisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void projectAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProjectAdvisor l = ProjectAdvisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteAdvisor l = UpdateDeleteAdvisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evaluation l = Evaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void individualEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupEvaluation l = GroupEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteEvaluation l = UpdateDeleteEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project l = Project.getInstance();
            l.Show();
            this.Hide();
        }

        private void assignGroupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupProject l = GroupProject.getInstance();
            l.Show();
            this.Hide();
        }
    }
    }

