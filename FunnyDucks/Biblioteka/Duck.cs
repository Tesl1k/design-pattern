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
            return "Буль буль буль";
        }

        public string performQuack()
        {
           return quackBehavior.quack();
        }

        public string performFly()
        {
            return flyBehavior.Fly();
        }

        public FlyBehavior SetFlyBehavior
        {
            get
            {
                return flyBehavior;
            }

            set
            {
                flyBehavior = value;
            }
        }

        public QuackBehavior SetQuackBehavior
        {
            get
            {
                return quackBehavior;
            }

            set
            {
                quackBehavior = value;
            }
        }       


        public abstract string Display();
    }
}
