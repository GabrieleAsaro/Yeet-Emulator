using YeetEmulator.Instructions;

namespace YeetEmulator.OpCodes.Handlers
{
	internal class Sub : YeetOpCodeHandler
	{
		public override void ExecuteInstruction(YeetCore core, YeetInstruction instr)
		{
			object y = core.VMStack.Pop();
			object x = core.VMStack.Pop();

			core.VMStack.Push((int)y - (int)x);
			core.Index++;
		}
	}
}