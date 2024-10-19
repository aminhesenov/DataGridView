namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string pasword = textBox2.Text;
            string title=comboBox1.Text;
            string description=richTextBox1.Text;
            
           

            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Username empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Password empty");
            }
            else
            {
                errorProvider2.Clear();
            }
         
            if (richTextBox1.Text == string.Empty)
            {
                errorProvider4.SetError(richTextBox1, "Description empty");
            }
            else
            {
                errorProvider4.Clear();
            }

            if(textBox1.Text != string.Empty && textBox2.Text!=string.Empty
                &&comboBox1.Text!=string.Empty && richTextBox1.Text != string.Empty)
            {
                dataGridView1.Rows.Add(username, pasword, DateTime.Now, title, description);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                richTextBox1.Text = "";
            }
        }
    }
}
