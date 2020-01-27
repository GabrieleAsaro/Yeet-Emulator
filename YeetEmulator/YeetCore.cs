using YeetEmulator.Instructions;
using System.Collections.Generic;

namespace YeetEmulator
{
    public class YeetCore
    {
        public Stack<object> VMStack { get; }
        public int Index { get; set; }

        private List<YeetInstruction> instructions;
        private Dictionary<YeetOpCodes, YeetOpCodeHandler> RegisteredHandlers;

        public YeetCore(List<YeetInstruction> instrs)
        {
            VMStack = new Stack<object>();
            instructions = instrs;
            Index = 0;
            RegisteredHandlers = new Dictionary<YeetOpCodes, YeetOpCodeHandler>();
            RegisterOpCode();
        }

        private void RegisterOpCode()
        {
            RegisteredHandlers.Add(YeetOpCodes.Add, new OpCodes.Handlers.Add());
            RegisteredHandlers.Add(YeetOpCodes.Sub, new OpCodes.Handlers.Sub());
            RegisteredHandlers.Add(YeetOpCodes.Div, new OpCodes.Handlers.Div());
            RegisteredHandlers.Add(YeetOpCodes.Mul, new OpCodes.Handlers.Mul());
            RegisteredHandlers.Add(YeetOpCodes.Ldc, new OpCodes.Handlers.Ldc());
            RegisteredHandlers.Add(YeetOpCodes.Ret, new OpCodes.Handlers.Ret());
        }

        public object Execute()
        {
            while (instructions.Count > Index)
            {
                YeetInstruction instruction = instructions[Index];
                YeetOpCodeHandler registredInstruction = RegisteredHandlers[instruction.OpCode];
                registredInstruction.ExecuteInstruction(this, instruction);
            }
            return VMStack.Count != 0 ? VMStack.Pop() : null;
        }
    }
}