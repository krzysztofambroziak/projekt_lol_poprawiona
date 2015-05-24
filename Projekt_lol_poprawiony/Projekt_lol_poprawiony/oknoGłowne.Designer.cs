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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGry = new System.Windows.Forms.TabPage();
            this.tabPageStatystyki = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AVG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFiltrowanie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanelGlowny.SuspendLayout();
            this.panelDoGlownego.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGry.SuspendLayout();
            this.tabPageStatystyki.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGry
            // 
            this.flowLayoutPanelGry.AutoScroll = true;
            this.flowLayoutPanelGry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGry.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanelGry.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelGry.Name = "flowLayoutPanelGry";
            this.flowLayoutPanelGry.Size = new System.Drawing.Size(846, 445);
            this.flowLayoutPanelGry.TabIndex = 0;
            this.flowLayoutPanelGry.SizeChanged += new System.EventHandler(this.flowLayoutPanelGry_SizeChanged);
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
            this.buttonUsun.Location = new System.Drawing.Point(100, 144);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(93, 28);
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
            this.groupBoxFiltrowanie.Location = new System.Drawing.Point(4, 251);
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
            this.buttonAktualizujDane.Location = new System.Drawing.Point(4, 215);
            this.buttonAktualizujDane.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAktualizujDane.Name = "buttonAktualizujDane";
            this.buttonAktualizujDane.Size = new System.Drawing.Size(189, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 377);
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
            // tableLayoutPanelGlowny
            // 
            this.tableLayoutPanelGlowny.ColumnCount = 2;
            this.tableLayoutPanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanelGlowny.Controls.Add(this.panelDoGlownego, 1, 0);
            this.tableLayoutPanelGlowny.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanelGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGlowny.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGlowny.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelGlowny.Name = "tableLayoutPanelGlowny";
            this.tableLayoutPanelGlowny.RowCount = 1;
            this.tableLayoutPanelGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGlowny.Size = new System.Drawing.Size(1083, 490);
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
            this.panelDoGlownego.Location = new System.Drawing.Point(874, 4);
            this.panelDoGlownego.Margin = new System.Windows.Forms.Padding(4);
            this.panelDoGlownego.Name = "panelDoGlownego";
            this.panelDoGlownego.Size = new System.Drawing.Size(205, 482);
            this.panelDoGlownego.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGry);
            this.tabControl.Controls.Add(this.tabPageStatystyki);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(862, 482);
            this.tabControl.TabIndex = 2;
            this.tabControl.SizeChanged += new System.EventHandler(this.tabControl_SizeChanged);
            // 
            // tabPageGry
            // 
            this.tabPageGry.Controls.Add(this.flowLayoutPanelGry);
            this.tabPageGry.Location = new System.Drawing.Point(4, 25);
            this.tabPageGry.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGry.Name = "tabPageGry";
            this.tabPageGry.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGry.Size = new System.Drawing.Size(854, 453);
            this.tabPageGry.TabIndex = 0;
            this.tabPageGry.Text = "Gry";
            this.tabPageGry.UseVisualStyleBackColor = true;
            // 
            // tabPageStatystyki
            // 
            this.tabPageStatystyki.Controls.Add(this.listView);
            this.tabPageStatystyki.Location = new System.Drawing.Point(4, 25);
            this.tabPageStatystyki.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStatystyki.Name = "tabPageStatystyki";
            this.tabPageStatystyki.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStatystyki.Size = new System.Drawing.Size(854, 453);
            this.tabPageStatystyki.TabIndex = 1;
            this.tabPageStatystyki.Text = "Statystyki";
            this.tabPageStatystyki.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.MIN,
            this.AVG,
            this.MAX});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(4, 4);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(846, 445);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 207;
            // 
            // MIN
            // 
            this.MIN.Text = "MIN";
            this.MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MIN.Width = 112;
            // 
            // AVG
            // 
            this.AVG.Text = "AVG";
            this.AVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAX
            // 
            this.MAX.Text = "MAX";
            this.MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 453);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Statystyki graczy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(3, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 407);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa gracza";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Min";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Avg";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Max";
            this.columnHeader4.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz statystykę";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IP",
            "Poziom",
            "Gold",
            "Zabójstwa",
            "Zgony",
            "Asysty",
            "Zabite miniony",
            "Zadane obrażenia fizyczne",
            "Zadane obrażenia magiczne",
            "Zadane obrażenia nieuniknione",
            "Otrzymane obrażenia fizyczne",
            "Otrzymane obrażenia magiczne",
            "Otrzymane obrażenia nieuniknione",
            "Ilość wyleczonego zdrowia",
            "Kupione wardy",
            "Postawione wardy",
            "Zniszczone wardy"});
            this.comboBox1.Location = new System.Drawing.Point(135, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(429, 441);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 447);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(407, 440);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(416, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 447);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // oknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 490);
            this.Controls.Add(this.tableLayoutPanelGlowny);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(18, 526);
            this.Name = "oknoGlowne";
            this.Text = "Okno Glowne";
            this.groupBoxFiltrowanie.ResumeLayout(false);
            this.groupBoxFiltrowanie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanelGlowny.ResumeLayout(false);
            this.panelDoGlownego.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageGry.ResumeLayout(false);
            this.tabPageStatystyki.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGry;
        private System.Windows.Forms.TabPage tabPageStatystyki;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader MIN;
        private System.Windows.Forms.ColumnHeader AVG;
        private System.Windows.Forms.ColumnHeader MAX;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

