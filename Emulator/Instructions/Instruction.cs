namespace Emulator.Instructions
{
    public class Instruction
    {
        public OpCodesL OpCode;
        public object Operand;

        public Instruction(OpCodesL opCodes, object operand)
        {
            OpCode = opCodes;
            Operand = operand;
        }
        public Instruction(OpCodesL opCodes)
        {
            OpCode = opCodes;
            Operand = null;
        }
    }
}