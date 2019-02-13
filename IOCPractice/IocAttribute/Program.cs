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
            var builder = new ContainerBuilder();
            builder.RegisterType(typeof(LogManager));
            builder.RegisterType(typeof(ConsoleLogger)).As(typeof(ILogger));
            //builder.RegisterType(typeof(TextLogger)).As(typeof(ILogger));

            using (var container = builder.Build())
            {
                var logManager = container.Resolve<LogManager>();
                logManager.Log("日志记录...");
            }
            Console.WriteLine("日志完毕");
            Console.ReadKey();
        }
    }
}
