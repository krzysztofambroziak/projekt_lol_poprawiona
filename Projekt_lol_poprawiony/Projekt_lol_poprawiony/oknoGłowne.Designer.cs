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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxGracze = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.buttonAktualizujDane = new System.Windows.Forms.Button();
            this.groupBoxFiltrowanie = new System.Windows.Forms.GroupBox();
            this.comboBoxPostac = new System.Windows.Forms.ComboBox();
            this.labelPostac = new System.Windows.Forms.Label();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.labelDo = new System.Windows.Forms.Label();
            this.labelOd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonZgony = new System.Windows.Forms.RadioButton();
            this.radioButtonZabojstwa = new System.Windows.Forms.RadioButton();
            this.radioButtonDataUtworzenia = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelGry = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxFiltrowanie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelGry, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 528);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listBoxGracze);
            this.flowLayoutPanel1.Controls.Add(this.buttonDodaj);
            this.flowLayoutPanel1.Controls.Add(this.buttonUsun);
            this.flowLayoutPanel1.Controls.Add(this.buttonWyswietl);
            this.flowLayoutPanel1.Controls.Add(this.buttonAktualizujDane);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxFiltrowanie);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1017, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 501);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // listBoxGracze
            // 
            this.listBoxGracze.FormattingEnabled = true;
            this.listBoxGracze.ItemHeight = 16;
            this.listBoxGracze.Location = new System.Drawing.Point(4, 4);
            this.listBoxGracze.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGracze.MultiColumn = true;
            this.listBoxGracze.Name = "listBoxGracze";
            this.listBoxGracze.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGracze.Size = new System.Drawing.Size(188, 132);
            this.listBoxGracze.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(4, 144);
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
            this.buttonUsun.Location = new System.Drawing.Point(105, 144);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(93, 28);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.Location = new System.Drawing.Point(4, 180);
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
            this.buttonAktualizujDane.Location = new System.Drawing.Point(4, 216);
            this.buttonAktualizujDane.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAktualizujDane.Name = "buttonAktualizujDane";
            this.buttonAktualizujDane.Size = new System.Drawing.Size(189, 28);
            this.buttonAktualizujDane.TabIndex = 7;
            this.buttonAktualizujDane.Text = "Aktualizuj dane";
            this.buttonAktualizujDane.UseVisualStyleBackColor = true;
            this.buttonAktualizujDane.Click += new System.EventHandler(this.buttonAktualizujDane_Click);
            // 
            // groupBoxFiltrowanie
            // 
            this.groupBoxFiltrowanie.Controls.Add(this.comboBoxPostac);
            this.groupBoxFiltrowanie.Controls.Add(this.labelPostac);
            this.groupBoxFiltrowanie.Controls.Add(this.dateTimePickerDo);
            this.groupBoxFiltrowanie.Controls.Add(this.dateTimePickerOd);
            this.groupBoxFiltrowanie.Controls.Add(this.labelDo);
            this.groupBoxFiltrowanie.Controls.Add(this.labelOd);
            this.groupBoxFiltrowanie.Location = new System.Drawing.Point(4, 252);
            this.groupBoxFiltrowanie.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltrowanie.Name = "groupBoxFiltrowanie";
            this.groupBoxFiltrowanie.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltrowanie.Size = new System.Drawing.Size(189, 118);
            this.groupBoxFiltrowanie.TabIndex = 4;
            this.groupBoxFiltrowanie.TabStop = false;
            this.groupBoxFiltrowanie.Text = "Filtrowanie";
            // 
            // comboBoxPostac
            // 
            this.comboBoxPostac.FormattingEnabled = true;
            this.comboBoxPostac.Location = new System.Drawing.Point(73, 84);
            this.comboBoxPostac.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPostac.Name = "comboBoxPostac";
            this.comboBoxPostac.Size = new System.Drawing.Size(107, 24);
            this.comboBoxPostac.Sorted = true;
            this.comboBoxPostac.TabIndex = 5;
            // 
            // labelPostac
            // 
            this.labelPostac.AutoSize = true;
            this.labelPostac.Location = new System.Drawing.Point(8, 87);
            this.labelPostac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostac.Name = "labelPostac";
            this.labelPostac.Size = new System.Drawing.Size(55, 17);
            this.labelPostac.TabIndex = 4;
            this.labelPostac.Text = "Postac:";
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDo.Location = new System.Drawing.Point(48, 50);
            this.dateTimePickerDo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerDo.TabIndex = 3;
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOd.Location = new System.Drawing.Point(48, 18);
            this.dateTimePickerOd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerOd.TabIndex = 2;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(8, 58);
            this.labelDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(30, 17);
            this.labelDo.TabIndex = 1;
            this.labelDo.Text = "Do:";
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(8, 26);
            this.labelOd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(31, 17);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Od:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonZgony);
            this.groupBox1.Controls.Add(this.radioButtonZabojstwa);
            this.groupBox1.Controls.Add(this.radioButtonDataUtworzenia);
            this.groupBox1.Location = new System.Drawing.Point(4, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(189, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortowanie";
            // 
            // radioButtonZgony
            // 
            this.radioButtonZgony.AutoSize = true;
            this.radioButtonZgony.Location = new System.Drawing.Point(12, 80);
            this.radioButtonZgony.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonZgony.Name = "radioButtonZgony";
            this.radioButtonZgony.Size = new System.Drawing.Size(69, 21);
            this.radioButtonZgony.TabIndex = 3;
            this.radioButtonZgony.TabStop = true;
            this.radioButtonZgony.Text = "Zgony";
            this.radioButtonZgony.UseVisualStyleBackColor = true;
            // 
            // radioButtonZabojstwa
            // 
            this.radioButtonZabojstwa.AutoSize = true;
            this.radioButtonZabojstwa.Location = new System.Drawing.Point(12, 52);
            this.radioButtonZabojstwa.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonZabojstwa.Name = "radioButtonZabojstwa";
            this.radioButtonZabojstwa.Size = new System.Drawing.Size(93, 21);
            this.radioButtonZabojstwa.TabIndex = 2;
            this.radioButtonZabojstwa.TabStop = true;
            this.radioButtonZabojstwa.Text = "Zabojstwa";
            this.radioButtonZabojstwa.UseVisualStyleBackColor = true;
            // 
            // radioButtonDataUtworzenia
            // 
            this.radioButtonDataUtworzenia.AutoSize = true;
            this.radioButtonDataUtworzenia.Checked = true;
            this.radioButtonDataUtworzenia.Location = new System.Drawing.Point(12, 23);
            this.radioButtonDataUtworzenia.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDataUtworzenia.Name = "radioButtonDataUtworzenia";
            this.radioButtonDataUtworzenia.Size = new System.Drawing.Size(131, 21);
            this.radioButtonDataUtworzenia.TabIndex = 1;
            this.radioButtonDataUtworzenia.TabStop = true;
            this.radioButtonDataUtworzenia.Text = "Data utworzenia";
            this.radioButtonDataUtworzenia.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelGry
            // 
            this.flowLayoutPanelGry.AutoScroll = true;
            this.flowLayoutPanelGry.AutoSize = true;
            this.flowLayoutPanelGry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelGry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGry.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelGry.Name = "flowLayoutPanelGry";
            this.flowLayoutPanelGry.Size = new System.Drawing.Size(1008, 522);
            this.flowLayoutPanelGry.TabIndex = 10;
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "oknoGlowne";
            this.Text = "Okno Glowne";
            this.ResizeEnd += new System.EventHandler(this.oknoGlowne_ResizeEnd);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxFiltrowanie.ResumeLayout(false);
            this.groupBoxFiltrowanie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxGracze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonZgony;
        private System.Windows.Forms.RadioButton radioButtonZabojstwa;
        private System.Windows.Forms.RadioButton radioButtonDataUtworzenia;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.GroupBox groupBoxFiltrowanie;
        private System.Windows.Forms.ComboBox comboBoxPostac;
        private System.Windows.Forms.Label labelPostac;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.Button buttonAktualizujDane;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonWyswietl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGry;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

