using DoItYourselfIoC.DiYIoC;
using DoItYourselfIoC.Models;
using DoItYourselfIoC.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoItYourselfIoC.Presentation.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiyIoC.Register<ILogger>(new ConsoleLogger());
            ILogger logger = DiyIoC.Resolve<ILogger>();

            //end user
            logger.Log("Hello DiyIoc");
            Console.ReadLine();
        }
    }
}
