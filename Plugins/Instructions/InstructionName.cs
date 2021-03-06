﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobalt.Components.CrmIQ.Plugin.Instructions
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class InstructionName : System.Attribute
    {
        public InstructionName(string instruction)
        {
            this.Instruction = instruction;
        }
        public string Instruction { get; private set; }
    }
}
