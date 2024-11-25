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
    public partial class DodavanjeKlijenta : Form
    {
        public DodavanjeKlijenta()
        {
            InitializeComponent();
        }

        private void DodavanjeKlj_Click(object sender, EventArgs e)
        {
            
            Klijent kl = new Klijent();
            kl.jmbgID = int.Parse(jmbg.Text);
            kl.imeprezime = imeiprez.Text;
            kl.datumRodj = datumrodjklij.Value;
            kl.mestoStanovanja = mestostanovanja.Text;
            kl.iskustvo = iskustvo.Text;
            Broker dt = new Broker();
            dt.OpenConnection();
            dt.DodajKlijenta(kl);
            dt.CloseConnection();
            this.Close();

        }
    }
}
