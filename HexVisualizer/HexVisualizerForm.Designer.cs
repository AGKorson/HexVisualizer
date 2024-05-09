namespace HexVisualizer {
    partial class HexVisualizerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Header = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statOffset = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharDisplay = new System.Windows.Forms.TextBox();
            this.HexDisplay = new System.Windows.Forms.RichTextBox();
            this.OffsetDisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Window;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.CausesValidation = false;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.ReadOnly = true;
            this.Header.Size = new System.Drawing.Size(702, 17);
            this.Header.TabIndex = 1;
            this.Header.Text = "Offset    00 01 02 03 04 05 06 07 | 08 09 0A 0B 0C 0D 0E 0F";
            this.Header.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.CharDisplay);
            this.panel1.Controls.Add(this.HexDisplay);
            this.panel1.Controls.Add(this.OffsetDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 310);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statOffset,
            this.statLength});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // statOffset
            // 
            this.statOffset.BackColor = System.Drawing.SystemColors.Control;
            this.statOffset.Name = "statOffset";
            this.statOffset.Size = new System.Drawing.Size(72, 17);
            this.statOffset.Text = "Offset(h): 0  ";
            this.statOffset.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // statLength
            // 
            this.statLength.BackColor = System.Drawing.SystemColors.Control;
            this.statLength.Name = "statLength";
            this.statLength.Size = new System.Drawing.Size(77, 17);
            this.statLength.Text = "Length(h): 0  ";
            this.statLength.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // CharDisplay
            // 
            this.CharDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharDisplay.HideSelection = false;
            this.CharDisplay.Location = new System.Drawing.Point(537, 0);
            this.CharDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.CharDisplay.Multiline = true;
            this.CharDisplay.Name = "CharDisplay";
            this.CharDisplay.Size = new System.Drawing.Size(148, 436);
            this.CharDisplay.TabIndex = 6;
            this.CharDisplay.WordWrap = false;
            this.CharDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDisplay_MouseMove);
            // 
            // HexDisplay
            // 
            this.HexDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.HexDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexDisplay.CausesValidation = false;
            this.HexDisplay.DetectUrls = false;
            this.HexDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexDisplay.HideSelection = false;
            this.HexDisplay.Location = new System.Drawing.Point(89, 0);
            this.HexDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.HexDisplay.Name = "HexDisplay";
            this.HexDisplay.ReadOnly = true;
            this.HexDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HexDisplay.ShortcutsEnabled = false;
            this.HexDisplay.Size = new System.Drawing.Size(466, 436);
            this.HexDisplay.TabIndex = 4;
            this.HexDisplay.TabStop = false;
            this.HexDisplay.Text = "";
            this.HexDisplay.WordWrap = false;
            this.HexDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richHex_MouseMove);
            // 
            // OffsetDisplay
            // 
            this.OffsetDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OffsetDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.OffsetDisplay.Location = new System.Drawing.Point(-1, 0);
            this.OffsetDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.OffsetDisplay.Multiline = true;
            this.OffsetDisplay.Name = "OffsetDisplay";
            this.OffsetDisplay.Size = new System.Drawing.Size(88, 436);
            this.OffsetDisplay.TabIndex = 5;
            // 
            // HexVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HexVisualizerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Byte Array Hex Visualizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CharDisplay;
        private System.Windows.Forms.RichTextBox HexDisplay;
        private System.Windows.Forms.TextBox OffsetDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statOffset;
        private System.Windows.Forms.ToolStripStatusLabel statLength;
    }
}