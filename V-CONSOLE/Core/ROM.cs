using System;

namespace V_CONSOLE.Core
{
    public static class ROM
    {
        static ushort[] ram = new ushort[32768];

        public static ushort GetMemoryAddr(int _address) { return ram[_address]; }

        public static ushort[] GetMemoryAll() { return ram; }

        public static void SetMemoryAddr(int _address, ushort _val) { ram[_address] = _val; }

        public static void SetMemoryAll(ushort[] _val) { ram = _val; }
    }
}
