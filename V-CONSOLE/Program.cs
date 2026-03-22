using System.Text.RegularExpressions;
using V_CONSOLE.Core;
using V_CONSOLE;
using System.Runtime.ExceptionServices;

namespace V_CONSOLE
{
    internal static class Program
    {
        // Ram
        
        [STAThread]
        static void Main(string[] args)
        {
            CPU_MODULAR.SetUp();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());
        }

        static void FileToRom(string _file)
        {
            
        }

        public static void Parser(string _code)
        {
            string str = "";
            List<Token> program = new List<Token>();

            CPU_MODULAR.ClearProgram();

            Regex linePattern = new Regex( @"^[^\r\n]+", RegexOptions.Multiline );

            MatchCollection matches = linePattern.Matches(_code);

            foreach (Match match in matches)
            {
                var parts = match.Value
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    var token = new Token(part.ToUpper());
                    program.Add(token);
                    str += part + ",";
                }
            }

            CPU_MODULAR.ProgramLoad(program);
        }

        // label name in memory

        static public ushort[] ProgramToRom() {
            List<ushort> rom = new List<ushort>();

            ushort value = 0x0000;

            foreach (var token in CPU_MODULAR.GetProgram())
            {
                if (CPU_MODULAR.opcodeTable.TryGetValue(token.val, out value))
                {
                    rom.Add(value);
                }
                else if (ushort.TryParse(token.val, out ushort literal))
                {
                    rom.Add(literal);
                }
                else
                {
                    rom.Add(0xFFFF); // unknown/label placeholder
                }
            }

            return rom.ToArray();
        }

        static public void RomToPrograme(ushort[] _rom) {
            CPU_MODULAR.ClearProgram();
            List<Token> newProgram = new List<Token>();
            string file = "";

            Memory.SetMemoryAll(_rom);

            int i = 0;

            // chance in a dictory

            Dictionary<ushort, string> opcodeReverse = CPU_MODULAR.opcodeTable.ToDictionary(kv => kv.Value, kv => kv.Key);

            foreach (var rom in Memory.GetMemoryAll()) {
                Token newT = new Token(opcodeReverse[rom]);

                if (newT.val != "") { newProgram.Add(newT); }

                i++;
            }

            CPU_MODULAR.ProgramLoad(newProgram);
        }
    }
}
