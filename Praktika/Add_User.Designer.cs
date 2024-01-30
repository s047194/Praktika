namespace Praktika
{
    partial class frm_add_user
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Praktika.AppData();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_adminuser = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllogTableAdapter = new Praktika.AppDataTableAdapters.tbllogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(127, 173);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(216, 24);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Pridėti";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(127, 220);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(216, 24);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Redaguoti";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(127, 267);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(216, 24);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Išsaugoti";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(127, 314);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(216, 24);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Ištrinti";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(127, 361);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(216, 24);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Atšaukti";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Username", true));
            this.txt_username.Location = new System.Drawing.Point(156, 23);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(187, 22);
            this.txt_username.TabIndex = 5;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            this.tbllogBindingSource.CurrentChanged += new System.EventHandler(this.tbllogBindingSource_CurrentChanged);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(156, 70);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(187, 22);
            this.txt_password.TabIndex = 6;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // cb_role
            // 
            this.cb_role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "Role", true));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Destytojas",
            "Studentas"});
            this.cb_role.Location = new System.Drawing.Point(156, 123);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(187, 24);
            this.cb_role.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vartotojo vardas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pavardė:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vaidmuo:";
            // 
            // dgv_adminuser
            // 
            this.dgv_adminuser.AutoGenerateColumns = false;
            this.dgv_adminuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adminuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgv_adminuser.DataSource = this.tbllogBindingSource;
            this.dgv_adminuser.Location = new System.Drawing.Point(389, 23);
            this.dgv_adminuser.Name = "dgv_adminuser";
            this.dgv_adminuser.ReadOnly = true;
            this.dgv_adminuser.RowHeadersWidth = 51;
            this.dgv_adminuser.RowTemplate.Height = 24;
            this.dgv_adminuser.Size = new System.Drawing.Size(399, 361);
            this.dgv_adminuser.TabIndex = 11;
            this.dgv_adminuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adminuser_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 116;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 115;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Vaidmuo";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 115;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // frm_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.dgv_adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 444);
            this.Name = "frm_add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frm_add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_adminuser;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}