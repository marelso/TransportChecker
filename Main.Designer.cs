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
            switchTheme.Location = new Point(567, 97);
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
            fl_main.Location = new Point(88, 144);
            fl_main.Margin = new Padding(3, 4, 3, 4);
            fl_main.Name = "fl_main";
            fl_main.Size = new Size(607, 415);
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
            materialExpansionPanel1.Location = new Point(67, 564);
            materialExpansionPanel1.Margin = new Padding(18, 1, 18, 0);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(27, 85, 27, 21);
            materialExpansionPanel1.Size = new Size(607, 48);
            materialExpansionPanel1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 933);
            Controls.Add(switchTheme);
            Controls.Add(materialExpansionPanel1);
            Controls.Add(fl_main);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Padding = new Padding(3, 85, 3, 4);
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