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
    public partial class MarksSheet : Form
    {
        private static MarksSheet l = null;
        public MarksSheet()
        {
            InitializeComponent();
        }
        public static MarksSheet getInstance()
        {
            if (l == null)
            {
                l = new MarksSheet();
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
            SqlCommand cmd = new SqlCommand("SELECT GroupStudent.GroupId,Student.RegistrationNo,GroupProject.ProjectId,Project.Title as ProjectTitle,Project.Description as ProjectDescription,GroupEvaluation.ObtainedMarks,Evaluation.Name as Evaluation_Detail from GroupStudent INNER JOIN Student on GroupStudent.StudentId=Student.Id inner join GroupProject on GroupStudent.GroupId=GroupProject.GroupId inner join Project on GroupProject.ProjectId=Project.Id inner join GroupEvaluation on GroupProject.GroupId=GroupEvaluation.GroupId inner join Evaluation on GroupEvaluation.EvaluationId=Evaluation.Id", con);
            //  SqlCommand cmd = new SqlCommand("SELECT Project.Title  AS ProjectTitle,Project.Description AS ProjectDescription,GroupProject.GroupId,([Group].Created_On),GroupStudent.StudentId from Project INNER JOIN GroupProject on Project.Id=GroupProject.ProjectId inner join [Group] on GroupProject.GroupId=[Group].Id inner join GroupStudent on GroupProject.GroupId=GroupStudent.StudentId", con);



            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["GroupId"].Visible = false;
            this.dataGridView1.Columns["ProjectId"].Visible = false;
            MergeGridviewCells(dataGridView1, new int[] { 0 });
        }
        private void MergeGridviewCells(DataGridView DGV, int[] idx)
        {
            DataGridViewRow Prev = null;

            foreach (DataGridViewRow item in DGV.Rows)
            {
                if (Prev != null)
                {
                    string firstCellText = string.Empty;
                    string secondCellText = string.Empty;

                    foreach (int i in idx)
                    {
                        DataGridViewCell firstCell = Prev.Cells[i];
                        DataGridViewCell secondCell = item.Cells[i];

                        firstCellText = (firstCell != null && firstCell.Value != null ? firstCell.Value.ToString() : string.Empty);
                        secondCellText = (secondCell != null && secondCell.Value != null ? secondCell.Value.ToString() : string.Empty);

                        if (firstCellText == secondCellText)
                        {
                            secondCell.Style.ForeColor = Color.Transparent;
                        }
                        else
                        {
                            Prev = item;
                            break;
                        }
                    }
                }
                else
                {
                    Prev = item;
                }
            }
        }

        private void groupsWithProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Show();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }
        private void MarksSheet_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void advisorsWithGroupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void editGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEvaluation l = EditEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup l = DeleteGroup.getInstance();
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

        private void updateDeleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteProject l = UpdateDeleteProject.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
