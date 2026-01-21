namespace A41_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello Welcome {txtName.Text}");
        }
    }
}
