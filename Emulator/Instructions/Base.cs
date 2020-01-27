namespace Emulator.Instructions
{
    public abstract class Base
    {
        public abstract void ExecuteInstruction(Core core, Instruction instr);
    }
}