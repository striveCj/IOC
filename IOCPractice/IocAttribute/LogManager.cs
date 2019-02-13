using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAttribute
{
    public partial class LogManager
    {
        private ILogger _logger;

        public LogManager(ILogger logger)
        {
            this._logger = logger;
        }

        public void Log(string content)
        {
            this._logger.Log(content);
        }
    }
}
