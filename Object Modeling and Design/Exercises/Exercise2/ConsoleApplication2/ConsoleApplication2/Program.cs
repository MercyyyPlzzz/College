using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDataBase> orderList = new List<IDataBase>();
            for (int i = 0; i <= 3; i++)
            {
                orderList.Add(new Order()); // create the orders
               
            }
            // schedule the orders and add to DB where appropriate
            if (orderList[0].scheduleOrder("Low"))
                orderList[0].AddToDB();
            else
                System.IO.File.WriteAllText(@"c:\OrderAdministratorLog.txt", "");

            if (orderList[1].scheduleOrder("Standard"))
                orderList[1].AddToDB();
            else
                System.IO.File.WriteAllText(@"c:\OrderAdministratorLog.txt", "");

            if (orderList[2].scheduleOrder("Rush"))
                orderList[2].AddToDB();
            else
                System.IO.File.WriteAllText(@"c:\OrderAdministratorLog.txt", "");

            if (orderList[3].scheduleOrder("None"))
                orderList[3].AddToDB();
            else
                System.IO.File.WriteAllText(@"c:\OrderAdministratorLog.txt", "");
           

        }
    }
}
