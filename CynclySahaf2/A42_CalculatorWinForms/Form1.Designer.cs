namespace A42_CalculatorWinForms
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblResult1 = new Label();
            lblResult2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            btnSubstract = new Button();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(62, 54);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(132, 20);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Enter First Number";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(62, 101);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(154, 20);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Enter Second Number";
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Location = new Point(62, 158);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(49, 20);
            lblResult1.TabIndex = 2;
            lblResult1.Text = "Result";
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.BorderStyle = BorderStyle.FixedSingle;
            lblResult2.Location = new Point(222, 158);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(2, 22);
            lblResult2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(342, 262);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(94, 29);
            btnSubstract.TabIndex = 7;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubstract_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubstract);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblResult2);
            Controls.Add(lblResult1);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblResult1;
        private Label lblResult2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnSubstract;
    }
}
