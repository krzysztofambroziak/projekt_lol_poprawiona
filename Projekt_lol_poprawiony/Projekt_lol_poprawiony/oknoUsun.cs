using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_lol_poprawiony
{
    public partial class oknoUsun : Form
    {
        public oknoUsun()
        {
            InitializeComponent();
            wczytajGraczy();
        }

        void wczytajGraczy()
        {
            listBoxUsunGraczy.Items.Clear();
            listBoxUsunGraczy.Items.AddRange(Baza.Polaczenie.Graczs.ToArray());
            listBoxUsunGraczy.DisplayMember = "name";
            listBoxUsunGraczy.ValueMember = "id";
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach(Gracz gracz in listBoxUsunGraczy.SelectedItems)
            {
                Baza.Polaczenie.Gries.DeleteAllOnSubmit(gracz.Gries);
                Baza.Polaczenie.Graczs.DeleteOnSubmit(gracz);
            }
            Baza.Polaczenie.SubmitChanges();
            Close();
        }
    }
}
