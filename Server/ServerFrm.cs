using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerFrm : Form
    {
        private Server svr;
        public ServerFrm()
        {
            InitializeComponent();
           
        }

        //private void svrstart_Click(object sender, EventArgs e)
        //{
        //    txtsvrinfo.Text = "Pokrenuut Server!";
        //    svrstart.Enabled = false;
        //    svrstop.Enabled = true;
           
        //    svr.Start();
            
        //}



        private async void svrstart_Click(object sender, EventArgs e)
        {
            svr = new Server();
            txtsvrinfo.Text = "Pokrenuut Server!";
            svrstart.Enabled = false;
            svrstop.Enabled = true;

            await Task.Run(() => svr.Start());
            // Ovaj kod će se izvršiti tek nakon što se svr.Start() završi

            // Možeš dodati kod koji se izvršava nakon što se server pokrene
        }



        private void svrstop_Click(object sender, EventArgs e)
        {
            svrstart.Enabled = true;
            svrstop.Enabled = false;
            svr.Stop();
            txtsvrinfo.Text = "Stopiran Server!";

        }
    }
}
