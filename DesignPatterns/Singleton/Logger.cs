using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger? _logger;

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if(_logger is null)
                _logger = new Logger();
            
            return _logger;
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
