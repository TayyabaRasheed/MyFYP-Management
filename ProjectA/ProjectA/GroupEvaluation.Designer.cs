﻿namespace ProjectA
{
    partial class GroupEvaluation
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
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gdGroup = new System.Windows.Forms.DataGridView();
            this.gdEvaluation = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupsWithProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorsWithGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gdGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEvaluation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(148, 89);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 20);
            this.txtMarks.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(148, 138);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obtained Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(46, 230);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(115, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save Result";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // gdGroup
            // 
            this.gdGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdGroup.Location = new System.Drawing.Point(366, 89);
            this.gdGroup.Name = "gdGroup";
            this.gdGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdGroup.Size = new System.Drawing.Size(240, 150);
            this.gdGroup.TabIndex = 5;
            this.gdGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdGroup_CellClick);
            // 
            // gdEvaluation
            // 
            this.gdEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdEvaluation.Location = new System.Drawing.Point(624, 89);
            this.gdEvaluation.Name = "gdEvaluation";
            this.gdEvaluation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdEvaluation.Size = new System.Drawing.Size(215, 150);
            this.gdEvaluation.TabIndex = 6;
            this.gdEvaluation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdEvaluation_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Group Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evaluation Details";
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
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.addStudentToolStripMenuItem1.Click += new System.EventHandler(this.addStudentToolStripMenuItem1_Click);
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
            this.groupsWithProjectToolStripMenuItem,
            this.advisorsWithGroupProjectToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // groupsWithProjectToolStripMenuItem
            // 
            this.groupsWithProjectToolStripMenuItem.Name = "groupsWithProjectToolStripMenuItem";
            this.groupsWithProjectToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.groupsWithProjectToolStripMenuItem.Text = "GroupsWithProject";
            this.groupsWithProjectToolStripMenuItem.Click += new System.EventHandler(this.groupsWithProjectToolStripMenuItem_Click);
            // 
            // advisorsWithGroupProjectToolStripMenuItem
            // 
            this.advisorsWithGroupProjectToolStripMenuItem.Name = "advisorsWithGroupProjectToolStripMenuItem";
            this.advisorsWithGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.advisorsWithGroupProjectToolStripMenuItem.Text = "AdvisorsWithGroupProject";
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 317);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gdEvaluation);
            this.Controls.Add(this.gdGroup);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtMarks);
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            this.Load += new System.EventHandler(this.GroupEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEvaluation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DataGridView gdGroup;
        private System.Windows.Forms.DataGridView gdEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ToolStripMenuItem groupsWithProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advisorsWithGroupProjectToolStripMenuItem;
    }
}