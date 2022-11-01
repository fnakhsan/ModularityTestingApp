using System.Text;
using System.Text.RegularExpressions;

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
            int stringExtends = 0;
            int stringNew = 0;
            int stringClass = 0;
            string? line;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C Sharp Files (.cs)|*.cs";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(file);
                        StringBuilder sb = new StringBuilder();

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (Regex.IsMatch(line, @"\s:\s")) stringExtends++;
                            if (Regex.IsMatch(line, @"\snew\s")) stringNew++;
                            if (Regex.IsMatch(line, @"\sclass\s")) stringClass++;
                            sb.AppendLine(line);
                        }

                        sr.Close();

                        richTextBox1.Text = sb.ToString();

                        textBoxExtend.Text = stringExtends.ToString();
                        textBoxNew.Text = stringNew.ToString();
                        textBoxClass.Text = stringClass.ToString();

                        textBoxTotalOut.Text = (stringClass).ToString();
                        textBoxTotalIn.Text = (stringExtends + stringNew).ToString();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTotalIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotalIn_Click(object sender, EventArgs e)
        {

        }
    }
}