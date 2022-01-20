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
            RedheadDuck readheadDuck = new RedheadDuck();
            Duck mallardDuck = new MallardDuck();
            DecoyDuck decoyDuck = new DecoyDuck();
            RubberDuck rubberDuck = new RubberDuck();

            Duck[] ducks = new Duck[] { readheadDuck, mallardDuck, decoyDuck, rubberDuck };

            foreach (var x in ducks)
            {
                Console.WriteLine(x.Swim());
                Console.WriteLine(x.Display());
                Console.WriteLine(x.performQuack());
                Console.WriteLine(x.performFly());
            }           

            Console.ReadKey();
        }
    }
}
