using ModularityTestingApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModularityTestingApp
{
    public partial class Form2 : Form
    {

        ClassList classListName = new ClassList();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string? line;

            string lineList = "";
            string[] lineArr = Array.Empty<string>();
            List<string> classList = new List<string>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C Sharp Files (.cs)|*.cs";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string[] files = Array.Empty<string>();
                try
                {
                    StreamReader sr = new StreamReader(file);
                    StringBuilder sb = new StringBuilder();

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (Regex.IsMatch(line, @"\snew\s"))
                        {
                            lineArr = line.Split("new");
                            lineList = lineArr[0];
                            string[] classArr = lineList.Split('=');
                            richTextBox1.Text = classArr[0];
                            classList.Add(classArr[0]);
                            classListName.nameList?.Add(classArr[1]);
                        }
                        sb.AppendLine(line); 
                    }
                    sr.Close();

                    textBox1.Text = lineArr[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
