﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Application
{
    class State
    {
        private string name;
        public string Name
        { get
            { return name; }
          set
            { name = value; }
        }
        public string destinationState;
        public State() { }
        public bool condition;
    }
}