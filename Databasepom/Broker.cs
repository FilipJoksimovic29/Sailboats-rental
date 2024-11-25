using Common;
using Common.Domain;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BrokerBaze
{
    public class Broker
    {
        private DbConnection connection;



        public Broker()
        {
            connection = new DbConnection();

        }

        public void OpenConnection()
        {

            connection?.OpenConnection();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }


        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void DodajJedrilicu(Jedrilica j)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Jedrilica values ('{j.regID}','{j.model}','{j.tip}')";
            command.ExecuteNonQuery();
        }
        public List<Jedrilica> UcitajJedrilice()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from jedrilica";
            SqlDataReader reader = command.ExecuteReader();
            List<Jedrilica> jedrilice = new List<Jedrilica>();

            while (reader.Read())
            {
                Jedrilica j = new Jedrilica();
                j.regID = (string)reader["regID"];
                j.model = (string)reader["model"];
                j.tip = (string)reader["tip"];
                //  Console.WriteLine(j.regID);

                jedrilice.Add(j);
            }
            reader.Close();
            return jedrilice;
        }


        public void DodajKlijenta(Klijent k)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Klijent VALUES (@jmbgID, @imePrezime, @datumRodj, @mestoStanovanja, @iskustvo)";

            // Dodajte parametre i postavite datum direktno kao DateTime
            command.Parameters.AddWithValue("@jmbgID", k.jmbgID);
            command.Parameters.AddWithValue("@imePrezime", k.imeprezime);
            command.Parameters.AddWithValue("@datumRodj", k.datumRodj); // Pretpostavljamo da je datumRodj DateTime
            command.Parameters.AddWithValue("@mestoStanovanja", k.mestoStanovanja);
            command.Parameters.AddWithValue("@iskustvo", k.iskustvo);

            command.ExecuteNonQuery();
        }


        public List<Klijent> UcitajKlijente()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Klijent";
            SqlDataReader reader = command.ExecuteReader();
            List<Klijent> klijenti = new List<Klijent>();

            while (reader.Read())
            {
                Klijent k = new Klijent();
                k.jmbgID = (int)reader["jmbgID"];
                k.imeprezime = (string)reader["imePrezime"];
                k.datumRodj = (DateTime)reader["datumRodj"];
                k.mestoStanovanja = (string)reader["mestoStanovanja"];
                k.iskustvo = (string)reader["iskustvo"];


                klijenti.Add(k);
            }
            reader.Close();
            return klijenti;


        }


        public Klijent VratiKlijenta(int trazenJMBG)
        {
            SqlCommand commanda = connection.CreateCommand();
            commanda.CommandText = $"select * from Klijent WHERE jmbgID = '{trazenJMBG}'";
            SqlDataReader reader = commanda.ExecuteReader();
            Klijent k = new Klijent();
            while (reader.Read())
            {
               
                k.jmbgID = (int)reader["jmbgID"];
                k.imeprezime = (string)reader["imePrezime"];
                k.datumRodj = (DateTime)reader["datumRodj"];
                k.mestoStanovanja = (string)reader["mestoStanovanja"];
                k.iskustvo = (string)reader["iskustvo"];


               
            }
            reader.Close();
            return k;


        }


        #region Dokument



        public Jedrilica VratiJedrilicu(string trazeniRegID)
        {
            using (SqlCommand commandaa = connection.CreateCommand()) { 
            commandaa.CommandText = $"SELECT * FROM jedrilica WHERE regID = @trazeniRegID";
            commandaa.Parameters.AddWithValue("@trazeniRegID", trazeniRegID);
                
                SqlDataReader readerr = commandaa.ExecuteReader();

            Jedrilica j = null; // Postavljamo na null jer trenutno nemamo pronađenu jedrilicu.

            while (readerr.Read())
            {
                j = new Jedrilica();
                j.regID = (string)readerr["regID"];
                j.model = (string)readerr["model"];
                j.tip = (string)readerr["tip"];
                // Ovdje možete postaviti ostale članove klase Jedrilica prema potrebi.
                // Console.WriteLine(j.regID);
            }
                readerr.Close(); return j;
            }
        }













        public void DodajDokument(DokumentOIznajmljenojJedrilici d)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO DokumentOIznajmljenojJedrilici (datumIzdavanja, datumVracanja, regID, jmbgID) VALUES  (@datumIzdavanja, @datumVracanja, @regID, @jmbgID)";

            // Dodajte parametre i postavite datum direktno kao DateTime
         //   command.Parameters.AddWithValue("@brojUgovoraID", d.brojUgovoraID);
            command.Parameters.AddWithValue("@datumIzdavanja", d.datumIzdavanja);
            command.Parameters.AddWithValue("@datumVracanja", d.datumVracanja); // Pretpostavljamo da je datumRodj DateTime
            command.Parameters.AddWithValue("@regID", d.jedrilica.regID);
            command.Parameters.AddWithValue("@jmbgID", d.klijent.jmbgID);

            command.ExecuteNonQuery();
        }


        public List<DokumentOIznajmljenojJedrilici> VratiDokumente()
        {
            List<DokumentOIznajmljenojJedrilici> ld = new List<DokumentOIznajmljenojJedrilici>();

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM DokumentOIznajmljenojJedrilici";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DokumentOIznajmljenojJedrilici d = new DokumentOIznajmljenojJedrilici();

                        d.brojUgovoraID = (int)reader["brojUgovoraID"];
                        d.datumIzdavanja = (DateTime)reader["datumIzdavanja"];
                        d.datumVracanja = (DateTime)reader["datumVracanja"];
                        string s = (string)reader["regID"];
                        int i = (int)reader["jmbgID"];

                        d.jedrilica = VratiJedrilicu(s);
                        d.klijent = VratiKlijenta(i);
                        ld.Add(d);
                    }
                }
            }

            return ld;
        }






        #endregion


        public User Login(User usr)
        {
           
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [user] where username = '{usr.Username}' and password = '{usr.Password}'";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["id"];
                user.FirstName = (string)reader["ime"];
                user.Username = (string)reader["username"];
                user.Password = (string)reader["password"];
                reader.Close();
                
                return user;
            }
            
            return null;
        }


        public int VratiMaxIdClanPosade()
        {
            int br = -1;
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select MAX(clanID) from ClanPosade";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                br = (int)reader[0];

            }
            return br;
        }
        public ClanPosade KreirajClanaPosade()
        {ClanPosade clanPosade = new ClanPosade(); 
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO ClanPosade DEFAULT VALUES";
            cmd.ExecuteNonQuery();
          clanPosade.Id = VratiMaxIdClanPosade();
            return clanPosade;
        }

        public ClanPosade ZapamiClanaPosade(ClanPosade argument)
        {
            ClanPosade clanPosade = argument;
            SqlCommand cmd = connection.CreateCommand();
            int br = VratiMaxIdClanPosade();
            cmd.CommandText = "Update ClanPosade set ime = @ime, iskustvo = @iskustvo WHERE clanID = @clanID";
            cmd.Parameters.AddWithValue("@ime", argument.Ime); 
            cmd.Parameters.AddWithValue("@iskustvo", argument.Iskustvo);
            cmd.Parameters.AddWithValue("@clanID", br);
            cmd.ExecuteNonQuery();
            
            return clanPosade;
        }

        public List<ClanPosade> VratiClanovePosade()
        {

            SqlCommand commanda = connection.CreateCommand();
            commanda.CommandText = $"select * from ClanPosade";
            SqlDataReader reader = commanda.ExecuteReader();
            List<ClanPosade> cplist = new List<ClanPosade>();
            while (reader.Read())
            {
                ClanPosade clan = new ClanPosade();
               clan.Id = (int)reader[0];
               clan.Ime = (string)reader[1];
               clan.Iskustvo = (string)reader[2];
                cplist.Add(clan);

            }
            reader.Close();
            return cplist;


        }

        public void ObrisiClanaPosade(ClanPosade argument)
        {
            SqlCommand commanda = connection.CreateCommand();
            commanda.CommandText = "DELETE FROM ClanPosade WHERE ClanID = @id";
            commanda.Parameters.AddWithValue("@id", argument.Id);
            commanda.ExecuteNonQuery();
        }

       

        public List<Klijent> NadjiKlijenta(string pretraga)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Klijent WHERE imeprezime LIKE '%{pretraga}%' or jmbgID LIKE '%{pretraga}%' or mestoStanovanja LIKE '%{pretraga}%'  ";
            SqlDataReader reader = command.ExecuteReader();
            List<Klijent> klijenti = new List<Klijent>();

            while (reader.Read())
            {
                Klijent k = new Klijent();
                k.jmbgID = (int)reader["jmbgID"];
                k.imeprezime = (string)reader["imePrezime"];
                k.datumRodj = (DateTime)reader["datumRodj"];
                k.mestoStanovanja = (string)reader["mestoStanovanja"];
                k.iskustvo = (string)reader["iskustvo"];


                klijenti.Add(k);
            }
            reader.Close();
            return klijenti;
        }

        public List<Jedrilica> NadjiJedrilicu(string pretraga)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Jedrilica WHERE regID LIKE '%{pretraga}%' or model LIKE '%{pretraga}%' or tip LIKE '%{pretraga}%'  ";
            SqlDataReader reader = command.ExecuteReader();
            List<Jedrilica> jedrilice = new List<Jedrilica>();

            while (reader.Read())
            {
                Jedrilica j = new Jedrilica();
                j.regID = (string)reader["regID"];
                j.model = (string)reader["model"];
                j.tip = (string)reader["tip"];
               


                jedrilice.Add(j);
            }
            reader.Close();
            return jedrilice;
        }

        public List<ClanPosade> UcitajListuClanovaPosade()
        {
            SqlCommand commanda = connection.CreateCommand();
            commanda.CommandText = $"select * from ClanPosade";
            SqlDataReader reader = commanda.ExecuteReader();
            List<ClanPosade> cplist = new List<ClanPosade>();
            while (reader.Read())
            {
                ClanPosade clan = new ClanPosade();
                clan.Id = (int)reader[0];
                clan.Ime = (string)reader[1];
                clan.Iskustvo = (string)reader[2];
                cplist.Add(clan);

            }
            reader.Close();
            return cplist;
        }

        public List<ClanPosade> NadjiClanaPosade(string pretraga)
        {
            SqlCommand commanda = connection.CreateCommand();
            commanda.CommandText = $"select * from ClanPosade where clanID like '%{pretraga}%' or ime like '%{pretraga}%' or iskustvo like '%{pretraga}%' ";
            SqlDataReader reader = commanda.ExecuteReader();
            List<ClanPosade> cplist = new List<ClanPosade>();
            while (reader.Read())
            {
                ClanPosade clan = new ClanPosade();
                clan.Id = (int)reader[0];
                clan.Ime = (string)reader[1];
                clan.Iskustvo = (string)reader[2];
                cplist.Add(clan);

            }
            reader.Close();
            return cplist;
        }
    }
}
