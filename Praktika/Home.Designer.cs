namespace Praktika
{
    partial class frm_home
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.btn_adduseradmin = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_grades = new System.Windows.Forms.Button();
            this.btn_sgrades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(704, 22);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 24);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.Location = new System.Drawing.Point(312, 58);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(58, 20);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Sveiki:";
            // 
            // btn_adduseradmin
            // 
            this.btn_adduseradmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduseradmin.Location = new System.Drawing.Point(506, 171);
            this.btn_adduseradmin.Name = "btn_adduseradmin";
            this.btn_adduseradmin.Size = new System.Drawing.Size(144, 95);
            this.btn_adduseradmin.TabIndex = 4;
            this.btn_adduseradmin.Text = "Pridėti vartotoją";
            this.btn_adduseradmin.UseVisualStyleBackColor = true;
            this.btn_adduseradmin.Click += new System.EventHandler(this.btn_adduseradmin_Click);
            // 
            // btn_student
            // 
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Location = new System.Drawing.Point(316, 171);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(144, 95);
            this.btn_student.TabIndex = 1;
            this.btn_student.Text = "Studentai";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_grades
            // 
            this.btn_grades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grades.Location = new System.Drawing.Point(126, 171);
            this.btn_grades.Name = "btn_grades";
            this.btn_grades.Size = new System.Drawing.Size(144, 95);
            this.btn_grades.TabIndex = 8;
            this.btn_grades.Text = "Pažymiai";
            this.btn_grades.UseVisualStyleBackColor = true;
            this.btn_grades.Click += new System.EventHandler(this.btn_grades_Click);
            // 
            // btn_sgrades
            // 
            this.btn_sgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sgrades.Location = new System.Drawing.Point(316, 284);
            this.btn_sgrades.Name = "btn_sgrades";
            this.btn_sgrades.Size = new System.Drawing.Size(144, 95);
            this.btn_sgrades.TabIndex = 9;
            this.btn_sgrades.Text = "Pažymiai";
            this.btn_sgrades.UseVisualStyleBackColor = true;
            this.btn_sgrades.Click += new System.EventHandler(this.btn_sgrades_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sgrades);
            this.Controls.Add(this.btn_grades);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_adduseradmin);
            this.Controls.Add(this.btn_student);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.Button btn_adduseradmin;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_grades;
        private System.Windows.Forms.Button btn_sgrades;
    }
}