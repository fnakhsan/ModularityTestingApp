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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxExtend = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.labelExtends = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClass2 = new System.Windows.Forms.TextBox();
            this.labelTotalIn = new System.Windows.Forms.Label();
            this.textBoxTotalIn = new System.Windows.Forms.TextBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelTotalOut = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxTotalOut = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse your project";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 133);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(680, 197);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(140, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose File";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Browse your c# file";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxExtend
            // 
            this.textBoxExtend.Location = new System.Drawing.Point(66, 12);
            this.textBoxExtend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExtend.Name = "textBoxExtend";
            this.textBoxExtend.Size = new System.Drawing.Size(110, 23);
            this.textBoxExtend.TabIndex = 4;
            this.textBoxExtend.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(66, 37);
            this.textBoxNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(110, 23);
            this.textBoxNew.TabIndex = 5;
            this.textBoxNew.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelExtends
            // 
            this.labelExtends.AutoSize = true;
            this.labelExtends.Location = new System.Drawing.Point(13, 14);
            this.labelExtends.Name = "labelExtends";
            this.labelExtends.Size = new System.Drawing.Size(43, 15);
            this.labelExtends.TabIndex = 6;
            this.labelExtends.Text = "extend";
            this.labelExtends.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "new";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.label4);
            this.groupBoxIn.Controls.Add(this.textBoxClass2);
            this.groupBoxIn.Controls.Add(this.labelTotalIn);
            this.groupBoxIn.Controls.Add(this.textBoxExtend);
            this.groupBoxIn.Controls.Add(this.textBoxTotalIn);
            this.groupBoxIn.Controls.Add(this.label3);
            this.groupBoxIn.Controls.Add(this.textBoxNew);
            this.groupBoxIn.Controls.Add(this.labelExtends);
            this.groupBoxIn.Location = new System.Drawing.Point(514, 9);
            this.groupBoxIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIn.Size = new System.Drawing.Size(175, 119);
            this.groupBoxIn.TabIndex = 8;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "In";
            this.groupBoxIn.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Class";
            // 
            // textBoxClass2
            // 
            this.textBoxClass2.Location = new System.Drawing.Point(66, 89);
            this.textBoxClass2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClass2.Name = "textBoxClass2";
            this.textBoxClass2.Size = new System.Drawing.Size(110, 23);
            this.textBoxClass2.TabIndex = 11;
            // 
            // labelTotalIn
            // 
            this.labelTotalIn.AutoSize = true;
            this.labelTotalIn.Location = new System.Drawing.Point(10, 64);
            this.labelTotalIn.Name = "labelTotalIn";
            this.labelTotalIn.Size = new System.Drawing.Size(45, 15);
            this.labelTotalIn.TabIndex = 11;
            this.labelTotalIn.Text = "Total In";
            this.labelTotalIn.Click += new System.EventHandler(this.labelTotalIn_Click);
            // 
            // textBoxTotalIn
            // 
            this.textBoxTotalIn.Location = new System.Drawing.Point(66, 62);
            this.textBoxTotalIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotalIn.Name = "textBoxTotalIn";
            this.textBoxTotalIn.Size = new System.Drawing.Size(110, 23);
            this.textBoxTotalIn.TabIndex = 10;
            this.textBoxTotalIn.TextChanged += new System.EventHandler(this.textBoxTotalIn_TextChanged);
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.labelTotalOut);
            this.groupBoxOut.Controls.Add(this.textBoxClass);
            this.groupBoxOut.Controls.Add(this.textBoxTotalOut);
            this.groupBoxOut.Controls.Add(this.labelClass);
            this.groupBoxOut.Location = new System.Drawing.Point(321, 9);
            this.groupBoxOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOut.Size = new System.Drawing.Size(188, 88);
            this.groupBoxOut.TabIndex = 9;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Out";
            // 
            // labelTotalOut
            // 
            this.labelTotalOut.AutoSize = true;
            this.labelTotalOut.Location = new System.Drawing.Point(7, 39);
            this.labelTotalOut.Name = "labelTotalOut";
            this.labelTotalOut.Size = new System.Drawing.Size(55, 15);
            this.labelTotalOut.TabIndex = 11;
            this.labelTotalOut.Text = "Total Out";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(74, 12);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(110, 23);
            this.textBoxClass.TabIndex = 4;
            // 
            // textBoxTotalOut
            // 
            this.textBoxTotalOut.Location = new System.Drawing.Point(74, 37);
            this.textBoxTotalOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotalOut.Name = "textBoxTotalOut";
            this.textBoxTotalOut.Size = new System.Drawing.Size(110, 23);
            this.textBoxTotalOut.TabIndex = 10;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(32, 14);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(34, 15);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private TextBox textBoxExtend;
        private TextBox textBoxNew;
        private Label labelExtends;
        private Label label3;
        private GroupBox groupBoxIn;
        private TextBox textBoxTotalIn;
        private Label labelTotalIn;
        private GroupBox groupBoxOut;
        private Label labelTotalOut;
        private TextBox textBoxClass;
        private TextBox textBoxTotalOut;
        private Label labelClass;
        private Label label2;
        private Button button2;
        private Label label4;
        private TextBox textBoxClass2;
        private Button button3;
    }
}