using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Order: IDataBase
    {
        private string OrdType;
        public string OrderType
        {
            get { return OrdType; }
        }
        private DateTime orderDate;
        private DateTime scheduledShipDate;
       private enum Priority { Rush, Standard, Low, None };        

       public Order()
        {
            orderDate = DateTime.Now;
        }
 
        public bool scheduleOrder(string status)
        {
            int leadtime=30;
            for (Priority ordPri = Priority.Rush; ordPri <= Priority.None;
                 ordPri++)
            {
                if (status == ordPri.ToString())
                {
                    if (ordPri == Priority.Rush)
                        leadtime = 7;
                    else if (ordPri == Priority.Standard)
                        leadtime = 14;
                    else if (ordPri == Priority.Low)
                        leadtime = 30;
                    else if (ordPri == Priority.None)
                            {
                                OrdType = ordPri.ToString();
                                return false; // Business rule not allowed schedule an order with no priority
                            }
                    OrdType = ordPri.ToString();
                    scheduledShipDate = DateTime.Now.AddDays(leadtime);
                }
            } 
            return true;
        }


        //Done
        //Single Responsibility Principle 
        private FileLogger obj = new FileLogger();
        public virtual void AddToDB()
        {
            try
            {
                // Will call a DAL API here later.
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());// write to event viewer
            }
        }
    }
}