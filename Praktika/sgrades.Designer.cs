namespace Praktika
{
    partial class frm_sgrades
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
            this.dgv_sgrades = new System.Windows.Forms.DataGridView();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardėDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student = new Praktika.Student();
            this.tblstudentTableAdapter = new Praktika.StudentTableAdapters.tblstudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sgrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sgrades
            // 
            this.dgv_sgrades.AutoGenerateColumns = false;
            this.dgv_sgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sgrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardėDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dgv_sgrades.DataSource = this.tblstudentBindingSource;
            this.dgv_sgrades.Location = new System.Drawing.Point(12, 12);
            this.dgv_sgrades.Name = "dgv_sgrades";
            this.dgv_sgrades.RowHeadersWidth = 51;
            this.dgv_sgrades.RowTemplate.Height = 24;
            this.dgv_sgrades.Size = new System.Drawing.Size(553, 305);
            this.dgv_sgrades.TabIndex = 0;
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
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tblstudent";
            this.tblstudentBindingSource.DataSource = this.student;
            this.tblstudentBindingSource.CurrentChanged += new System.EventHandler(this.tblstudentBindingSource_CurrentChanged);
            // 
            // student
            // 
            this.student.DataSetName = "Student";
            this.student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentTableAdapter
            // 
            this.tblstudentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_sgrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 329);
            this.Controls.Add(this.dgv_sgrades);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(594, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(594, 376);
            this.Name = "frm_sgrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pažymiai";
            this.Load += new System.EventHandler(this.frm_sgrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sgrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sgrades;
        private Student student;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private StudentTableAdapters.tblstudentTableAdapter tblstudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardėDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
    }
}