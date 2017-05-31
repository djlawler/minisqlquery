﻿namespace MiniSqlQuery.Exports.Plugin
{
    partial class ExportWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbtHtml = new System.Windows.Forms.RadioButton();
            this.rbtCsv = new System.Windows.Forms.RadioButton();
            this.rbtXml = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbxTrimming = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.chkDumpAll = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbxQuoting = new System.Windows.Forms.ComboBox();
            this.txtDelim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkRowNames = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRowBgAltColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRowBgcolor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHeaderBGColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFontColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFontFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxBatch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export to file:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(15, 25);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(428, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageKey = "VSFolder_open.bmp";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(449, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "VSFolder_open.bmp");
            // 
            // rbtHtml
            // 
            this.rbtHtml.AutoSize = true;
            this.rbtHtml.Location = new System.Drawing.Point(15, 51);
            this.rbtHtml.Name = "rbtHtml";
            this.rbtHtml.Size = new System.Drawing.Size(46, 17);
            this.rbtHtml.TabIndex = 3;
            this.rbtHtml.Text = "Html";
            this.rbtHtml.UseVisualStyleBackColor = true;
            this.rbtHtml.CheckedChanged += new System.EventHandler(this.rbtHtml_CheckedChanged);
            // 
            // rbtCsv
            // 
            this.rbtCsv.AutoSize = true;
            this.rbtCsv.Checked = true;
            this.rbtCsv.Location = new System.Drawing.Point(77, 51);
            this.rbtCsv.Name = "rbtCsv";
            this.rbtCsv.Size = new System.Drawing.Size(43, 17);
            this.rbtCsv.TabIndex = 4;
            this.rbtCsv.TabStop = true;
            this.rbtCsv.Text = "Csv";
            this.rbtCsv.UseVisualStyleBackColor = true;
            this.rbtCsv.CheckedChanged += new System.EventHandler(this.rbtCsv_CheckedChanged);
            // 
            // rbtXml
            // 
            this.rbtXml.AutoSize = true;
            this.rbtXml.Location = new System.Drawing.Point(126, 51);
            this.rbtXml.Name = "rbtXml";
            this.rbtXml.Size = new System.Drawing.Size(42, 17);
            this.rbtXml.TabIndex = 5;
            this.rbtXml.Text = "Xml";
            this.rbtXml.UseVisualStyleBackColor = true;
            this.rbtXml.CheckedChanged += new System.EventHandler(this.rbtXml_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(320, 603);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 386);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbxTrimming);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtSQL);
            this.groupBox3.Controls.Add(this.chkDumpAll);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbxQuoting);
            this.groupBox3.Controls.Add(this.txtDelim);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.chkRowNames);
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 166);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Csv";
            // 
            // cmbxTrimming
            // 
            this.cmbxTrimming.FormattingEnabled = true;
            this.cmbxTrimming.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right",
            "Both"});
            this.cmbxTrimming.Location = new System.Drawing.Point(68, 57);
            this.cmbxTrimming.Name = "cmbxTrimming";
            this.cmbxTrimming.Size = new System.Drawing.Size(79, 21);
            this.cmbxTrimming.TabIndex = 18;
            this.cmbxTrimming.Text = "Right";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Trimming";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "SQL";
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(170, 74);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(261, 92);
            this.txtSQL.TabIndex = 8;
            this.txtSQL.WordWrap = false;
            // 
            // chkDumpAll
            // 
            this.chkDumpAll.AutoSize = true;
            this.chkDumpAll.Location = new System.Drawing.Point(9, 132);
            this.chkDumpAll.Name = "chkDumpAll";
            this.chkDumpAll.Size = new System.Drawing.Size(101, 17);
            this.chkDumpAll.TabIndex = 7;
            this.chkDumpAll.Text = "Dump from SQL";
            this.chkDumpAll.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Quotes";
            // 
            // cmbxQuoting
            // 
            this.cmbxQuoting.FormattingEnabled = true;
            this.cmbxQuoting.Items.AddRange(new object[] {
            "When Needed",
            "Never",
            "Always"});
            this.cmbxQuoting.Location = new System.Drawing.Point(349, 16);
            this.cmbxQuoting.Name = "cmbxQuoting";
            this.cmbxQuoting.Size = new System.Drawing.Size(94, 21);
            this.cmbxQuoting.TabIndex = 5;
            this.cmbxQuoting.Text = "Always";
            // 
            // txtDelim
            // 
            this.txtDelim.Location = new System.Drawing.Point(223, 17);
            this.txtDelim.Name = "txtDelim";
            this.txtDelim.Size = new System.Drawing.Size(47, 20);
            this.txtDelim.TabIndex = 4;
            this.txtDelim.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Delimiter";
            // 
            // chkRowNames
            // 
            this.chkRowNames.AutoSize = true;
            this.chkRowNames.Checked = true;
            this.chkRowNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRowNames.Location = new System.Drawing.Point(9, 19);
            this.chkRowNames.Name = "chkRowNames";
            this.chkRowNames.Size = new System.Drawing.Size(145, 17);
            this.chkRowNames.TabIndex = 0;
            this.chkRowNames.Text = "Column names in first row";
            this.chkRowNames.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRowBgAltColor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRowBgcolor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHeaderBGColor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFontColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFontSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFontFamily);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Html";
            // 
            // txtRowBgAltColor
            // 
            this.txtRowBgAltColor.Location = new System.Drawing.Point(241, 131);
            this.txtRowBgAltColor.Name = "txtRowBgAltColor";
            this.txtRowBgAltColor.Size = new System.Drawing.Size(100, 20);
            this.txtRowBgAltColor.TabIndex = 15;
            this.txtRowBgAltColor.Text = "#F2F2F2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Alternate";
            // 
            // txtRowBgcolor
            // 
            this.txtRowBgcolor.Location = new System.Drawing.Point(62, 131);
            this.txtRowBgcolor.Name = "txtRowBgcolor";
            this.txtRowBgcolor.Size = new System.Drawing.Size(100, 20);
            this.txtRowBgcolor.TabIndex = 13;
            this.txtRowBgcolor.Text = "#FFFFFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Row";
            // 
            // txtHeaderBGColor
            // 
            this.txtHeaderBGColor.Location = new System.Drawing.Point(62, 82);
            this.txtHeaderBGColor.Name = "txtHeaderBGColor";
            this.txtHeaderBGColor.Size = new System.Drawing.Size(100, 20);
            this.txtHeaderBGColor.TabIndex = 10;
            this.txtHeaderBGColor.Text = "#CAE1FF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Color";
            // 
            // txtFontColor
            // 
            this.txtFontColor.Location = new System.Drawing.Point(319, 35);
            this.txtFontColor.Name = "txtFontColor";
            this.txtFontColor.Size = new System.Drawing.Size(100, 20);
            this.txtFontColor.TabIndex = 8;
            this.txtFontColor.Text = "#000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Font";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(223, 35);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(53, 20);
            this.txtFontSize.TabIndex = 5;
            this.txtFontSize.Text = "12px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Font size";
            // 
            // txtFontFamily
            // 
            this.txtFontFamily.Location = new System.Drawing.Point(62, 35);
            this.txtFontFamily.Name = "txtFontFamily";
            this.txtFontFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFontFamily.TabIndex = 3;
            this.txtFontFamily.Text = "Verdana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Family";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Header";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(473, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBoxBatch);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(15, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 112);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batch CSV Export";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageKey = "VSFolder_open.bmp";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(421, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxBatch
            // 
            this.textBoxBatch.Location = new System.Drawing.Point(15, 35);
            this.textBoxBatch.Name = "textBoxBatch";
            this.textBoxBatch.Size = new System.Drawing.Size(396, 20);
            this.textBoxBatch.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-2, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Batch File";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Batch CSV Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(15, 62);
            this.label16.MinimumSize = new System.Drawing.Size(300, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(300, 47);
            this.label16.TabIndex = 9;
            this.label16.Text = "File with a list of paths to SQL queries.  One query per file.  Output will be pl" +
    "aced in the same directory and use the same file name (.csv extension)";
            // 
            // ExportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 656);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbtXml);
            this.Controls.Add(this.rbtCsv);
            this.Controls.Add(this.rbtHtml);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportWindowFormClosing);
            this.Load += new System.EventHandler(this.ExportWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbxTrimming;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkDumpAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDelim;
        private System.Windows.Forms.ComboBox cmbxQuoting;
        private System.Windows.Forms.Label label12;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtHtml;
        private System.Windows.Forms.RadioButton rbtCsv;
        private System.Windows.Forms.RadioButton rbtXml;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRowBgAltColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRowBgcolor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHeaderBGColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFontColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFontFamily;
        private System.Windows.Forms.CheckBox chkRowNames;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBatch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}