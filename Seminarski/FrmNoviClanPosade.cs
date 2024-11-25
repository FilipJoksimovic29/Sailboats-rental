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
    public partial class FrmNoviClanPosade : Form
    {
        ClanPosade pom = null;
        ClanPosade cp;
        public FrmNoviClanPosade()
        {
            InitializeComponent();
            Communication.Instance.Connect();
             cp = Communication.Instance.KreirajClanaPosade();
            if (cp != null)
            {
                MessageBox.Show("Uspesno kreiran novi Clan Posade.");
            }
            else { MessageBox.Show("Nije kreiran novi Clan Posade."); }
            txtclanid.Enabled = false;
            txtclanid.Text = cp.Id.ToString();
           

        }

        private void btnzapamticlanaposade_Click(object sender, EventArgs e)
        {
            cp.Ime = txtclanime.Text;
            cp.Iskustvo = txtclaniskustvo.Text;
            pom = Communication.Instance.ZapamiClanaPosade(cp);
            if ( pom!= null)
            {
                MessageBox.Show("Uspesno zapamcen novi Clan Posade.");
            }
            else { MessageBox.Show("Nije zapamcen novi Clan Posade."); }
        }


        //private void FrmNoviClanPosade_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //       if(pom == null)
        //        {
        //            Communication.Instance.ObrisiClanaPosade(cp);

        //        }
        //    }
        //}


        private void FrmNoviClanPosade_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pom == null)
            {
                Communication.Instance.ObrisiClanaPosade(cp);

            }
            
        }


    }
}
