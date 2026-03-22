using System;
using System.Numerics;
using System.Windows.Forms;

namespace V_CONSOLE.Core
{
    public static class GPU_MODULAR
    {
        static Vector2 viewSize = new Vector2(MathF.Sqrt(16384), MathF.Sqrt(16384));

        static ushort[] vRam = new ushort[16384];

        static Bitmap frameBuffer = SetBuffer();

        public static void SetPixel(int _x, int _y, ushort _color)
        {
            if (_x < 0 || _y < 0 || _x >= viewSize.X || _y >= viewSize.Y) return;

            SetMemoryAddr((int)(_y * viewSize.X + _x), _color);
        }

        public static Bitmap RunBuffer()
        {
            for (int y = 0; y < frameBuffer.Height; y++)
            {
                for (int x = 0; x < frameBuffer.Width; x++)
                {
                    // Calculate memory offset if you want
                    int width = frameBuffer.Width;
                    int address = y * width + x;
                    ushort val = GetMemoryAddr(address);
                    frameBuffer.SetPixel(x, y, ByteToColor(val));
                }
            }
            return frameBuffer;
        }

        static Color ByteToColor(ushort _val) {
            // Extract bits
            int r = (_val >> 11) & 0b11111;   // 5 bits
            int g = (_val >> 5) & 0b111111;  // 6 bits
            int b = _val & 0b11111;           // 5 bits

            // Scale to 0–255
            int r8 = (r * 255) / 31;
            int g8 = (g * 255) / 63;
            int b8 = (b * 255) / 31;

            return Color.FromArgb(r, g, b); 
        }

        public static Bitmap SetBuffer()
        {
            frameBuffer = new Bitmap((int)viewSize.X, (int)viewSize.Y);

            return frameBuffer;
        }

        public static void Clear()
        {
            Array.Fill(vRam, (ushort)0);
        }

        public static ushort GetMemoryAddr(int _address) { return vRam[_address]; }

        public static ushort[] GetMemoryAll() { return vRam; }

        public static void SetMemoryAddr(int _address, ushort _val) { vRam[_address] = _val; }

        public static void SetMemoryAll(ushort[] _val) { vRam = _val; }

       
    }
}
