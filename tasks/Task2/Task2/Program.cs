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

            Lehrer a = new Lehrer("Mathematik",35,0);

            Lehrer b = new Lehrer("Informatik",45,10);
            b.Geburtstag();
            b.allesAusgeben();
            b.Berufserfahrung = 0;
            b.allesAusgeben();
           


            //  a.allesAusgeben();
            a.allesAusgeben();
            a.Fach = "Deutsch";
            a.allesAusgeben();
            a.Geburtstag();
            a.allesAusgeben();


        }
    }
}
