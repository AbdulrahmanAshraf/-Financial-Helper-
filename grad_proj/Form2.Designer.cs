namespace grad_proj
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.data_operation = new System.Windows.Forms.ToolStripMenuItem();
            this.add_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.modify = new System.Windows.Forms.ToolStripMenuItem();
            this.user_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.add_user = new System.Windows.Forms.ToolStripMenuItem();
            this.change_password = new System.Windows.Forms.ToolStripMenuItem();
            this.datahistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_profision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_profisin = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.gb_professor = new System.Windows.Forms.GroupBox();
            this.cb_research = new System.Windows.Forms.CheckBox();
            this.cb_supervisory = new System.Windows.Forms.CheckBox();
            this.cb_accomodation = new System.Windows.Forms.CheckBox();
            this.cb_traffic = new System.Windows.Forms.CheckBox();
            this.cb_exams_observation = new System.Windows.Forms.CheckBox();
            this.cb_exams_control = new System.Windows.Forms.CheckBox();
            this.cb_over_time = new System.Windows.Forms.CheckBox();
            this.cb_summer_course = new System.Windows.Forms.CheckBox();
            this.cb_exams_marking = new System.Windows.Forms.CheckBox();
            this.cb_deputation = new System.Windows.Forms.CheckBox();
            this.lab_department = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.but_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.gb_professor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data_operation,
            this.user_setting,
            this.datahistory});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(527, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // data_operation
            // 
            this.data_operation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_delete,
            this.modify});
            this.data_operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.data_operation.Name = "data_operation";
            this.data_operation.Size = new System.Drawing.Size(99, 20);
            this.data_operation.Text = "Data Operation";
            // 
            // add_delete
            // 
            this.add_delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.add_delete.ForeColor = System.Drawing.Color.White;
            this.add_delete.Name = "add_delete";
            this.add_delete.Size = new System.Drawing.Size(134, 22);
            this.add_delete.Text = "Add/Delete";
            this.add_delete.Click += new System.EventHandler(this.add_delete_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(134, 22);
            this.modify.Text = "Modify";
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // user_setting
            // 
            this.user_setting.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.user_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_user,
            this.change_password});
            this.user_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.user_setting.Name = "user_setting";
            this.user_setting.Size = new System.Drawing.Size(82, 20);
            this.user_setting.Text = "User Setting";
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.add_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(168, 22);
            this.add_user.Text = "Add User";
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // change_password
            // 
            this.change_password.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.change_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(168, 22);
            this.change_password.Text = "Change password";
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // datahistory
            // 
            this.datahistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.datahistory.Name = "datahistory";
            this.datahistory.Size = new System.Drawing.Size(82, 20);
            this.datahistory.Text = "Data history";
            this.datahistory.Click += new System.EventHandler(this.datahistory_Click);
            // 
            // cb_profision
            // 
            this.cb_profision.BackColor = System.Drawing.Color.White;
            this.cb_profision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_profision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_profision.FormattingEnabled = true;
            this.cb_profision.Location = new System.Drawing.Point(143, 82);
            this.cb_profision.Name = "cb_profision";
            this.cb_profision.Size = new System.Drawing.Size(139, 24);
            this.cb_profision.TabIndex = 1;
            this.cb_profision.SelectionChangeCommitted += new System.EventHandler(this.cb_profision_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(43, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(143, 151);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 24);
            this.name.TabIndex = 5;
            this.name.SelectionChangeCommitted += new System.EventHandler(this.name_SelectionChangeCommitted);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.lab_name.Location = new System.Drawing.Point(16, 153);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(65, 20);
            this.lab_name.TabIndex = 6;
            this.lab_name.Text = "Name :";
            // 
            // lab_profisin
            // 
            this.lab_profisin.AutoSize = true;
            this.lab_profisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_profisin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.lab_profisin.Location = new System.Drawing.Point(16, 85);
            this.lab_profisin.Name = "lab_profisin";
            this.lab_profisin.Size = new System.Drawing.Size(86, 18);
            this.lab_profisin.TabIndex = 7;
            this.lab_profisin.Text = "Profision :";
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.but_cancel.FlatAppearance.BorderSize = 0;
            this.but_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancel.ForeColor = System.Drawing.Color.White;
            this.but_cancel.Location = new System.Drawing.Point(423, 446);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 30);
            this.but_cancel.TabIndex = 10;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // gb_professor
            // 
            this.gb_professor.Controls.Add(this.cb_research);
            this.gb_professor.Controls.Add(this.cb_supervisory);
            this.gb_professor.Controls.Add(this.cb_accomodation);
            this.gb_professor.Controls.Add(this.cb_traffic);
            this.gb_professor.Controls.Add(this.cb_exams_observation);
            this.gb_professor.Controls.Add(this.cb_exams_control);
            this.gb_professor.Controls.Add(this.cb_over_time);
            this.gb_professor.Controls.Add(this.cb_summer_course);
            this.gb_professor.Controls.Add(this.cb_exams_marking);
            this.gb_professor.Controls.Add(this.cb_deputation);
            this.gb_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_professor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.gb_professor.Location = new System.Drawing.Point(14, 231);
            this.gb_professor.Name = "gb_professor";
            this.gb_professor.Size = new System.Drawing.Size(498, 177);
            this.gb_professor.TabIndex = 15;
            this.gb_professor.TabStop = false;
            this.gb_professor.Text = "Salary bonuses";
            // 
            // cb_research
            // 
            this.cb_research.AutoSize = true;
            this.cb_research.Location = new System.Drawing.Point(10, 118);
            this.cb_research.Name = "cb_research";
            this.cb_research.Size = new System.Drawing.Size(127, 20);
            this.cb_research.TabIndex = 24;
            this.cb_research.Text = "Research Bonus";
            this.cb_research.UseVisualStyleBackColor = true;
            // 
            // cb_supervisory
            // 
            this.cb_supervisory.AutoSize = true;
            this.cb_supervisory.Location = new System.Drawing.Point(286, 87);
            this.cb_supervisory.Name = "cb_supervisory";
            this.cb_supervisory.Size = new System.Drawing.Size(139, 20);
            this.cb_supervisory.TabIndex = 23;
            this.cb_supervisory.Text = "Supervisory bonus";
            this.cb_supervisory.UseVisualStyleBackColor = true;
            // 
            // cb_accomodation
            // 
            this.cb_accomodation.AutoSize = true;
            this.cb_accomodation.Location = new System.Drawing.Point(286, 54);
            this.cb_accomodation.Name = "cb_accomodation";
            this.cb_accomodation.Size = new System.Drawing.Size(189, 20);
            this.cb_accomodation.TabIndex = 22;
            this.cb_accomodation.Text = "Accommodation allowance";
            this.cb_accomodation.UseVisualStyleBackColor = true;
            // 
            // cb_traffic
            // 
            this.cb_traffic.AutoSize = true;
            this.cb_traffic.Location = new System.Drawing.Point(286, 21);
            this.cb_traffic.Name = "cb_traffic";
            this.cb_traffic.Size = new System.Drawing.Size(128, 20);
            this.cb_traffic.TabIndex = 21;
            this.cb_traffic.Text = "Traffic allowance";
            this.cb_traffic.UseVisualStyleBackColor = true;
            // 
            // cb_exams_observation
            // 
            this.cb_exams_observation.AutoSize = true;
            this.cb_exams_observation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_exams_observation.Location = new System.Drawing.Point(132, 85);
            this.cb_exams_observation.Name = "cb_exams_observation";
            this.cb_exams_observation.Size = new System.Drawing.Size(133, 19);
            this.cb_exams_observation.TabIndex = 20;
            this.cb_exams_observation.Text = "Exams  observation";
            this.cb_exams_observation.UseVisualStyleBackColor = true;
            // 
            // cb_exams_control
            // 
            this.cb_exams_control.AutoSize = true;
            this.cb_exams_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_exams_control.Location = new System.Drawing.Point(10, 52);
            this.cb_exams_control.Name = "cb_exams_control";
            this.cb_exams_control.Size = new System.Drawing.Size(104, 19);
            this.cb_exams_control.TabIndex = 1;
            this.cb_exams_control.Text = "Exams control";
            this.cb_exams_control.UseVisualStyleBackColor = true;
            // 
            // cb_over_time
            // 
            this.cb_over_time.AutoSize = true;
            this.cb_over_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_over_time.Location = new System.Drawing.Point(132, 52);
            this.cb_over_time.Name = "cb_over_time";
            this.cb_over_time.Size = new System.Drawing.Size(78, 19);
            this.cb_over_time.TabIndex = 19;
            this.cb_over_time.Text = "Over time";
            this.cb_over_time.UseVisualStyleBackColor = true;
            // 
            // cb_summer_course
            // 
            this.cb_summer_course.AutoSize = true;
            this.cb_summer_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_summer_course.Location = new System.Drawing.Point(10, 19);
            this.cb_summer_course.Name = "cb_summer_course";
            this.cb_summer_course.Size = new System.Drawing.Size(116, 19);
            this.cb_summer_course.TabIndex = 0;
            this.cb_summer_course.Text = "Summer Course";
            this.cb_summer_course.UseVisualStyleBackColor = true;
            // 
            // cb_exams_marking
            // 
            this.cb_exams_marking.AutoSize = true;
            this.cb_exams_marking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_exams_marking.Location = new System.Drawing.Point(10, 85);
            this.cb_exams_marking.Name = "cb_exams_marking";
            this.cb_exams_marking.Size = new System.Drawing.Size(112, 19);
            this.cb_exams_marking.TabIndex = 2;
            this.cb_exams_marking.Text = "Exams marking";
            this.cb_exams_marking.UseVisualStyleBackColor = true;
            // 
            // cb_deputation
            // 
            this.cb_deputation.AutoSize = true;
            this.cb_deputation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_deputation.Location = new System.Drawing.Point(132, 21);
            this.cb_deputation.Name = "cb_deputation";
            this.cb_deputation.Size = new System.Drawing.Size(86, 19);
            this.cb_deputation.TabIndex = 3;
            this.cb_deputation.Text = "Deputation";
            this.cb_deputation.UseVisualStyleBackColor = true;
            // 
            // lab_department
            // 
            this.lab_department.AutoSize = true;
            this.lab_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.lab_department.Location = new System.Drawing.Point(16, 118);
            this.lab_department.Name = "lab_department";
            this.lab_department.Size = new System.Drawing.Size(114, 20);
            this.lab_department.TabIndex = 16;
            this.lab_department.Text = "Department :";
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.Color.White;
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(143, 116);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(139, 24);
            this.cb_department.TabIndex = 20;
            this.cb_department.SelectionChangeCommitted += new System.EventHandler(this.cb_department_SelectionChangeCommitted);
            // 
            // but_save
            // 
            this.but_save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.but_save.FlatAppearance.BorderSize = 0;
            this.but_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.but_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_save.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.ForeColor = System.Drawing.Color.White;
            this.but_save.Location = new System.Drawing.Point(331, 446);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 30);
            this.but_save.TabIndex = 2;
            this.but_save.Text = "Save";
            this.but_save.UseVisualStyleBackColor = false;
            this.but_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 137);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(527, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.gb_professor);
            this.Controls.Add(this.lab_department);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.lab_profisin);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.cb_profision);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Text = "Main window";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gb_professor.ResumeLayout(false);
            this.gb_professor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem data_operation;
        private System.Windows.Forms.ToolStripMenuItem add_delete;
        private System.Windows.Forms.ToolStripMenuItem modify;
        private System.Windows.Forms.ToolStripMenuItem user_setting;
        private System.Windows.Forms.ToolStripMenuItem add_user;
        private System.Windows.Forms.ToolStripMenuItem change_password;
        private System.Windows.Forms.ToolStripMenuItem datahistory;
        private System.Windows.Forms.ComboBox cb_profision;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_profisin;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.GroupBox gb_professor;
        private System.Windows.Forms.Label lab_department;
        private System.Windows.Forms.CheckBox cb_exams_control;
        private System.Windows.Forms.CheckBox cb_summer_course;
        private System.Windows.Forms.CheckBox cb_exams_marking;
        private System.Windows.Forms.CheckBox cb_deputation;
        private System.Windows.Forms.CheckBox cb_over_time;
        private System.Windows.Forms.CheckBox cb_exams_observation;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.CheckBox cb_research;
        private System.Windows.Forms.CheckBox cb_supervisory;
        private System.Windows.Forms.CheckBox cb_accomodation;
        private System.Windows.Forms.CheckBox cb_traffic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}