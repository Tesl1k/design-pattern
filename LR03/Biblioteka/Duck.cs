using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    abstract public class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public string Swim()
        {
            return "Swim" + " " + this.GetType();
        }

        public string performQuack()
        {
           return quackBehavior.quack();
        }

        public string performFly()
        {
            return flyBehavior.Fly();
        }

        public abstract string Display();
    }
}
