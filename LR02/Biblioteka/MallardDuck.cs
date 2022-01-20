using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class MallardDuck : Duck, Quackable, Flyable
    {
        public override string Display()
        {
            return "Display" + " " + this.GetType();
        }

        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }

        public string Fly()
        {
            return "Fly" + " " + this.GetType();
        }
    }
}
