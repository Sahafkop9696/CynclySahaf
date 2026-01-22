namespace A52_WindowsFormsOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Contact1_Click(object sender, EventArgs e)
        {
            Contact Sahaf = new Contact();
            Sahaf.Name = "Sahaf Hussain";
            Sahaf.Address = "Kozhikode";
            MessageBox.Show($"My Name is {Sahaf.Name} and I'm from {Sahaf.Address}");
        }
    }
}
