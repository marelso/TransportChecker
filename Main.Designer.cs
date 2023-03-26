namespace TransportChecker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            fl_main = new FlowLayoutPanel();
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            SuspendLayout();
            // 
            // switchTheme
            // 
            switchTheme.AutoSize = true;
            switchTheme.Depth = 0;
            switchTheme.Location = new Point(469, 73);
            switchTheme.Margin = new Padding(0);
            switchTheme.MouseLocation = new Point(-1, -1);
            switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            switchTheme.Name = "switchTheme";
            switchTheme.Ripple = true;
            switchTheme.Size = new Size(107, 37);
            switchTheme.TabIndex = 0;
            switchTheme.Text = "Theme";
            switchTheme.UseVisualStyleBackColor = true;
            switchTheme.CheckedChanged += switchTheme_CheckedChanged;
            // 
            // fl_main
            // 
            fl_main.AutoScroll = true;
            fl_main.Location = new Point(54, 108);
            fl_main.Name = "fl_main";
            fl_main.Size = new Size(567, 365);
            fl_main.TabIndex = 1;
            fl_main.WrapContents = false;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.Collapse = true;
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.ExpandHeight = 200;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(54, 477);
            materialExpansionPanel1.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel1.Size = new Size(531, 48);
            materialExpansionPanel1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 700);
            Controls.Add(switchTheme);
            Controls.Add(materialExpansionPanel1);
            Controls.Add(fl_main);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private FlowLayoutPanel fl_main;
        private MaterialSkin.Controls.MaterialListView list_weight;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
    }
}