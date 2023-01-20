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

            string contents = File.ReadAllText(database_path);
            FileParser parser = new FileParser(contents);

            foreach (KeyValuePair<string, int> item in parser.GetWordCount())
            {
                resultsView_txtBox.Text += item.Key + ": " + item.Value.ToString() + Environment.NewLine;
            }
        }
    }
}