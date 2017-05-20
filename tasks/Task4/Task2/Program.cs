using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Lehrer a = new Lehrer("Mathematik",35,1);
            Lehrer c = new Lehrer("Infomartik", 11, 2);

            var feld = new ILehrer[] { a, c};

            for(int i = 0; i < feld.Length; i++)
            {
                string s = JsonConvert.SerializeObject(feld[i]);
                Console.WriteLine(s);
                feld[i] = JsonConvert.DeserializeObject<Lehrer>(s);
                feld[i].allesAusgeben();
            }

            
            

            


        }
    }
}
