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
    public partial class IzborClanaPosade : Form
    {
        Frmmain frmmain;
        private BindingList<ClanPosade> clanoviPosade;
        public IzborClanaPosade(Frmmain frmmain)
        {
            this.frmmain = frmmain;
            InitializeComponent();
            clanoviPosade = new BindingList<ClanPosade>(Communication.Instance.UcitajListuClanovaPosade());
       
        dgvclanposade.DataSource = clanoviPosade;
            dgvclanposade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvclanposade.MultiSelect = false;
        }

        private void txtpretragaclanovaposade_TextChanged(object sender, EventArgs e)
        {
            clanoviPosade = new BindingList<ClanPosade>(Communication.Instance.PretragaClanovaPosade(txtpretragaclanovaposade.Text));
            if (clanoviPosade.Count == 0)
                MessageBox.Show("Sistem ne moze da nadje trenere po zadatoj vrednosti.");
            else
            {
                dgvclanposade.DataSource = null;
                dgvclanposade.DataSource = clanoviPosade;
            }
        }

        private void dgvclanposade_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frmmain.listaIzabranihClanovaPosade.Add((ClanPosade)dgvclanposade.SelectedRows[0].DataBoundItem);
            frmmain.osveziDgvZaClanovePosade();
            this.Dispose();
        }
    }
}
