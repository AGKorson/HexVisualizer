using HexVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;

namespace MyTestConsole {
    internal class TestConsole {

        static void Main(string[] args) {
            byte[] bTest = new byte[256];
            for (int i = 0;  i < bTest.Length; i++) {
                bTest[i] = (byte)(255-i);
            }
            byte[] cTest = new byte[100];

            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(null, typeof(DebuggerHexVisualizer));
            //visualizerHost.ShowVisualizer();
            MessageBox.Show("stop here, test debugger");
        }
    }
}
