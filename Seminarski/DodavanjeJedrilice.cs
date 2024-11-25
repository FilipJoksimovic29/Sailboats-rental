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
    public partial class DodavanjeJedrilice : Form
    {
        public DodavanjeJedrilice()
        {
            InitializeComponent();
        }

        private void DodajJedrilicu_Click(object sender, EventArgs e)
        {
            Jedrilica j = new Jedrilica();
            j.regID = reg.Text;
            j.model = mod.Text;
            j.tip = tip.Text;
            Broker dt = new Broker();
            dt.OpenConnection();
            dt.DodajJedrilicu(j);
            dt.CloseConnection();
            this.Close();
        }
    }
}
