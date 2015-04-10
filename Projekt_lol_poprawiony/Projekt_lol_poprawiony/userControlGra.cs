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
        private userControlGra uc;
        public userControlGra()
        {
            InitializeComponent();

        }

        public userControlGra(Gry gra)
        {
            this.gra = gra;
            InitializeComponent();
            groupBoxNazwaGracza.Click += groupBoxNazwaGracza_Click;
            Image spell1 = Image.FromFile(@"C:\Users\Bartek\Desktop\projekt_lol_poprawiona\ikonki\"+gra.spell1 + ".png");
            Image spell2 = Image.FromFile(@"C:\Users\Bartek\Desktop\projekt_lol_poprawiona\ikonki\" + gra.spell2 + ".png");

            groupBoxNazwaGracza.Text = this.gra.Gracz.name;
            picturePostac.ImageLocation = this.gra.Postac.ikona;
            pictureBoxItem0.ImageLocation = this.gra.IkonaPrzedmiotu.ikona;
            pictureBoxItem1.ImageLocation = this.gra.IkonaPrzedmiotu1.ikona;
            pictureBoxItem2.ImageLocation = this.gra.IkonaPrzedmiotu2.ikona;
            pictureBoxItem3.ImageLocation = this.gra.IkonaPrzedmiotu3.ikona;
            pictureBoxItem4.ImageLocation = this.gra.IkonaPrzedmiotu4.ikona;
            pictureBoxItem5.ImageLocation = this.gra.IkonaPrzedmiotu5.ikona;
            pictureBoxItem6.ImageLocation = this.gra.IkonaPrzedmiotu6.ikona;
            pictureBoxSpell1.Image = spell1;
            pictureBoxSpell2.Image = spell2;
            if(gra.win)
            {
                groupBoxNazwaGracza.BackColor = Color.ForestGreen;
            }
            else
            {
                groupBoxNazwaGracza.BackColor=Color.Red;
            }
            labelLevel.Text = labelLevel.Text + gra.level;
            labelKillsWartosc.Text = gra.championsKilled.ToString();
            labelDeathsWartosc.Text = gra.numDeaths.ToString();
            labelAssistsWartosc.Text = gra.assists.ToString();
            float KDA = (float)(gra.championsKilled + gra.assists) / gra.numDeaths;
            labelKDA.Text =labelKDA.Text+ String.Format("{0:N2}",KDA);
            labelMiniony.Text =labelMiniony.Text + gra.minionsKilled.ToString();
            labelZdobyteIPWartosc.Text = labelZdobyteIPWartosc.Text + gra.ipEarned.ToString();
            labelZdobyteZlotoWartosc.Text = labelZdobyteZlotoWartosc.Text + gra.goldEarned.ToString();
            labelDataGryWartosc.Text = labelDataGryWartosc.Text + gra.createDate.ToString();
            labelZadaneCalkowiteObrazeniaWartosc.Text = labelZadaneCalkowiteObrazeniaWartosc.Text + gra.totalDamageDealt.ToString();
            labelOtrzymaneCalkowiteObrazeniaWartosc.Text = labelOtrzymaneCalkowiteObrazeniaWartosc.Text + gra.totalDamageTaken.ToString();
            if(gra.team == 100)
            {
                labelDruzynaWartosc.Text = labelDruzynaWartosc.Text + "Niebieska";
            }
            else
            {
                labelDruzynaWartosc.Text = labelDruzynaWartosc.Text + "Czerwona";
            }
            labelNajwiekszeWielobojstwoWartosc.Text = labelNajwiekszeWielobojstwoWartosc.Text + gra.largestMultiKill.ToString();
            labelZabiteNeutralneMinionyWartosc.Text = labelZabiteNeutralneMinionyWartosc.Text + gra.neutralMinionsKilled.ToString();
            labelFizyczneObrazeniaZadaneGraczomWartosc.Text = labelFizyczneObrazeniaZadaneGraczomWartosc.Text + gra.physicalDamageDealtPlayer.ToString();
            labelMagiczneObrazeniaZadaneGraczomWartosc.Text = labelMagiczneObrazeniaZadaneGraczomWartosc.Text + gra.magicDamageDealtPlayer.ToString();
            labelOtrzymaneFizyczneObrazeniaWartosc.Text = labelOtrzymaneFizyczneObrazeniaWartosc.Text + gra.physicalDamageTaken.ToString();
            labelOtrzymaneMagiczneObrazeniaWartosc.Text = labelOtrzymaneMagiczneObrazeniaWartosc.Text + gra.magicDamageTaken.ToString();
            int pom1 = gra.timePlayed;
            int pom2 = pom1 % 100;
            labelCzasGryWartosc.Text = labelCzasGryWartosc.Text + (gra.timePlayed / 100).ToString() + ":"+pom2;
            labelOgolnaIloscHPWyleczonaWartosc.Text = labelOgolnaIloscHPWyleczonaWartosc.Text + gra.totalHeal.ToString();
            labelKupionychWardowWartosc.Text = labelKupionychWardowWartosc.Text + gra.sightWardsBought.ToString();
            labelMagiczneObrazeniaZadanePotworomWartosc.Text = labelMagiczneObrazeniaZadanePotworomWartosc.Text + gra.magicDamageDealtToChampions.ToString();
            labelFizyczneObrazeniaZadanePotworomWartosc.Text = labelFizyczneObrazeniaZadanePotworomWartosc.Text + gra.physicalDamageDealtToChampions.ToString();
            labelCalkowitaIloscObrazenPotworomWartosc.Text = labelCalkowitaIloscObrazenPotworomWartosc.Text + gra.totalDamageDealtToChampions.ToString();
            labelNieuchronneObrazeniaZadaneGraczomWartosc.Text = labelNieuchronneObrazeniaZadaneGraczomWartosc.Text + gra.trueDamageDealtPlayer.ToString();
            labelNieuchronneObrazeniaZadanePotworomWartosc.Text = labelNieuchronneObrazeniaZadanePotworomWartosc.Text + gra.trueDamageDealtToChampions.ToString();
            labelOtrzymaneNieuchronneObrazeniaWartosc.Text = labelOtrzymaneNieuchronneObrazeniaWartosc.Text + gra.trueDamageTaken.ToString();
            labelZniszczoneWardyWartosc.Text = labelZniszczoneWardyWartosc.Text + gra.wardKilled.ToString();
            labelPostawioneWardyWartosc.Text = labelPostawioneWardyWartosc.Text + gra.wardPlaced.ToString();
            labelCalkowityCzasZadanychCCWartosc.Text = labelCalkowityCzasZadanychCCWartosc.Text + gra.totalTimeCrowdControlDealt.ToString();

            
        }

        void groupBoxNazwaGracza_Click(object sender, EventArgs e)
        {
            userControlGra uc = this;
            if (uc.Height == 231)
            {
                uc.Size = new System.Drawing.Size(712, 478);
            }
            else
            {
                uc.Size = new System.Drawing.Size(712, 231);
            }

        }

      
    }
}
