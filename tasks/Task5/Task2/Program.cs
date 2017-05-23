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
            Dozent d = new Dozent("Sebi", "kielbasa", "asdasd", 10);

            var feld = new ILehrer[] { a, d};

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(feld, settings));

            var text = JsonConvert.SerializeObject(feld, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "object.json");
            File.WriteAllText(filename, text);

            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<ILehrer[]>(textFromFile, settings);

            for (int i = 0; i < feld.Length; i++)
            {
                Console.WriteLine(JsonConvert.SerializeObject(feld[i]));
             
            }

        }
    }
}
