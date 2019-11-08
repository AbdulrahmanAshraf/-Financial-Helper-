namespace grad_proj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.log_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.user_txt.Location = new System.Drawing.Point(56, 144);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(176, 26);
            this.user_txt.TabIndex = 3;
            this.user_txt.Text = "User Name";
            this.user_txt.Enter += new System.EventHandler(this.user_txt_Enter);
            this.user_txt.Leave += new System.EventHandler(this.user_txt_Leave);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass_txt.Location = new System.Drawing.Point(56, 188);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(176, 26);
            this.pass_txt.TabIndex = 4;
            this.pass_txt.Text = "Password";
            this.pass_txt.Enter += new System.EventHandler(this.pass_txt_Enter);
            this.pass_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_txt_KeyDown);
            this.pass_txt.Leave += new System.EventHandler(this.pass_txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "password";
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.log_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.log_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(56, 250);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(80, 33);
            this.log_btn.TabIndex = 1;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(152, 250);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(80, 33);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Exit";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(53, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "WRONG UserName or Password";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(291, 311);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.e);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

