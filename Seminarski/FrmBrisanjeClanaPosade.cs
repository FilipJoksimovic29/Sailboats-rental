using BrokerBaze;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarski
{
    public partial class FrmBrisanjeClanaPosade : Form
    {
        BindingList<ClanPosade> clanPosade;
        public FrmBrisanjeClanaPosade()
        {
           
            Communication.Instance.Connect();
           
            InitializeComponent();
            clanPosade = new BindingList<ClanPosade>(Communication.Instance.NadjiClanaPosade());
            ClanoviPosadeGrid.DataSource = clanPosade;
        }

        private void FrmBrisanjeClanaPosade_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower(); // Tekst za pretragu
            var filteredList = new BindingList<ClanPosade>(clanPosade.Where(
                x => x.Id.ToString().ToLower().Contains(searchText) || // Id kolona za pretragu
                     x.Ime.ToLower().Contains(searchText) || // Ime kolona za pretragu
                     x.Iskustvo.ToLower().Contains(searchText) // Iskustvo kolona za pretragu
                ).ToList());

            ClanoviPosadeGrid.DataSource = filteredList;
        }
    }
}
