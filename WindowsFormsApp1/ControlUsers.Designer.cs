namespace WindowsFormsApp1
{
    partial class ControlUsers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.РольПользователя = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФИО = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Почта = new System.Windows.Forms.TextBox();
            this.Фотография = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ФотоПуть = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Ок = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Страна = new System.Windows.Forms.ComboBox();
            this.databaseVolleyBallDataSet = new WindowsFormsApp1.DatabaseVolleyBallDataSet();
            this.databaseVolleyBallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1.DatabaseVolleyBallDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Фотография)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 43;
            this.label1.Text = "Управление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 44;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Роль пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "ФИО";
            // 
            // РольПользователя
            // 
            this.РольПользователя.DataSource = this.roleBindingSource;
            this.РольПользователя.DisplayMember = "RoleName";
            this.РольПользователя.FormattingEnabled = true;
            this.РольПользователя.Location = new System.Drawing.Point(194, 114);
            this.РольПользователя.Name = "РольПользователя";
            this.РольПользователя.Size = new System.Drawing.Size(252, 21);
            this.РольПользователя.TabIndex = 72;
            this.РольПользователя.ValueMember = "RoleName";
            // 
            // ФИО
            // 
            this.ФИО.Location = new System.Drawing.Point(194, 150);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(252, 20);
            this.ФИО.TabIndex = 73;
            // 
            // Пароль
            // 
            this.Пароль.Location = new System.Drawing.Point(194, 218);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(252, 20);
            this.Пароль.TabIndex = 75;
            // 
            // Почта
            // 
            this.Почта.Location = new System.Drawing.Point(194, 253);
            this.Почта.Name = "Почта";
            this.Почта.Size = new System.Drawing.Size(252, 20);
            this.Почта.TabIndex = 76;
            // 
            // Фотография
            // 
            this.Фотография.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Фотография.Location = new System.Drawing.Point(486, 63);
            this.Фотография.Name = "Фотография";
            this.Фотография.Size = new System.Drawing.Size(189, 175);
            this.Фотография.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Фотография.TabIndex = 77;
            this.Фотография.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 21);
            this.button2.TabIndex = 80;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ФотоПуть
            // 
            this.ФотоПуть.Location = new System.Drawing.Point(488, 265);
            this.ФотоПуть.Name = "ФотоПуть";
            this.ФотоПуть.Size = new System.Drawing.Size(152, 20);
            this.ФотоПуть.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(517, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 78;
            this.label11.Text = "Выбрать фото";
            // 
            // Ок
            // 
            this.Ок.Location = new System.Drawing.Point(194, 311);
            this.Ок.Name = "Ок";
            this.Ок.Size = new System.Drawing.Size(252, 29);
            this.Ок.TabIndex = 83;
            this.Ок.Text = "+ Добавить пользователя";
            this.Ок.UseVisualStyleBackColor = true;
            this.Ок.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(510, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 29);
            this.button6.TabIndex = 84;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Страна
            // 
            this.Страна.FormattingEnabled = true;
            this.Страна.Location = new System.Drawing.Point(194, 185);
            this.Страна.Name = "Страна";
            this.Страна.Size = new System.Drawing.Size(252, 21);
            this.Страна.TabIndex = 85;
            // 
            // databaseVolleyBallDataSet
            // 
            this.databaseVolleyBallDataSet.DataSetName = "DatabaseVolleyBallDataSet";
            this.databaseVolleyBallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseVolleyBallDataSetBindingSource
            // 
            this.databaseVolleyBallDataSetBindingSource.DataSource = this.databaseVolleyBallDataSet;
            this.databaseVolleyBallDataSetBindingSource.Position = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.databaseVolleyBallDataSetBindingSource;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // ControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 382);
            this.Controls.Add(this.Страна);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Ок);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ФотоПуть);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Фотография);
            this.Controls.Add(this.Почта);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.РольПользователя);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ControlUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball championship 2018";
            this.Load += new System.EventHandler(this.ControlUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Фотография)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVolleyBallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox РольПользователя;
        private System.Windows.Forms.TextBox ФИО;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.TextBox Почта;
        private System.Windows.Forms.PictureBox Фотография;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ФотоПуть;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Ок;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox Страна;
        private System.Windows.Forms.BindingSource databaseVolleyBallDataSetBindingSource;
        private DatabaseVolleyBallDataSet databaseVolleyBallDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DatabaseVolleyBallDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}