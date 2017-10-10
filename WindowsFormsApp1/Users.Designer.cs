﻿namespace WindowsFormsApp1
{
    partial class Users
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
            this.label1 = new System.Windows.Forms.Label();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseVolleyBallDataSet1 = new WindowsFormsApp1.DatabaseVolleyBallDataSet1();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseVolleyBallDataSet = new WindowsFormsApp1.DatabaseVolleyBallDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userTableAdapter = new WindowsFormsApp1.DatabaseVolleyBallDataSetTableAdapters.UserTableAdapter();
            this.roleTableAdapter = new WindowsFormsApp1.DatabaseVolleyBallDataSet1TableAdapters.RoleTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DatabaseVolleyBallDataSet1TableAdapters.TableAdapterManager();
            this.countryTableAdapter = new WindowsFormsApp1.DatabaseVolleyBallDataSet1TableAdapters.CountryTableAdapter();
            this.roleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKUserRoleId3E52440BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new WindowsFormsApp1.DatabaseVolleyBallDataSet1TableAdapters.UserTableAdapter();
            this.fKUserRoleId3E52440BBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKUserRoleId3E52440BBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseVolleyBallDataSet2 = new WindowsFormsApp1.DatabaseVolleyBallDataSet2();
            this.roleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter1 = new WindowsFormsApp1.DatabaseVolleyBallDataSet2TableAdapters.RoleTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(254, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "Пользователи";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.databaseVolleyBallDataSet1;
            // 
            // databaseVolleyBallDataSet1
            // 
            this.databaseVolleyBallDataSet1.DataSetName = "DatabaseVolleyBallDataSet1";
            this.databaseVolleyBallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.databaseVolleyBallDataSet;
            // 
            // databaseVolleyBallDataSet
            // 
            this.databaseVolleyBallDataSet.DataSetName = "DatabaseVolleyBallDataSet";
            this.databaseVolleyBallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Роль";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.countryBindingSource;
            this.comboBox2.DisplayMember = "CountryName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(219, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 21);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "CountryName";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.databaseVolleyBallDataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(138, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Страна";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharityTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.EventTypeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.MarathonTableAdapter = null;
            this.tableAdapterManager.RegistrationEventTableAdapter = null;
            this.tableAdapterManager.RegistrationSportsmenTableAdapter = null;
            this.tableAdapterManager.RegistrationStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = this.roleTableAdapter;
            this.tableAdapterManager.RunnerTableAdapter = null;
            this.tableAdapterManager.SasTableAdapter = null;
            this.tableAdapterManager.SponsorshipTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TicketsSalesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DatabaseVolleyBallDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VolunteerTableAdapter = null;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // roleBindingSource1
            // 
            this.roleBindingSource1.DataMember = "Role";
            this.roleBindingSource1.DataSource = this.databaseVolleyBallDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 185);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.roleBindingSource3;
            this.comboBox1.DisplayMember = "RoleName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.ValueMember = "RoleName";
            // 
            // roleBindingSource2
            // 
            this.roleBindingSource2.DataMember = "Role";
            this.roleBindingSource2.DataSource = this.databaseVolleyBallDataSet1;
            // 
            // fKUserRoleId3E52440BBindingSource
            // 
            this.fKUserRoleId3E52440BBindingSource.DataMember = "FK__User__RoleId__3E52440B";
            this.fKUserRoleId3E52440BBindingSource.DataSource = this.roleBindingSource2;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // fKUserRoleId3E52440BBindingSource1
            // 
            this.fKUserRoleId3E52440BBindingSource1.DataMember = "FK__User__RoleId__3E52440B";
            this.fKUserRoleId3E52440BBindingSource1.DataSource = this.roleBindingSource2;
            // 
            // fKUserRoleId3E52440BBindingSource2
            // 
            this.fKUserRoleId3E52440BBindingSource2.DataMember = "FK__User__RoleId__3E52440B";
            this.fKUserRoleId3E52440BBindingSource2.DataSource = this.roleBindingSource;
            // 
            // databaseVolleyBallDataSet2
            // 
            this.databaseVolleyBallDataSet2.DataSetName = "DatabaseVolleyBallDataSet2";
            this.databaseVolleyBallDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleBindingSource3
            // 
            this.roleBindingSource3.DataMember = "Role";
            this.roleBindingSource3.DataSource = this.databaseVolleyBallDataSet2;
            // 
            // roleTableAdapter1
            // 
            this.roleTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 72;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 73;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball championship 2018";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserRoleId3E52440BBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private DatabaseVolleyBallDataSet databaseVolleyBallDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DatabaseVolleyBallDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private DatabaseVolleyBallDataSet1 databaseVolleyBallDataSet1;
        private DatabaseVolleyBallDataSet1TableAdapters.RoleTableAdapter roleTableAdapter;
        private DatabaseVolleyBallDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private DatabaseVolleyBallDataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource roleBindingSource2;
        private System.Windows.Forms.BindingSource fKUserRoleId3E52440BBindingSource;
        private DatabaseVolleyBallDataSet1TableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.BindingSource fKUserRoleId3E52440BBindingSource2;
        private System.Windows.Forms.BindingSource fKUserRoleId3E52440BBindingSource1;
        private DatabaseVolleyBallDataSet2 databaseVolleyBallDataSet2;
        private System.Windows.Forms.BindingSource roleBindingSource3;
        private DatabaseVolleyBallDataSet2TableAdapters.RoleTableAdapter roleTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}