namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Madeline Baxter
            // 07/08/2022
            // Lab 2: program that requires user input with 2 types of exception handling
            // (Est. 30 mins to complete)
            // Total time to complete: 45 mins - to record and write paper

            int result;
            string str = textBox1.Text;
            if (int.TryParse(str,out result))
            {
                MessageBox.Show("This is a valid integer");
            }
            else
            {
                MessageBox.Show("This is NOT a valid integer, try again!");
            }
            try
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("CATCH - Not a Valid Integer!");
                MessageBox.Show("Please try again");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}