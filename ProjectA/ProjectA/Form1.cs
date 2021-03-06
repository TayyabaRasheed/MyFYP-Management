﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Person : Form
    {
        private static Person l = null;
        public Person()
        {
            InitializeComponent();
            GetStudentRecord();
            DatabaseConnection.getInstance().ConnectionString = "Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora";
        }
        public static Person getInstance()
        {
            if (l == null)
            {
                l = new Person();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        private void GetStudentRecord()
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Person", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            
        }



        public bool Checkchar(string s)
        {
            if (s.All(Char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CheckPhonedigits(string ph)
        {
            if (ph.All(Char.IsDigit) == true)
            {
                return true;
            }
            if (ph.Length!=11)
            {               
                return false;
            }
            if (ph != "")
            {
                return false;
            }
            else
            {
                return false;
            }
        }


        //Registration Number Under Checking
        public bool CheckRegnum(string myRegistrationNum)
        {
            string sd1,sd2,sd3,sd4,sd5;               
                       

            sd1 = myRegistrationNum.Substring(0, 4);
            sd2 = myRegistrationNum.Substring(5, 2);
            sd3 = myRegistrationNum.Substring(8);
            sd4 = myRegistrationNum.Substring(4, 1);
            sd5 = myRegistrationNum.Substring(7, 1);


            
                if ((sd4 == "_" || sd4 == "-") && (sd5 == "_" || sd5 == "-") && sd1.All(Char.IsDigit) && sd2.All(Char.IsLetter) && sd3.All(Char.IsDigit))
                {

                    return true;
                }
                else
            {
                return false;
            }
                
           

        }


       
        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            if ((Checkchar(txtFirstName.Text)) != true)
            {

                MessageBox.Show("First Name Must Contain only Alphabet");

            }
            else if ((Checkchar(txtLastName.Text)) != true)
            {

                MessageBox.Show("Last  Name Must Contain only Alphabet");

            }

            else if ((CheckPhonedigits(txtContact.Text)) != true)
            {

                MessageBox.Show("Contact Must Contain only digits");

            }

            else if ((txtContact.Text.Length)!=11)
            {

                MessageBox.Show("Contact Must Contain 11 digits");

            }

            else if (CheckRegnum(txtReg.Text) != true)
            {

                MessageBox.Show("Enter vailid registration number  FORMAT IS xxxx-xx-xxx");

            }

            else if ((txtReg.Text.Length) > 11|| (txtReg.Text.Length) < 10)
            {

                MessageBox.Show("Enter vailid registration number  FORMAT IS xxxx-xx-xxx");

            }

            else if ((txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com"))==false)
            {
                MessageBox.Show("Invalid Mail Correct Email Address format is ----@----.com");
            }
           

            else
            {


                try
                {


                    String frstname = txtFirstName.Text;
                    String lstname = txtLastName.Text;
                    String cntct = txtContact.Text;
                    String mail = txtEmail.Text;
                    DateTime db = dtpDOB.Value;




                    string LookUp = "Select Id from Lookup where Value = '" + comboBox1.Text + "'";
                    SqlCommand nd = new SqlCommand(LookUp, con);
                    SqlDataReader r = nd.ExecuteReader();
                    int ID = 0;
                    while (r.Read())
                    {
                        ID = r.GetInt32(0);
                    }
                    r.Close();

                    String cmd = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}','{5}' )", frstname, lstname, cntct, mail, db, ID);
                    int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);

                    SqlCommand cdd = new SqlCommand("select IDENT_CURRENT('Person')", con);
                    int s = Convert.ToInt32(cdd.ExecuteScalar());

                    SqlCommand cd = new SqlCommand("Insert into Student Values (@Id,@RegistrationNo)", con);
                    cd.CommandType = CommandType.Text;
                    cd.Parameters.AddWithValue("@Id", s);
                    cd.Parameters.AddWithValue("@RegistrationNo", txtReg.Text);
                    cd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(String.Format("{0} rows affected", rows));
                    GetStudentRecord();
                    ClearTextBoxs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void ClearTextBoxs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtFirstName.Focus();
        }
        private void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseConnection.getInstance().closeConnection();
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

        private void addInstructorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
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

        private void editStudentDataToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void advisorWithGroupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksSheet l = MarksSheet.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
