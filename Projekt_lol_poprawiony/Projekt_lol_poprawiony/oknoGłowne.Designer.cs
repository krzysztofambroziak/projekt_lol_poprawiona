namespace Projekt_lol_poprawiony
{
    partial class oknoGlowne
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
            this.flowLayoutPanelGry = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxGracze = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.groupBoxOpcjeDodatkowe = new System.Windows.Forms.GroupBox();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.buttonAktualizujDane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGry
            // 
            this.flowLayoutPanelGry.AutoScroll = true;
            this.flowLayoutPanelGry.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelGry.Name = "flowLayoutPanelGry";
            this.flowLayoutPanelGry.Size = new System.Drawing.Size(572, 338);
            this.flowLayoutPanelGry.TabIndex = 0;
            // 
            // listBoxGracze
            // 
            this.listBoxGracze.FormattingEnabled = true;
            this.listBoxGracze.Location = new System.Drawing.Point(590, 12);
            this.listBoxGracze.MultiColumn = true;
            this.listBoxGracze.Name = "listBoxGracze";
            this.listBoxGracze.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGracze.Size = new System.Drawing.Size(142, 108);
            this.listBoxGracze.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(590, 126);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(70, 23);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(662, 126);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(70, 23);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // groupBoxOpcjeDodatkowe
            // 
            this.groupBoxOpcjeDodatkowe.Location = new System.Drawing.Point(590, 213);
            this.groupBoxOpcjeDodatkowe.Name = "groupBoxOpcjeDodatkowe";
            this.groupBoxOpcjeDodatkowe.Size = new System.Drawing.Size(142, 136);
            this.groupBoxOpcjeDodatkowe.TabIndex = 4;
            this.groupBoxOpcjeDodatkowe.TabStop = false;
            this.groupBoxOpcjeDodatkowe.Text = "Opcje Dodatkowe";
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.Location = new System.Drawing.Point(590, 155);
            this.buttonWyswietl.Name = "buttonWyswietl";
            this.buttonWyswietl.Size = new System.Drawing.Size(142, 23);
            this.buttonWyswietl.TabIndex = 6;
            this.buttonWyswietl.Text = "Wyswietl";
            this.buttonWyswietl.UseVisualStyleBackColor = true;
            this.buttonWyswietl.Click += new System.EventHandler(this.buttonWyswietl_Click);
            // 
            // buttonAktualizujDane
            // 
            this.buttonAktualizujDane.Location = new System.Drawing.Point(590, 184);
            this.buttonAktualizujDane.Name = "buttonAktualizujDane";
            this.buttonAktualizujDane.Size = new System.Drawing.Size(142, 23);
            this.buttonAktualizujDane.TabIndex = 7;
            this.buttonAktualizujDane.Text = "Aktualizuj dane";
            this.buttonAktualizujDane.UseVisualStyleBackColor = true;
            this.buttonAktualizujDane.Click += new System.EventHandler(this.buttonAktualizujDane_Click);
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 360);
            this.Controls.Add(this.buttonAktualizujDane);
            this.Controls.Add(this.buttonWyswietl);
            this.Controls.Add(this.groupBoxOpcjeDodatkowe);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxGracze);
            this.Controls.Add(this.flowLayoutPanelGry);
            this.Name = "oknoGlowne";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGry;
        private System.Windows.Forms.ListBox listBoxGracze;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.GroupBox groupBoxOpcjeDodatkowe;
        private System.Windows.Forms.Button buttonWyswietl;
        private System.Windows.Forms.Button buttonAktualizujDane;
    }
}

