using ModularityTestingApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

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
            int stringMiaw = 0;
            string? line;
            int x = 0;
            string lineList = "";
            string[] lineArr = Array.Empty<string>();
            string[] lineArr2 = Array.Empty<string>();
            List<string> classList2 = new List<string>();
            string[] jamur = Array.Empty<string>();
            List<string> classList = new List<string>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog.Filter = "C Sharp Files (.cs)|*.cs";
            openFileDialog2.Filter = "C Sharp Files (.cs)|*.cs";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    StreamReader sr = new StreamReader(file);
                    StringBuilder sb = new StringBuilder();
                    //richTextBox1.Text = line2.ToString();
                    //MessageBox.Show(classList2[0]);
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (Regex.IsMatch(line, @"\snew\s"))
                        {
                            lineArr = line.Split("new");
                            lineList = lineArr[0];
                            string[] classArr = lineList.Split(" ");
                            int index = classArr.Length - 3;
                            classList.Add(classArr[index]);
                            classListName.nameList?.Add(classArr[index]);
                        }
                        sb.AppendLine(line);
                        sb.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                MessageBox.Show("Please confirm your file");

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string? line2;

                    StreamReader sr = new StreamReader(file);
                    StringBuilder sb = new StringBuilder();
                    try
                    {
                        while ((line2 = sr.ReadLine()) != null)
                        {
                            jamur = line2.Split(new string[] { ".", " " }, StringSplitOptions.None);
                            for (int i = 0; i < jamur.Length; i++)
                            {
                                classList2.Add(jamur[i]);
                            }
                            sb.AppendLine(line2);
                        }
                        textBox1.Text = classList2.Count.ToString();
                    }
                    catch
                    {

                    }
                }

            }
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string item in classListName.nameList)
            {
                result[item] = 0;
            }

            foreach (string item in classList2)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
            }
            richTextBox1.Text = result["sr"].ToString();
        }
    }
}
