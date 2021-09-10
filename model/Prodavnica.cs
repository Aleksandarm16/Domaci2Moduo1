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
        public Prodavnica(Oglas pOglas)
        {
            ProdavnicaAuta.Add(pOglas);
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
                    for (int j = 0; j < ProdavnicaAuta[i].DodatnaOprema.Length; j++)
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
                for (int j = 0; j < ProdavnicaAuta[i].DodatnaOprema.Length; j++)
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
        public void NoviSkupOpreme (string sifra, string oprema)
        {
            int redniBroj = 0;
            List<string> novaOprema = new List<string>();
            for (int i = 0; i < ProdavnicaAuta.Count; i++)
            {
                if(ProdavnicaAuta[i].SifraOglasa==sifra)
                {
                    redniBroj = i;
                    novaOprema = oprema.Split(';').ToList();
                }
            }
            for (int i = 0; i < novaOprema.Count; i++)
            {
                ProdavnicaAuta[redniBroj].DodatnaOprema[i] = novaOprema[i];
            }
        }
    }
}
