using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2Moduo1
{
    public class NizOglasa
    {
        public static void PravljenjeKonstruktoraPrekoTxtFajla(string x,List<Oglas> y)
        {
            
            StreamReader sr = File.OpenText(x);
            string s = sr.ReadToEnd();
            string[] citanje = s.Split('\n');
            for (int i = 0; i < citanje.Length; i++)
            {
                
              
                string[] deloviOglasa = citanje[i].Split(';');
               
                string[] deloviOpreme = deloviOglasa[4].Split(',');
                
                
                Oglas pOglase = new Oglas(deloviOglasa[0], deloviOglasa[1], Int32.Parse(deloviOglasa[2]), Int32.Parse(deloviOglasa[3]), deloviOpreme);
              
                y.Add(pOglase);
                
            }


            




        }
    }
}
