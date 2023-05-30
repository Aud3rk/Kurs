namespace Kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FilmsList = new System.Windows.Forms.ComboBox();
            this.outInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BoxNameFilm = new System.Windows.Forms.TextBox();
            this.BoxNameDirector = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NominationBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RunningTimeBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningTimeBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.FilmsList);
            this.panel1.Controls.Add(this.outInfo);
            this.panel1.Location = new System.Drawing.Point(29, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 423);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(17, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 16);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 5, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(383, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FilmsList
            // 
            this.FilmsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.FilmsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FilmsList.FormattingEnabled = true;
            this.FilmsList.Location = new System.Drawing.Point(17, 54);
            this.FilmsList.Name = "FilmsList";
            this.FilmsList.Size = new System.Drawing.Size(383, 28);
            this.FilmsList.TabIndex = 2;
            this.FilmsList.SelectedIndexChanged += new System.EventHandler(this.Film_SelectedIndexChanged);
            // 
            // outInfo
            // 
            this.outInfo.AutoSize = true;
            this.outInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outInfo.Location = new System.Drawing.Point(13, 85);
            this.outInfo.Name = "outInfo";
            this.outInfo.Size = new System.Drawing.Size(0, 24);
            this.outInfo.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.flowLayoutPanel2.Controls.Add(this.BoxNameFilm);
            this.flowLayoutPanel2.Controls.Add(this.BoxNameDirector);
            this.flowLayoutPanel2.Controls.Add(this.CountryBox);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.NominationBox);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.RunningTimeBox);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.DayBox);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(475, 28);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 423);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // BoxNameFilm
            // 
            this.BoxNameFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxNameFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BoxNameFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNameFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxNameFilm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BoxNameFilm.Location = new System.Drawing.Point(3, 10);
            this.BoxNameFilm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BoxNameFilm.Name = "BoxNameFilm";
            this.BoxNameFilm.Size = new System.Drawing.Size(260, 26);
            this.BoxNameFilm.TabIndex = 0;
            this.BoxNameFilm.Text = "Название фильма";
            // 
            // BoxNameDirector
            // 
            this.BoxNameDirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxNameDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BoxNameDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNameDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxNameDirector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BoxNameDirector.Location = new System.Drawing.Point(3, 56);
            this.BoxNameDirector.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BoxNameDirector.Name = "BoxNameDirector";
            this.BoxNameDirector.Size = new System.Drawing.Size(260, 26);
            this.BoxNameDirector.TabIndex = 1;
            this.BoxNameDirector.Text = "Имя режиссера";
            // 
            // CountryBox
            // 
            this.CountryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.CountryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CountryBox.Location = new System.Drawing.Point(3, 102);
            this.CountryBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(260, 26);
            this.CountryBox.TabIndex = 9;
            this.CountryBox.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номинация:";
            // 
            // NominationBox
            // 
            this.NominationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.NominationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NominationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NominationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NominationBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NominationBox.FormattingEnabled = true;
            this.NominationBox.Location = new System.Drawing.Point(3, 161);
            this.NominationBox.Name = "NominationBox";
            this.NominationBox.Size = new System.Drawing.Size(260, 28);
            this.NominationBox.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(3, 204);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 31);
            this.button5.TabIndex = 18;
            this.button5.Text = "Добавить номинацию";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Add_Nomination);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Длительность (в минутах):";
            // 
            // RunningTimeBox
            // 
            this.RunningTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.RunningTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunningTimeBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RunningTimeBox.Location = new System.Drawing.Point(3, 261);
            this.RunningTimeBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RunningTimeBox.Name = "RunningTimeBox";
            this.RunningTimeBox.Size = new System.Drawing.Size(260, 26);
            this.RunningTimeBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "День показа:";
            // 
            // DayBox
            // 
            this.DayBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayBox.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.DayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayBox.Location = new System.Drawing.Point(3, 313);
            this.DayBox.MaxDate = new System.DateTime(2023, 5, 31, 0, 0, 0, 0);
            this.DayBox.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(260, 26);
            this.DayBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addObject_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(29, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 77);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(172, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 51);
            this.button4.TabIndex = 1;
            this.button4.Text = "Открыть расписание из файла";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(17, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "Запись в файл";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.WriteToFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FestivalOfFilms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningTimeBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outInfo;
        private System.Windows.Forms.TextBox BoxNameFilm;
        private System.Windows.Forms.TextBox BoxNameDirector;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FilmsList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox NominationBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RunningTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DayBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
    }
}

