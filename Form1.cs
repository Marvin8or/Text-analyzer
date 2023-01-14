namespace TextParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Parse_Text_Click(object sender, EventArgs e)
        {
            string database_path = this.textBox1.Text.ToString();
            this.textBox2.Text = database_path;
            Form2 form2= new Form2();
            form2.some_text = database_path;
            form2.ShowDialog();
        }
    }
}