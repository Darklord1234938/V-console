using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_CONSOLE.Core
{
    public class ConsoleRedirect : System.IO.TextWriter
    {
        private RichTextBox box;
        public ConsoleRedirect(RichTextBox _box) { box = _box; }
        public override System.Text.Encoding Encoding => System.Text.Encoding.UTF8;
        public override void WriteLine(string value)
        {
            string line = $"[{DateTime.Now:HH:mm:ss}] {value}\n";
            if (box.InvokeRequired)
                box.Invoke(() => box.Text += line);
            else
                box.Text += line;
        }
        public override void Write(string value)
        {
            if (box.InvokeRequired)
                box.Invoke(() => box.Text += value);
            else
                box.Text += value;
        }
    }
}
