using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWapp
{
    public class CompositionRoot : ICompositionRoot
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
