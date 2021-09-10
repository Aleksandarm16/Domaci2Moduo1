using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2Moduo1
{
    public class IzmenaOglasa
    {
        public static void Izmeni(Prodavnica x)
        {
            int izmena;
            bool provera = false;
            int redniBrojOglasa=0;
            string izmenaSifra;
            Console.WriteLine("Unesite sifru vozila koje zelite da izmenite:");
            izmenaSifra = Console.ReadLine();
            for (int i = 0; i <x.ProdavnicaAuta.Count; i++)
            {
                if (izmenaSifra == x.ProdavnicaAuta[i].SifraOglasa)
                {
                    provera = true;
                    redniBrojOglasa = i;
                    break;
                }
                else          
                    provera = false;
                    
               
                    
            }
            if (provera)
            {
                Console.WriteLine("Sta zelite da izmenite?");
                Console.WriteLine("Za izmenu osnovnih detalja pritisnite 1");
                Console.WriteLine("Za izmenu opreme vozila pritisnite 2");
                izmena = Int32.Parse(Console.ReadLine());
                if (izmena == 1)
                {
                    int izmenaosnovna;
                    Console.WriteLine("Sta zelite da izmenite:");
                    Console.WriteLine("1.Naslov");
                    Console.WriteLine("2.Cena");
                    Console.WriteLine("3.Godina Proizvodnje");
                    izmenaosnovna = Int32.Parse(Console.ReadLine());
                    if (izmenaosnovna == 1)
                    {
                        string noviNaslov;
                        Console.WriteLine("Unesite novi naslov oglasa:");
                        noviNaslov = Console.ReadLine();
                        x.ProdavnicaAuta[redniBrojOglasa].NaslovOglasa = noviNaslov;

                    }
                    else if (izmenaosnovna == 2)
                    {
                        int novaCena;
                        Console.WriteLine("Unesite novu cenu za oglas");
                        novaCena = Int32.Parse(Console.ReadLine());
                        x.ProdavnicaAuta[redniBrojOglasa].CenaOglasa = novaCena;
                    }
                    else if (izmenaosnovna == 3)
                    {
                        int novaGodina;
                        Console.WriteLine("Unesite novu godinu proizvodnje");
                        novaGodina = Int32.Parse(Console.ReadLine());
                        x.ProdavnicaAuta[redniBrojOglasa].GodinaProizvodnje=novaGodina;
                    }
                    else
                        Console.WriteLine("Pogresno ste uneli aj opet xD");
                }
                else if (izmena == 2)
                {
                    Console.WriteLine("Od opreme automobil ima:");
                    for (int i = 0; i < x.ProdavnicaAuta[redniBrojOglasa].DodatnaOprema.Count; i++)
                    {
                        Console.WriteLine(i+1+" "  + x.ProdavnicaAuta[redniBrojOglasa].DodatnaOprema[i]);
                    }
                    Console.WriteLine("Izaberite sta zelite da izmenite");
                    int redniBrojOpreme;
                    redniBrojOpreme = Int32.Parse(Console.ReadLine());
                    if (redniBrojOpreme>=0 && redniBrojOpreme<=5)
                    {
                        Console.WriteLine("Unesite izmenjenu vrednost opreme");
                        string izmenaOprema;
                        izmenaOprema = Console.ReadLine();
                        x.ProdavnicaAuta[redniBrojOglasa].DodatnaOprema[redniBrojOpreme - 1] = izmenaOprema;

                    }
                    else
                    {
                        Console.WriteLine("Uneli ste pogresno");
                    }
                }
                else
                {
                    Console.WriteLine("Pogresan unos!");
                }
            }
            else
                Console.WriteLine("Pogresna sifra!");
        }
    }
}
