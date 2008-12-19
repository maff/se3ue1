namespace A3
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.debugSwitch = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.andererButton = new A3.TestButton();
            this.kleinerButton = new A3.TestButton();
            this.grosserButton = new A3.TestButton();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugSwitch
            // 
            this.debugSwitch.AutoSize = true;
            this.debugSwitch.Checked = true;
            this.debugSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugSwitch.Location = new System.Drawing.Point(12, 161);
            this.debugSwitch.Name = "debugSwitch";
            this.debugSwitch.Size = new System.Drawing.Size(160, 17);
            this.debugSwitch.TabIndex = 3;
            this.debugSwitch.Text = "Debugmeldungen ausgeben";
            this.debugSwitch.UseVisualStyleBackColor = true;
            this.debugSwitch.CheckedChanged += new System.EventHandler(this.debugSwitch_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 187);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(369, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // andererButton
            // 
            this.andererButton.ForeColor = System.Drawing.Color.Red;
            this.andererButton.Location = new System.Drawing.Point(207, 41);
            this.andererButton.Name = "andererButton";
            this.andererButton.Size = new System.Drawing.Size(150, 110);
            this.andererButton.TabIndex = 2;
            this.andererButton.Text = "Anderer Button";
            this.andererButton.UseVisualStyleBackColor = true;
            // 
            // kleinerButton
            // 
            this.kleinerButton.ForeColor = System.Drawing.Color.Red;
            this.kleinerButton.Location = new System.Drawing.Point(207, 12);
            this.kleinerButton.Name = "kleinerButton";
            this.kleinerButton.Size = new System.Drawing.Size(150, 23);
            this.kleinerButton.TabIndex = 1;
            this.kleinerButton.Text = "Kleiner Button";
            this.kleinerButton.UseVisualStyleBackColor = true;
            // 
            // grosserButton
            // 
            this.grosserButton.ForeColor = System.Drawing.Color.Red;
            this.grosserButton.Location = new System.Drawing.Point(12, 12);
            this.grosserButton.Name = "grosserButton";
            this.grosserButton.Size = new System.Drawing.Size(189, 139);
            this.grosserButton.TabIndex = 0;
            this.grosserButton.Text = "Großer Button";
            this.grosserButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 209);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.debugSwitch);
            this.Controls.Add(this.andererButton);
            this.Controls.Add(this.kleinerButton);
            this.Controls.Add(this.grosserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "ButtonTester";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestButton grosserButton;
        private TestButton kleinerButton;
        private TestButton andererButton;
        private System.Windows.Forms.CheckBox debugSwitch;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
    }
}

