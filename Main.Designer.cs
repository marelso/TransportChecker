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
            SuspendLayout();
            // 
            // switchTheme
            // 
            switchTheme.AutoSize = true;
            switchTheme.Depth = 0;
            switchTheme.Location = new Point(3, 64);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(switchTheme);
            Name = "Main";
            Text = "Transport checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch switchTheme;
    }
}