using YeetEmulator.Instructions;

namespace YeetEmulator.OpCodes.Handlers
{
	internal class Add : YeetOpCodeHandler
	{
		public override void ExecuteInstruction(YeetCore core, YeetInstruction instr)
		{
			object x = core.VMStack.Pop();
			object y = core.VMStack.Pop();

			core.VMStack.Push((int)y + (int)x);
			core.Index++;
		}
	}
}