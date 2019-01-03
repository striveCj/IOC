using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public class ClassA
    {
        private readonly ClassB b;

        public ClassA(ClassB b)
        {
            this.b = b;
        }

        public void Show()
        {
            Console.WriteLine("I am ClassA's instance !");
        }
    }
}
