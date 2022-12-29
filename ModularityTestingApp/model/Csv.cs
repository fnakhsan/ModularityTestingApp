using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularityTestingApp.model
{
    /*setiap kelas atau objek brp fen in
    kolom pertama nomor
    kolom kedua nama class / object name
    kolom ketiga number
    kolom keempat number of fen in
    nomor kelima number of fen out
    rata-rata fen in
    jumlah fen in seluruh objek, dibagi total objeknya
    jumlah seluruh fen out, dibagi jumlah objek*/
    internal class Csv
    {
        private string? number = "";
        public string? Number
        {
            get { return number; }
            set { number = value; }
        }

        private string? className = "";

        public string? ClassName
        {
            get { return className; }
            set { className = value; }
        }

        private string? objectName = "";

        public string? ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }

        private string? objectUsage = "";

        public string? ObjectUsage
        {
            get { return objectUsage; }
            set { objectUsage = value; }
        }

        private string? fenIn = "";

        public string? FenIn
        {
            get { return fenIn; }
            set { fenIn = value; }
        }

        private string? fenOut = "";

        public string? FenOut
        {
            get { return fenOut; }
            set { fenOut = value; }
        }
    }
}
