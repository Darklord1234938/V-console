using System;

namespace V_CONSOLE.Core
{
    public static class CPU_MODULAR
    {
        // Opcode
        static public Dictionary<string, ushort> opcodeTable = new Dictionary<string, ushort>()
        {
            // BASIC
            { "MOVE", 0x0001},
            { "LOAD", 0x0002},
            { "STORE", 0x0003},
            { "SWAP", 0x0004},
            { "CLEAR", 0x0005},
            
            // MATH
            { "ADD", 0x0006},
            { "SUB", 0x0007},
            { "MULTI", 0x0008},
            { "DIV", 0x0009},
            { "MOD", 0x000A},
            { "INC", 0x000B},
            { "DEC", 0x000C},

            // CONTROL FLOW
            { "JUMP", 0x000D},
            { "JZERO", 0x000E},
            { "NOTJZ", 0x000F},
            { "JCARRY", 0x0010},
            { "NOTJC", 0x0011},
            { "JNEG", 0x0012},
            { "NOTJN", 0x0013},
            { "JOVER", 0x0014},
            { "NOTJO", 0x0015},
            { "CALL", 0x0016},
            { "RET", 0x0017},
            { "HALT", 0x0018},

            // BITWISE
            { "AND", 0x0019},
            { "OR", 0x001A},
            { "XOR", 0x001B},
            { "NOT", 0x001C},
            { "SHIFTL", 0x001D},
            { "SHIFTR", 0x001E},

            // DRAW
            { "PIX", 0x001F},
            { "LINE", 0x0020},
            { "SQUAR", 0x0021},
            { "DRAW", 0x0022},
            { "CLS", 0x0023},
            { "SPR", 0x0024},

            // INPUT
            { "INPUT", 0x0025},
            { "SOUND", 0x0026},
            { "SND", 0x0027},
            { "WAIT", 0x0028},
            
            // FLAGS
            { "CLEARC", 0x0029},
            { "CLEARO", 0x002A},

            // EXTRA
            { "NOP", 0x002B},

            // HARDWARE
            { "A", 0x002C},
            { "B", 0x002D},
            { "C", 0x002E},
            { "$", 0x002F},

            { "END", 0x0030},
        };

        // Regis
        static public Dictionary<string, ushort> regis = new Dictionary<string, ushort>(){
            { "0x002C", 0},
            { "0x002D", 0},
            { "0x002E", 0},
        };

        // Program Counter
        static public int pc;

        // Flag 
        static bool z; // Zero Flag 
        static bool c; // Carry Flag if add is above 65535, sub lower then zero, 
        static bool n; // Negative Flag 
        static bool o; // Overflow Flag if the overflow, if bit 15 is 1

        static bool l; // Loop Flag 
        static bool r; // Running Flag 

        // Program
        static public Dictionary<string, ushort> labels = new Dictionary<string, ushort>();
        static public Stack<int> rememberI = new Stack<int>();
        static List<Token> program = new List<Token>();

        static public void SetUp() {
            r = true;

            regis["0x002C"] = 0;
            regis["0x002D"] = 0;
            regis["0x002E"] = 0;

            Console.WriteLine("HELOO FORM ASM");
        }

        // State Flow
        static Token Advance() { pc++; return Peek(); }

        static public Token Peek() { return new Token($"0x{ROM.GetMemoryAddr(pc).ToString("X4")}"); }

        // Flag Funcs
        static void IsZero(string _regi) { z = regis[_regi] == 0; }
        static public bool GetZero() {  return z; }

        static void IsCarry(string _regi) {  }
        static public bool GetCarry() { return c; }

        static void IsNegative(string _regi) { }
        static public bool GetNegative() { return n; }

        static void IsOverflow(string _regi) { }
        static public bool GetOverflow() { return o; }

        static public bool GetLoop() { return l; }

        static public bool GetRunning() { return r; }

