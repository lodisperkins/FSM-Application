using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Application
{
    class State
    {
        private string name;
        public string Name { get; set; }
        private string transition_state;
        public string transition_State { get; set; }
        public State(string newName)
        {
            name = newName;
        }
        public State() { }
        
    }
}
