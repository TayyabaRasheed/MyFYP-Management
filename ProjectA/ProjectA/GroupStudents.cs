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
using System.Configuration;

namespace ProjectA
{
    public partial class GroupStudents : Form
    {
        private static GroupStudents l = null;
        public GroupStudents()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public int stdID { get; set; }
        public int GroupID { get; set; }
        public static GroupStudents getInstance()
        {
            if (l == null)
            {
                l = new GroupStudents();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void GroupStudents_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);
            textBox1.Visible = false;
        }

        private void GetStudentRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Student", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            stdID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
            // textBox2.Text = stdID.ToString();
        }
        int num = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }
        private void CheckCount(bool isChecked)
        {
            if (isChecked)
            {
                num++;
            }
            //else
            //{
            //    num--;
            //}
            // "Selected Items: "+
            textBox1.Text =   Convert.ToString(num) ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into [Group] Values (@Created_On)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Created_On", dptCreate.Value);
            cmd.ExecuteNonQuery();

            SqlCommand cdd = new SqlCommand("select IDENT_CURRENT('Group')", con);
            int s = Convert.ToInt32(cdd.ExecuteScalar());

            if (Convert.ToInt32(textBox1.Text) < 4 || Convert.ToInt32(textBox1.Text) > 4)
            {
                MessageBox.Show("Minimum Students count is 04", "GroupCreated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                    if (chkboxselected)
                    {
                        SqlCommand cmd2 = new SqlCommand("Insert into GroupStudent Values (@GroupId,@StudentId,@Status,@AssignmentDate)", con);
                        cmd2.CommandType = CommandType.Text;

                        cmd2.Parameters.AddWithValue("@GroupId", s);
                        cmd2.Parameters.AddWithValue("@StudentId", dr.Cells[1].Value);

                        string LookUp = "Select Id from Lookup where Value = '" + cmbStatus.Text + "'";
                        SqlCommand nd = new SqlCommand(LookUp, con);
                        SqlDataReader r = nd.ExecuteReader();
                        int ID = 0;
                        while (r.Read())
                        {
                            ID = r.GetInt32(0);
                        }
                        r.Close();

                        //int status = 0;
                        //if (cmbStatus.Text == "Active")
                        //{
                        //    status = 3;
                        //}
                        //else if (cmbStatus.Text == "In-active")
                        //{
                        //    status = 4;
                        //}
                        cmd2.Parameters.AddWithValue("@Status", ID);
                        cmd2.Parameters.AddWithValue("@AssignmentDate", dtpAssDate.Value);
                        cmd2.ExecuteNonQuery();
                    }
                }

                //SqlCommand cmd2 = new SqlCommand("Insert into GroupStudent Values (@GroupId,@StudentId,@Status,@AssignmentDate)", con);
                //cmd2.CommandType = CommandType.Text;

                //cmd2.Parameters.AddWithValue("@GroupId", s);




                //cmd2.Parameters.AddWithValue("@StudentId", this.stdID);
                //int status = 0;
                //if (cmbStatus.Text == "Active")
                //{
                //    status = 3;
                //}
                //else if (cmbStatus.Text == "In-active")
                //{
                //    status = 4;
                //}
                //cmd2.Parameters.AddWithValue("@Status", status);
                //cmd2.Parameters.AddWithValue("@AssignmentDate", dtpAssDate.Value);
                //cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added in the Group Successfully", "GroupCreated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //private void createGroupToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Group l = Group.getInstance();
        //    l.Show();
        //    this.Hide();
        //}

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
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

        private void updateDeleteAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteAdvisor l = UpdateDeleteAdvisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteEvaluation l = UpdateDeleteEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteProjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteProject l = UpdateDeleteProject.getInstance();
            l.Show();
            this.Hide();
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

        private void groupWithProjectToolStripMenuItem_Click(object sender, EventArgs e)
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
        
        //private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    GroupID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
        //    textBox1.Text = GroupID.ToString();
        //}


    }
}
