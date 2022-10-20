using System.Runtime.CompilerServices;
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
                        int stringExtends = 0;
                        int stringNew = 0;

                        string regexNew = "new";

                        while ((line = sr.ReadLine()) != null) sb.Append(line);
                        string[] stringArray = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach (string s in stringArray)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(s, ":\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                stringExtends++;
                            } else if (System.Text.RegularExpressions.Regex.IsMatch(s, regexNew, System.Text.RegularExpressions.RegexOptions.IgnoreCase)) 
                            {
                                stringNew++;
                            }
                        }

                        sr.Close();
                        richTextBox1.Text = String.Join(',', stringArray);
                        textBox1.Text = stringExtends.ToString();
                        textBox2.Text = stringNew.ToString();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}