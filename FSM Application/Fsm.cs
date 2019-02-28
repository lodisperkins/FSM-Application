using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Application
{
    class Fsm
    {
        private Dictionary<string, State> states;
        public void Add(State state) { }
        public void Remove(State state) { }
        public void Switch(ICondition condition) { }
        State current;

    }
}
