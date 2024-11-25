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
    public partial class IzaberiKlijenta : Form
    {
        Frmmain frmmain;

        private BindingList<Klijent> klijenti; // Lista klijenata

        public IzaberiKlijenta(Frmmain frmmain)
        {this.frmmain = frmmain;
            InitializeComponent();
            klijenti = new BindingList<Klijent>(Communication.Instance.UcitajKlijente());
           
            gridklijenti.DataSource = klijenti;
           
            gridklijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridklijenti.MultiSelect = false;
        }

       

        //private void pretragakltxt_TextChanged(object sender, EventArgs e)
        //{
        //    string pretraga = txtpretragaklijenata.Text;

        //  //  klijenti.RowFilter = $"imeprezime LIKE '%{pretraga}%'";

        //    // Postavite izvor podataka DataGridView-a na DataView
        //    gridklijenti.DataSource = klijenti;
           
        //}

        private void btnpretragaklijenata_Click(object sender, EventArgs e)
        {
            klijenti = new BindingList<Klijent>(Communication.Instance.PretragaKlijenata(txtpretragaklijenata.Text));
            if (klijenti.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje trenere po zadatoj vrednosti.");
            else
            {
                gridklijenti.DataSource = null;
                gridklijenti.DataSource = klijenti;
            }
        }

        private void txtpretragaklijenata_TextChanged(object sender, EventArgs e)
        {
            klijenti = new BindingList<Klijent>(Communication.Instance.PretragaKlijenata(txtpretragaklijenata.Text));
            if (klijenti.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje trenere po zadatoj vrednosti.");
            else
            {
                gridklijenti.DataSource = null;
                gridklijenti.DataSource = klijenti;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridklijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frmmain.izabraniKlijent = (Klijent)gridklijenti.SelectedRows[0].DataBoundItem;
            this.Dispose();
            frmmain.osveziTxtboxZaKlijenta();

        }
    }
}
