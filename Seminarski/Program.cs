using BrokerBaze;
using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarski
{
    internal static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());

            //SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            // Initial Catalog=Seminarski;Integrated Security=True;");
            //Broker br = new Broker();
            //br.OpenConnection();
            //br.KreirajClanaPosade();
            //br.CloseConnection();

            //connection.Open();

            //Jedrilica jedrilica = new Jedrilica
            //{
            //    regID = "YU123",
            //    model = "Bavaria",
            //    tip = "jednojedro12m"

            //};

            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "insert into jedrilice values ('{jedrilica.regID}','{jedrilica.model}','{jedrilica.tip}')";
            //connection.Close();


        }
    }
}
