using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public partial class TextLogger : ILogger
    {
        private string _logPath = ConfigurationManager.AppSettings["logpath"];
        public void Log(string content)
        {
            using (var writer = new StreamWriter(_logPath, true, Encoding.UTF8))
            {
                writer.WriteLine("-------------------------------------------------");
                writer.WriteLine("时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteLine("内容：" + content);
                writer.WriteLine("-------------------------------------------------");
            }
        }
    }
}
