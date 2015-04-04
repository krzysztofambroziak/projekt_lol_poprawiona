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
        public oknoGlowne()
        {
            InitializeComponent();
            wczytajGraczy();
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
                                ikona = @"C:\Users\Bartek\Desktop\projekt_lol_poprawiona\IkonyPostaci\" + postacJson.key + ".png",
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
        }
        void dodajIkonePrzedmiotu(int item)
        {
            if (Baza.Polaczenie.IkonaPrzedmiotus.Count(i => i.itemId == item) == 0)
            {
                IkonaPrzedmiotu ikonaPrzedmiotu = new IkonaPrzedmiotu()
                    {
                        itemId = item,
                        ikona = @"C:\Users\Bartek\Desktop\projekt_lol_poprawiona\IkonyPrzedmiotow\" + item + ".png",
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
            flowLayoutPanelGry.Controls.Clear();

            int i = 0;
            foreach(Gry gra in Baza.Polaczenie.Gries.OrderByDescending(d=>d.timePlayed))
            {
                userControlGra wyswietlanaGra = new userControlGra(gra);
                wyswietlanaGra.Size = new System.Drawing.Size(712, 231);
                wyswietlanaGra.Tag = i++;
                flowLayoutPanelGry.Controls.Add(wyswietlanaGra);
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            wyswietlGry();
        }

    }
}