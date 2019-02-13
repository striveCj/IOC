using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public partial class ConsoleLogger:ILogger
    {
        public void Log(string content)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"时间{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"内容{content}");
            Console.WriteLine("------------------------------");
        }
    }
}
