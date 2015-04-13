using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_lol_poprawiony
{
    public partial class userControlGra : UserControl
    {
        private Gry gra;

        public userControlGra()
        {
            InitializeComponent();
        }

        public userControlGra(Gry gra)
        {
            this.gra = gra;
            InitializeComponent();

            groupBoxNazwaGracza.Text = this.gra.Gracz.name;
            picturePostac.ImageLocation = this.gra.Postac.ikona;
            pictureBoxItem0.ImageLocation = this.gra.IkonaPrzedmiotu.ikona;
            pictureBoxItem1.ImageLocation = this.gra.IkonaPrzedmiotu1.ikona;
            pictureBoxItem2.ImageLocation = this.gra.IkonaPrzedmiotu2.ikona;
            pictureBoxItem3.ImageLocation = this.gra.IkonaPrzedmiotu3.ikona;
            pictureBoxItem4.ImageLocation = this.gra.IkonaPrzedmiotu4.ikona;
            pictureBoxItem5.ImageLocation = this.gra.IkonaPrzedmiotu5.ikona;
            pictureBoxItem6.ImageLocation = this.gra.IkonaPrzedmiotu6.ikona;
            if(gra.win)
            {
                groupBoxNazwaGracza.BackColor = Color.ForestGreen;
            }
            else
            {
                groupBoxNazwaGracza.BackColor=Color.Red;
            }
            labelLevel.Text = labelLevel.Text + gra.level;
            labelKDA.Text =labelKDA.Text+ gra.championsKilled + "/" + gra.assists + "/" + gra.numDeaths;
            labelMiniony.Text =labelMiniony.Text + gra.minionsKilled.ToString();
        }
    }
}
