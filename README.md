<p align="center">
    <img width="500" height="500" src="https://i.imgur.com/kDkwJB9.png" alt="Yeet Emulator">
</p>

<p align="center">
    <a href="https://github.com/NotAccursed/Yeet-Emulator/issues">Contribution guide</a>&nbsp;&nbsp;&nbsp;
    <a href="https://twitter.com/NAccursed">Twitter</a>&nbsp;&nbsp;&nbsp;
    <a href="https://discordapp.com/invite/f55n5tM">Discord</a>&nbsp;&nbsp;&nbsp;
    <a href="https://t.me/notaccursedtelegram">Telegram</a>&nbsp;&nbsp;&nbsp;
</p>

<br>

<br>

<p align="center">
  <sub>Built with ❤︎ by <a href="https://twitter.com/NAccursed">NotAccursed</a></sub>
</p>
<br>

# Yeet Emulator [![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)


# 📜 Why do you need Yeet Emulator ?

You can easily understand how to make a virtualization like Eazfuscator.

# 💥 What does it do ?

- [x] Emulate IL Code
- [x] Easy to add more functions
- [x] Easy to understand

## Example
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
