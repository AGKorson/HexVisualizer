using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HexVisualizer {
    public partial class HexVisualizerForm : Form {
        bool showhex = true;

        public HexVisualizerForm() {
            InitializeComponent();
        }

        public byte[] CharData {  get; set; }

        public void LoadData(byte[] data) {
            StringBuilder sb = new StringBuilder();
            LoadingPanel.Refresh();
            for (int i = 0; i < data.Length; i++) {
                if ((i % 16) == 0) {
                    LoadingPanel.Refresh();
                    if (i > 0) {
                        OffsetDisplay.AppendText("\r\n");
                        CharDisplay.AppendText(sb.ToString() + "\r\n");
                        HexDisplay.AppendText("\r\n");
                        sb.Clear();
                    }
                    OffsetDisplay.AppendText(i.ToString("X8"));
                }
                if ((i % 16) == 8) {
                    HexDisplay.AppendText("  ");
                }
                HexDisplay.AppendText(data[i].ToString("X2") + ((i % 16 == 15) ? "" :  " "));
                char ch;
                if (data[i] < 32 || data[i] == 127) {
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
                CharDisplay.AppendText(sb.ToString());
            }
            HexDisplay.Height = (((data.Length - 1) / 16) + 1) * HexDisplay.Font.Height + 2;
            OffsetDisplay.Height = HexDisplay.Height;
            CharDisplay.Height = HexDisplay.Height;
            CharDisplay.SelectionLength = 0;
            CharDisplay.SelectionStart = 0;
            HexDisplay.SelectionLength = 0;
            HexDisplay.SelectionStart = 0;
            LoadingPanel.Visible = false;
            panel1.Visible = true;
        }

        private void txtDisplay_MouseMove(object sender, MouseEventArgs e) {
            // update selection in richHex to match selection in txtDisplay
            HexDisplay.SelectionStart = CharDisplayToHexDisplay(CharDisplay.SelectionStart, true);
            if (CharDisplay.SelectionLength > 0) {
                HexDisplay.SelectionLength = CharDisplayToHexDisplay(CharDisplay.SelectionStart + CharDisplay.SelectionLength) - HexDisplay.SelectionStart;
            }
            else {
                HexDisplay.SelectionLength = 0;
            }
            UpdateStatus();
        }

        private void richHex_MouseMove(object sender, MouseEventArgs e) {
            // update selection in txtDisplay to match selection in richHex
            CharDisplay.SelectionStart = HexDisplayToCharDisplay(HexDisplay.SelectionStart);
            if (HexDisplay.SelectionLength > 0) {
                CharDisplay.SelectionLength = HexDisplayToCharDisplay(HexDisplay.SelectionStart + HexDisplay.SelectionLength) - CharDisplay.SelectionStart;
            }
            else {
                CharDisplay.SelectionLength = 0;
            }
            UpdateStatus();
        }

        int CharDisplayToHexDisplay(int charpos, bool start = false) {
            int row = charpos / 18;
            int col = charpos % 18;
            if (col > 0 && col < 9) {
                col = (col * 3) - 1;
            }
            else if (col > 8 && col < 17) {
                col = (col * 3) + 1;
            }
            else if (col == 17) {
                col = 49;
            }
            if (start) {
                if (col > 0 && col < 49) {
                    col++;
                    if (col == 24) {
                        col += 2;
                    }
                }
            }
            return (50 * row) + col;
        }
        int HexDisplayToCharDisplay(int hexpos) {
            int row = hexpos / 50;
            int col = hexpos % 50 - 1;
            if (col < 0) {
                col = 0;
            else if (col > 0 && col < 24) {
                col = (col + 2) / 3;
            }
            else if (col > 23) {
                col /= 3;
            }
            return 18 * row + col;
        }
        int Offset(int charpos) {
            int row = charpos / 18;
            int col = charpos % 18;
            if (col > 16) {
                col = 16;
            }
            return (row * 16 + col);
        }

        int Length(int start, int end) {
            return Offset(end) - Offset(start);
        }
        private void status_DoubleClick(object sender, EventArgs e) {
            showhex = !showhex;
            // redraw status bar
            UpdateStatus();
        }
        void UpdateStatus() {
            statOffset.Text = "Offset" + (showhex ? "(h)" : "") + $": {Offset(CharDisplay.SelectionStart).ToString(showhex ? "x" : "").ToUpper()}  ";
            statLength.Text = "Length" + (showhex ? "(h)" : "") + $": {Length(CharDisplay.SelectionStart, CharDisplay.SelectionStart + CharDisplay.SelectionLength).ToString(showhex ? "x" : "").ToUpper()}  ";
        }

        private void HexVisualizerForm_Load(object sender, EventArgs e) {
            this.Show();
            LoadData(CharData);
        }

        private void OffsetDisplay_Leave(object sender, EventArgs e) {
            OffsetDisplay.SelectionStart = 0;
            OffsetDisplay.SelectionLength = 0;
        }

        private void HexVisualizer_MouseWheel(object sender, MouseEventArgs e) {
            // scroll the form, if scrollbar is visible
            int newval;
            if (panel1.VerticalScroll.Visible) {
                if (e.Delta > 0) {
                    newval = panel1.VerticalScroll.Value - panel1.VerticalScroll.LargeChange;
                }
                else if (e.Delta < 0) {
                    newval = panel1.VerticalScroll.Value + panel1.VerticalScroll.LargeChange;
                }
                else {
                    return;
                }
                if (newval < panel1.VerticalScroll.Minimum) {
                    newval = panel1.VerticalScroll.Minimum;
                }
                if (newval > panel1.VerticalScroll.Maximum) {
                    newval = panel1.VerticalScroll.Maximum;
                }
                panel1.VerticalScroll.Value = newval;
                if (panel1.VerticalScroll.Value != newval) {
                    System.Threading.Thread.Sleep(1);
                    panel1.VerticalScroll.Value = newval;
                }
                HexDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
                OffsetDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
                CharDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e) {
            HexDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
            OffsetDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
            CharDisplay.AutoScrollOffset = new Point(0, -panel1.VerticalScroll.Value);
        }
    }
}
