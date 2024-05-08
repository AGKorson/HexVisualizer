using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexVisualizer {
    public partial class HexViewer : Form {
        public HexViewer() {
            InitializeComponent();
        }
        public void DrawBytes(byte[] data) {
            StringBuilder sb = new StringBuilder();

            richHex.Font = new Font("Courier New", 10);
            richHex.ForeColor = SystemColors.HighlightText;
            richHex.Text = "Offset    00 01 02 03 04 05 06 07 08 | 09 0A 0B 0C 0D 0E 0F";
                //         "00000000  
            for (int i = 0; i < data.Length; i++) {
                if ((i % 16) == 0) {
                    richHex.AppendText("  " + sb.ToString());
                    sb.Clear();
                    richHex.AppendText("\n");
                    richHex.ForeColor = SystemColors.Highlight;
                    richHex.AppendText(i.ToString("X8") + "  ");
                    richHex.ForeColor = Color.Black;
                }
                if ((i % 16) == 9) {
                    richHex.AppendText("  ");
                }
                richHex.AppendText(data[i].ToString("X2") + " ");
                char ch;
                if (data[i] < 32) {
                    ch = '.';
                }
                else if (data[i] > 127) {
                    byte[] charbyte = new byte[1];
                    charbyte[0] = data[i];
                    ch = Encoding.GetEncoding(437).GetString(charbyte)[0];
                }
                else {
                    ch = (char)data[i];
                }
                sb.Append(ch);
            }
            if (sb.Length > 0) {
                for (int i = sb.Length; i < 16; i++) {
                    sb.Insert(0, "   ");
                }
                if ((data.Length % 16) < 9 && (data.Length % 16 > 0)) {
                    sb.Insert(0, "  ");
                }
                sb.Insert(0, "  ");
                richHex.AppendText(sb.ToString());
            }
        }
    }
}
