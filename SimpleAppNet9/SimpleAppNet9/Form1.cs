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

            if(number < 0 || number >= 30)
            {
                MessageBox.Show("Please enter a numbe between 0 ", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i] = i+1;
            }

            foreach (int i in numbers)
            {
                lblResult.Text = i.ToString();
            }
        }
    }
}
