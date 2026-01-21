namespace A41_WindowsForms
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
            Hello = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // Hello
            // 
            Hello.Location = new Point(77, 323);
            Hello.Name = "Hello";
            Hello.Size = new Size(94, 29);
            Hello.TabIndex = 0;
            Hello.Text = "&Hello1";
            Hello.UseVisualStyleBackColor = true;
            Hello.Click += Hello_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(227, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(Hello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hello;
        private TextBox txtName;
    }
}
