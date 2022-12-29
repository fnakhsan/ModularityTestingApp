using ModularityTestingApp.model;
using System;
using System.Collections;
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

        private void button14_Click(object sender, EventArgs e)
        {
            //int className = 0;
            //List<string> classNameList = new List<string>();
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "Select which folder you want to be tested.";
            //dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    string folderPath = dialog.SelectedPath;
            //    string[] fileEntries = Directory.GetFiles(folderPath, "*.cs");
            //    foreach (string fileName in fileEntries)
            //    {
            //        className++;
            //    }
            //    stringClassTextBox.Text = className.ToString();
            //    totalFanOut.Text = className.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string? line;
            //string lineList = "";
            //int stringExtend = 0;

            //string[] lineArr = Array.Empty<string>();
            //string[] lineArr2 = Array.Empty<string>();
            //List<string> classList2 = new List<string>();
            //string[] jamur = Array.Empty<string>();
            //List<string> classList = new List<string>();

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //OpenFileDialog openFileDialog2 = new OpenFileDialog();
            //openFileDialog.Filter = "C Sharp Files (.cs)|*.cs";
            //openFileDialog2.Filter = "C Sharp Files (.cs)|*.cs";
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //openFileDialog.Title = "Choose the file which you want to be tested.";

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string file = openFileDialog.FileName;

            //    try
            //    {
            //        StreamReader sr = new StreamReader(file);
            //        StringBuilder sb = new StringBuilder();
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            if (Regex.IsMatch(line, @"\snew\s"))
            //            {
            //                lineArr = line.Split("new");
            //                lineList = lineArr[0];
            //                string[] classArr = lineList.Split(" ");
            //                int index = classArr.Length - 3;
            //                classList.Add(classArr[index]);
            //                classListName.nameList?.Add(classArr[index]);
            //                MessageBox.Show(classArr[index]);
            //            }
            //            sb.AppendLine(line);
            //            sb.Clear();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    MessageBox.Show("Please confirm your file");

            //    if (openFileDialog2.ShowDialog() == DialogResult.OK)
            //    {
            //        string? line2;

            //        StreamReader sr = new StreamReader(file);
            //        StringBuilder sb = new StringBuilder();
            //        try
            //        {
            //            while ((line2 = sr.ReadLine()) != null)
            //            {
            //                jamur = line2.Split(new string[] { "(", ")", "[", ".", " " }, StringSplitOptions.None);
            //                for (int i = 0; i < jamur.Length; i++)
            //                {
            //                    if (Regex.IsMatch(line2, @"\s:\s")) stringExtend++;

            //                    classList2.Add(jamur[i]);
            //                }
            //                sb.AppendLine(line2);
            //            }
            //            objTextBox.Text = classList2.Count.ToString();
            //        }
            //        catch
            //        {

            //        }
            //    }

            //}
            //Dictionary<string, int> result = new Dictionary<string, int>();

            //foreach (string item in classListName.nameList)
            //{
            //    result[item] = 0;
            //}
            //foreach (string item in classList2)
            //{
            //    if (result.ContainsKey(item))
            //    {
            //        result[item]++;
            //    }
            //}

            ///*            List<int> values2 = result;

            //            List<int> values = result.Values.ToList();
            //            foreach (KeyValuePair<string,int> itemm in result)
            //            {
            //                richTextBox1.AppendText(itemm.Key + ": " + itemm.Value + Environment.NewLine);
            //            }*/

            //int sumObj = result.Values.Sum();
            //int totFanIn = sumObj + stringExtend;
            //objTextBox.Text = sumObj.ToString();
            //stringExtendTextBox.Text = stringExtend.ToString();
            //totalFanIn.Text = totFanIn.ToString();

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //    {
            //        if (sfd.ShowDialog() == DialogResult.OK)
            //        {
            //            var classCollectionCSV = new List<string>();
            //            classCollectionCSV.Add("Class Name,Super Class Name,Class ID,Class Target");
            //            foreach (var item in ClassCollection)
            //            {
            //                classCollectionCSV.Add($"{item.className},{item.superClass},{item.id},{item.target}");
            //            }
            //            File.WriteAllLines(sfd.FileName, classCollectionCSV);

            //            MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
        }


    /* private void csvButton_Click(object sender, EventArgs e)
     {
         int jumlahObj = classListName.nameList.Count();
         string filePath = @"C:\Data\data.csv";
         int[][] array1D = new int[jumlahObj][];


         for(int i = 0; i < array1D.Length; i++) 
         {
             for (int j = 0; j < array1D[i].Length; j++)
             {
                 array1D[i][j] = i * j;
             }
         }


         using (StreamWriter sw = new StreamWriter(filePath))
         {

         }
     }
*/
}
}

