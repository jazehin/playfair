namespace playfairGUI
{
    partial class MainForm
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
            lblSzoveg = new Label();
            tbSzoveg = new TextBox();
            SuspendLayout();
            // 
            // lblSzoveg
            // 
            lblSzoveg.AutoSize = true;
            lblSzoveg.ForeColor = Color.Green;
            lblSzoveg.Location = new Point(12, 9);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(108, 15);
            lblSzoveg.TabIndex = 0;
            lblSzoveg.Text = "Előkészített szöveg:";
            // 
            // tbSzoveg
            // 
            tbSzoveg.Location = new Point(12, 38);
            tbSzoveg.Multiline = true;
            tbSzoveg.Name = "tbSzoveg";
            tbSzoveg.Size = new Size(521, 179);
            tbSzoveg.TabIndex = 1;
            tbSzoveg.TextChanged += OnTbSzovegTextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 236);
            Controls.Add(tbSzoveg);
            Controls.Add(lblSzoveg);
            Name = "MainForm";
            Text = "playfairGUI";
            Load += OnFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSzoveg;
        private TextBox tbSzoveg;
    }
}