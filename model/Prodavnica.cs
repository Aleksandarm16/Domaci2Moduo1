using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2Moduo1
{
    public class Prodavnica
    {
        public List<Oglas> ProdavnicaAuta { get; set; }
        public Prodavnica(List<Oglas> x)
        {
            ProdavnicaAuta = x;
        }
        
        public void IspisSvihOglasa()
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            
            {
                Console.WriteLine("Redni broj Oglasa: " + i + " Sifra oglasa: " +ProdavnicaAuta[i].SifraOglasa + " Naslov Oglasa: " + ProdavnicaAuta[i].NaslovOglasa
                    + " Cena Oglasa: " + ProdavnicaAuta[i].CenaOglasa);
            }

        }
        
        public void IspisPoGodini(int godina)
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if (godina==ProdavnicaAuta[i].GodinaProizvodnje)
                {
                    ProdavnicaAuta[i].IspisPojedinacnogOglasa(i);
                }
            }
        }
        public void IspisOglasaDetaljno (string sifra)
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if (sifra == ProdavnicaAuta[i].SifraOglasa)
                {

                  
                    
                    Console.WriteLine("Sifra Oglasa: " + ProdavnicaAuta[i].SifraOglasa + " Naslov Oglasa: " +ProdavnicaAuta[i].NaslovOglasa + " Cena Oglasa: " + ProdavnicaAuta[i].CenaOglasa);
                    Console.WriteLine("Od dodatne opreme ima: ");
                    for (int j = 0; j < ProdavnicaAuta[i].DodatnaOprema.Count; j++)
                    {
                        //Console.Write ne radi(ne ispisuje prvi clan kako treba)
                        Console.WriteLine(ProdavnicaAuta[i].DodatnaOprema[j]);
                    }
                    Console.WriteLine("\n");
                    
                }
            }
            
        }
        public void IspisCenaIzmedju (int rangCenaManja, int rangCenaVeca)
        {
            
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if(ProdavnicaAuta[i].CenaOglasa>=rangCenaManja && ProdavnicaAuta[i].CenaOglasa<=rangCenaVeca)
                {
                    ProdavnicaAuta[i].IspisPojedinacnogOglasa(i);
                }
            }
        }
        public void IspisCenaManje (int cenaManje)
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)

            {
                if(ProdavnicaAuta[i].CenaOglasa<cenaManje)
                {
                    ProdavnicaAuta[i].IspisPojedinacnogOglasa(i);
                }
            }
        }
        public void IspisCenaVece (int cenaVece)
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if (ProdavnicaAuta[i].CenaOglasa > cenaVece)
                    ProdavnicaAuta[i].IspisPojedinacnogOglasa(i);
            }
        }
        public void IspisOglasaPretragaPoOpremi (string[] zeljenaOprema)
        {
            
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                int tmp = 0;
                for (int j = 0; j < ProdavnicaAuta[i].DodatnaOprema.Count; j++)
                {
                    
                    for (int k = 0; k < zeljenaOprema.Length; k++)
                    {
                        if(zeljenaOprema[k].ToLower()==ProdavnicaAuta[i].DodatnaOprema[j].ToLower())
                        {
                            tmp++;
                           
                            if(tmp==zeljenaOprema.Length)
                            {
                                ProdavnicaAuta[i].IspisPojedinacnogOglasa(i);
                                
                            }    
                        }
                    }
                    
                }
            }
        }
        public void DodavanjeOpreme(string sifra, string oprema)
        {
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if (ProdavnicaAuta[i].SifraOglasa == sifra)
                    ProdavnicaAuta[i].DodavanjeDelaOpreme(oprema);
            }
        }
        public void NoviSkupOpreme (string sifra)
        {
            int redniBrojOglasa = 0;
            
            string deoOpreme;
            bool tmp = false;
            List<string> novaOprema = new List<string>();
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if(ProdavnicaAuta[i].SifraOglasa==sifra)
                {
                    redniBrojOglasa = i;
                    tmp = true;
                }
            }
            if(tmp)
            {
                do
                {
                    Console.WriteLine("Unesite deo opreme za unos, za prekid unesite 0:");
                    deoOpreme = Console.ReadLine();
                    if(deoOpreme!="0")
                    {
                        novaOprema.Add(deoOpreme);
                    }


                } while (deoOpreme!="0");
                ProdavnicaAuta[redniBrojOglasa].DefinisanjeNovogSkupaOpreme(novaOprema);
            }
            else
            {
                Console.WriteLine("Pogresna sifra!");
            }
            
        }
        public static void NovOglas(List<Oglas> listaOglasa)
        {

            List<string> listaOpreme = new List<string>();
            string novaOprema;
            Console.Clear();
            Console.WriteLine("Unesite sifru oglasa");
            string novaSifra = Console.ReadLine();
            Console.WriteLine("Unesite naziv oglasa:");
            string novNaziv = Console.ReadLine();
            Console.WriteLine("Unesite cenu oglasa");
            int novaCena = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesite godiste automobila");
            int novaGodina = Int32.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Unesite dodatnu opremmu, za prekid unesite 0");
                novaOprema = Console.ReadLine();
                if (novaOprema != "0")
                {
                    listaOpreme.Add(novaOprema);
                }

            } while (novaOprema != "0");
            Oglas novOglas = new Oglas(novaSifra, novNaziv, novaCena, novaGodina, listaOpreme);
            listaOglasa.Add(novOglas);
        }
        public static void BrisanjeOglasa(List<Oglas> listaOglasa)
        {
            bool provera=false;
            int redniBrojOglasa = 0;
            Console.WriteLine("Unesite sifru oglasa za brisanje");
            string sifra = Console.ReadLine();
            for (int i = 0; i < listaOglasa.Count; i++)
            {
                if (sifra == listaOglasa[i].SifraOglasa)
                {
                    provera = true;
                    redniBrojOglasa = i;
                    break;
                }
                else
                {
                    provera = false;
                    
                }
            }
            if(provera)
            {
                listaOglasa.RemoveAt(redniBrojOglasa);
            }
            else
            {
                Console.WriteLine("Uneli ste pogresnu sifru oglasa");
            }

        }
        
        
    }
}
