namespace WindowsFormsApp1
{
    partial class EditProfile
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ЗагрузкаФото = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Почта = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Телефон = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ПовторитьПароль = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ФИО = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Статус = new System.Windows.Forms.ComboBox();
            this.ДатаРождения = new System.Windows.Forms.DateTimePicker();
            this.Страна = new System.Windows.Forms.ComboBox();
            this.Фотография = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Фотография)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 29);
            this.button3.TabIndex = 61;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 60;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ЗагрузкаФото
            // 
            this.ЗагрузкаФото.Location = new System.Drawing.Point(525, 313);
            this.ЗагрузкаФото.Name = "ЗагрузкаФото";
            this.ЗагрузкаФото.Size = new System.Drawing.Size(130, 20);
            this.ЗагрузкаФото.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(522, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 56;
            this.label11.Text = "Выберите файл";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(30, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Страна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Повторите пароль";
            // 
            // Почта
            // 
            this.Почта.Enabled = false;
            this.Почта.Location = new System.Drawing.Point(188, 136);
            this.Почта.Name = "Почта";
            this.Почта.Size = new System.Drawing.Size(310, 20);
            this.Почта.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Дата рождения";
            // 
            // Телефон
            // 
            this.Телефон.Location = new System.Drawing.Point(188, 243);
            this.Телефон.Name = "Телефон";
            this.Телефон.Size = new System.Drawing.Size(310, 20);
            this.Телефон.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Пароль";
            // 
            // Пароль
            // 
            this.Пароль.Location = new System.Drawing.Point(188, 171);
            this.Пароль.Name = "Пароль";
            this.Пароль.PasswordChar = '*';
            this.Пароль.Size = new System.Drawing.Size(310, 20);
            this.Пароль.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email";
            // 
            // ПовторитьПароль
            // 
            this.ПовторитьПароль.Location = new System.Drawing.Point(188, 207);
            this.ПовторитьПароль.Name = "ПовторитьПароль";
            this.ПовторитьПароль.PasswordChar = '*';
            this.ПовторитьПароль.Size = new System.Drawing.Size(310, 20);
            this.ПовторитьПароль.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Статус";
            // 
            // ФИО
            // 
            this.ФИО.Location = new System.Drawing.Point(188, 66);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(310, 20);
            this.ФИО.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(181, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Редактировать профль";
            // 
            // Статус
            // 
            this.Статус.FormattingEnabled = true;
            this.Статус.Location = new System.Drawing.Point(188, 103);
            this.Статус.Name = "Статус";
            this.Статус.Size = new System.Drawing.Size(310, 21);
            this.Статус.TabIndex = 62;
            // 
            // ДатаРождения
            // 
            this.ДатаРождения.CustomFormat = "yyyy - MM - dd";
            this.ДатаРождения.Location = new System.Drawing.Point(188, 279);
            this.ДатаРождения.Name = "ДатаРождения";
            this.ДатаРождения.Size = new System.Drawing.Size(310, 20);
            this.ДатаРождения.TabIndex = 63;
            // 
            // Страна
            // 
            this.Страна.FormattingEnabled = true;
            this.Страна.Location = new System.Drawing.Point(188, 311);
            this.Страна.Name = "Страна";
            this.Страна.Size = new System.Drawing.Size(310, 21);
            this.Страна.TabIndex = 64;
            // 
            // Фотография
            // 
            this.Фотография.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Фотография.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Фотография.Location = new System.Drawing.Point(504, 66);
            this.Фотография.Name = "Фотография";
            this.Фотография.Size = new System.Drawing.Size(196, 175);
            this.Фотография.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Фотография.TabIndex = 65;
            this.Фотография.TabStop = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 382);
            this.Controls.Add(this.Фотография);
            this.Controls.Add(this.Страна);
            this.Controls.Add(this.ДатаРождения);
            this.Controls.Add(this.Статус);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ЗагрузкаФото);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Почта);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Телефон);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ПовторитьПароль);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball championship 2018";
            ((System.ComponentModel.ISupportInitialize)(this.Фотография)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ЗагрузкаФото;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Почта;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Телефон;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ПовторитьПароль;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ФИО;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Статус;
        private System.Windows.Forms.DateTimePicker ДатаРождения;
        private System.Windows.Forms.ComboBox Страна;
        private System.Windows.Forms.PictureBox Фотография;
    }
}