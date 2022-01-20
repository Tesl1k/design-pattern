using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class RubberDuck : Duck
    {
        public override string Display()
        {
            return "" + this.GetType() + " " + flyBehavior.GetType() + " " + quackBehavior.GetType();
        }

        public RubberDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
    }
}
