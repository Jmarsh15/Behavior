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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ChangeStudent = new System.Windows.Forms.Button();
            this.combo_StudentNames = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_StudentID = new System.Windows.Forms.TextBox();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.txt_TeacherPassword = new System.Windows.Forms.TextBox();
            this.Combo_Teachers = new System.Windows.Forms.ComboBox();
            this.radio_Change = new System.Windows.Forms.RadioButton();
            this.radio_Delete = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Questions = new System.Windows.Forms.ComboBox();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Location = new System.Drawing.Point(115, 12);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(105, 49);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_AddTeacher
            // 
            this.btn_AddTeacher.Location = new System.Drawing.Point(226, 12);
            this.btn_AddTeacher.Name = "btn_AddTeacher";
            this.btn_AddTeacher.Size = new System.Drawing.Size(105, 49);
            this.btn_AddTeacher.TabIndex = 2;
            this.btn_AddTeacher.Text = "Add Teacher";
            this.btn_AddTeacher.UseVisualStyleBackColor = true;
            this.btn_AddTeacher.Click += new System.EventHandler(this.btn_AddTeacher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Student Reports ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ChangeStudent
            // 
            this.btn_ChangeStudent.Location = new System.Drawing.Point(559, 12);
            this.btn_ChangeStudent.Name = "btn_ChangeStudent";
            this.btn_ChangeStudent.Size = new System.Drawing.Size(105, 49);
            this.btn_ChangeStudent.TabIndex = 5;
            this.btn_ChangeStudent.Text = "Change/Delete Student";
            this.btn_ChangeStudent.UseVisualStyleBackColor = true;
            this.btn_ChangeStudent.Click += new System.EventHandler(this.btn_ChangeStudent_Click);
            // 
            // combo_StudentNames
            // 
            this.combo_StudentNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_StudentNames.FormattingEnabled = true;
            this.combo_StudentNames.Location = new System.Drawing.Point(28, 40);
            this.combo_StudentNames.Margin = new System.Windows.Forms.Padding(2);
            this.combo_StudentNames.Name = "combo_StudentNames";
            this.combo_StudentNames.Size = new System.Drawing.Size(104, 21);
            this.combo_StudentNames.TabIndex = 22;
            this.combo_StudentNames.SelectedIndexChanged += new System.EventHandler(this.combo_StudentNames_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(492, 306);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Teacher";
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
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(190, 37);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 12;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(190, 67);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 13;
            // 
            // txt_StudentID
            // 
            this.txt_StudentID.Location = new System.Drawing.Point(190, 97);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentID.TabIndex = 14;
            // 
            // txt_Days
            // 
            this.txt_Days.Location = new System.Drawing.Point(190, 157);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(100, 20);
            this.txt_Days.TabIndex = 16;
            // 
            // txt_TeacherPassword
            // 
            this.txt_TeacherPassword.Location = new System.Drawing.Point(190, 97);
            this.txt_TeacherPassword.Name = "txt_TeacherPassword";
            this.txt_TeacherPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_TeacherPassword.TabIndex = 20;
            // 
            // Combo_Teachers
            // 
            this.Combo_Teachers.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_Teachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Teachers.FormattingEnabled = true;
            this.Combo_Teachers.Location = new System.Drawing.Point(190, 126);
            this.Combo_Teachers.Margin = new System.Windows.Forms.Padding(2);
            this.Combo_Teachers.Name = "Combo_Teachers";
            this.Combo_Teachers.Size = new System.Drawing.Size(100, 21);
            this.Combo_Teachers.TabIndex = 21;
            // 
            // radio_Change
            // 
            this.radio_Change.AutoSize = true;
            this.radio_Change.Location = new System.Drawing.Point(65, 115);
            this.radio_Change.Margin = new System.Windows.Forms.Padding(2);
            this.radio_Change.Name = "radio_Change";
            this.radio_Change.Size = new System.Drawing.Size(105, 17);
            this.radio_Change.TabIndex = 24;
            this.radio_Change.TabStop = true;
            this.radio_Change.Text = "Change Teacher";
            this.radio_Change.UseVisualStyleBackColor = true;
            // 
            // radio_Delete
            // 
            this.radio_Delete.AutoSize = true;
            this.radio_Delete.Location = new System.Drawing.Point(190, 115);
            this.radio_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.radio_Delete.Name = "radio_Delete";
            this.radio_Delete.Size = new System.Drawing.Size(96, 17);
            this.radio_Delete.TabIndex = 25;
            this.radio_Delete.TabStop = true;
            this.radio_Delete.Text = "Delete Student";
            this.radio_Delete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Students";
            // 
            // combo_Questions
            // 
            this.combo_Questions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Questions.FormattingEnabled = true;
            this.combo_Questions.Location = new System.Drawing.Point(28, 113);
            this.combo_Questions.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Questions.Name = "combo_Questions";
            this.combo_Questions.Size = new System.Drawing.Size(194, 21);
            this.combo_Questions.TabIndex = 27;
            // 
            // panel_Student
            // 
            this.panel_Student.Controls.Add(this.combo_Questions);
            this.panel_Student.Controls.Add(this.label3);
            this.panel_Student.Controls.Add(this.radio_Delete);
            this.panel_Student.Controls.Add(this.radio_Change);
            this.panel_Student.Controls.Add(this.Combo_Teachers);
            this.panel_Student.Controls.Add(this.txt_TeacherPassword);
            this.panel_Student.Controls.Add(this.txt_Days);
            this.panel_Student.Controls.Add(this.txt_StudentID);
            this.panel_Student.Controls.Add(this.txt_LastName);
            this.panel_Student.Controls.Add(this.txt_FirstName);
            this.panel_Student.Controls.Add(this.btn_Save);
            this.panel_Student.Controls.Add(this.label10);
            this.panel_Student.Controls.Add(this.label11);
            this.panel_Student.Controls.Add(this.label4);
            this.panel_Student.Controls.Add(this.label2);
            this.panel_Student.Controls.Add(this.label1);
            this.panel_Student.Controls.Add(this.dataGridView1);
            this.panel_Student.Controls.Add(this.combo_StudentNames);
            this.panel_Student.Location = new System.Drawing.Point(0, 67);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(737, 427);
            this.panel_Student.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Individual Student Reports ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ChangeStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_Student);
            this.Controls.Add(this.btn_AddTeacher);
            this.Controls.Add(this.btn_AddStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Student.ResumeLayout(false);
            this.panel_Student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_AddTeacher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ChangeStudent;
        private System.Windows.Forms.ComboBox combo_StudentNames;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_StudentID;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.TextBox txt_TeacherPassword;
        private System.Windows.Forms.ComboBox Combo_Teachers;
        private System.Windows.Forms.RadioButton radio_Change;
        private System.Windows.Forms.RadioButton radio_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Questions;
        private System.Windows.Forms.Panel panel_Student;
        private System.Windows.Forms.Button button2;
    }
}