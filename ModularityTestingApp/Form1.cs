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
        int totalAllIn = 0;
        int totalAllOut = 0;
        int averageIn = 0;
        int averageOut = 0;

        string stringNumber = "";
        string stringObjectName = "";
        string stringObjectUsage = "";
        string stringFenIn = "";
        string stringFenOut = "";
        string stringAverageFenOut = "";
        string stringAverageFenIn = "";
        string stringModularitySum = "";

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
                    }
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        string fileExt = Path.GetExtension(file);
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
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        if (Regex.IsMatch(line, $" {classList[i].ClassName} " ?? ""))
                                        {
                                            lineArr = line.Split(classList[i].ClassName);
                                            newLine = lineArr[1];
                                            lineArr2 = newLine.Split(" ");
                                            ObjectList objectItem = new ObjectList();
                                            objectItem.ClassName = classList[i].ClassName;
                                            objectItem.ObjectName = lineArr2[1];
                                            objectItem.ObjectUsage = 0;
                                            objectItem.FanIn = 0;
                                            objectItem.FanOut = 0;
                                            objectItem.AverageFanIn = 0;
                                            objectItem.AverageFanOut = 0;
                                            objectItem.Modularity = 0;
                                            objectList.Add(objectItem);
                                        }
                                        sb.AppendLine(line);
                                    }
                                    sr.Close();
                                }
                                else
                                {
                                    ObjectList objectItem = new ObjectList();
                                    objectItem.ClassName = classList[i].ClassName;
                                    objectItem.ObjectName = "";
                                    objectItem.ObjectUsage = 0;
                                    objectItem.FanIn = 0;
                                    objectItem.FanOut = 0;
                                    objectItem.AverageFanIn = 0;
                                    objectItem.AverageFanOut = 0;
                                    objectItem.Modularity = 0;
                                    objectList.Add(objectItem);
                                }
                            }
                        }

                    }
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
                                    if (Regex.IsMatch(line, objectItem.ObjectName ?? "") && objectItem.ObjectName != "")
                                    {
                                        objectUsage++;
                                        objectItem.ObjectUsage += objectUsage;
                                    }
                                    sb.AppendLine(line);
                                }
                                sr.Close();
                                objectUsage = 0;
                            }
                        }
                    }
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
                                        if (Regex.IsMatch(line, objectItem.ObjectName ?? "") && objectItem.ObjectName != "")
                                        {
                                            totalIn++;
                                        }
                                    }
                                    if (Regex.IsMatch(line, @"\s:\s"))
                                    {
                                        totalIn++;
                                    }
                                    sb.AppendLine(line);
                                }
                                objectItem.FanIn += totalIn;
                                totalAllIn += totalIn;
                                sr.Close();
                                totalIn = 0;
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
                                        if (Regex.IsMatch(line, objectItem.ObjectName ?? "") && objectItem.ObjectName != "")
                                        {
                                            totalOut++;
                                        }
                                        sb.AppendLine(line);
                                    }
                                    sr.Close();
                                }
                            }
                        }
                        objectItem.FanOut += totalOut;
                        totalAllOut += totalOut;
                        totalOut = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int number = 0;
            averageIn = totalAllIn / objectList.Count();
            averageOut = totalAllOut / objectList.Count();

            foreach (var item in objectList)
            {
                item.AverageFanIn = averageIn;
                item.AverageFanOut = averageOut;
                item.Modularity = (item.FanIn * item.FanIn) - (item.FanOut * item.FanOut);
                number++;
                stringNumber = number.ToString();
                stringObjectName = $"{item.ClassName} / {item.ObjectName}";
                stringObjectUsage = item.ObjectUsage.ToString() ?? "";
                stringFenIn = item.FanIn.ToString() ?? "";
                stringFenOut = item.FanOut.ToString() ?? "";
                stringAverageFenIn = averageIn.ToString();
                stringAverageFenOut = averageOut.ToString();
                stringModularitySum = item.Modularity.ToString() ?? "";
                dataGridView1.Rows.Add(stringNumber, stringObjectName, stringObjectUsage, stringFenIn, stringFenOut, stringAverageFenIn, stringAverageFenOut, stringModularitySum);
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int number = 0;
            averageIn = totalAllIn / objectList.Count();
            averageOut = totalAllOut / objectList.Count();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var classCollectionCSV = new List<string>();
                    classCollectionCSV.Add("Number, Class / Object, Number of Object Occurance, Fan In, Fan Out, Average Fan In, Average Fan Out, Modularity");
                    foreach (var item in objectList)
                    {
                        item.AverageFanIn = averageIn;
                        item.AverageFanOut = averageOut;
                        item.Modularity = (item.FanIn * item.FanIn) - (item.FanOut * item.FanOut);
                        number++;
                        stringNumber = number.ToString();
                        stringObjectName = $"{item.ClassName} / {item.ObjectName}";
                        stringObjectUsage = item.ObjectUsage.ToString() ?? "";
                        stringFenIn = item.FanIn.ToString() ?? "";
                        stringFenOut = item.FanOut.ToString() ?? "";
                        stringAverageFenIn = averageIn.ToString();
                        stringAverageFenOut = averageOut.ToString();
                        stringModularitySum = item.Modularity.ToString() ?? "";
                        classCollectionCSV.Add($"{stringNumber},{item.ClassName} / {item.ObjectName}, {item.ObjectUsage}, {item.FanIn}, {item.FanOut}, {item.AverageFanIn}, {item.AverageFanOut}, {item.Modularity}");
                    }
                    File.WriteAllLines(sfd.FileName, classCollectionCSV);

                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}