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
        Int32 szerokosc;
        public userControlGra()
        {
            InitializeComponent();

        }

        public userControlGra(Gry gra, int width)
        {
            this.gra = gra;
            this.Width = width;
            this.szerokosc = width;
           
            InitializeComponent();
            List<int> lista = new List<int>();
            this.Click += userControlGra_Click;
            Image spell1 = Image.FromFile(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Projekt_LOL\\ikonki\\" + gra.spell1 + ".png");
            Image spell2 = Image.FromFile(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Projekt_LOL\\ikonki\\" + gra.spell2 + ".png");

            labelNameGracza.Text = this.gra.Gracz.name;
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
            if (gra.win)
            {
                this.BackColor = Color.ForestGreen;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            labelLevel.Text = labelLevel.Text + gra.level;
            labelKillsWartosc.Text = gra.championsKilled.ToString();
            labelDeathsWartosc.Text = gra.numDeaths.ToString();
            labelAssistsWartosc.Text = gra.assists.ToString();
            float KDA = (float)(gra.championsKilled + gra.assists) / gra.numDeaths;
            labelKDA.Text = labelKDA.Text + String.Format("{0:N2}", KDA);
            labelMiniony.Text = labelMiniony.Text + gra.minionsKilled.ToString();
            labelZdobyteIPWartosc.Text = labelZdobyteIPWartosc.Text + gra.ipEarned.ToString();
            labelZdobyteZlotoWartosc.Text = labelZdobyteZlotoWartosc.Text + gra.goldEarned.ToString();
            labelDataGryWartosc.Text = labelDataGryWartosc.Text + FromUnixTime(Convert.ToInt64(gra.createDate)).ToShortDateString();
            labelGodzinaGry.Text = labelGodzinaGry.Text + "  " + FromUnixTime(Convert.ToInt64(gra.createDate)).ToShortTimeString();
            if (gra.team == 100)
            {
                labelDruzynaWartosc.Text = labelDruzynaWartosc.Text + "Niebieska";
            }
            else
            {
                labelDruzynaWartosc.Text = labelDruzynaWartosc.Text + "Czerwona";
            }
            labelNajwiekszeWielobojstwoWartosc.Text = labelNajwiekszeWielobojstwoWartosc.Text + gra.largestMultiKill.ToString();
            labelZabiteNeutralneMinionyWartosc.Text = labelZabiteNeutralneMinionyWartosc.Text + gra.neutralMinionsKilled.ToString();
            labelKupionychWardowWartosc.Text = labelKupionychWardowWartosc.Text + gra.sightWardsBought.ToString();
            labelZniszczoneWardyWartosc.Text = labelZniszczoneWardyWartosc.Text + gra.wardKilled.ToString();
            labelPostawioneWardyWartosc.Text = labelPostawioneWardyWartosc.Text + gra.wardPlaced.ToString();
            labelCalkowityCzasZadanychCCWartosc.Text = labelCalkowityCzasZadanychCCWartosc.Text + gra.totalTimeCrowdControlDealt.ToString();

            chartOgolneObrazenia.Series.Add("Otrzymane obrażenia");
            chartOgolneObrazenia.Series.Add("Zadane obrażenia");
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            chartOgolneObrazenia.Series["Zadane obrażenia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            chartOgolneObrazenia.Visible = true;
            chartOgolneObrazenia.BackColor = this.BackColor;
            chartOgolneObrazenia.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            lista.Add(gra.totalDamageDealtToChampions);
            lista.Add(gra.physicalDamageTaken);
            lista.Add(gra.magicDamageTaken);
            lista.Add(gra.trueDamageTaken);
            lista.Add(gra.totalDamageDealt);
            lista.Add(gra.physicalDamageDealtPlayer);
            lista.Add(gra.magicDamageDealtPlayer);
            lista.Add(gra.trueDamageDealtPlayer);
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points.AddXY(1, gra.totalDamageDealtToChampions);
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points.AddXY(2, gra.physicalDamageTaken);
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points.AddXY(3, gra.magicDamageTaken);
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points.AddXY(4, gra.trueDamageTaken);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(6, gra.totalDamageDealt);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(7, gra.physicalDamageDealtPlayer);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(8, gra.magicDamageDealtPlayer);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(9, gra.trueDamageDealtPlayer);
            chartOgolneObrazenia.Legends["Legend1"].Position.Auto = false;
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points[0].AxisLabel = "Otrzymane obrażenia";
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points[1].AxisLabel = "Otrzymane obrażenia fizyczne";
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points[2].AxisLabel = "Otrzymane obrażenia magiczne";
            chartOgolneObrazenia.Series["Otrzymane obrażenia"].Points[3].AxisLabel = "Otrzymane obrażenia nieuchronne";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[0].AxisLabel = "Zadane obrażenia";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[1].AxisLabel = "Zadane obrażenia fizycznie";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[2].AxisLabel = "Zadane obrażenia magiczne";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[3].AxisLabel = "Zadane obrażenia nieuchronne";
            int max = lista.Max();
            chartOgolneObrazenia.ChartAreas[0].AxisY.Minimum = 0;
            chartOgolneObrazenia.ChartAreas[0].AxisY.Maximum = max;
            if (max < 50000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 10000;
            }
            else if (max < 100000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 25000;
            }
            else if (max > 100000 && max < 180000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 50000;
            }
            else
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 100000;
            }
        }

        private void wyswietlGry()
        {
           
        }
        void userControlGra_Click(object sender, EventArgs e)
        {
            userControlGra uc = this;

            if (uc.Height == 221)
            {
                uc.Height = 450;
            }
            else
            {
                uc.Height = 221;
            }

        }
     
        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970,1,1, 0, 0, 0,  DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTime);
        }
        public long ToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalMilliseconds);
        }

        private void userControlGra_Resize(object sender, EventArgs e)
        {
            this.Width = szerokosc;
        }

        private void userControlGra_Load(object sender, EventArgs e)
        {
            this.Width = szerokosc;
            
        }
      
      
    }
}
