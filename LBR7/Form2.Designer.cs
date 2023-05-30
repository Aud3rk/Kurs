namespace LBR7
{
    partial class Form2
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
            this.table = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayPremier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.NameDirector,
            this.Nomination,
            this.DayPremier});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(800, 450);
            this.table.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название фильма";
            this.NameColumn.Name = "NameColumn";
            // 
            // NameDirector
            // 
            this.NameDirector.HeaderText = "Имя режиссера";
            this.NameDirector.Name = "NameDirector";
            // 
            // Nomination
            // 
            this.Nomination.HeaderText = "Номинация";
            this.Nomination.Name = "Nomination";
            // 
            // DayPremier
            // 
            this.DayPremier.HeaderText = "Премьера";
            this.DayPremier.Name = "DayPremier";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Name = "Form2";
            this.Text = "FestivalOfFilms";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayPremier;
    }
}