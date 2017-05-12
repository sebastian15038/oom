using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Lehrer a = new Lehrer("Mathematik",35,1);    
            Dozent sebi = new Dozent("Sebi", "Kielbasa", "Mathematik", 12);

            var feld = new ILehrer[] { a, sebi};

            for(int i = 0; i < feld.Length; i++)
            {
                feld[i].allesAusgeben();
            }

        }
    }
}
