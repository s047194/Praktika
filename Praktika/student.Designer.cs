namespace Praktika
{
    partial class frm_student
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
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.appData = new Praktika.AppData();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbllogTableAdapter = new Praktika.AppDataTableAdapters.tbllogTableAdapter();
            this.tbllogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToOrderColumns = true;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(8, 12);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowHeadersWidth = 51;
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.Size = new System.Drawing.Size(617, 342);
            this.dgv_student.TabIndex = 0;
            this.dgv_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellContentClick);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // tbllogBindingSource1
            // 
            this.tbllogBindingSource1.DataMember = "tbllog";
            this.tbllogBindingSource1.DataSource = this.appData;
            // 
            // frm_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 366);
            this.Controls.Add(this.dgv_student);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(653, 413);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 413);
            this.Name = "frm_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentai";
            this.Load += new System.EventHandler(this.frm_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_student;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.BindingSource tbllogBindingSource1;
    }
}