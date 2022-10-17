using System.Text;

namespace ModularityTestingApp
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filePath = String.Empty;
            String fileExt = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileExt = Path.GetExtension(filePath);
                if (fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(filePath);
                        StringBuilder sb = new StringBuilder();

                        string line = "";

                        while ((line = sr.ReadLine()) != null) sb.Append(line);

                        sr.Close();
                        richTextBox1.Text = sb.ToString();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}