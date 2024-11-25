using Common;
using Common.Domain;
using Seminarski;
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
    public partial class Frmmain : Form
    {
        internal static Klijent izabraniKlijent;
        internal static Jedrilica izabranaJedrilica;
        internal static BindingList<ClanPosade> listaIzabranihClanovaPosade = new BindingList<ClanPosade>();
        public Frmmain(User user)
        {
            InitializeComponent();
            pozdrav.Text = $" Zdravo {user.FirstName} ";
        }
        internal void osveziDgvZaClanovePosade()
        {
            dgvodabranislanovi.DataSource = null;
            dgvodabranislanovi.DataSource = listaIzabranihClanovaPosade;
        }

        internal void osveziTxtboxZaKlijenta()
        {
            txtodabranklijent.Text = $"JMBG: {izabraniKlijent.jmbgID} Ime i Prezime: {izabraniKlijent.imeprezime}";
        }

        internal void osveziTxtboxZaJedrilicu()
        {
            txtodabranajedrilica.Text = $"Registracija: {izabranaJedrilica.regID} Model: {izabranaJedrilica.model} Tip: {izabranaJedrilica.tip}";
        }
        private void klijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeKlijenta dk = new DodavanjeKlijenta();
            dk.ShowDialog();


        }

        private void jedrilicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeJedrilice j = new DodavanjeJedrilice();
            j.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void izaberiklijenta_Click(object sender, EventArgs e)
        {
            IzaberiKlijenta izkl = new IzaberiKlijenta(this);
            izkl.ShowDialog();
           

        }

        private void clanaPosadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNoviClanPosade frmnovicl = new FrmNoviClanPosade();
            frmnovicl.ShowDialog();
        }

        private void clanPosadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBrisanjeClanaPosade fr = new FrmBrisanjeClanaPosade();
            fr.ShowDialog();
        }

        private void klijentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzborJedrilice izborJedrilice = new IzborJedrilice(this);
            izborJedrilice.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzborClanaPosade izborcp = new IzborClanaPosade(this);
            izborcp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}


