using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface IDataBase
    {
        void AddToDB();
        bool scheduleOrder(string status);
    }
}
