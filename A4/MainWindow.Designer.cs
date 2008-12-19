namespace A4
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
            this.labelZahl1 = new System.Windows.Forms.Label();
            this.labelZahl2 = new System.Windows.Forms.Label();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonModulo = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZahl1
            // 
            this.labelZahl1.AutoSize = true;
            this.labelZahl1.Location = new System.Drawing.Point(14, 15);
            this.labelZahl1.Name = "labelZahl1";
            this.labelZahl1.Size = new System.Drawing.Size(37, 13);
            this.labelZahl1.TabIndex = 0;
            this.labelZahl1.Text = "Zahl 1";
            // 
            // labelZahl2
            // 
            this.labelZahl2.AutoSize = true;
            this.labelZahl2.Location = new System.Drawing.Point(14, 48);
            this.labelZahl2.Name = "labelZahl2";
            this.labelZahl2.Size = new System.Drawing.Size(37, 13);
            this.labelZahl2.TabIndex = 0;
            this.labelZahl2.Text = "Zahl 2";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(68, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(164, 20);
            this.textBoxZahl1.TabIndex = 1;
            this.textBoxZahl1.Text = "0";
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(68, 45);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(164, 20);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.Text = "0";
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(14, 80);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(48, 13);
            this.labelErgebnis.TabIndex = 0;
            this.labelErgebnis.Text = "Ergebnis";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(68, 77);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(164, 20);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(238, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(25, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(269, 9);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(25, 25);
            this.buttonSubtract.TabIndex = 2;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(238, 74);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(25, 25);
            this.buttonDivide.TabIndex = 2;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonModulo
            // 
            this.buttonModulo.Location = new System.Drawing.Point(269, 74);
            this.buttonModulo.Name = "buttonModulo";
            this.buttonModulo.Size = new System.Drawing.Size(25, 25);
            this.buttonModulo.TabIndex = 2;
            this.buttonModulo.Text = "%";
            this.buttonModulo.UseVisualStyleBackColor = true;
            this.buttonModulo.Click += new System.EventHandler(this.buttonModulo_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(238, 42);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(25, 25);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 114);
            this.Controls.Add(this.buttonModulo);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.labelZahl2);
            this.Controls.Add(this.labelZahl1);
            this.Name = "MainWindow";
            this.Text = "Ganzzahl-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZahl1;
        private System.Windows.Forms.Label labelZahl2;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonModulo;
        private System.Windows.Forms.Button buttonMultiply;
    }
}

