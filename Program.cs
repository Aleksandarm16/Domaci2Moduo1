using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2Moduo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oglas[] ProdavnicaAutomobila=new Oglas[50];
            string[] DodatnaOprema1 = { "ABS", "ESP", "alarm", "DVD", "klima" };
            string[] DodatnaOprema2 = { "servo volan", "putni računar", "tempomat", "zatamljena stakla"};
            string[] DodatnaOprema3 = { "ABS", "alarm", "CD", "DVD", "Parking Senzor" };
            ProdavnicaAutomobila[0] = new Oglas("0001", "Reno Klio", 2000, 2012, DodatnaOprema1);
            ProdavnicaAutomobila[1] = new Oglas("0002", "Golf IV", 1000, 2001,DodatnaOprema2);
            ProdavnicaAutomobila[2] = new Oglas("0003", "Dacia", 3000, 2019, DodatnaOprema3);
            ProdavnicaAutomobila[3] = new Oglas("0004", "Nisan", 2500, 2012, DodatnaOprema1);

            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;
                ProdavnicaAutomobila[i].IspisOglasa(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ispis to godini proizvodnje:");
            int GodinaProizvodnje = 2012;
            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;
                if (ProdavnicaAutomobila[i].GodinaProizvodnje == GodinaProizvodnje)
                    ProdavnicaAutomobila[i].IspisOglasa(i);

            }
            Console.WriteLine("\n");
            Console.WriteLine("Ispis celog oglasa:");
            ProdavnicaAutomobila[2].IspisCelogOglasa();
            Console.WriteLine("\n");
            ProdavnicaAutomobila[2].CenaOglasa = 5500;
            ProdavnicaAutomobila[2].SifraOglasa = "0010";
            ProdavnicaAutomobila[2].NaslovOglasa = "Hyndai";
            ProdavnicaAutomobila[2].DodatnaOprema = new string[5] { "ABS","Alarm", "CD", "airbag", "klima" };
            Console.WriteLine("Menjanje parametra u oglasu redni broj 2:");
            ProdavnicaAutomobila[2].IspisCelogOglasa();
            Console.WriteLine("\n");
            Console.WriteLine("Oglasi u rangu 2000-3000");
            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;
                if (ProdavnicaAutomobila[i].CenaOglasa <= 3000 && ProdavnicaAutomobila[i].CenaOglasa >= 2000)
                {
                   
                    ProdavnicaAutomobila[i].IspisOglasa(i);
                }
              

            }
            Console.WriteLine("\n");
            Console.WriteLine("Oglasi jeftiniji od 5000");
            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;
               
              
                else if (ProdavnicaAutomobila[i].CenaOglasa < 5000)
                {
                    
                    ProdavnicaAutomobila[i].IspisOglasa(i);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Oglasi skuplji od 5000");
            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;


                else if (ProdavnicaAutomobila[i].CenaOglasa > 5000)
                {

                    ProdavnicaAutomobila[i].IspisOglasa(i);
                }

            }
            Console.WriteLine("\n");
            string[] Oprema = new string[] { "ABS","DVD"};
            int duzina = Oprema.Length;
            int tmp = 0;
            Console.WriteLine("Oglasi koji odgovara trazenom kriterijumu su: ");
            for (int i = 0; i < ProdavnicaAutomobila.Length; i++)
            {
                if (ProdavnicaAutomobila[i] == null)
                    break;
                for (int j = 0; j < ProdavnicaAutomobila[i].DodatnaOprema.Length; j++)
                {
                   
                    for (int k = 0; k < Oprema.Length; k++)
                    {
                        if (Oprema[k] == null)
                            break;
                        if(ProdavnicaAutomobila[i].DodatnaOprema[j]==Oprema[k])
                        {
                            tmp++;
                            if (tmp == duzina)
                            {                                
                                ProdavnicaAutomobila[i].IspisOglasa(i);
                                tmp = 0;
                            }
                            
                        }

                    }

                }

            }
            Console.WriteLine("\nDefinisanje novog skupa:");
            ProdavnicaAutomobila[0].IspisCelogOglasa();
            ProdavnicaAutomobila[0].DodatnaOprema = new string[] {"airbag","DVD","Klima","Cd","Servo","maglenke"};
            ProdavnicaAutomobila[0].IspisCelogOglasa();

            Console.WriteLine("\nDodavanje opreme (putni racnuar)");
            ProdavnicaAutomobila[0].IspisCelogOglasa();
            ProdavnicaAutomobila[0].DodavanjeDelaOpreme("putni racunar");
            ProdavnicaAutomobila[0].IspisCelogOglasa();




            Console.ReadKey();
        }
    }
}
