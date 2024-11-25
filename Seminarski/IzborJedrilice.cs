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
    public partial class IzborJedrilice : Form
    {
        Frmmain frmmain;
        private BindingList<Jedrilica> jedrilice;
        public IzborJedrilice(Frmmain frmmain)
        {this.frmmain = frmmain;
            InitializeComponent();
            jedrilice = new BindingList<Jedrilica>(Communication.Instance.UcitajJedrilice());
        dgvjedrilice.DataSource = jedrilice;
            dgvjedrilice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvjedrilice.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtpretragajedrilica_TextChanged(object sender, EventArgs e)
        {
            jedrilice = new BindingList<Jedrilica>(Communication.Instance.PretragaJedrilica(txtpretragajedrilica.Text));
            if (jedrilice.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje trenere po zadatoj vrednosti.");
            else
            {
                dgvjedrilice.DataSource = null;
                dgvjedrilice.DataSource = jedrilice;
            }
        }

        private void dgvjedrilice_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frmmain.izabranaJedrilica = (Jedrilica)dgvjedrilice.SelectedRows[0].DataBoundItem;
            this.Dispose();
            frmmain.osveziTxtboxZaJedrilicu();
        }
    }
}
