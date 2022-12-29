using ModularityTestingApp.model;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ModularityTestingApp
{
    public partial class Form1 : Form
    {

        List<ClassList> classList = new List<ClassList>();
        List<ObjectList> objectList = new List<ObjectList>();

        int objectUsage = 0;
        int totalIn = 0;
        int totalOut = 0;

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

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            StringBuilder sb = new StringBuilder();
            string? line;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] files = Directory.GetFiles(dialog.SelectedPath);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string fileExt = Path.GetExtension(file);
                        if (fileExt.CompareTo(".cs") == 0)
                        {
                            ClassList classItem = new ClassList();
                            classItem.ClassName = fileName;
                            classList.Add(classItem);
                        }
                        //if (fileExt.CompareTo(".cs") == 0 && fileName != classListName.nameList[0])
                        //{
                        //    StreamReader sr = new StreamReader(file);
                        //    while ((line = sr.ReadLine()) != null)
                        //    {
                        //        if (Regex.IsMatch(line, classListName.nameList[0]))
                        //        {
                        //            richTextBox1.Text = classListName.nameList[0];
                        //            stringClass++;
                        //        }
                        //        sb.AppendLine(line);
                        //    }
                        //    sr.Close();
                        //    textBoxClass.Text = stringClass.ToString();
                        //    textBoxTotalOut.Text = stringClass.ToString();
                        //}
                        

                    }
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string fileExt = Path.GetExtension(file);
                        //rtb2.Text = classList?[4].ClassName?.ToString();
                        string newLine = "";
                        string[] lineArr = Array.Empty<string>();
                        string[] lineArr2;

                        if (fileExt.CompareTo(".cs") == 0)
                        {   
                            for (int i = 0; i < classList?.Count; i++)
                            {
                                if (classList[i].ClassName != fileName)
                                {
                                    StreamReader sr = new StreamReader(file);
                                    rtb2.Text = classList[i].ClassName;
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        if (Regex.IsMatch(line, $" {classList[i].ClassName} " ?? ""))
                                        {
                                            rtb1.Text = classList[i].ClassName;
                                            lineArr = line.Split(classList[i].ClassName);
                                            newLine = lineArr[1];
                                            //rtb3.Text = "text";
                                            lineArr2 = newLine.Split(" ");
                                            rtb3.Text = lineArr2[1];
                                            ObjectList objectItem = new ObjectList();
                                            objectItem.ClassName = classList[i].ClassName;
                                            objectItem.ObjectName = lineArr2[1];
                                            objectItem.ObjectUsage = 0;
                                            objectItem.FenIn = 0;
                                            objectList.Add(objectItem);
                                        }
                                        sb.AppendLine(line);
                                    }
                                    sr.Close();
                                }
                            }
                        }
                        
                    }
                    foreach (string file in files)
                    {
                        //rtb3.Text = objectList[0].ObjectName;
                        //rtb3.Text = "test";
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string fileExt = Path.GetExtension(file);
                        if (fileExt.CompareTo(".cs") == 0)
                        {
                            foreach (ObjectList objectItem in objectList)
                            {
                                StreamReader sr = new StreamReader(file);
                                while ((line = sr.ReadLine()) != null)
                                {
                                    if (Regex.IsMatch(line, objectItem.ObjectName ?? ""))
                                    {
                                        objectUsage++;
                                        objectItem.ObjectUsage = objectUsage;
                                    }
                                    sb.AppendLine(line);
                                }
                                sr.Close();
                                objectUsage = 0;
                            }
                        }
                    }
                    //foreach (ObjectList objectItem in objectList)
                    //{
                    //    foreach (string file in files)
                    //    {
                    //        string fileName = Path.GetFileNameWithoutExtension(file);
                    //        string fileExt = Path.GetExtension(file);
                    //        if (objectItem.ClassName != fileName)
                    //        {
                    //            StreamReader sr = new StreamReader(file);
                    //            while ((line = sr.ReadLine()) != null)
                    //            {
                    //                if (Regex.IsMatch(line, objectItem.ObjectName ?? ""))
                    //                {
                    //                    totalIn++;
                    //                }
                    //                objectItem.FenIn = totalIn;
                    //                sb.AppendLine(line);
                    //            }
                    //            sr.Close();
                    //        }
                    //    }

                    //}
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string fileExt = Path.GetExtension(file);
                        if (fileExt.CompareTo(".cs") == 0)
                        {
                            foreach (ObjectList objectItem in objectList)
                            {
                                StreamReader sr = new StreamReader(file);
                                while ((line = sr.ReadLine()) != null)
                                {
                                    if (objectItem.ClassName != fileName)
                                    {
                                        if (Regex.IsMatch(line, objectItem.ObjectName ?? ""))
                                        {
                                            totalIn++;
                                        }
                                    }
                                    sb.AppendLine(line);
                                }
                                objectItem.FenIn = totalIn;
                                totalIn = 0;
                                sr.Close();
                            }
                        }
                    }
                    foreach (ObjectList objectItem in objectList)
                    {
                        foreach (string file in files)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);
                            string fileExt = Path.GetExtension(file);
                            if (fileExt.CompareTo(".cs") == 0)
                            {
                                if (fileName != objectItem.ClassName)
                                {
                                    StreamReader sr = new StreamReader(file);
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        if (Regex.IsMatch(line, objectItem.ObjectName ?? ""))
                                        {
                                            totalOut++;
                                        }
                                        sb.AppendLine(line);
                                    }
                                    sr.Close();
                                }
                            }
                        }
                        objectItem.FenOut = totalOut;
                        totalOut = 0;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 0;
            string stringNumber = "";
            string stringObjectUsage = "";
            string stringFenIn = "";
            string stringFenOut = "";
            //StringBuilder sb1 = new StringBuilder();
            //foreach (ObjectList item in objectList)
            //{
            //    number++;
            //    stringNumber = number.ToString();
       
            //    sb1.AppendLine(stringNumber);
            //    sb1.AppendLine(item.ClassName);
            //    sb1.AppendLine(item.ObjectName);
            //    sb1.AppendLine(item.ObjectName);
            //    stringObjectUsage = item.ObjectUsage.ToString() ?? "";
            //    stringFenIn = item.FenIn.ToString() ?? "";
            //    stringFenOut = item.FenOut.ToString() ?? "";
            //    sb1.AppendLine(stringObjectUsage);
            //    sb1.AppendLine(stringFenIn);
            //    sb1.AppendLine(stringFenOut);
                
            //}
            //rtb1.Text = sb1.ToString();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var classCollectionCSV = new List<string>();
                    classCollectionCSV.Add("Number, Class / Object, usage, fen in, fen out");
                    foreach (var item in objectList)
                    {
                        number++;
                        stringNumber = number.ToString();
                        stringObjectUsage = item.ObjectUsage.ToString() ?? "";
                        stringFenIn = item.FenIn.ToString() ?? "";
                        stringFenOut = item.FenOut.ToString() ?? "";
                        classCollectionCSV.Add($"{stringNumber},{item.ClassName} / {item.ObjectName}, {item.ObjectUsage}, {item.FenIn}, {item.FenOut}");
                    }
                    File.WriteAllLines(sfd.FileName, classCollectionCSV);

                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C Sharp Files (.cs)|*.cs";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string fileExt = Path.GetExtension(file);
                    
                    StringBuilder sb = new StringBuilder();
                    string? line;
                    string newLine = "";
                    string[] lineArr = Array.Empty<string>();
                    string[] lineArr2;

                    if (fileExt.CompareTo(".cs") == 0)
                    {
                        StreamReader sr = new StreamReader(file);
                        foreach (ClassList classItem in classList ?? new List<ClassList>())
                        {
                            if (classItem.ClassName != fileName)
                            {
                                while ((line = sr.ReadLine()) != null)
                                {    
                                    if (Regex.IsMatch(line, @"\sForm2\s"))
                                    {
                                        lineArr = line.Split("Form2");
                                        newLine = lineArr[1];
                                        
                                        lineArr2 = newLine.Split(" ");
                                        rtb3.Text = lineArr2[1];
                                        ObjectList objectItem = new ObjectList();
                                        objectItem.ClassName = classItem.ClassName;
                                        objectItem.ObjectName = lineArr2[1];
                                        objectItem.ObjectUsage = 0;
                                        objectItem.FenIn = 0;
                                        objectList.Add(objectItem);
                                    }
                                    sb.AppendLine(line);
                                }
                            }
                        }
                        sr.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}