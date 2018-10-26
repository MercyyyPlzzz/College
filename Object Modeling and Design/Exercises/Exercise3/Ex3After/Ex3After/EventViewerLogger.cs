using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3After
{
    class EventViewerLogger:ILogger
    {
        public void Handle(string error)
        {
            //Log errors to event viewer.
        }
    }
}
