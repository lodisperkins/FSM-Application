using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Application
{
    public class State
    {
        private string name;
        public string Name
        { get
            { return name; }
          set
            { name = value; }
        }
        public string destinationName;
        public State() { }
        public State(string stateName, string destination)
        {
            name = stateName;
            this.destinationName = destination;
        }
        public bool condition;
        public State destinationState;
    }
}
