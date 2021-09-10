using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2Moduo1
{
   public class Oglas
    {
        public string SifraOglasa { get; set; }
        public string NaslovOglasa { get; set; }
        public int CenaOglasa { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string[] DodatnaOprema { get; set; } = new string[5];

        public Oglas(string SifraOglasa,string NaslovOglasa, int CenaOglasa,int GodinaProizvodnje,string[] DodatnaOprema)
        {
            this.SifraOglasa = SifraOglasa;
            this.NaslovOglasa = NaslovOglasa;
            this.CenaOglasa = CenaOglasa;
            this.GodinaProizvodnje = GodinaProizvodnje;
            this.DodatnaOprema = DodatnaOprema;
        }


        public void IspisPojedinacnogOglasa(int rednibroj)
        {
            Console.WriteLine("Redni broj Oglasa: " + rednibroj + " Sifra oglasa: " +SifraOglasa + " Naslov Oglasa: " + NaslovOglasa
                    + " Cena Oglasa: " + CenaOglasa);
        }
       

        public void DodavanjeDelaOpreme (string y)
        {
            
            List<string> ls = DodatnaOprema.ToList();
            ls.Add(y);
            DodatnaOprema = ls.ToArray();
            
        }


    }
}
