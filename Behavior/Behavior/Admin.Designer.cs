namespace Behavior
{
    partial class Admin
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
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_AddTeacher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Teacher = new System.Windows.Forms.TextBox();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.txt_StudentID = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(184, 12);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(105, 49);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            // 
            // btn_AddTeacher
            // 
            this.btn_AddTeacher.Location = new System.Drawing.Point(295, 12);
            this.btn_AddTeacher.Name = "btn_AddTeacher";
            this.btn_AddTeacher.Size = new System.Drawing.Size(105, 49);
            this.btn_AddTeacher.TabIndex = 2;
            this.btn_AddTeacher.Text = "Add Teacher";
            this.btn_AddTeacher.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Teacher);
            this.panel1.Controls.Add(this.txt_Days);
            this.panel1.Controls.Add(this.txt_StudentID);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 427);
            this.panel1.TabIndex = 3;
            // 
            // txt_Teacher
            // 
            this.txt_Teacher.Location = new System.Drawing.Point(190, 127);
            this.txt_Teacher.Name = "txt_Teacher";
            this.txt_Teacher.Size = new System.Drawing.Size(100, 20);
            this.txt_Teacher.TabIndex = 17;
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(190, 157);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(100, 20);
            this.txt_Days.TabIndex = 16;
            // 
            // txt_StudentID
            // 
            this.txt_StudentID.Location = new System.Drawing.Point(190, 97);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentID.TabIndex = 14;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(190, 67);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 13;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(190, 37);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(296, 348);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 49);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Day\'s needed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AddTeacher);
            this.Controls.Add(this.btn_AddStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_AddTeacher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Teacher;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.TextBox txt_StudentID;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
    }
}