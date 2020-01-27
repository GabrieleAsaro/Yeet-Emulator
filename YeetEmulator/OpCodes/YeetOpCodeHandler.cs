namespace YeetEmulator.Instructions
{
    public abstract class YeetOpCodeHandler
    {
        public abstract void ExecuteInstruction(YeetCore core, YeetInstruction instr);
    }
}