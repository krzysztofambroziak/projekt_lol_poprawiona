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
            List<int> listaZadane = new List<int>();
            List<int> listaOtrzymane = new List<int>();
            this.Click += userControlGra_Click;
            Image spell1 = Image.FromFile(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Projekt_LOL\\ikonki\\" + gra.spell1 + ".png");
            Image spell2 = Image.FromFile(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Projekt_LOL\\ikonki\\" + gra.spell2 + ".png");
            Size panelSize = new Size(500, 500);
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
            labelCalkowityCzasZadanychCC.Text = labelCalkowityCzasZadanychCC.Text + gra.totalTimeCrowdControlDealt.ToString();

            chartOtrzymane.Series.Add("Otrzymane obrażenia");
            chartOgolneObrazenia.Series.Add("Zadane obrażenia");
            chartOtrzymane.Series["Otrzymane obrażenia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            chartOgolneObrazenia.Series["Zadane obrażenia"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            chartOgolneObrazenia.Visible = true;
            chartOgolneObrazenia.BackColor = this.BackColor;
            chartOgolneObrazenia.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartOtrzymane.Visible = true;
            chartOtrzymane.BackColor = this.BackColor;
            chartOtrzymane.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            listaZadane.Add(gra.totalDamageDealtToChampions);
            listaOtrzymane.Add(gra.physicalDamageTaken);
            listaOtrzymane.Add(gra.magicDamageTaken);
            listaOtrzymane.Add(gra.trueDamageTaken);
            listaZadane.Add(gra.totalDamageDealt);
            listaZadane.Add(gra.physicalDamageDealtPlayer);
            listaZadane.Add(gra.magicDamageDealtPlayer);
            listaZadane.Add(gra.trueDamageDealtPlayer);
            chartOtrzymane.Series["Otrzymane obrażenia"].Points.AddXY(1, gra.totalDamageDealtToChampions);
            chartOtrzymane.Series["Otrzymane obrażenia"].Points.AddXY(2, gra.physicalDamageTaken);
            chartOtrzymane.Series["Otrzymane obrażenia"].Points.AddXY(3, gra.magicDamageTaken);
            chartOtrzymane.Series["Otrzymane obrażenia"].Points.AddXY(4, gra.trueDamageTaken);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(6, gra.totalDamageDealt);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(7, gra.physicalDamageDealtPlayer);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(8, gra.magicDamageDealtPlayer);
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points.AddXY(9, gra.trueDamageDealtPlayer);
            chartOgolneObrazenia.Legends["Legend1"].Position.Auto = false;
            chartOtrzymane.Legends["Legend1"].Position.Auto = false;
            chartOtrzymane.Series["Otrzymane obrażenia"].Points[0].AxisLabel = "Otrzymane obrażenia";
            chartOtrzymane.Series["Otrzymane obrażenia"].Points[1].AxisLabel = "Otrzymane obrażenia fizyczne";
            chartOtrzymane.Series["Otrzymane obrażenia"].Points[2].AxisLabel = "Otrzymane obrażenia magiczne";
            chartOtrzymane.Series["Otrzymane obrażenia"].Points[3].AxisLabel = "Otrzymane obrażenia nieuchronne";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[0].AxisLabel = "Zadane obrażenia";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[1].AxisLabel = "Zadane obrażenia fizycznie";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[2].AxisLabel = "Zadane obrażenia magiczne";
            chartOgolneObrazenia.Series["Zadane obrażenia"].Points[3].AxisLabel = "Zadane obrażenia nieuchronne";
            int maxZadane = listaZadane.Max();
            int maxOtrzymane = listaOtrzymane.Max();
            chartOgolneObrazenia.ChartAreas[0].AxisY.Minimum = 0;
            chartOgolneObrazenia.ChartAreas[0].AxisY.Maximum = maxZadane;
            chartOtrzymane.ChartAreas[0].AxisY.Minimum = 0;
            chartOtrzymane.ChartAreas[0].AxisY.Maximum = maxOtrzymane;
            if (maxZadane < 50000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 10000;
            }
            else if (maxZadane < 100000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 25000;
            }
            else if (maxZadane > 100000 && maxZadane < 180000)
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 50000;
            }
            else
            {
                chartOgolneObrazenia.ChartAreas[0].AxisY.Interval = 100000;
            }
            if (maxOtrzymane < 50000)
            {
                chartOtrzymane.ChartAreas[0].AxisY.Interval = 10000;
            }
            else if (maxOtrzymane < 100000)
            {
                chartOtrzymane.ChartAreas[0].AxisY.Interval = 25000;
            }
            else if (maxOtrzymane > 100000 && maxOtrzymane < 180000)
            {
                chartOtrzymane.ChartAreas[0].AxisY.Interval = 50000;
            }
            else
            {
                chartOtrzymane.ChartAreas[0].AxisY.Interval = 100000;
            }
            panel1.Click += userControlGra_Click;
            panelLabele.Click += userControlGra_Click;
            picturePostac.Click += userControlGra_Click;
            pictureBoxSpell2.Click += userControlGra_Click;
            pictureBoxSpell1.Click += userControlGra_Click;
            pictureBoxItem6.Click += userControlGra_Click;
            pictureBoxItem5.Click += userControlGra_Click;
            pictureBoxItem4.Click += userControlGra_Click;
            pictureBoxItem3.Click += userControlGra_Click;
            pictureBoxItem2.Click += userControlGra_Click;
            pictureBoxItem1.Click += userControlGra_Click;
            pictureBoxItem0.Click += userControlGra_Click;
            chartOgolneObrazenia.Click += userControlGra_Click;
            chartOtrzymane.Click += userControlGra_Click;
            flowLayoutPanel1.Click += userControlGra_Click;
        }
        void userControlGra_Click(object sender, EventArgs e)
        {
            userControlGra uc = this;

            if (uc.Height == 159)
            {
                uc.Height = 335;
            }
            else
            {
                uc.Height = 159;
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
      
      
    }
}
