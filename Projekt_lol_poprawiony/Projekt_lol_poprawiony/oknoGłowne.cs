using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Projekt_lol_poprawiony
{
    public partial class oknoGlowne : Form
    {
        List<Gry> listaGry;

        public oknoGlowne()
        {
            InitializeComponent();
            listaGry = new List<Gry>();

            wczytajGraczy();
            wczytajPostacie();
            ustawDaty();
            flowLayoutPanelGry_SizeChanged(null, null);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            oknoDodaj oD = new oknoDodaj();
            oD.FormClosed += okno_FormClosed;
            oD.Show();
        }

        void wczytajGraczy()
        {
            listBoxGracze.Items.Clear();
            listBoxGracze.Items.AddRange(Baza.Polaczenie.Graczs.ToArray());
            listBoxGracze.DisplayMember = "name";
            listBoxGracze.ValueMember = "id";
        }
        private void okno_FormClosed(object sender, FormClosedEventArgs e)
        {
            wczytajGraczy();
        }

        private void buttonAktualizujDane_Click(object sender, EventArgs e)
        {
            foreach (Gracz gracz in Baza.Polaczenie.Graczs)
            {
                string gryString = KlientWeb.Polaczenie.DownloadString(gracz.urlGry);
                ListaGierJson gryJson = JsonConvert.DeserializeObject<ListaGierJson>(gryString);

                foreach (GraJson gra in gryJson.games)
                {
                    if (gra.invalid == false && gra.gameMode == "CLASSIC" && gra.gameType == "MATCHED_GAME" && (gra.subType == "RANKED_SOLO_5x5" || gra.subType == "RANKED_PREMADE_5x5") && Baza.Polaczenie.Gries.Count(g => g.gameId == gra.gameId && g.summonerId == gryJson.summonerId) == 0)
                    {
                        dodajIkonePrzedmiotu(gra.stats.item0);
                        dodajIkonePrzedmiotu(gra.stats.item1);
                        dodajIkonePrzedmiotu(gra.stats.item2);
                        dodajIkonePrzedmiotu(gra.stats.item3);
                        dodajIkonePrzedmiotu(gra.stats.item4);
                        dodajIkonePrzedmiotu(gra.stats.item5);
                        dodajIkonePrzedmiotu(gra.stats.item6);

                        if (Baza.Polaczenie.Postacs.Count(p => p.championId == gra.championId) == 0)
                        {
                            string postacstring = KlientWeb.Polaczenie.DownloadString("https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion/" + gra.championId + "?api_key=f4d10937-bd33-42ac-80ef-62290e4755bf");
                            ChampionJson postacJson = JsonConvert.DeserializeObject<ChampionJson>(postacstring);

                            Postac postac = new Postac()
                            {
                                championId = postacJson.id,
                                name = postacJson.name,
                                ikona = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Projekt_LOL\\IkonyPostaci\\" + postacJson.key + ".png",
                            };

                            KlientWeb.Polaczenie.DownloadFile("http://ddragon.leagueoflegends.com/cdn/5.2.1/img/champion/" + postacJson.key + ".png", postac.ikona);
                            Baza.Polaczenie.Postacs.InsertOnSubmit(postac);
                        }

                        Gry dodawanagra = new Gry()
                        {
                            gameId = gra.gameId,
                            summonerId = gryJson.summonerId,
                            championId = gra.championId,
                            spell1 = gra.spell1,
                            spell2 = gra.spell2,
                            ipEarned = gra.ipEarned,
                            createDate = gra.createDate,
                            level = gra.stats.level,
                            goldEarned = gra.stats.goldEarned,
                            numDeaths = gra.stats.numDeaths,
                            minionsKilled = gra.stats.minionsKilled,
                            championsKilled = gra.stats.championsKilled,
                            totalDamageDealt = gra.stats.totalDamageDealt,
                            totalDamageTaken = gra.stats.totalDamageTaken,
                            team = gra.stats.team,
                            win = gra.stats.win,
                            neutralMinionsKilled = gra.stats.neutralMinionsKilled,
                            largestMultiKill = gra.stats.largestMultiKill,
                            physicalDamageDealtPlayer = gra.stats.physicalDamageDealtPlayer,
                            magicDamageDealtPlayer = gra.stats.magicDamageDealtPlayer,
                            physicalDamageTaken = gra.stats.physicalDamageTaken,
                            magicDamageTaken = gra.stats.magicDamageTaken,
                            timePlayed = gra.stats.timePlayed,
                            totalHeal = gra.stats.totalHeal,
                            assists = gra.stats.assists,
                            item0 = gra.stats.item0,
                            item1 = gra.stats.item1,
                            item2 = gra.stats.item2,
                            item3 = gra.stats.item3,
                            item4 = gra.stats.item4,
                            item5 = gra.stats.item5,
                            item6 = gra.stats.item6,
                            sightWardsBought = gra.stats.sightWardsBought,
                            magicDamageDealtToChampions = gra.stats.magicDamageDealtToChampions,
                            physicalDamageDealtToChampions = gra.stats.physicalDamageDealtToChampions,
                            totalDamageDealtToChampions = gra.stats.totalDamageDealtToChampions,
                            trueDamageDealtPlayer = gra.stats.trueDamageDealtPlayer,
                            trueDamageDealtToChampions = gra.stats.trueDamageDealtToChampions,
                            trueDamageTaken = gra.stats.trueDamageTaken,
                            wardKilled = gra.stats.wardKilled,
                            wardPlaced = gra.stats.wardPlaced,
                            totalTimeCrowdControlDealt = gra.stats.totalTimeCrowdControlDealt,
                        };

                        Baza.Polaczenie.Gries.InsertOnSubmit(dodawanagra);
                        Baza.Polaczenie.SubmitChanges();

                    }
                }
            }
            wczytajPostacie();
            ustawDaty();
        }
        void dodajIkonePrzedmiotu(int item)
        {
            if (Baza.Polaczenie.IkonaPrzedmiotus.Count(i => i.itemId == item) == 0)
            {
                IkonaPrzedmiotu ikonaPrzedmiotu = new IkonaPrzedmiotu()
                    {
                        itemId = item,
                        ikona = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Projekt_LOL\\IkonyPrzedmiotow\\" + item + ".png",
                    };

                KlientWeb.Polaczenie.DownloadFile("http://ddragon.leagueoflegends.com/cdn/5.2.1/img/item/" + item + ".png", ikonaPrzedmiotu.ikona);

                Baza.Polaczenie.IkonaPrzedmiotus.InsertOnSubmit(ikonaPrzedmiotu);
                Baza.Polaczenie.SubmitChanges();
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            oknoUsun oU = new oknoUsun();
            oU.FormClosed += okno_FormClosed;
            oU.Show();
        }

        private void wyswietlGry()
        {
            listaGry.Clear();
            listView.Items.Clear();

            flowLayoutPanelGry.Controls.Clear();
            if (radioButtonDataUtworzenia.Checked)
            {
                foreach (Gry gra in Baza.Polaczenie.Gries.OrderByDescending(d => d.createDate))
                {
                    filtrujGry(gra);
                    flowLayoutPanelGry_SizeChanged(null, null);
                }
            }
            else if(radioButtonZabojstwa.Checked)
            {
                foreach (Gry gra in Baza.Polaczenie.Gries.OrderByDescending(d => d.championsKilled))
                {
                    filtrujGry(gra);
                    flowLayoutPanelGry_SizeChanged(null, null);
                }
            }
            else if (radioButtonZgony.Checked)
            {
                foreach (Gry gra in Baza.Polaczenie.Gries.OrderByDescending(d => d.numDeaths))
                {
                    filtrujGry(gra);
                    flowLayoutPanelGry_SizeChanged(null, null);
                }
            }

            wyswietlStatystyki();

        }

        void filtrujGry(Gry gra)
        {
            if (listBoxGracze.SelectedItems.Contains(gra.Gracz) && gra.createDate >= ToUnixTime(dateTimePickerOd.Value) && gra.createDate <= ToUnixTime(dateTimePickerDo.Value))
            {
                if (gra.Postac==comboBoxPostac.SelectedItem)
                {
                    if (tabControl.SelectedIndex == 0)
                    {
                        userControlGra wyswietlanaGra = new userControlGra(gra);
                        flowLayoutPanelGry.Controls.Add(wyswietlanaGra);
                    }
                    listaGry.Add(gra);
                }
                else if(comboBoxPostac.SelectedItem=="---------")
                {
                    if (tabControl.SelectedIndex == 0)
                    {
                        userControlGra wyswietlanaGra = new userControlGra(gra);
                        flowLayoutPanelGry.Controls.Add(wyswietlanaGra);
                    }
                    listaGry.Add(gra);
                }
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            wyswietlGry();
        }

         void wczytajPostacie()
        {
            comboBoxPostac.Items.Clear();
            comboBoxPostac.Items.Add("---------");
            comboBoxPostac.SelectedItem = "---------";

             foreach(Postac p in Baza.Polaczenie.Postacs)
             {
                 comboBoxPostac.Items.Add(p);
                 comboBoxPostac.DisplayMember = "name";
             }
        }

        void ustawDaty()
         {
            dateTimePickerDo.Value = DateTime.Now;
            dateTimePickerOd.Value = FromUnixTime(Baza.Polaczenie.Gries.Min(d => d.createDate));
         }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTime);
        }

        public long ToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalMilliseconds);
        }

        private void flowLayoutPanelGry_SizeChanged(object sender, EventArgs e)
        {
            if (flowLayoutPanelGry.Controls.Count > 0)
            {
                flowLayoutPanelGry.Controls[0].Dock = DockStyle.None;
                flowLayoutPanelGry.Controls[0].Width = flowLayoutPanelGry.Width - 20 - flowLayoutPanelGry.Controls[0].Margin.Horizontal;

                for (int i = 1; i < flowLayoutPanelGry.Controls.Count; i++)
                {
                    flowLayoutPanelGry.Controls[i].Dock = DockStyle.Top;
                    flowLayoutPanelGry.Controls[i].Width = flowLayoutPanelGry.Width - 20 - flowLayoutPanelGry.Controls[i].Margin.Horizontal;
                }
            }
            tabControl_SizeChanged(null, null);
        }


        private void tabControl_SizeChanged(object sender, EventArgs e)
        {
            foreach (ColumnHeader ch in listView.Columns)
            {
                ch.Width = (int)(tabControl.Size.Width * 0.25 - 4);
            }
        }

        void wyswietlStatystyki()
        {
            if (listaGry.Count != 0)
            {
                string[] IP = { "IP", listaGry.Min(i => i.ipEarned).ToString(), Math.Round(listaGry.Average(i => i.ipEarned), 2).ToString(), listaGry.Max(i => i.ipEarned).ToString() };
                listView.Items.Add(new ListViewItem(IP));

                string[] Level = { "Poziom", listaGry.Min(i => i.level).ToString(), Math.Round(listaGry.Average(i => i.level), 2).ToString(), listaGry.Max(i => i.level).ToString() };
                listView.Items.Add(new ListViewItem(Level));

                string[] gold = { "Gold", listaGry.Min(i => i.goldEarned).ToString(), Math.Round(listaGry.Average(i => i.goldEarned), 2).ToString(), listaGry.Max(i => i.goldEarned).ToString() };
                listView.Items.Add(new ListViewItem(gold));

                string[] Zabojstwa = { "Zabojstwa", listaGry.Min(i => i.championsKilled).ToString(), Math.Round(listaGry.Average(i => i.championsKilled), 2).ToString(), listaGry.Max(i => i.championsKilled).ToString() };
                listView.Items.Add(new ListViewItem(Zabojstwa));

                string[] Zgony = { "Zgony", listaGry.Min(i => i.numDeaths).ToString(), Math.Round(listaGry.Average(i => i.numDeaths), 2).ToString(), listaGry.Max(i => i.numDeaths).ToString() };
                listView.Items.Add(new ListViewItem(Zgony));

                string[] Asysty = { "Asysty", listaGry.Min(i => i.assists).ToString(), Math.Round(listaGry.Average(i => i.assists), 2).ToString(), listaGry.Max(i => i.assists).ToString() };
                listView.Items.Add(new ListViewItem(Asysty));

                string[] ZabiteMiniony = { "Zabite miniony", listaGry.Min(i => i.minionsKilled).ToString(), Math.Round(listaGry.Average(i => i.minionsKilled), 2).ToString(), listaGry.Max(i => i.minionsKilled).ToString() };
                listView.Items.Add(new ListViewItem(ZabiteMiniony));

                string[] ZadDmg = { "Zadane obrazenia fizyczne", listaGry.Min(i => i.physicalDamageDealtToChampions).ToString(), Math.Round(listaGry.Average(i => i.physicalDamageDealtToChampions), 2).ToString(), listaGry.Max(i => i.physicalDamageDealtToChampions).ToString() };
                listView.Items.Add(new ListViewItem(ZadDmg));

                string[] ZadAp = { "Zadane obrazenia magiczne", listaGry.Min(i => i.magicDamageDealtToChampions).ToString(), Math.Round(listaGry.Average(i => i.magicDamageDealtToChampions), 2).ToString(), listaGry.Max(i => i.magicDamageDealtToChampions).ToString() };
                listView.Items.Add(new ListViewItem(ZadAp));

                string[] zN = { "Zadane obrazenia nieuniknione", listaGry.Min(i => i.trueDamageDealtToChampions).ToString(), Math.Round(listaGry.Average(i => i.trueDamageDealtToChampions), 2).ToString(), listaGry.Max(i => i.trueDamageDealtToChampions).ToString() };
                listView.Items.Add(new ListViewItem(zN));

                string[] oDmg = { "Otrzymane obrazenia fizyczne", listaGry.Min(i => i.physicalDamageTaken).ToString(), Math.Round(listaGry.Average(i => i.physicalDamageTaken), 2).ToString(), listaGry.Max(i => i.physicalDamageTaken).ToString() };
                listView.Items.Add(new ListViewItem(oDmg));

                string[] oAP = { "Otrzymane obrazenia magiczne", listaGry.Min(i => i.magicDamageTaken).ToString(), Math.Round(listaGry.Average(i => i.magicDamageTaken), 2).ToString(), listaGry.Max(i => i.magicDamageTaken).ToString() };
                listView.Items.Add(new ListViewItem(oAP));

                string[] oN = { "Otrzymane obrazenia nieuniknione", listaGry.Min(i => i.trueDamageTaken).ToString(), Math.Round(listaGry.Average(i => i.trueDamageTaken), 2).ToString(), listaGry.Max(i => i.trueDamageTaken).ToString() };
                listView.Items.Add(new ListViewItem(oN));

                string[] heal = { "Ilosc wyleczonego zdrowie", listaGry.Min(i => i.totalHeal).ToString(), Math.Round(listaGry.Average(i => i.totalHeal), 2).ToString(), listaGry.Max(i => i.totalHeal).ToString() };
                listView.Items.Add(new ListViewItem(heal));

                string[] kW = { "Kupione wardy", listaGry.Min(i => i.sightWardsBought).ToString(), Math.Round(listaGry.Average(i => i.sightWardsBought), 2).ToString(), listaGry.Max(i => i.sightWardsBought).ToString() };
                listView.Items.Add(new ListViewItem(kW));

                string[] pW = { "Postawione wardy", listaGry.Min(i => i.wardPlaced).ToString(), Math.Round(listaGry.Average(i => i.wardPlaced), 2).ToString(), listaGry.Max(i => i.wardPlaced).ToString() };
                listView.Items.Add(new ListViewItem(pW));

                string[] zW = { "Zabite wardy", listaGry.Min(i => i.wardKilled).ToString(), Math.Round(listaGry.Average(i => i.wardKilled), 2).ToString(), listaGry.Max(i => i.wardKilled).ToString() };
                listView.Items.Add(new ListViewItem(zW));
            }


        }
    }
}