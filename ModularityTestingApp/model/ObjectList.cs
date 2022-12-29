using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularityTestingApp.model
{
    internal class ObjectList
    {
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

		private int? objectUsage = 0;

		public int? ObjectUsage
		{
			get { return objectUsage; }
			set { objectUsage = value; }
		}

		private int? fenIn = 0;

		public int? FenIn
		{
			get { return fenIn; }
			set { fenIn = value; }
		}

        private int? fenOut = 0;

        public int? FenOut
        {
            get { return fenOut; }
            set { fenOut = value; }
        }

    }
}
