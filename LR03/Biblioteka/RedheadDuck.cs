using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class RedheadDuck : Duck
    {
        public override string Display()
        {
            return "" + this.GetType() + " " + flyBehavior.GetType() + " " + quackBehavior.GetType();
        }

        public RedheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
