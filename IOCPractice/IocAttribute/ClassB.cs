using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public class ClassB
    {
        public ClassA A { get; set; }

        public void Show()
        {
            Console.WriteLine("I am ClassB's instance !");
        }

    }
}
