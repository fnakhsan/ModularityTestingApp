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
                if (fileExt.CompareTo(".cs") == 0)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(filePath);
                        StringBuilder sb = new StringBuilder();

                        string? line = "";
                        int stringExtends = 0;
                        int stringNew = 0;
                        int stringClass = 0;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains(":")) stringExtends++;
                            if (line.Contains("new")) stringNew++;
                            if (line.Contains("class")) stringClass++;
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