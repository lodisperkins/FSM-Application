using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Application
{
    public class Test: ICondition
    {
        public int state = 1;
        bool ICondition.Evaluate()
        {
            if (state <= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
