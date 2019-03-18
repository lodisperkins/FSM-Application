using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace FSM_Application

{
    //Stores all of the states that are to be written to a file
    public class Fsm 
    {
        
        public delegate bool evaluate();
        public List<State> statesList = new List<State>();
        public void Add(State state)
        {
            if (statesList.Count == 0)
            {
                current = state;
                statesList.Add(state);
            }
            else
            {
                statesList.Add(state);
            }
        }
         
        public void Switch()
        {
            Dictionary<string, State> statesDictionary = new Dictionary<string, State>();
            foreach (var state in statesList)
            {
                statesDictionary.Add(state.Name, state);
            }
          
            if(!statesDictionary.TryGetValue(current.destinationName, out current))
            {
                return;
            }
            else
            {
                return;
            }
            
        }
        public State current;

    }
}
