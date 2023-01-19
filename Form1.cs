using HelpersLibrary;
namespace TextParser
{
    public partial class Form1 : Form
    {
        private delegate bool isPathValid(string path);
        public Form1()
        {
            InitializeComponent();
        }

        private void parseText_btnClick(object sender, EventArgs e)
        {
            isPathValid validator = PathValidator.IsAbsolutePath;
            validator += PathValidator.IsFileNameValid;
            validator += PathValidator.IsFileExtensionValid;
            string database_path = this.filePath_txtBox.Text.ToString();

            foreach(isPathValid method in validator.GetInvocationList())
            {
                if(!method(database_path))
                {
                    throw new Exception("Path to file is invalid!");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}