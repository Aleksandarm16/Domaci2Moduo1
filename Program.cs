using System;
using System.Collections.Generic;
using System.IO;


namespace Domaci2Moduo1
{
     class Program
    {
        static void Main(string[] args)
        {
            string fajl = @"C:\Users\Alex\Desktop\Kurs .NET\Vezbe\Moduo1\Domaci2Moduo1\Oglasi.txt";
            List<Oglas> MojaProdavnica = new List<Oglas>();
            NizOglasa.PravljenjeKonstruktoraPrekoTxtFajla(fajl,MojaProdavnica);
            Prodavnica AutoProdavnica = new Prodavnica(MojaProdavnica);
            //Kako moze jednostavnije da ne pravim listu u programu.cs
            // AutoProdavnica.IspisSvihOglasa();
            //AutoProdavnica.IspisPoGodini(2012);
            //AutoProdavnica.IspisOglasaDetaljno("A1");
            
            int opcija;
            do
            {
                Console.WriteLine("------------Prodavnica Automobila------------");
                Console.WriteLine("1.Ispis svih postojecih oglasa");
                Console.WriteLine("2.Pretraga po godini proizvodnje");
                Console.WriteLine("3.Detaljan ispis zeljenog oglasa");
                Console.WriteLine("4.Izmena detalja o vozilu");
                Console.WriteLine("5.Filtriranje oglasa po ceni");
                Console.WriteLine("6.Filtriranje po opremi");

                Console.WriteLine("8.Dodavanje nove opreme");


                Console.WriteLine("0.Izlaz");
                opcija = Int32.Parse(Console.ReadLine());
                switch (opcija)
                {
                    case 1:
                        AutoProdavnica.IspisSvihOglasa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Unesite godinu proizvodnje: ");
                        int godinaProizvodnje = Int32.Parse(Console.ReadLine());
                        AutoProdavnica.IspisPoGodini(godinaProizvodnje);
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Unesite sifru oglasa za detaljan ispis:");
                        string sifraOglasa = Console.ReadLine();
                        AutoProdavnica.IspisOglasaDetaljno(sifraOglasa);
                        break;
                    case 4:
                        Console.Clear();
                        IzmenaOglasa.Izmeni(AutoProdavnica);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Unesite zeljenu pretragu");
                        Console.WriteLine("1. od do");
                        Console.WriteLine("2. Manje od");
                        Console.WriteLine("3. Vece od");
                        int pretragaCena = Int32.Parse(Console.ReadLine());
                        if(pretragaCena==1)
                        {
                            Console.WriteLine("Unesite manji iznos: ");
                            int manjIznos = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Unesite veci iznos");
                            int veciIznos = Int32.Parse(Console.ReadLine());
                            AutoProdavnica.IspisCenaIzmedju(manjIznos, veciIznos);
                        }
                        else if(pretragaCena==2)
                        {
                            Console.WriteLine("Unesite iznos: ");
                            int iznos = Int32.Parse(Console.ReadLine());
                            AutoProdavnica.IspisCenaManje(iznos);
                        }
                        else if(pretragaCena==3)
                        {
                            Console.WriteLine("Unesite iznos: ");
                            int iznos = Int32.Parse(Console.ReadLine());
                            AutoProdavnica.IspisCenaVece(iznos);
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Unesite zeljenu opremu i razdvojite je zarezom");
                        string pretragaOpreme = Console.ReadLine();
                        string[] listaOpreme = pretragaOpreme.Split(',');
                        AutoProdavnica.IspisOglasaPretragaPoOpremi(listaOpreme);
                        //nece neke delove da ispise (konkretno oglas 4 poslednji string )

                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Unesite sifru oglasa");
                        string sifra = Console.ReadLine();
                        Console.WriteLine("Unesi novu dodatnu opremeu razdvojenu sa ;");
                        string novaOprema = Console.ReadLine();
                        AutoProdavnica.NoviSkupOpreme(sifra, novaOprema);

                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Unesite sifru oglasa:");
                        string sifraZaDodavanje = Console.ReadLine();
                        Console.WriteLine("Unesite 1 novu opremu da dodate");
                        string opremaZaDodavanje = Console.ReadLine();
                        AutoProdavnica.DodavanjeOpreme(sifraZaDodavanje, opremaZaDodavanje);

                        break;

                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ne postoji ta opcija!");
                        break;
                }
                
            } while (opcija!=0);


           



            //Oglas[] ProdavnicaAutomobila=new Oglas[50];
            //string[] DodatnaOprema1 = { "ABS", "ESP", "alarm", "DVD", "klima" };
            //string[] DodatnaOprema2 = { "servo volan", "putni računar", "tempomat", "zatamljena stakla"};
            //string[] DodatnaOprema3 = { "ABS", "alarm", "CD", "DVD", "Parking Senzor" };
            //ProdavnicaAutomobila[0] = new Oglas("0001", "Reno Klio", 2000, 2012, DodatnaOprema1);
            //ProdavnicaAutomobila[1] = new Oglas("0002", "Golf IV", 1000, 2001,DodatnaOprema2);
            //ProdavnicaAutomobila[2] = new Oglas("0003", "Dacia", 3000, 2019, DodatnaOprema3);
            //ProdavnicaAutomobila[3] = new Oglas("0004", "Nisan", 2500, 2012, DodatnaOprema1);

            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;
            //    ProdavnicaAutomobila[i].IspisOglasa(i);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Ispis to godini proizvodnje:");
            //int GodinaProizvodnje = 2012;
            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;
            //    if (ProdavnicaAutomobila[i].GodinaProizvodnje == GodinaProizvodnje)
            //        ProdavnicaAutomobila[i].IspisOglasa(i);

            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Ispis celog oglasa:");
            //ProdavnicaAutomobila[2].IspisCelogOglasa();
            //Console.WriteLine("\n");
            //ProdavnicaAutomobila[2].CenaOglasa = 5500;
            //ProdavnicaAutomobila[2].SifraOglasa = "0010";
            //ProdavnicaAutomobila[2].NaslovOglasa = "Hyndai";
            //ProdavnicaAutomobila[2].DodatnaOprema = new string[5] { "ABS","Alarm", "CD", "airbag", "klima" };
            //Console.WriteLine("Menjanje parametra u oglasu redni broj 2:");
            //ProdavnicaAutomobila[2].IspisCelogOglasa();
            //Console.WriteLine("\n");
            //Console.WriteLine("Oglasi u rangu 2000-3000");
            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;
            //    if (ProdavnicaAutomobila[i].CenaOglasa <= 3000 && ProdavnicaAutomobila[i].CenaOglasa >= 2000)
            //    {

            //        ProdavnicaAutomobila[i].IspisOglasa(i);
            //    }


            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Oglasi jeftiniji od 5000");
            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;


            //    else if (ProdavnicaAutomobila[i].CenaOglasa < 5000)
            //    {

            //        ProdavnicaAutomobila[i].IspisOglasa(i);
            //    }

            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("Oglasi skuplji od 5000");
            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;


            //    else if (ProdavnicaAutomobila[i].CenaOglasa > 5000)
            //    {

            //        ProdavnicaAutomobila[i].IspisOglasa(i);
            //    }

            //}
            //Console.WriteLine("\n");
            //string[] Oprema = new string[] { "ABS","DVD"};
            //int duzina = Oprema.Length;
            //int tmp = 0;
            //Console.WriteLine("Oglasi koji odgovara trazenom kriterijumu su: ");
            //for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            //{
            //    if (ProdavnicaAutomobila[i] == null)
            //        break;
            //    for (int j = 0; j < ProdavnicaAutomobila[i].DodatnaOprema.Length; j++)
            //    {

            //        for (int k = 0; k < Oprema.Length; k++)
            //        {
            //            if (Oprema[k] == null)
            //                break;
            //            if(ProdavnicaAutomobila[i].DodatnaOprema[j]==Oprema[k])
            //            {
            //                tmp++;
            //                if (tmp == duzina)
            //                {                                
            //                    ProdavnicaAutomobila[i].IspisOglasa(i);
            //                    tmp = 0;
            //                }

            //            }

            //        }

            //    }

            //}
            //Console.WriteLine("\nDefinisanje novog skupa:");
            //ProdavnicaAutomobila[0].IspisCelogOglasa();
            //ProdavnicaAutomobila[0].DodatnaOprema = new string[] {"airbag","DVD","Klima","Cd","Servo","maglenke"};
            //ProdavnicaAutomobila[0].IspisCelogOglasa();

            //Console.WriteLine("\nDodavanje opreme (putni racnuar)");
            //ProdavnicaAutomobila[0].IspisCelogOglasa();
            //ProdavnicaAutomobila[0].DodavanjeDelaOpreme("putni racunar");
            //ProdavnicaAutomobila[0].IspisCelogOglasa();




            Console.ReadKey();
        }
    }
}
