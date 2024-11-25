# Sailboats-rental

# Tehnologije
Projekat je razvijen u C# koristeći Windows Forms za izradu korisničkog interfejsa i SQL Server za upravljanje bazom podataka.
Projekat je zasnovan na klijent-server arhitekturi, gde klijent aplikacija (Windows Forms aplikacija) komunicira sa serverom koji obrađuje zahteve.
Server je odgovoran za obradu poslovne logike i upravljanje bazom podataka, dok klijent pruža korisnički interfejs za interakciju sa sistemom.
Za pokretanje aplikacije potrebno je provo pokrenuti server, i nakon klika na START, moze se pokrenuti klijent deo.

# Opis i namena
The application enables keeping records of clients who have rented sailboats, as well as the sailboats that have been provided to them for use. It is necessary to record the sailboat (model, registration number, etc.) that has been given to them, with the ability to modify, search, and delete it. There is also a need for the possibility to add and delete employees, that is, crew members. An employee can enter data about a new client, modify it, or delete it if the client is not a frequent customer. They can also search for a client. If there are currently available sailboats, the employee creates a document about the rented sailboat, including the number of days it is rented for, the crew that will operate it, etc. If the client wishes to, for example, extend the trip, it is necessary to enable modification of that document.

# Sistemske operacije
1.	Signal KreirajClanaPosade(ClanPosade)
2.	Signal NadjiClanaPosade(String zadataVrednost, List<ClanaPosade>)	
3.	Signal ObrisiClanaPosade(ClanPosade)
4.	Signal KreirajJedrilicu(Jedrilica)
5.	Signal NadjiJedrilicu(String zadataVrednost, List<Jedrilica>)
6.	Signal ObrisiJedrilicu(Jedrilica)
7.	Signal IzmeniJedrilicu(Jedrilica)
8.	Signal KreirajKlijenta(Klijent)
9.	Signal NadjiKlijenta(String zadataVrednost, List<Klijent>)
10.	Signal UcitajKlijenta(Klijent)
11.	Signal ObrisiKlijenta(Klijent)
12.	Signal IzmeniKlijenta(Klijent)
13.	Signal UcitajListuKlijenata(List<Klijent>)
14.	Signal UcitajListuClanovaPosade(List<ClanPosade>)
15.	Signal UcitajListuJedrilica(List<Jedrilica>)
16.	Signal UcitajListuDokumenata(List<Dokument>)  
17.	Signal KreirajDokument(Dokument)
18.	Signal NadjiDokumentOIznajmljenoj(String zadataVrednost, List<Dokument>)	
19.	Signal IzmeniDokument(Dokument)

