﻿namespace ModularityTestingApp
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
            this.textBoxExtend = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.labelExtends = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.labelTotalIn = new System.Windows.Forms.Label();
            this.textBoxTotalIn = new System.Windows.Forms.TextBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelTotalOut = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxTotalOut = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse your .CS file";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 261);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose File";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxExtend
            // 
            this.textBoxExtend.Location = new System.Drawing.Point(75, 16);
            this.textBoxExtend.Name = "textBoxExtend";
            this.textBoxExtend.Size = new System.Drawing.Size(125, 27);
            this.textBoxExtend.TabIndex = 4;
            this.textBoxExtend.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(75, 49);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(125, 27);
            this.textBoxNew.TabIndex = 5;
            this.textBoxNew.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelExtends
            // 
            this.labelExtends.AutoSize = true;
            this.labelExtends.Location = new System.Drawing.Point(15, 19);
            this.labelExtends.Name = "labelExtends";
            this.labelExtends.Size = new System.Drawing.Size(54, 20);
            this.labelExtends.TabIndex = 6;
            this.labelExtends.Text = "extend";
            this.labelExtends.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "new";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.labelTotalIn);
            this.groupBoxIn.Controls.Add(this.textBoxExtend);
            this.groupBoxIn.Controls.Add(this.textBoxTotalIn);
            this.groupBoxIn.Controls.Add(this.label3);
            this.groupBoxIn.Controls.Add(this.textBoxNew);
            this.groupBoxIn.Controls.Add(this.labelExtends);
            this.groupBoxIn.Location = new System.Drawing.Point(588, 12);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(200, 118);
            this.groupBoxIn.TabIndex = 8;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "In";
            this.groupBoxIn.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelTotalIn
            // 
            this.labelTotalIn.AutoSize = true;
            this.labelTotalIn.Location = new System.Drawing.Point(11, 85);
            this.labelTotalIn.Name = "labelTotalIn";
            this.labelTotalIn.Size = new System.Drawing.Size(58, 20);
            this.labelTotalIn.TabIndex = 11;
            this.labelTotalIn.Text = "Total In";
            this.labelTotalIn.Click += new System.EventHandler(this.labelTotalIn_Click);
            // 
            // textBoxTotalIn
            // 
            this.textBoxTotalIn.Location = new System.Drawing.Point(75, 82);
            this.textBoxTotalIn.Name = "textBoxTotalIn";
            this.textBoxTotalIn.Size = new System.Drawing.Size(125, 27);
            this.textBoxTotalIn.TabIndex = 10;
            this.textBoxTotalIn.TextChanged += new System.EventHandler(this.textBoxTotalIn_TextChanged);
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.labelTotalOut);
            this.groupBoxOut.Controls.Add(this.textBoxClass);
            this.groupBoxOut.Controls.Add(this.textBoxTotalOut);
            this.groupBoxOut.Controls.Add(this.labelClass);
            this.groupBoxOut.Location = new System.Drawing.Point(367, 12);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(215, 118);
            this.groupBoxOut.TabIndex = 9;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Out";
            // 
            // labelTotalOut
            // 
            this.labelTotalOut.AutoSize = true;
            this.labelTotalOut.Location = new System.Drawing.Point(8, 52);
            this.labelTotalOut.Name = "labelTotalOut";
            this.labelTotalOut.Size = new System.Drawing.Size(70, 20);
            this.labelTotalOut.TabIndex = 11;
            this.labelTotalOut.Text = "Total Out";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(84, 16);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(125, 27);
            this.textBoxClass.TabIndex = 4;
            // 
            // textBoxTotalOut
            // 
            this.textBoxTotalOut.Location = new System.Drawing.Point(84, 49);
            this.textBoxTotalOut.Name = "textBoxTotalOut";
            this.textBoxTotalOut.Size = new System.Drawing.Size(125, 27);
            this.textBoxTotalOut.TabIndex = 10;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(36, 19);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(42, 20);
            this.labelClass.TabIndex = 6;
            this.labelClass.Text = "Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
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
    }
}