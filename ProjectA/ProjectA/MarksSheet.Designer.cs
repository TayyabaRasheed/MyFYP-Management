namespace ProjectA
{
    partial class MarksSheet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupStudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsWithProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorsWithGroupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
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
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem1
            // 
            this.homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            this.homeToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem1.Text = "Home";
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
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupStudentsToolStripMenuItem1,
            this.deleteGroupToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // groupStudentsToolStripMenuItem1
            // 
            this.groupStudentsToolStripMenuItem1.Name = "groupStudentsToolStripMenuItem1";
            this.groupStudentsToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.groupStudentsToolStripMenuItem1.Text = "Group Students";
            this.groupStudentsToolStripMenuItem1.Click += new System.EventHandler(this.groupStudentsToolStripMenuItem1_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteGroupToolStripMenuItem.Text = "Delete Group";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.assignGroupProjectToolStripMenuItem,
            this.updateDeleteProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // assignGroupProjectToolStripMenuItem
            // 
            this.assignGroupProjectToolStripMenuItem.Name = "assignGroupProjectToolStripMenuItem";
            this.assignGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.assignGroupProjectToolStripMenuItem.Text = "Assign Group Project";
            this.assignGroupProjectToolStripMenuItem.Click += new System.EventHandler(this.assignGroupProjectToolStripMenuItem_Click);
            // 
            // updateDeleteProjectToolStripMenuItem
            // 
            this.updateDeleteProjectToolStripMenuItem.Name = "updateDeleteProjectToolStripMenuItem";
            this.updateDeleteProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.updateDeleteProjectToolStripMenuItem.Text = "UpdateDelete Project";
            this.updateDeleteProjectToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteProjectToolStripMenuItem_Click);
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
            this.groupsWithProjectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.groupsWithProjectToolStripMenuItem.Text = "GroupsWithProject";
            // 
            // advisorsWithGroupProjectToolStripMenuItem
            // 
            this.advisorsWithGroupProjectToolStripMenuItem.Name = "advisorsWithGroupProjectToolStripMenuItem";
            this.advisorsWithGroupProjectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.advisorsWithGroupProjectToolStripMenuItem.Text = "MarksSheet";
            this.advisorsWithGroupProjectToolStripMenuItem.Click += new System.EventHandler(this.advisorsWithGroupProjectToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 128);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97727F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.02273F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(443, 201);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "MarksSheet Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // MarksSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 347);
            this.Controls.Add(this.groupBox1);
            this.Name = "MarksSheet";
            this.Text = "MarksSheet";
            this.Load += new System.EventHandler(this.MarksSheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInstructorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGroupEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupStudentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignGroupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsWithProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advisorsWithGroupProjectToolStripMenuItem;
    }
}