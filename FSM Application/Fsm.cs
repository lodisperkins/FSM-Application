using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace FSM_Application
{
    public class Fsm
    {
      
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
         
        public void Switch(ICondition condition)
        {
            Dictionary<string, State> statesDictionary = new Dictionary<string, State>();
            foreach (var state in statesList)
            {
                statesDictionary.Add(state.Name, state);
            }
            if(condition.Evaluate() == current.condition)
            {
                if(!statesDictionary.TryGetValue(current.destinationName, out current))
                {
                    return;
                }
            }
            else
            {
                return;
            }
            
        }
        public void test()
        {
            Test test = new Test();
            Fsm machine = new Fsm();
            State state1 = new State();
            State state2 = new State();
            State state3 = new State();
            state1.Name = "state1";
            state2.Name = "state2";
            state3.Name = "state3";
            state1.destinationName = "state2";
            state2.destinationName = "state3";
            state3.destinationName = "state1";
            state1.condition = false;
            state2.condition = false;
            state3.condition = true;
            machine.Add(state1);
            machine.Add(state2);
            machine.Add(state3);
            for (test.state =1; test.state<= 4; test.state++)

            {
                machine.Switch(test);
            }

        }
        public State current;

    }
}
