using System.CodeDom;

namespace A42_CalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j, result = 0;

        private void Assign()
        {
            i = Int32.Parse(textBox1.Text);
            j = Int32.Parse(textBox2.Text);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Assign();
            result = i + j;
            lblResult2.Text = result.ToString();
        }

        private void btnSubstract_Click_1(object sender, EventArgs e)
        {
            Assign();
            result = i - j;
            lblResult2.Text = result.ToString();
        }
    }
}