        static public void Interperter()
        {
            while (pc < ROM.GetMemoryAll().Length && r)
            {
                if (!l)
                {
                    switch (Peek().val)
                    {
                        // DO NOT WORK WITH NORMAL NUMS

                        // MEMORY
                            case "0x0001": /* MOVE - DONE */ Move(); break;
                            case "0x0002": /* LOAD - DONE */ Load(); break;
                            case "0x0003": /* STORE - DONE */ Store(); break;
                            case "0x0004": /* SWAP - DONE */ Swap(); break;
                            case "0x0005": /* CLEAR - DONE */ Clear(); break;

                        // MATH
                            case "0x0006": /* ADD - DONE */ Add(); break;
                            case "0x0007": /* SUB - DONE */ Sub(); break;
                            case "0x0008": /* MULTI - DONE */ Multi(); break;
                            case "0x0009": /* DIVI - DONE */ Div(); break;
                            case "0x000A": /* MOD - DONE */ Mod(); break;
                            case "0x000B": /* INC - DONE */ Inc(); break;
                            case "0x000C": /* DEC - DONE */ Dec(); break;

                        // CONTROLFLOW
                            case "0x000D": /* JUMP - DONE */ Jump(); break;
                            case "0x000E": /* JZERO - DONE */ if (z) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x000F": /* NOTJZ - DONE */ if (!z) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0010": /* JCARRY - DONE */ if (c) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0011": /* NOTJC - DONE */ if (!c) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0012": /* JNEG - DONE */ if (n) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0013": /* NOTJN - DONE */ if (!n) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0014": /* JOVER - DONE */ if (o) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0015": /* NOTJO - DONE */ if (!o) { Jump(); } else { Advance(); Advance(); } break;
                            case "0x0016": /* CALL - DONE */ rememberI.Push(pc + 1); Jump(); break;
                            case "0x0017": /* RET - DONE */ if (rememberI.Count > 0) { Advance(); pc = rememberI.Pop(); } break;
                            case "0x0018": /* HALT - DONE */ r = false; break;

                        // BITWISE OPR
                            case "0x0019": /* AND - DONE */ And(); break;
                            case "0x001A": /* OR - DONE */ Or(); break;
                            case "0x001B": /* XOR - DONE */ Xor(); break;
                            case "0x001C": /* NOT - DONE */ Not(); break;
                            case "0x001D": /* SHIFTL - DONE */ ShiftL(); break;
                            case "0x001E": /* SHIFTR - DONE */ ShiftR(); break;

                        // DO NOT WORK
                        // DRAW
                        case "0x001F": // PIX
                            Advance();
                            if (regis.ContainsKey(Peek().val)) {
                                int x = regis[Peek().val];
                                Console.WriteLine($"PIXEL X: {x}");

                                Advance();
                                if (regis.ContainsKey(Peek().val)) {
                                    int y = regis[Peek().val];
                                    Console.WriteLine($"PIXEL Y: {y}");

                                    Advance();
                                    if (regis.ContainsKey(Peek().val))
                                    {
                                        ushort c = regis[Peek().val];

                                        GPU_MODULAR.SetPixel(y * 128, x, c);
                                        Console.WriteLine($"PIXEL COLOR: {c}");

                                        Advance();
                                    }
                                }
                            }
                            break;
                        // Line - 0x0020,
                        // Squar - 0x0021,
                        // Draw - 0x0022,
                        case "0x0023": // CLS
                            Advance();

                            GPU_MODULAR.Clear();
                            
                            break;
                        // Spr - 0x0024,

                        // Input - 0x0025,
                        // Sound - 0x0026,
                        // Snd - 0x0027,
                        // Wait - 0x0028,

                        // Flags
                        case "0x0029": /* ClearC - DONE */ Advance(); c = false; break;
                        case "0x002A": /* ClearO - DONE */ Advance(); o = false; break;

                        // Extra
                        case "0x002B": /* NOp - DONE */ Advance(); break;

                        default:
                            Advance();
                            break;

                    }
                }
                else
                {
                    if (Peek().val == "0x0031")
                    {
                        l = false;
                    }
                    else
                    {
                        break;
                    }
                    Advance();
                }
            }
        }

