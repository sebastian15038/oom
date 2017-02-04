using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Lehrer
    {
        private string fach;
        private UInt16 alter;
        private UInt16 berufserfahrung; 
        private bool berufserfahren;

        public Lehrer(string fach, UInt16 alter, UInt16 berufserfahrung)
        {
            if (string.IsNullOrWhiteSpace(fach)) throw new ArgumentException("Fach darf nicht leer sein!\n");
            if (alter < 0) throw new ArgumentOutOfRangeException("Alter darf nicht < 0 sein!\n");
            if (berufserfahrung < 0) throw new ArgumentOutOfRangeException("Berufserfahrung darf nicht <0 sein");
            this.fach = fach;
            this.alter = alter;
            this.berufserfahrung = berufserfahrung;
            berufserf();        
        }

        public string Fach
        {
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Fach darf nicht leer sein!\n");
                fach = value;
            }
            get
            {
                return fach;
            }

        }

        public UInt16 Berufserfahrung
        {
            set
            {
                if (value < 0) throw new ArgumentException("Nur Lehrer mit Berufserfahrung!\n");
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
