using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3After
{
    class Volunteer : StaffMember
    {
        public Volunteer()
        {
            //Code to Initialise
        }

        public override double pay()
        {
            return base.getPayRate() + 0;
        }
    }
}
