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
            this.labelFiltr = new System.Windows.Forms.Label();
            this.radioButtonKills = new System.Windows.Forms.RadioButton();
            this.radioButtonDeaths = new System.Windows.Forms.RadioButton();
            this.radioButtonAssists = new System.Windows.Forms.RadioButton();
            this.radioButtonZarobioneIP = new System.Windows.Forms.RadioButton();
            this.radioButtonCzasGry = new System.Windows.Forms.RadioButton();
            this.radioButtonObrazeniaZadane = new System.Windows.Forms.RadioButton();
            this.radioButtonObrazeniaOtrzymane = new System.Windows.Forms.RadioButton();
            this.groupBoxOpcjeDodatkowe.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGry
            // 
            this.flowLayoutPanelGry.AutoScroll = true;
            this.flowLayoutPanelGry.Location = new System.Drawing.Point(16, 15);
            this.flowLayoutPanelGry.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelGry.Name = "flowLayoutPanelGry";
            this.flowLayoutPanelGry.Size = new System.Drawing.Size(763, 416);
            this.flowLayoutPanelGry.TabIndex = 0;
            // 
            // listBoxGracze
            // 
            this.listBoxGracze.FormattingEnabled = true;
            this.listBoxGracze.ItemHeight = 16;
            this.listBoxGracze.Location = new System.Drawing.Point(787, 15);
            this.listBoxGracze.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGracze.MultiColumn = true;
            this.listBoxGracze.Name = "listBoxGracze";
            this.listBoxGracze.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGracze.Size = new System.Drawing.Size(188, 132);
            this.listBoxGracze.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(787, 155);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(93, 28);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(883, 155);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(93, 28);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // groupBoxOpcjeDodatkowe
            // 
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonObrazeniaOtrzymane);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonObrazeniaZadane);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonCzasGry);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonZarobioneIP);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonAssists);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonDeaths);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.radioButtonKills);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.labelFiltr);
            this.groupBoxOpcjeDodatkowe.Location = new System.Drawing.Point(787, 262);
            this.groupBoxOpcjeDodatkowe.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOpcjeDodatkowe.Name = "groupBoxOpcjeDodatkowe";
            this.groupBoxOpcjeDodatkowe.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOpcjeDodatkowe.Size = new System.Drawing.Size(253, 167);
            this.groupBoxOpcjeDodatkowe.TabIndex = 4;
            this.groupBoxOpcjeDodatkowe.TabStop = false;
            this.groupBoxOpcjeDodatkowe.Text = "Opcje Dodatkowe";
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.Location = new System.Drawing.Point(787, 191);
            this.buttonWyswietl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyswietl.Name = "buttonWyswietl";
            this.buttonWyswietl.Size = new System.Drawing.Size(189, 28);
            this.buttonWyswietl.TabIndex = 6;
            this.buttonWyswietl.Text = "Wyswietl";
            this.buttonWyswietl.UseVisualStyleBackColor = true;
            this.buttonWyswietl.Click += new System.EventHandler(this.buttonWyswietl_Click);
            // 
            // buttonAktualizujDane
            // 
            this.buttonAktualizujDane.Location = new System.Drawing.Point(787, 226);
            this.buttonAktualizujDane.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAktualizujDane.Name = "buttonAktualizujDane";
            this.buttonAktualizujDane.Size = new System.Drawing.Size(189, 28);
            this.buttonAktualizujDane.TabIndex = 7;
            this.buttonAktualizujDane.Text = "Aktualizuj dane";
            this.buttonAktualizujDane.UseVisualStyleBackColor = true;
            this.buttonAktualizujDane.Click += new System.EventHandler(this.buttonAktualizujDane_Click);
            // 
            // labelFiltr
            // 
            this.labelFiltr.AutoSize = true;
            this.labelFiltr.Location = new System.Drawing.Point(7, 25);
            this.labelFiltr.Name = "labelFiltr";
            this.labelFiltr.Size = new System.Drawing.Size(35, 17);
            this.labelFiltr.TabIndex = 1;
            this.labelFiltr.Text = "Filtr:";
            // 
            // radioButtonKills
            // 
            this.radioButtonKills.AutoSize = true;
            this.radioButtonKills.Location = new System.Drawing.Point(7, 46);
            this.radioButtonKills.Name = "radioButtonKills";
            this.radioButtonKills.Size = new System.Drawing.Size(54, 21);
            this.radioButtonKills.TabIndex = 9;
            this.radioButtonKills.TabStop = true;
            this.radioButtonKills.Text = "Kills";
            this.radioButtonKills.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeaths
            // 
            this.radioButtonDeaths.AutoSize = true;
            this.radioButtonDeaths.Location = new System.Drawing.Point(7, 73);
            this.radioButtonDeaths.Name = "radioButtonDeaths";
            this.radioButtonDeaths.Size = new System.Drawing.Size(74, 21);
            this.radioButtonDeaths.TabIndex = 10;
            this.radioButtonDeaths.TabStop = true;
            this.radioButtonDeaths.Text = "Deaths";
            this.radioButtonDeaths.UseVisualStyleBackColor = true;
            // 
            // radioButtonAssists
            // 
            this.radioButtonAssists.AutoSize = true;
            this.radioButtonAssists.Location = new System.Drawing.Point(7, 100);
            this.radioButtonAssists.Name = "radioButtonAssists";
            this.radioButtonAssists.Size = new System.Drawing.Size(73, 21);
            this.radioButtonAssists.TabIndex = 11;
            this.radioButtonAssists.TabStop = true;
            this.radioButtonAssists.Text = "Assists";
            this.radioButtonAssists.UseVisualStyleBackColor = true;
            // 
            // radioButtonZarobioneIP
            // 
            this.radioButtonZarobioneIP.AutoSize = true;
            this.radioButtonZarobioneIP.Location = new System.Drawing.Point(7, 128);
            this.radioButtonZarobioneIP.Name = "radioButtonZarobioneIP";
            this.radioButtonZarobioneIP.Size = new System.Drawing.Size(110, 21);
            this.radioButtonZarobioneIP.TabIndex = 12;
            this.radioButtonZarobioneIP.TabStop = true;
            this.radioButtonZarobioneIP.Text = "Zarobione IP";
            this.radioButtonZarobioneIP.UseVisualStyleBackColor = true;
            // 
            // radioButtonCzasGry
            // 
            this.radioButtonCzasGry.AutoSize = true;
            this.radioButtonCzasGry.Location = new System.Drawing.Point(86, 46);
            this.radioButtonCzasGry.Name = "radioButtonCzasGry";
            this.radioButtonCzasGry.Size = new System.Drawing.Size(84, 21);
            this.radioButtonCzasGry.TabIndex = 13;
            this.radioButtonCzasGry.TabStop = true;
            this.radioButtonCzasGry.Text = "Czas gry";
            this.radioButtonCzasGry.UseVisualStyleBackColor = true;
            // 
            // radioButtonObrazeniaZadane
            // 
            this.radioButtonObrazeniaZadane.AutoSize = true;
            this.radioButtonObrazeniaZadane.Location = new System.Drawing.Point(86, 74);
            this.radioButtonObrazeniaZadane.Name = "radioButtonObrazeniaZadane";
            this.radioButtonObrazeniaZadane.Size = new System.Drawing.Size(146, 21);
            this.radioButtonObrazeniaZadane.TabIndex = 14;
            this.radioButtonObrazeniaZadane.TabStop = true;
            this.radioButtonObrazeniaZadane.Text = "Obrażenia zadane";
            this.radioButtonObrazeniaZadane.UseVisualStyleBackColor = true;
            // 
            // radioButtonObrazeniaOtrzymane
            // 
            this.radioButtonObrazeniaOtrzymane.AutoSize = true;
            this.radioButtonObrazeniaOtrzymane.Location = new System.Drawing.Point(86, 101);
            this.radioButtonObrazeniaOtrzymane.Name = "radioButtonObrazeniaOtrzymane";
            this.radioButtonObrazeniaOtrzymane.Size = new System.Drawing.Size(165, 21);
            this.radioButtonObrazeniaOtrzymane.TabIndex = 15;
            this.radioButtonObrazeniaOtrzymane.TabStop = true;
            this.radioButtonObrazeniaOtrzymane.Text = "Obrażenia otrzymane";
            this.radioButtonObrazeniaOtrzymane.UseVisualStyleBackColor = true;
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 443);
            this.Controls.Add(this.buttonAktualizujDane);
            this.Controls.Add(this.buttonWyswietl);
            this.Controls.Add(this.groupBoxOpcjeDodatkowe);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxGracze);
            this.Controls.Add(this.flowLayoutPanelGry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "oknoGlowne";
            this.Text = "Form1";
            this.groupBoxOpcjeDodatkowe.ResumeLayout(false);
            this.groupBoxOpcjeDodatkowe.PerformLayout();
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
        private System.Windows.Forms.Label labelFiltr;
        private System.Windows.Forms.RadioButton radioButtonDeaths;
        private System.Windows.Forms.RadioButton radioButtonKills;
        private System.Windows.Forms.RadioButton radioButtonObrazeniaOtrzymane;
        private System.Windows.Forms.RadioButton radioButtonObrazeniaZadane;
        private System.Windows.Forms.RadioButton radioButtonCzasGry;
        private System.Windows.Forms.RadioButton radioButtonZarobioneIP;
        private System.Windows.Forms.RadioButton radioButtonAssists;
    }
}

