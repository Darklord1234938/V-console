using System.Windows.Forms;
using V_CONSOLE.Core;

namespace V_CONSOLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.SetOut(new ConsoleRedirect(ConsoleBox));
            BuildSet();
        }

        private void BuildSet()
        {
            ushort[] bytes = Program.ProgramToRom();

            ROM.SetMemoryAll(bytes);

            Canvas.Image = GPU_MODULAR.SetBuffer();
            Canvas.SizeMode = PictureBoxSizeMode.Zoom;
            Canvas.Image = GPU_MODULAR.RunBuffer();

            RamGrid.Rows.Clear();
            foreach (byte ramUnit in Memory.GetMemoryAll()) { RamGrid.Rows.Add($"0x{ramUnit:X4}"); }

            VRamGrid.Rows.Clear();
            foreach (byte ramUnit in GPU_MODULAR.GetMemoryAll()) { VRamGrid.Rows.Add($"0x{ramUnit:X4}"); }

            RomGrid.Rows.Clear();
            foreach (byte ramUnit in ROM.GetMemoryAll()) { RomGrid.Rows.Add($"0x{ramUnit:X4}"); }

            RegistatorAT.Text = $"0x{CPU_MODULAR.regis["0x002C"]:X4}";
            RegistatorBT.Text = $"0x{CPU_MODULAR.regis["0x002D"]:X4}";
            RegistatorCT.Text = $"0x{CPU_MODULAR.regis["0x002E"]:X4}";

            PCBox.Text = $"{CPU_MODULAR.pc}";

            ZCheck.Checked = CPU_MODULAR.GetZero();
            CCheck.Checked = CPU_MODULAR.GetCarry();
            NCheck.Checked = CPU_MODULAR.GetNegative();

            OCheck.Checked = CPU_MODULAR.GetOverflow();
            LCheck.Checked = CPU_MODULAR.GetLoop();
            RCheck.Checked = CPU_MODULAR.GetRunning();
        }

        private void ConsoleTxt_Click(object sender, EventArgs e)
        {

        }

        private async void BuildBttn_Click(object sender, EventArgs e)
        {
            string code = CodeBox.Text;

            await Task.Run(() =>
            {
                Program.Parser(code);
            });

            BuildSet();
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            string code = CodeBox.Text; // read on UI thread first
            CPU_MODULAR.SetUp();
            Program.Parser(code);

            await Task.Run(() =>
            {
                CPU_MODULAR.pc = 0;
                CPU_MODULAR.Interperter();

                Console.WriteLine("IMG GEN");
                Canvas.Image = GPU_MODULAR.RunBuffer();
            });

            BuildSet();
            Console.WriteLine("Done");
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }
    }
}
