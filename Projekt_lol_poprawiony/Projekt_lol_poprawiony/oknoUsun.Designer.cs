namespace Projekt_lol_poprawiony
{
    partial class oknoUsun
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUsunGraczy = new System.Windows.Forms.ListBox();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaznacz graczy ktorych chcesz usunać";
            // 
            // listBoxUsunGraczy
            // 
            this.listBoxUsunGraczy.FormattingEnabled = true;
            this.listBoxUsunGraczy.Location = new System.Drawing.Point(12, 29);
            this.listBoxUsunGraczy.Name = "listBoxUsunGraczy";
            this.listBoxUsunGraczy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxUsunGraczy.Size = new System.Drawing.Size(196, 147);
            this.listBoxUsunGraczy.TabIndex = 1;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(12, 183);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // oknoUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 215);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.listBoxUsunGraczy);
            this.Controls.Add(this.label1);
            this.Name = "oknoUsun";
            this.Text = "oknoUsun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUsunGraczy;
        private System.Windows.Forms.Button buttonUsun;
    }
}