﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class UpdateDeleteStudent : Form
    {
        private static UpdateDeleteStudent l = null;
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public int stdID { get; set; }
        public static UpdateDeleteStudent getInstance()
        {
            if (l == null)
            {
                l = new UpdateDeleteStudent();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            this.dataGridView1.Columns["Id"].Visible = false;
        }

        private void GetStudentRecord()
        {
            SqlCommand cmd = new SqlCommand("SELECT Person.Id,Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person INNER JOIN Student on Person.Id=Student.Id", con);

            DataTable dt = new DataTable();
            con.Close();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        private void ClearTextBoxs()
        {
            stdID = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Person SET FirstName= @FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                int gndr;
                if (rdmale.Checked == true)
                {
                    gndr = 1;
                }
                else
                {
                    gndr = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gndr);
                con.Open();
                cmd.ExecuteNonQuery();

                SqlCommand cdd = new SqlCommand("select IDENT_CURRENT('Person')", con);
                int s = Convert.ToInt32(cdd.ExecuteScalar());
                con.Close();

                SqlCommand cd = new SqlCommand("Update Student SET RegistrationNo=@RegistrationNo where Id=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.stdID);
                cd.Parameters.AddWithValue("@RegistrationNo", txtReg.Text);
                con.Open();
                cd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Student for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            if (stdID > 0)
            {
                
                SqlCommand cd = new SqlCommand("Delete Student where Id=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.stdID);
                cd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Person where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Student to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) == 1)
            {
                rdmale.Checked = true;
            }
            else
            {
                rdfml.Checked = true;
            }
            txtReg.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
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

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }

        private void seToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}