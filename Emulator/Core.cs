using Emulator.Instructions;
using System.Collections.Generic;

namespace Emulator
{
    public class Core
    {
        public Stack<object> VMStack;

        public int Index;
        private List<Instruction> instructions;

        private Dictionary<OpCodesL, Base> RegistredInstructions;

        public Core(List<Instruction> instrs)
        {
            VMStack = new Stack<object>();
            instructions = instrs;
            Index = 0;
            RegistredInstructions = new Dictionary<OpCodesL, Base>();
            RegisterOpCode();
        }

        private void RegisterOpCode()
        {
            RegistredInstructions.Add(OpCodesL.Add, new OpCodes.List.Add());
            RegistredInstructions.Add(OpCodesL.Sub, new OpCodes.List.Sub());
            RegistredInstructions.Add(OpCodesL.Div, new OpCodes.List.Div());
            RegistredInstructions.Add(OpCodesL.Mul, new OpCodes.List.Mul());
            RegistredInstructions.Add(OpCodesL.Ldstr, new OpCodes.List.Ldstr());
            RegistredInstructions.Add(OpCodesL.Ldc, new OpCodes.List.Ldc());
            RegistredInstructions.Add(OpCodesL.Ret, new OpCodes.List.Ret());
        }

        public object Execute()
        {
            while (instructions.Count > Index)
            {
                Instruction instruction = instructions[Index];
                Base registredInstruction = RegistredInstructions[instruction.OpCode];
                registredInstruction.ExecuteInstruction(this, instruction);
            }
            return VMStack.Count != 0 ? VMStack.Pop() : null;
        }
    }
}