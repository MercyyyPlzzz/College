using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3After
{
    class Executive : StaffMember
    {
        public Executive()
        {
            //Code to Initialise
        }

        public override double pay()
        {
            return base.getPayRate()+base.getBonus();
        }
    }
}
