using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Dozent : ILehrer
    {


        public string name { get; private set; }
        public string nname { get; private set; }
        public string freifach { get; private set; }
        public byte alter { get; private set; }

        public Dozent(string Name, string Nname, string Freifach, byte Alter){

            name = Name;
            nname = Nname;
            freifach = Freifach;
            alter = Alter;

            }


       public void Geburtstag()
        {
            alter++;

        }

        public void allesAusgeben()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("NName : " + nname);
            Console.WriteLine("Freifach : " + freifach);
            Console.WriteLine("Alter : " + alter);
        }

    }
}
