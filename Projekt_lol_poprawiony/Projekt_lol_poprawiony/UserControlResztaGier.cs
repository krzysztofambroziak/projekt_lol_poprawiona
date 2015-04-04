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
    public partial class UserControlResztaGier : UserControl
    {
        Gry gra;
        public UserControlResztaGier()
        {
            InitializeComponent();
        }
        public UserControlResztaGier(Gry gra)
        {
            this.gra = gra;
            InitializeComponent();

        }
    }
}
