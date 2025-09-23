# Yeet Emulator [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)

## 📜 Why do you need Yeet Emulator

You can easily understand how to make a virtualization like Eazfuscator.

## 💥 What does it do

- [x] Emulate IL Code
- [x] Easy to add more functions
- [x] Easy to understand

### Example
```C#
private static void Main(string[] args) {

    List<Instruction> instruction = new List<Instruction>
	{
	    new Instruction(OpCodesL.Ldc, 4),
	    new Instruction(OpCodesL.Ldc, 2),
	    new Instruction(OpCodesL.Add),
	    new Instruction(OpCodesL.Ret)
	};

        Core core = new Core(instruction);

        Console.WriteLine(core.Execute());
        Console.ReadLine();
        
}
```
