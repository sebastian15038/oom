using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Lehrer : ILehrer
    {

       
        private byte alter;
        private byte berufserfahrung; 
        private bool berufserfahren;


        public Lehrer(string Fach, byte alter, byte berufserfahrung)
        {
            if (string.IsNullOrWhiteSpace(Fach)) throw new ArgumentException("Fach darf nicht leer sein!\n");
            if (alter < 0) throw new ArgumentOutOfRangeException("Alter darf nicht < 0 sein!\n");
            if (berufserfahrung < 0) throw new ArgumentOutOfRangeException("Berufserfahrung darf nicht <0 sein");
            fach = Fach;
            this.alter = alter;
            this.berufserfahrung = berufserfahrung;
            berufserf();        
        }

        public string fach { get; private set; }


        public byte Berufserfahrung
        {
            set
            {
                if (value <= 0) throw new ArgumentException("Nur Lehrer mit Berufserfahrung!\n");
                berufserfahrung = value;
                berufserf();
            }
            get
            {
                return berufserfahrung;
            }
        }

        public void Geburtstag()
        {
            alter++;
            berufserfahrung++;
            berufserf();
        }

           
        public void berufserf()
        {
            if(berufserfahrung > 0)
            {
                berufserfahren = true;
            }else
            {
                berufserfahren = false;
            }

        }

        public void allesAusgeben()
        {
            Console.WriteLine("Fach : "+fach);
            Console.WriteLine("Alter : " +alter);
            Console.WriteLine("Berufserfahrung : "+berufserfahrung);
            Console.WriteLine("Berufserfahren : " +berufserfahren);
            Console.WriteLine("\n");
        }



    }
}
