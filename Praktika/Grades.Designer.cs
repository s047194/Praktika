namespace Praktika
{
    partial class frm_grades
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
            this.components = new System.ComponentModel.Container();
            this.txt_namegrade = new System.Windows.Forms.TextBox();
            this.studentbinding = new System.Windows.Forms.BindingSource(this.components);
            this.student = new Praktika.Student();
            this.txt_passgrade = new System.Windows.Forms.TextBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.btn_addgrade = new System.Windows.Forms.Button();
            this.btn_editgrade = new System.Windows.Forms.Button();
            this.btn_savegrade = new System.Windows.Forms.Button();
            this.btn_deletegrade = new System.Windows.Forms.Button();
            this.dgv_grades = new System.Windows.Forms.DataGridView();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblstudentTableAdapter = new Praktika.StudentTableAdapters.tblstudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentbinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grades)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_namegrade
            // 
            this.txt_namegrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentbinding, "Vardas", true));
            this.txt_namegrade.Location = new System.Drawing.Point(120, 22);
            this.txt_namegrade.Name = "txt_namegrade";
            this.txt_namegrade.Size = new System.Drawing.Size(168, 22);
            this.txt_namegrade.TabIndex = 0;
            this.txt_namegrade.TextChanged += new System.EventHandler(this.txt_namegrade_TextChanged);
            // 
            // studentbinding
            // 
            this.studentbinding.DataMember = "tblstudent";
            this.studentbinding.DataSource = this.student;
            // 
            // student
            // 
            this.student.DataSetName = "Student";
            this.student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_passgrade
            // 
            this.txt_passgrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentbinding, "Pavardė", true));
            this.txt_passgrade.Location = new System.Drawing.Point(120, 69);
            this.txt_passgrade.Name = "txt_passgrade";
            this.txt_passgrade.Size = new System.Drawing.Size(168, 22);
            this.txt_passgrade.TabIndex = 1;
            this.txt_passgrade.TextChanged += new System.EventHandler(this.txt_passgrade_TextChanged);
            // 
            // txt_grade
            // 
            this.txt_grade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentbinding, "Grade", true));
            this.txt_grade.Location = new System.Drawing.Point(120, 165);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(168, 22);
            this.txt_grade.TabIndex = 2;
            this.txt_grade.TextChanged += new System.EventHandler(this.txt_grade_TextChanged);
            // 
            // cb_subject
            // 
            this.cb_subject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentbinding, "Subject", true));
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Items.AddRange(new object[] {
            "Informacijos sistemos",
            "Vadyba",
            "Teisė",
            "Matematika",
            "Specialybės kalba",
            "Duomenų bazių projektavimas"});
            this.cb_subject.Location = new System.Drawing.Point(120, 116);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(168, 24);
            this.cb_subject.TabIndex = 3;
            this.cb_subject.SelectedIndexChanged += new System.EventHandler(this.cb_subject_SelectedIndexChanged);
            // 
            // btn_addgrade
            // 
            this.btn_addgrade.Location = new System.Drawing.Point(119, 220);
            this.btn_addgrade.Name = "btn_addgrade";
            this.btn_addgrade.Size = new System.Drawing.Size(169, 25);
            this.btn_addgrade.TabIndex = 4;
            this.btn_addgrade.Text = "Pridėti";
            this.btn_addgrade.UseVisualStyleBackColor = true;
            this.btn_addgrade.Click += new System.EventHandler(this.btn_addgrade_Click);
            // 
            // btn_editgrade
            // 
            this.btn_editgrade.Location = new System.Drawing.Point(120, 267);
            this.btn_editgrade.Name = "btn_editgrade";
            this.btn_editgrade.Size = new System.Drawing.Size(169, 25);
            this.btn_editgrade.TabIndex = 5;
            this.btn_editgrade.Text = "Redaguoti";
            this.btn_editgrade.UseVisualStyleBackColor = true;
            this.btn_editgrade.Click += new System.EventHandler(this.btn_editgrade_Click);
            // 
            // btn_savegrade
            // 
            this.btn_savegrade.Location = new System.Drawing.Point(120, 314);
            this.btn_savegrade.Name = "btn_savegrade";
            this.btn_savegrade.Size = new System.Drawing.Size(169, 25);
            this.btn_savegrade.TabIndex = 6;
            this.btn_savegrade.Text = "Išsaugoti";
            this.btn_savegrade.UseVisualStyleBackColor = true;
            this.btn_savegrade.Click += new System.EventHandler(this.btn_savegrade_Click);
            // 
            // btn_deletegrade
            // 
            this.btn_deletegrade.Location = new System.Drawing.Point(120, 361);
            this.btn_deletegrade.Name = "btn_deletegrade";
            this.btn_deletegrade.Size = new System.Drawing.Size(169, 25);
            this.btn_deletegrade.TabIndex = 7;
            this.btn_deletegrade.Text = "Ištrinti";
            this.btn_deletegrade.UseVisualStyleBackColor = true;
            this.btn_deletegrade.Click += new System.EventHandler(this.btn_deletegrade_Click);
            // 
            // dgv_grades
            // 
            this.dgv_grades.AutoGenerateColumns = false;
            this.dgv_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardėDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dgv_grades.DataSource = this.studentbinding;
            this.dgv_grades.Location = new System.Drawing.Point(335, 12);
            this.dgv_grades.Name = "dgv_grades";
            this.dgv_grades.RowHeadersWidth = 51;
            this.dgv_grades.RowTemplate.Height = 24;
            this.dgv_grades.Size = new System.Drawing.Size(438, 387);
            this.dgv_grades.TabIndex = 8;
            this.dgv_grades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grades_CellContentClick);
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.Width = 125;
            // 
            // pavardėDataGridViewTextBoxColumn
            // 
            this.pavardėDataGridViewTextBoxColumn.DataPropertyName = "Pavardė";
            this.pavardėDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.pavardėDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pavardėDataGridViewTextBoxColumn.Name = "pavardėDataGridViewTextBoxColumn";
            this.pavardėDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Pažymys";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Dalykas";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pavardė:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dalykas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Įvetinimas:";
            // 
            // tblstudentTableAdapter
            // 
            this.tblstudentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_grades);
            this.Controls.Add(this.btn_deletegrade);
            this.Controls.Add(this.btn_savegrade);
            this.Controls.Add(this.btn_editgrade);
            this.Controls.Add(this.btn_addgrade);
            this.Controls.Add(this.cb_subject);
            this.Controls.Add(this.txt_grade);
            this.Controls.Add(this.txt_passgrade);
            this.Controls.Add(this.txt_namegrade);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(804, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(804, 460);
            this.Name = "frm_grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pažymiai";
            this.Load += new System.EventHandler(this.frm_grades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentbinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_namegrade;
        private System.Windows.Forms.TextBox txt_passgrade;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.Button btn_addgrade;
        private System.Windows.Forms.Button btn_editgrade;
        private System.Windows.Forms.Button btn_savegrade;
        private System.Windows.Forms.Button btn_deletegrade;
        private System.Windows.Forms.DataGridView dgv_grades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource studentbinding;
        private Student student;
        private StudentTableAdapters.tblstudentTableAdapter tblstudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
    }
}