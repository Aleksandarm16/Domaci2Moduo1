using System;
using System.Collections.Generic;
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

        public void IspisOglasa (int x)
        {
            Console.WriteLine("Redni broj Oglasa: "+ x +" Sifra oglasa: "+SifraOglasa+" Naslov Oglasa: "+NaslovOglasa+" Cena Oglasa: "+CenaOglasa );
        }
        public void IspisCelogOglasa()
        {
            Console.WriteLine("Sifra Oglasa: "+SifraOglasa+" Naslov Oglasa: "+ NaslovOglasa+ " Cena Oglasa: "+CenaOglasa);
            Console.WriteLine("Od dodatne opreme ima: ");
            for (int i = 0; i < DodatnaOprema.Length; i++)
                Console.Write(DodatnaOprema[i] + " ");
            Console.WriteLine();
        }

        public void DodavanjeDelaOpreme (string y)
        {
            
            List<string> ls = DodatnaOprema.ToList();
            ls.Add(y);
            DodatnaOprema = ls.ToArray();
            
        }


    }
}
