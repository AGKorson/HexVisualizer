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
            this.CharDisplay = new System.Windows.Forms.TextBox();
            this.HexDisplay = new System.Windows.Forms.RichTextBox();
            this.OffsetDisplay = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statOffset = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(1404, 34);
            this.Header.TabIndex = 1;
            this.Header.TabStop = false;
            this.Header.Text = "Offset    00 01 02 03 04 05 06 07 | 08 09 0A 0B 0C 0D 0E 0F";
            this.Header.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.CharDisplay);
            this.panel1.Controls.Add(this.HexDisplay);
            this.panel1.Controls.Add(this.OffsetDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 553);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HexVisualizer_MouseWheel);
            // 
            // CharDisplay
            // 
            this.CharDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.CharDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharDisplay.CausesValidation = false;
            this.CharDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharDisplay.HideSelection = false;
            this.CharDisplay.Location = new System.Drawing.Point(1074, 0);
            this.CharDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.CharDisplay.Multiline = true;
            this.CharDisplay.Name = "CharDisplay";
            this.CharDisplay.ReadOnly = true;
            this.CharDisplay.Size = new System.Drawing.Size(296, 838);
            this.CharDisplay.TabIndex = 5;
            this.CharDisplay.TabStop = false;
            this.CharDisplay.WordWrap = false;
            this.CharDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDisplay_MouseMove);
            this.CharDisplay.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HexVisualizer_MouseWheel);
            // 
            // HexDisplay
            // 
            this.HexDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.HexDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexDisplay.CausesValidation = false;
            this.HexDisplay.DetectUrls = false;
            this.HexDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexDisplay.HideSelection = false;
            this.HexDisplay.Location = new System.Drawing.Point(178, 0);
            this.HexDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.HexDisplay.Name = "HexDisplay";
            this.HexDisplay.ReadOnly = true;
            this.HexDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HexDisplay.ShortcutsEnabled = false;
            this.HexDisplay.Size = new System.Drawing.Size(932, 872);
            this.HexDisplay.TabIndex = 4;
            this.HexDisplay.TabStop = false;
            this.HexDisplay.Text = "";
            this.HexDisplay.WordWrap = false;
            this.HexDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richHex_MouseMove);
            this.HexDisplay.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HexVisualizer_MouseWheel);
            // 
            // OffsetDisplay
            // 
            this.OffsetDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.OffsetDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OffsetDisplay.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(191)))));
            this.OffsetDisplay.Location = new System.Drawing.Point(-2, 0);
            this.OffsetDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.OffsetDisplay.Multiline = true;
            this.OffsetDisplay.Name = "OffsetDisplay";
            this.OffsetDisplay.ReadOnly = true;
            this.OffsetDisplay.Size = new System.Drawing.Size(176, 838);
            this.OffsetDisplay.TabIndex = 3;
            this.OffsetDisplay.TabStop = false;
            this.OffsetDisplay.Leave += new System.EventHandler(this.OffsetDisplay_Leave);
            this.OffsetDisplay.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HexVisualizer_MouseWheel);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statOffset,
            this.statLength});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1404, 42);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // statOffset
            // 
            this.statOffset.BackColor = System.Drawing.SystemColors.Control;
            this.statOffset.Name = "statOffset";
            this.statOffset.Size = new System.Drawing.Size(146, 32);
            this.statOffset.Text = "Offset(h): 0  ";
            this.statOffset.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // statLength
            // 
            this.statLength.BackColor = System.Drawing.SystemColors.Control;
            this.statLength.Name = "statLength";
            this.statLength.Size = new System.Drawing.Size(155, 32);
            this.statLength.Text = "Length(h): 0  ";
            this.statLength.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadingPanel.Controls.Add(this.label1);
            this.LoadingPanel.Controls.Add(this.progressBar1);
            this.LoadingPanel.Location = new System.Drawing.Point(178, 81);
            this.LoadingPanel.Margin = new System.Windows.Forms.Padding(6);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(890, 400);
            this.LoadingPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 215);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // HexVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 629);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HexVisualizerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Byte Array Hex Visualizer";
            this.Load += new System.EventHandler(this.HexVisualizerForm_Load);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HexVisualizer_MouseWheel);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LoadingPanel.ResumeLayout(false);
            this.LoadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.TextBox CharDisplay;
        private System.Windows.Forms.RichTextBox HexDisplay;
        private System.Windows.Forms.TextBox OffsetDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statOffset;
        private System.Windows.Forms.ToolStripStatusLabel statLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}