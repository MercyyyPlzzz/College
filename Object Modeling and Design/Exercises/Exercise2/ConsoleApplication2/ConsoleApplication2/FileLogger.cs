using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText("c:/Error.txt", error);
        }
    }
}
