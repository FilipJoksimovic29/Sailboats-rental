
using Databasepom;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace Seminarski
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Seminarski;
                //    Integrated Security=True;");

            #region ubacijedrilicu
            //connection.Open();

            //Jedrilica jedrilica = new Jedrilica
            //{
            //    regID = "yu123",
            //    model = "bavaria",
            //    tip = "jednojedro12m"

            //};

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection; 
            //command.CommandText = $"insert into Jedrilica values ('{jedrilica.regID}','{jedrilica.model}','{jedrilica.tip}')";
            //command.ExecuteNonQuery();
            //connection.Close();
            #endregion 


            //connection.Open();
            //SqlCommand command = new SqlCommand("", connection);
            //command.CommandText = $"select * from jedrilica";
            //SqlDataReader reader = command.ExecuteReader();
            //List<Jedrilica> jedrilice = new List<Jedrilica>();
            
            //while (reader.Read())
            //{
            //    Jedrilica j = new Jedrilica();
            //    j.regID = (string)reader["regID"];
            //    j.model = (string)reader["model"];
            //    j.tip = (string)reader["tip"];
            //  //  Console.WriteLine(j.regID);
               
            //    jedrilice.Add(j);
            //}
            //foreach (Jedrilica j in jedrilice)
            //{ Console.WriteLine(j.regID+"  " +j.model+"  " + j.tip); }
            //Console.ReadKey();
            //connection.Close();

            Broker pom = new Broker();
            //pom.OpenConnection();
            Jedrilica j = new Jedrilica { regID = "yu123", model = "yamaha34", tip = "blejacka" };
            //pom.DodajJedrilicu(j);
            //pom.CloseConnection();

          //  pom.OpenConnection();
            Klijent k = new Klijent { jmbgID = 1234, imeprezime = "Miroslava Kaurin", datumRodj = new DateTime(2000, 12, 5), iskustvo = "Slabo", mestoStanovanja = "Zupa"};
           // pom.DodajKlijenta(k);
          //  List<Klijent> klijenti = new List<Klijent>();
          //  klijenti =  pom.VratiKlijente();
          //  foreach (Klijent ka in klijenti)
            {
                //  Console.WriteLine($"{ka.jmbgID} {ka.imeprezime} {ka.datumRodj} {ka.mestoStanovanja} {ka.iskustvo}");
              //  Console.WriteLine(ka);
               
            }
            // pom.CloseConnection();
            //   Console.ReadKey();

          //   pom.OpenConnection();
           //   DokumentOIznajmljenojJedrilici dok = new DokumentOIznajmljenojJedrilici {brojUgovoraID = 1252, datumIzdavanja = new DateTime(2000,10,7), datumVracanja = new DateTime(1999,4,6),jedrilica = j,klijent = k };
         //    pom.DodajDokument(dok);
         //     pom.CloseConnection();

            List<DokumentOIznajmljenojJedrilici> ld = new List<DokumentOIznajmljenojJedrilici>();
            

            pom.OpenConnection();
            ld = pom.VratiDokumente();
            pom.CloseConnection();
            foreach (DokumentOIznajmljenojJedrilici doku in ld)
            {
                Console.WriteLine(doku);
                Console.ReadKey();

            }
           



        }
    }
}
