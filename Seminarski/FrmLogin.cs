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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Communication.Instance.Connect();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            User usr = new User();  
           usr.Username = usrtext.Text;
           usr.Password = pswtext.Text;
            User user;
           user = (User)Communication.Instance.Login(usr).Result;
            if(user != null)
            {
                MessageBox.Show("Uspesna prijava");
                   Frmmain main = new Frmmain(user);
                   main.ShowDialog();
            }


            //Datpom dat = new Datpom();
            //dat.OpenConnection();
            //User user = dat.Login(username, password);
            //if (user != null)
            //{
            //    MessageBox.Show("Uspesna prijava");
            //    Frmmain main = new Frmmain(user);
            //    main.ShowDialog();
            //}
            //else { MessageBox.Show("Neuspesna prijava!"); }

            //dat.CloseConnection();
        }
    }
}
