namespace A52_WindowsFormsOOP
{
    partial class Form1
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
            Contact2 = new Button();
            Contact1 = new Button();
            SuspendLayout();
            // 
            // Contact2
            // 
            Contact2.Location = new Point(452, 227);
            Contact2.Name = "Contact2";
            Contact2.Size = new Size(94, 29);
            Contact2.TabIndex = 0;
            Contact2.Text = "Atif";
            Contact2.UseVisualStyleBackColor = true;
            // 
            // Contact1
            // 
            Contact1.Cursor = Cursors.Cross;
            Contact1.Location = new Point(98, 227);
            Contact1.Name = "Contact1";
            Contact1.Size = new Size(94, 29);
            Contact1.TabIndex = 1;
            Contact1.Text = "Sahaf";
            Contact1.UseVisualStyleBackColor = true;
            Contact1.Click += Contact1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Contact1);
            Controls.Add(Contact2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Contact2;
        private Button Contact1;
    }
}
