using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Urok_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary newDictionary = new MyDictionary();

            //WriteLine(newDictionary.Translate("Англия"));
            //WriteLine(newDictionary.Translate("Argentina"));

            //Point3D<double> p = new Point3D<double>(2.11,32.22,11.33);
            //WriteLine(p.ToString());

            //Straight<int> line = new Straight<int>(3, 4, 5, 6);
            //WriteLine(line.ToString());

            WordCounter wc = new WordCounter();
            wc.Run("This is the house that Jack built.This is the malt that lay in the house that Jack built.This is the rat that ate the maltThat lay in the house that Jack built.This is the cat that killed the ratThat ate the malt that lay in the house that Jack built.This is the dog that worried the catThat killed the rat that ate the maltThat lay in the house that Jack built.This is the cow with the crumpled hornThat tossed the dog that worried the catThat killed the rat that ate the maltThat lay in the house that Jack built.This is the maiden all forlornThat milked the cow with the crumpled hornThat tossed the dog that worried the catThat killed the rat that ate the maltThat lay in the house that Jack built.This is the man all tattered and tornThat kissed the maiden all forlorn"); 
            
            WriteLine("Press a key");
            ReadKey();
        }
    }
}
