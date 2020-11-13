using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10
{
    public class IndexerTest
    {
        private Hashtable myFavorite = new Hashtable();

        public string this[string kind]
        {
            get { return (string)myFavorite[kind]; }
            set { myFavorite[kind] = value; }
        }
    }



    public class Test
    {
        
        public static void Main(string[] args)
        {
            IndexerTest it = new IndexerTest();
            it["fruit"] = "apple";
            it["color"] = "blue";
            System.Console.WriteLine(it["fruit"]);
            System.Console.WriteLine(it["color"]);

        }
    }
}
