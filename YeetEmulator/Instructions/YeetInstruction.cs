namespace YeetEmulator.Instructions
{
    public class YeetInstruction
    {
        public YeetOpCodes OpCode { get; }
        public object Operand { get; }

        public YeetInstruction(YeetOpCodes opCodes, object operand)
        {
            OpCode = opCodes;
            Operand = operand;
        }
        public YeetInstruction(YeetOpCodes opCodes)
        {
            OpCode = opCodes;
            Operand = null;
        }
    }
}