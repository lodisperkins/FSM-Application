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
        //The name of the state
        public string Name
        { get
            { return name; }
          set
            { name = value; }
        }
        //The name of the state that the current state will be transferrring to
        public string destinationName;
        public State() { }
        public State(string stateName, string destination)
        {
            name = stateName;
            this.destinationName = destination;
        }
        //Condition on which the state should switch
        public bool condition;
    }
}
