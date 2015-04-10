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
            this.labelFiltr = new System.Windows.Forms.Label();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.buttonAktualizujDane = new System.Windows.Forms.Button();
            this.checkBoxCzasGry = new System.Windows.Forms.CheckBox();
            this.checkBoxChampion = new System.Windows.Forms.CheckBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxChampion = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
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
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.labelOd);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.textBoxDo);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.labelDo);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.textBoxChampion);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.textBoxOd);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.checkBoxChampion);
            this.groupBoxOpcjeDodatkowe.Controls.Add(this.checkBoxCzasGry);
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
            // labelFiltr
            // 
            this.labelFiltr.AutoSize = true;
            this.labelFiltr.Location = new System.Drawing.Point(7, 25);
            this.labelFiltr.Name = "labelFiltr";
            this.labelFiltr.Size = new System.Drawing.Size(35, 17);
            this.labelFiltr.TabIndex = 1;
            this.labelFiltr.Text = "Filtr:";
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
            // checkBoxCzasGry
            // 
            this.checkBoxCzasGry.AutoSize = true;
            this.checkBoxCzasGry.Location = new System.Drawing.Point(8, 46);
            this.checkBoxCzasGry.Name = "checkBoxCzasGry";
            this.checkBoxCzasGry.Size = new System.Drawing.Size(85, 21);
            this.checkBoxCzasGry.TabIndex = 2;
            this.checkBoxCzasGry.Text = "Czas gry";
            this.checkBoxCzasGry.UseVisualStyleBackColor = true;
            // 
            // checkBoxChampion
            // 
            this.checkBoxChampion.AutoSize = true;
            this.checkBoxChampion.Location = new System.Drawing.Point(8, 74);
            this.checkBoxChampion.Name = "checkBoxChampion";
            this.checkBoxChampion.Size = new System.Drawing.Size(93, 21);
            this.checkBoxChampion.TabIndex = 3;
            this.checkBoxChampion.Text = "Champion";
            this.checkBoxChampion.UseVisualStyleBackColor = true;
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(136, 46);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(36, 22);
            this.textBoxOd.TabIndex = 4;
            // 
            // textBoxChampion
            // 
            this.textBoxChampion.Location = new System.Drawing.Point(113, 75);
            this.textBoxChampion.Name = "textBoxChampion";
            this.textBoxChampion.Size = new System.Drawing.Size(100, 22);
            this.textBoxChampion.TabIndex = 5;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(178, 46);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(24, 17);
            this.labelDo.TabIndex = 6;
            this.labelDo.Text = "do";
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(208, 47);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(36, 22);
            this.textBoxDo.TabIndex = 7;
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(106, 47);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(24, 17);
            this.labelOd.TabIndex = 8;
            this.labelOd.Text = "od";
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
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxChampion;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.CheckBox checkBoxChampion;
        private System.Windows.Forms.CheckBox checkBoxCzasGry;
    }
}

