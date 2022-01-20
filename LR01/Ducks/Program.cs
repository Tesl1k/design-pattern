using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck readheadduck = new RedheadDuck();
            MallardDuck mallardduck = new MallardDuck();

            Duck[] ducks = new Duck[] { readheadduck, mallardduck };

            foreach (var x in ducks)
            {
                Console.WriteLine(x.Swim());
                Console.WriteLine(x.Display());
                Console.WriteLine(x.Quack());
            }

            Console.ReadKey();
        }
    }
}
