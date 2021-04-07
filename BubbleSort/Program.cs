using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {

        public List<int> bubbleSort(List<int> liste)
        {
            // bubbleSort hier
            throw new NotImplementedException();
            
            return liste;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();

            List<int> nichtSortierteListe = new List<int>() { 3, 5, 1, 2 }; // erzeugen einer unsortierten Liste 
            List<int> sortierteListe = prg.bubbleSort(nichtSortierteListe); // sortieren der Liste in der Funktion 
            for (int i = 0; i < sortierteListe.Count; i++)                  // Ausgabe der sortierten Liste
            {
                Console.WriteLine(sortierteListe[i]);
            }

            Console.ReadKey();
        }

    }
}
