﻿namespace ProjectA
{
    partial class GroupStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpAssDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dptCreate = new System.Windows.Forms.DateTimePicker();
            this.assignGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteProjectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupStudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInstructorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGroupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupWithProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorsWithGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(286, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.cmbStatus.Location = new System.Drawing.Point(237, 142);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // dtpAssDate
            // 
            this.dtpAssDate.Location = new System.Drawing.Point(237, 204);
            this.dtpAssDate.Name = "dtpAssDate";
            this.dtpAssDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAssDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assignment Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add To Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Created On";
            // 
            // dptCreate
            // 
            this.dptCreate.Location = new System.Drawing.Point(237, 81);
            this.dptCreate.Name = "dptCreate";
            this.dptCreate.Size = new System.Drawing.Size(200, 20);
            this.dptCreate.TabIndex = 11;
            // 
            // assignGroupProjectToolStripMenuItem
            // 
            this.assignGroupProjectToolStripMenuItem.Name = "assignGroupProjectToolStripMenuItem";
            this.assignGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.assignGroupProjectToolStripMenuItem.Text = "Assign Group Project";
            this.assignGroupProjectToolStripMenuItem.Click += new System.EventHandler(this.assignGroupProjectToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.assignGroupProjectToolStripMenuItem,
            this.updateDeleteProjectDetailsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // updateDeleteProjectDetailsToolStripMenuItem
            // 
            this.updateDeleteProjectDetailsToolStripMenuItem.Name = "updateDeleteProjectDetailsToolStripMenuItem";
            this.updateDeleteProjectDetailsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.updateDeleteProjectDetailsToolStripMenuItem.Text = "UpdateDelete Project Details";
            this.updateDeleteProjectDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteProjectDetailsToolStripMenuItem_Click);
            // 
            // groupStudentsToolStripMenuItem1
            // 
            this.groupStudentsToolStripMenuItem1.Name = "groupStudentsToolStripMenuItem1";
            this.groupStudentsToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.groupStudentsToolStripMenuItem1.Text = "Group Students";
            this.groupStudentsToolStripMenuItem1.Click += new System.EventHandler(this.groupStudentsToolStripMenuItem1_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupStudentsToolStripMenuItem1,
            this.deleteGroupToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteGroupToolStripMenuItem.Text = "Delete Group";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem1,
            this.addStudentToolStripMenuItem1,
            this.addInstructorToolStripMenuItem1,
            this.evaluateGroupsToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem1.Text = "Home";
            this.homeToolStripMenuItem1.Click += new System.EventHandler(this.homeToolStripMenuItem1_Click);
            // 
            // addStudentToolStripMenuItem1
            // 
            this.addStudentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seToolStripMenuItem,
            this.searchStudentsToolStripMenuItem,
            this.editStudentDataToolStripMenuItem});
            this.addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            this.addStudentToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.addStudentToolStripMenuItem1.Text = "Student ";
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.seToolStripMenuItem.Text = "Add Students";
            this.seToolStripMenuItem.Click += new System.EventHandler(this.seToolStripMenuItem_Click);
            // 
            // searchStudentsToolStripMenuItem
            // 
            this.searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            this.searchStudentsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.searchStudentsToolStripMenuItem.Text = "Student\'s Record";
            this.searchStudentsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentsToolStripMenuItem_Click);
            // 
            // editStudentDataToolStripMenuItem
            // 
            this.editStudentDataToolStripMenuItem.Name = "editStudentDataToolStripMenuItem";
            this.editStudentDataToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editStudentDataToolStripMenuItem.Text = "Update&Delete Student Data";
            this.editStudentDataToolStripMenuItem.Click += new System.EventHandler(this.editStudentDataToolStripMenuItem_Click);
            // 
            // addInstructorToolStripMenuItem1
            // 
            this.addInstructorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdvisorToolStripMenuItem,
            this.projectAdvisorToolStripMenuItem,
            this.updateDeleteAdvisorToolStripMenuItem});
            this.addInstructorToolStripMenuItem1.Name = "addInstructorToolStripMenuItem1";
            this.addInstructorToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.addInstructorToolStripMenuItem1.Text = "Instructor";
            // 
            // addAdvisorToolStripMenuItem
            // 
            this.addAdvisorToolStripMenuItem.Name = "addAdvisorToolStripMenuItem";
            this.addAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addAdvisorToolStripMenuItem.Text = "Add Advisor";
            this.addAdvisorToolStripMenuItem.Click += new System.EventHandler(this.addAdvisorToolStripMenuItem_Click);
            // 
            // projectAdvisorToolStripMenuItem
            // 
            this.projectAdvisorToolStripMenuItem.Name = "projectAdvisorToolStripMenuItem";
            this.projectAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.projectAdvisorToolStripMenuItem.Text = "Project Advisor";
            this.projectAdvisorToolStripMenuItem.Click += new System.EventHandler(this.projectAdvisorToolStripMenuItem_Click);
            // 
            // updateDeleteAdvisorToolStripMenuItem
            // 
            this.updateDeleteAdvisorToolStripMenuItem.Name = "updateDeleteAdvisorToolStripMenuItem";
            this.updateDeleteAdvisorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.updateDeleteAdvisorToolStripMenuItem.Text = "UpdateDelete Advisor";
            this.updateDeleteAdvisorToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteAdvisorToolStripMenuItem_Click);
            // 
            // evaluateGroupsToolStripMenuItem
            // 
            this.evaluateGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupWiseToolStripMenuItem,
            this.individualEvaluationToolStripMenuItem,
            this.updateDeleteEvaluationToolStripMenuItem,
            this.editGroupEvaluationToolStripMenuItem});
            this.evaluateGroupsToolStripMenuItem.Name = "evaluateGroupsToolStripMenuItem";
            this.evaluateGroupsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.evaluateGroupsToolStripMenuItem.Text = "Evaluation";
            // 
            // groupWiseToolStripMenuItem
            // 
            this.groupWiseToolStripMenuItem.Name = "groupWiseToolStripMenuItem";
            this.groupWiseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.groupWiseToolStripMenuItem.Text = "Evaluation Details";
            this.groupWiseToolStripMenuItem.Click += new System.EventHandler(this.groupWiseToolStripMenuItem_Click);
            // 
            // individualEvaluationToolStripMenuItem
            // 
            this.individualEvaluationToolStripMenuItem.Name = "individualEvaluationToolStripMenuItem";
            this.individualEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.individualEvaluationToolStripMenuItem.Text = "Groupl Evaluation";
            this.individualEvaluationToolStripMenuItem.Click += new System.EventHandler(this.individualEvaluationToolStripMenuItem_Click);
            // 
            // updateDeleteEvaluationToolStripMenuItem
            // 
            this.updateDeleteEvaluationToolStripMenuItem.Name = "updateDeleteEvaluationToolStripMenuItem";
            this.updateDeleteEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.updateDeleteEvaluationToolStripMenuItem.Text = "UpdateDelete Evaluation";
            this.updateDeleteEvaluationToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteEvaluationToolStripMenuItem_Click);
            // 
            // editGroupEvaluationToolStripMenuItem
            // 
            this.editGroupEvaluationToolStripMenuItem.Name = "editGroupEvaluationToolStripMenuItem";
            this.editGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.editGroupEvaluationToolStripMenuItem.Text = "EditGroup Evaluation";
            this.editGroupEvaluationToolStripMenuItem.Click += new System.EventHandler(this.editGroupEvaluationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupWithProjectToolStripMenuItem,
            this.advisorsWithGroupProjectToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // groupWithProjectToolStripMenuItem
            // 
            this.groupWithProjectToolStripMenuItem.Name = "groupWithProjectToolStripMenuItem";
            this.groupWithProjectToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.groupWithProjectToolStripMenuItem.Text = "GroupWithProject";
            this.groupWithProjectToolStripMenuItem.Click += new System.EventHandler(this.groupWithProjectToolStripMenuItem_Click);
            // 
            // advisorsWithGroupProjectToolStripMenuItem
            // 
            this.advisorsWithGroupProjectToolStripMenuItem.Name = "advisorsWithGroupProjectToolStripMenuItem";
            this.advisorsWithGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.advisorsWithGroupProjectToolStripMenuItem.Text = "AdvisorsWithGroupProject";
            // 
            // GroupStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 360);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dptCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAssDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GroupStudents";
            this.Text = "GroupStudents";
            this.Load += new System.EventHandler(this.GroupStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpAssDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dptCreate;
        private System.Windows.Forms.ToolStripMenuItem assignGroupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupStudentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteProjectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGroupEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupWithProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advisorsWithGroupProjectToolStripMenuItem;
    }
}