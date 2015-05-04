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
            this.groupBoxFiltrowanie = new System.Windows.Forms.GroupBox();
            this.comboBoxPostac = new System.Windows.Forms.ComboBox();
            this.labelPostac = new System.Windows.Forms.Label();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.labelDo = new System.Windows.Forms.Label();
            this.labelOd = new System.Windows.Forms.Label();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.buttonAktualizujDane = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonZgony = new System.Windows.Forms.RadioButton();
            this.radioButtonZabojstwa = new System.Windows.Forms.RadioButton();
            this.radioButtonDataUtworzenia = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelGlowny = new System.Windows.Forms.TableLayoutPanel();
            this.panelDoGlownego = new System.Windows.Forms.Panel();
            this.groupBoxFiltrowanie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanelGlowny.SuspendLayout();
            this.panelDoGlownego.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGry
            // 
            this.flowLayoutPanelGry.AutoScroll = true;
            this.flowLayoutPanelGry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGry.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelGry.Name = "flowLayoutPanelGry";
            this.flowLayoutPanelGry.Size = new System.Drawing.Size(646, 392);
            this.flowLayoutPanelGry.TabIndex = 0;
            this.flowLayoutPanelGry.SizeChanged += new System.EventHandler(this.flowLayoutPanelGry_SizeChanged);
            // 
            // listBoxGracze
            // 
            this.listBoxGracze.FormattingEnabled = true;
            this.listBoxGracze.Location = new System.Drawing.Point(3, 3);
            this.listBoxGracze.MultiColumn = true;
            this.listBoxGracze.Name = "listBoxGracze";
            this.listBoxGracze.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGracze.Size = new System.Drawing.Size(142, 108);
            this.listBoxGracze.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(3, 117);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(70, 23);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(75, 117);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(70, 23);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // groupBoxFiltrowanie
            // 
            this.groupBoxFiltrowanie.Controls.Add(this.comboBoxPostac);
            this.groupBoxFiltrowanie.Controls.Add(this.labelPostac);
            this.groupBoxFiltrowanie.Controls.Add(this.dateTimePickerDo);
            this.groupBoxFiltrowanie.Controls.Add(this.dateTimePickerOd);
            this.groupBoxFiltrowanie.Controls.Add(this.labelDo);
            this.groupBoxFiltrowanie.Controls.Add(this.labelOd);
            this.groupBoxFiltrowanie.Location = new System.Drawing.Point(3, 204);
            this.groupBoxFiltrowanie.Name = "groupBoxFiltrowanie";
            this.groupBoxFiltrowanie.Size = new System.Drawing.Size(142, 96);
            this.groupBoxFiltrowanie.TabIndex = 4;
            this.groupBoxFiltrowanie.TabStop = false;
            this.groupBoxFiltrowanie.Text = "Filtrowanie";
            // 
            // comboBoxPostac
            // 
            this.comboBoxPostac.FormattingEnabled = true;
            this.comboBoxPostac.Location = new System.Drawing.Point(55, 68);
            this.comboBoxPostac.Name = "comboBoxPostac";
            this.comboBoxPostac.Size = new System.Drawing.Size(81, 21);
            this.comboBoxPostac.Sorted = true;
            this.comboBoxPostac.TabIndex = 5;
            // 
            // labelPostac
            // 
            this.labelPostac.AutoSize = true;
            this.labelPostac.Location = new System.Drawing.Point(6, 71);
            this.labelPostac.Name = "labelPostac";
            this.labelPostac.Size = new System.Drawing.Size(43, 13);
            this.labelPostac.TabIndex = 4;
            this.labelPostac.Text = "Postac:";
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDo.Location = new System.Drawing.Point(36, 41);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDo.TabIndex = 3;
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOd.Location = new System.Drawing.Point(36, 15);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerOd.TabIndex = 2;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(6, 47);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(24, 13);
            this.labelDo.TabIndex = 1;
            this.labelDo.Text = "Do:";
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(6, 21);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(24, 13);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Od:";
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.Location = new System.Drawing.Point(3, 146);
            this.buttonWyswietl.Name = "buttonWyswietl";
            this.buttonWyswietl.Size = new System.Drawing.Size(142, 23);
            this.buttonWyswietl.TabIndex = 6;
            this.buttonWyswietl.Text = "Wyswietl";
            this.buttonWyswietl.UseVisualStyleBackColor = true;
            this.buttonWyswietl.Click += new System.EventHandler(this.buttonWyswietl_Click);
            // 
            // buttonAktualizujDane
            // 
            this.buttonAktualizujDane.Location = new System.Drawing.Point(3, 175);
            this.buttonAktualizujDane.Name = "buttonAktualizujDane";
            this.buttonAktualizujDane.Size = new System.Drawing.Size(142, 23);
            this.buttonAktualizujDane.TabIndex = 7;
            this.buttonAktualizujDane.Text = "Aktualizuj dane";
            this.buttonAktualizujDane.UseVisualStyleBackColor = true;
            this.buttonAktualizujDane.Click += new System.EventHandler(this.buttonAktualizujDane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonZgony);
            this.groupBox1.Controls.Add(this.radioButtonZabojstwa);
            this.groupBox1.Controls.Add(this.radioButtonDataUtworzenia);
            this.groupBox1.Location = new System.Drawing.Point(3, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortowanie";
            // 
            // radioButtonZgony
            // 
            this.radioButtonZgony.AutoSize = true;
            this.radioButtonZgony.Location = new System.Drawing.Point(9, 65);
            this.radioButtonZgony.Name = "radioButtonZgony";
            this.radioButtonZgony.Size = new System.Drawing.Size(55, 17);
            this.radioButtonZgony.TabIndex = 3;
            this.radioButtonZgony.TabStop = true;
            this.radioButtonZgony.Text = "Zgony";
            this.radioButtonZgony.UseVisualStyleBackColor = true;
            // 
            // radioButtonZabojstwa
            // 
            this.radioButtonZabojstwa.AutoSize = true;
            this.radioButtonZabojstwa.Location = new System.Drawing.Point(9, 42);
            this.radioButtonZabojstwa.Name = "radioButtonZabojstwa";
            this.radioButtonZabojstwa.Size = new System.Drawing.Size(74, 17);
            this.radioButtonZabojstwa.TabIndex = 2;
            this.radioButtonZabojstwa.TabStop = true;
            this.radioButtonZabojstwa.Text = "Zabojstwa";
            this.radioButtonZabojstwa.UseVisualStyleBackColor = true;
            // 
            // radioButtonDataUtworzenia
            // 
            this.radioButtonDataUtworzenia.AutoSize = true;
            this.radioButtonDataUtworzenia.Checked = true;
            this.radioButtonDataUtworzenia.Location = new System.Drawing.Point(9, 19);
            this.radioButtonDataUtworzenia.Name = "radioButtonDataUtworzenia";
            this.radioButtonDataUtworzenia.Size = new System.Drawing.Size(102, 17);
            this.radioButtonDataUtworzenia.TabIndex = 1;
            this.radioButtonDataUtworzenia.TabStop = true;
            this.radioButtonDataUtworzenia.Text = "Data utworzenia";
            this.radioButtonDataUtworzenia.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelGlowny
            // 
            this.tableLayoutPanelGlowny.ColumnCount = 2;
            this.tableLayoutPanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelGlowny.Controls.Add(this.flowLayoutPanelGry, 0, 0);
            this.tableLayoutPanelGlowny.Controls.Add(this.panelDoGlownego, 1, 0);
            this.tableLayoutPanelGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGlowny.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGlowny.Name = "tableLayoutPanelGlowny";
            this.tableLayoutPanelGlowny.RowCount = 1;
            this.tableLayoutPanelGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGlowny.Size = new System.Drawing.Size(812, 398);
            this.tableLayoutPanelGlowny.TabIndex = 9;
            // 
            // panelDoGlownego
            // 
            this.panelDoGlownego.Controls.Add(this.listBoxGracze);
            this.panelDoGlownego.Controls.Add(this.groupBox1);
            this.panelDoGlownego.Controls.Add(this.buttonDodaj);
            this.panelDoGlownego.Controls.Add(this.buttonAktualizujDane);
            this.panelDoGlownego.Controls.Add(this.buttonUsun);
            this.panelDoGlownego.Controls.Add(this.buttonWyswietl);
            this.panelDoGlownego.Controls.Add(this.groupBoxFiltrowanie);
            this.panelDoGlownego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoGlownego.Location = new System.Drawing.Point(655, 3);
            this.panelDoGlownego.Name = "panelDoGlownego";
            this.panelDoGlownego.Size = new System.Drawing.Size(154, 392);
            this.panelDoGlownego.TabIndex = 1;
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 398);
            this.Controls.Add(this.tableLayoutPanelGlowny);
            this.MinimumSize = new System.Drawing.Size(0, 436);
            this.Name = "oknoGlowne";
            this.Text = "Okno Glowne";
            this.groupBoxFiltrowanie.ResumeLayout(false);
            this.groupBoxFiltrowanie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanelGlowny.ResumeLayout(false);
            this.panelDoGlownego.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGry;
        private System.Windows.Forms.ListBox listBoxGracze;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.GroupBox groupBoxFiltrowanie;
        private System.Windows.Forms.Button buttonWyswietl;
        private System.Windows.Forms.Button buttonAktualizujDane;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.ComboBox comboBoxPostac;
        private System.Windows.Forms.Label labelPostac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonZgony;
        private System.Windows.Forms.RadioButton radioButtonZabojstwa;
        private System.Windows.Forms.RadioButton radioButtonDataUtworzenia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGlowny;
        private System.Windows.Forms.Panel panelDoGlownego;
    }
}

