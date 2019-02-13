using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public class ClassC
    {
        public string Name { get; set; }

        public ClassD D { get; set; }

        public void Show()
        {
            Console.WriteLine("I am ClassC's instance !" + Name);
        }
    }
}
