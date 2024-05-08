using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HexVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace MyTestConsole {
    internal class TestConsole {

        static void Main(string[] args) {
            byte[] bTest = new byte[256];
            for (int i = 0;  i < bTest.Length; i++) {
                bTest[i] = (byte)(255-i);
            }
            byte[] cTest = new byte[100];

            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(null, typeof(DebuggerSide));
            //visualizerHost.ShowVisualizer();
            MessageBox.Show("stop here, test debugger");
        }
    }
}
