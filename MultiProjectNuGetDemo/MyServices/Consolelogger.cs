using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyServices
{
    public class Consolelogger : ILoggerService
    {
        public void log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