        // MEMORY
        static private void Move() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Advance();
                Console.WriteLine("REGI: " + Peek().val);

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {

                    string r2 = Peek().val;

                    regis[r2] = regis[r1];

                    Console.WriteLine("NOW: " + regis[r2]);
                    Advance();
                }
            }
        }
        static private void Load() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val)) {

                string r1 = Peek().val;

                Advance();
                Console.WriteLine("MEMORY: " + Peek().val);

                if (Convert.ToUInt32(Peek().val, 16) == opcodeTable["$"]) {
                    Advance();

                    if (Peek().val != null) {

                        int i = Convert.ToInt32(Peek().val, 16);

                        regis[r1] = (ushort)i;

                        Console.WriteLine("NOW: " + regis[r1]);
                        Advance();
                    }
                } else if (Peek().val != null) {

                    int m = Convert.ToInt32(Peek().val, 16);

                    regis[r1] = Memory.GetMemoryAddr(m);

                    Console.WriteLine("NOW: " + Memory.GetMemoryAddr(m));
                    Advance();
                }
            }
        }
        static private void Store() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val)) {

                string r1 = Peek().val;

                Advance();
                Console.WriteLine("MEMORY: " + Peek().val);

                if (Peek().val != null)
                {
                    ushort m = (ushort)Convert.ToInt32(Peek().val, 16);

                    Memory.SetMemoryAddr(m, regis[r1]);

                    Console.WriteLine("NOW: " + Memory.GetMemoryAddr(m));
                    Advance();
                }
            }
            else if (Convert.ToUInt32(Peek().val, 16) == opcodeTable["$"])
            {
                Advance();

                if (Peek().val != null) {
                    int i = Convert.ToInt32(Peek().val, 16);

                    Console.WriteLine("INT: " + Peek().val);
                    Advance();
                    
                    if (Peek().val != null) {
                        ushort m = (ushort)Convert.ToInt32(Peek().val, 16);

                        Memory.SetMemoryAddr(m, (ushort)i);

                        Console.WriteLine("NOW: " + Memory.GetMemoryAddr(m));
                        Advance();
                    }
                }
            }
        }
        static private void Swap() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Advance();
                Console.WriteLine("REGI: " + Peek().val);

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {

                    string r2 = Peek().val;
                    ushort r2Byte = regis[r2];

                    regis[r2] = regis[r1];
                    regis[r1] = r2Byte;

                    Console.WriteLine("NOW: " + regis[r2]);
                    Advance();
                }
            }
        }
        static private void Clear() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {
                string r1 = Peek().val;

                regis[r1] = 0x00;

                Advance();
            }
        }

        // MATH
        static private void Add() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] + regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    IsZero(r1);
                    Advance();
                }
            }
        }
        static private void Sub() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] - regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    IsZero(r1);
                    Advance();
                }
            }
        }
        static private void Multi() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] * regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    IsZero(r1);
                    Advance();
                }
            }
        }
        static private void Div() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] / regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    IsZero(r1);
                    Advance();
                }
            }
        }
        static private void Mod() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] % regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    IsZero(r1);
                    Advance();
                }
            }
        }
        static private void Inc() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);
            if (regis.ContainsKey(Peek().val))
            {
                string r1 = Peek().val;
                Advance();

                Console.WriteLine(Convert.ToUInt16(regis[r1] + 1));

                regis[r1] = Convert.ToUInt16(regis[r1] + 1);

                Console.WriteLine($"NOW {regis[r1]}");

                IsZero(r1);
            }
        }
        static private void Dec() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);
            if (regis.ContainsKey(Peek().val))
            {
                string r1 = Peek().val;
                Advance();

                Console.WriteLine(Convert.ToUInt16(regis[r1] - 1));

                regis[r1] = Convert.ToUInt16(regis[r1] - 1);

                Console.WriteLine($"NOW {regis[r1]}");

                IsZero(r1);
            }
        }

        // CONTROLFLOW
        static private void Jump (){

            Advance();
            Console.WriteLine($"To: {Peek().val}");

            if (Peek().val != null) {

                int num = int.Parse(Advance().val); // label

                if (pc < program.Count) { pc = num; }
            }
        }

        // BITWISE OPR
        static private void And() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] & regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    Advance();
                }
            }
        }
        static private void Or() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] | regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    Advance();
                }
            }
        }
        static private void Xor() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] ^ regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    Advance();
                }
            }
        }
        static private void Not() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val)) {

                string r1 = Peek().val;

                regis[r1] = Convert.ToUInt16(~regis[r1]);
                Console.WriteLine($"NOW {regis[r1]}");

                Advance();
            }
        }
        static private void ShiftL() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] << regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    Advance();
                }
            }
        }
        static private void ShiftR() {

            Advance();
            Console.WriteLine("REGI: " + Peek().val);

            if (regis.ContainsKey(Peek().val))
            {

                string r1 = Peek().val;

                Console.WriteLine("REGI: " + Peek().val);
                Advance();

                if (regis.ContainsKey(Peek().val) && r1 != Peek().val)
                {
                    string r2 = Peek().val;

                    regis[r1] = Convert.ToUInt16(regis[r1] >> regis[r2]);
                    Console.WriteLine($"NOW {regis[r1]}");

                    Advance();
                }
            }
        }

        static public void ClearProgram() { program.Clear(); }

        static public void ProgramLoad(List<Token> _program) { program = _program; }

        static public Token[] GetProgram() { return program.ToArray(); }
    }
}
