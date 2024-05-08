using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(HexVisualizer.DebuggerSide),
typeof(VisualizerObjectSource),
Target = typeof(byte[]),
Description = "Byte Array Hex Visualizer")]

namespace HexVisualizer {
    public class DebuggerSide : DialogDebuggerVisualizer {
        public DebuggerSide() : base(FormatterPolicy.Legacy) {
        //public DebuggerSide() : base(FormatterPolicy.NewtonsoftJson) {
                // nothing else to do
            }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider) {
            try {
                IVisualizerObjectProvider3 objectProvider3 = (IVisualizerObjectProvider3)objectProvider;
                byte[] bArray;

                using (Stream opData = objectProvider3.GetData()) {
                    BinaryFormatter bf = new BinaryFormatter();
                    bArray = bf.Deserialize(opData) as byte[];
                }
                
                HexViewer hexViewer = new HexViewer {
                    Text = "Byte Viewer"
                };
                hexViewer.DrawBytes(bArray);
                windowService.ShowDialog(hexViewer);
                
            }
            catch (Exception ex) {
                MessageBox.Show("Error in visualizer: " + ex.Message);
            }
        }
    }
}
