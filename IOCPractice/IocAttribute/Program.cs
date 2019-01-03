using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace IocAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();

            //builder.Register(n => new ClassC { D = n.Resolve<ClassD>(), Name = "Sniper" });
            //builder.RegisterType<ClassD>();

            //var container = builder.Build();

            //var c = container.Resolve<ClassC>();
            //c.Show();
            //c.D.Show();
        }
    }
}
