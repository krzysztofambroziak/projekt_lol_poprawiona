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
    public partial class oknoDodaj : Form
    {
        public oknoDodaj()
        {
            InitializeComponent();
            wczytajRegiony();
        }

        void wczytajRegiony()
        {
            comboBoxRegiony.Items.AddRange(Baza.Polaczenie.Regions.ToArray());
            comboBoxRegiony.DisplayMember = "nazwa";
            comboBoxRegiony.SelectedIndex = 0;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string urlgracz = "https://"+comboBoxRegiony.Text+".api.pvp.net/api/lol/" + comboBoxRegiony.Text + "/v1.4/summoner/by-name/" + textBoxNazwaGracza.Text + "?api_key=f4d10937-bd33-42ac-80ef-62290e4755bf";

            string graczWeb = KlientWeb.Polaczenie.DownloadString(urlgracz);
            Dictionary<string, GraczJson> graczJson = JsonConvert.DeserializeObject<Dictionary<string, GraczJson>>(graczWeb);

            if(Baza.Polaczenie.Graczs.Count(g=>g.name==graczJson.ElementAt(0).Value.name)==0)
            {
                Gracz gracz= new Gracz()
                {
                    id=graczJson.ElementAt(0).Value.id,
                    name=graczJson.ElementAt(0).Value.name,
                    idIkony=graczJson.ElementAt(0).Value.profileIconId,
                    revisionDate=graczJson.ElementAt(0).Value.revisionDate,
                    summonerLevel=graczJson.ElementAt(0).Value.summonerLevel,
                    idRegionu=(comboBoxRegiony.SelectedItem as Region).id,
                    urlInformacje=urlgracz,
                    urlGry="https://"+comboBoxRegiony.Text +".api.pvp.net/api/lol/"+comboBoxRegiony.Text+"/v1.3/game/by-summoner/"+graczJson.ElementAt(0).Value.id+"/recent?api_key=f4d10937-bd33-42ac-80ef-62290e4755bf",
                };

                if(Baza.Polaczenie.IkonaGraczas.Count(i=>i.profileIconId==graczJson.ElementAt(0).Value.profileIconId)==0)
                {
                    IkonaGracza ikonaGracza = new IkonaGracza()
                    {
                        profileIconId = graczJson.ElementAt(0).Value.profileIconId,
                        ikona = @"C:\Users\Bartek\Desktop\projekt_lol_poprawiona\IkonyGraczy\" + graczJson.ElementAt(0).Value.profileIconId + ".png",
                    };

                    KlientWeb.Polaczenie.DownloadFile("http://ddragon.leagueoflegends.com/cdn/5.2.1/img/profileicon/" + graczJson.ElementAt(0).Value.profileIconId + ".png", ikonaGracza.ikona);

                    Baza.Polaczenie.IkonaGraczas.InsertOnSubmit(ikonaGracza);
                }

                Baza.Polaczenie.Graczs.InsertOnSubmit(gracz);
                Baza.Polaczenie.SubmitChanges();
                Close();
            }
            else
            {
                textBoxNazwaGracza.Text = "Podany gracz juz istnieje";
            }
        }
    }
}
