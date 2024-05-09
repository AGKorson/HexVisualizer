using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(HexVisualizer.DebuggerHexVisualizer),
typeof(VisualizerObjectSource),
Target = typeof(byte[]),
Description = "Byte Array Hex Visualizer")]

namespace HexVisualizer {
    public class DebuggerHexVisualizer : DialogDebuggerVisualizer {
        public DebuggerHexVisualizer() : base(FormatterPolicy.Legacy) {
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
                HexVisualizerForm hexViewer = new HexVisualizerForm {
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
