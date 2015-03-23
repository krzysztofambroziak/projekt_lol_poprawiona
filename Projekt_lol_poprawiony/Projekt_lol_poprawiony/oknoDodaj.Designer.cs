namespace Projekt_lol_poprawiony
{
    partial class oknoDodaj
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
            this.textBoxNazwaGracza = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.comboBoxRegiony = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNazwaGracza
            // 
            this.textBoxNazwaGracza.Location = new System.Drawing.Point(12, 12);
            this.textBoxNazwaGracza.Name = "textBoxNazwaGracza";
            this.textBoxNazwaGracza.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwaGracza.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 38);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // comboBoxRegiony
            // 
            this.comboBoxRegiony.FormattingEnabled = true;
            this.comboBoxRegiony.Location = new System.Drawing.Point(118, 12);
            this.comboBoxRegiony.Name = "comboBoxRegiony";
            this.comboBoxRegiony.Size = new System.Drawing.Size(72, 21);
            this.comboBoxRegiony.TabIndex = 2;
            // 
            // oknoDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 73);
            this.Controls.Add(this.comboBoxRegiony);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxNazwaGracza);
            this.Name = "oknoDodaj";
            this.Text = "Dodaj Gracza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazwaGracza;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ComboBox comboBoxRegiony;
    }
}