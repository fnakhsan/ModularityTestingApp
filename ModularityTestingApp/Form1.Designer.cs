namespace ModularityTestingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanInAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanOutAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modularity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse your project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(5, 46);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(99, 22);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Choose Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(135, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose File";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Print to CSV";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 158);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(5, 102);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(82, 22);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.className,
            this.occurance,
            this.fanIn,
            this.fanOut,
            this.fanInAverage,
            this.fanOutAverage,
            this.modularity});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(135, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(823, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // number
            // 
            this.number.FillWeight = 40F;
            this.number.HeaderText = "No.";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // className
            // 
            this.className.FillWeight = 160F;
            this.className.HeaderText = "Class / Object Name";
            this.className.MinimumWidth = 6;
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // occurance
            // 
            this.occurance.FillWeight = 125F;
            this.occurance.HeaderText = "Number of Object Occurance";
            this.occurance.MinimumWidth = 6;
            this.occurance.Name = "occurance";
            this.occurance.ReadOnly = true;
            // 
            // fanIn
            // 
            this.fanIn.FillWeight = 108.4844F;
            this.fanIn.HeaderText = "Fan In";
            this.fanIn.MinimumWidth = 6;
            this.fanIn.Name = "fanIn";
            this.fanIn.ReadOnly = true;
            // 
            // fanOut
            // 
            this.fanOut.FillWeight = 108.4844F;
            this.fanOut.HeaderText = "Fan Out";
            this.fanOut.MinimumWidth = 6;
            this.fanOut.Name = "fanOut";
            this.fanOut.ReadOnly = true;
            // 
            // fanInAverage
            // 
            this.fanInAverage.FillWeight = 108.4844F;
            this.fanInAverage.HeaderText = "Fan In Average";
            this.fanInAverage.MinimumWidth = 6;
            this.fanInAverage.Name = "fanInAverage";
            this.fanInAverage.ReadOnly = true;
            // 
            // fanOutAverage
            // 
            this.fanOutAverage.FillWeight = 108.4844F;
            this.fanOutAverage.HeaderText = "Fan Out Average";
            this.fanOutAverage.MinimumWidth = 6;
            this.fanOutAverage.Name = "fanOutAverage";
            this.fanOutAverage.ReadOnly = true;
            // 
            // modularity
            // 
            this.modularity.FillWeight = 108.4844F;
            this.modularity.HeaderText = "Modularity";
            this.modularity.MinimumWidth = 6;
            this.modularity.Name = "modularity";
            this.modularity.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btnFolder;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnShow;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btnPrint;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn occurance;
        private DataGridViewTextBoxColumn fanIn;
        private DataGridViewTextBoxColumn fanOut;
        private DataGridViewTextBoxColumn fanInAverage;
        private DataGridViewTextBoxColumn fanOutAverage;
        private DataGridViewTextBoxColumn modularity;
    }
}