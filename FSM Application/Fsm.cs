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
        public void Add(State state)
        {
            if (states.Count == 0)
            {
                current = state;
                states.Add(state.Name, state);
            }
            else
            {
                states.Add(state.Name, state);
            }
        }
        public void Remove(string state)
        {
            if (states.ContainsKey(state))
            {
                states.Remove(state);
            }
            else
            {
                return;
            }
        }
        public void Switch(ICondition condition)
        {
            if(condition.Evaluate() == current.condition)
            {
                if(!states.TryGetValue(current.destinationState, out current))
                {
                    return;
                }
                else
                {
                    current = states[current.destinationState];
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
            state1.destinationState = "state2";
            state2.destinationState = "state3";
            state3.destinationState = "state1";
            state1.condition = false;
            state2.condition = false;
            state3.condition = true;
            machine.Add(state1);
            machine.Add(state2);
            machine.Add(state3);
            if
            machine.Switch(test);
        }
        State current;

    }
}
