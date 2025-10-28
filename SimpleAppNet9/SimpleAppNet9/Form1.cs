namespace SimpleAppNet9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;

            if (int.TryParse(input, out int number))
            {
                lblResult.Text = $"You entered: {number}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
