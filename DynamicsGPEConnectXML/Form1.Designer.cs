namespace DynamicsGPEConnectXML
{
    partial class Form1
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
            this.CmbServerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dbList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.xmlEcon = new DLTextEditor.TextAreaControl();
            this.excep = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbServerName
            // 
            this.CmbServerName.FormattingEnabled = true;
            this.CmbServerName.Location = new System.Drawing.Point(15, 25);
            this.CmbServerName.Name = "CmbServerName";
            this.CmbServerName.Size = new System.Drawing.Size(237, 21);
            this.CmbServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get DBs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // dbList
            // 
            this.dbList.Enabled = false;
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(393, 23);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(206, 21);
            this.dbList.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xmlEcon
            // 
            this.xmlEcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xmlEcon.LineViewerStyle = DLTextEditor.Document.LineViewerStyle.FullRow;
            this.xmlEcon.Location = new System.Drawing.Point(15, 74);
            this.xmlEcon.Name = "xmlEcon";
            this.xmlEcon.ShowEOLMarkers = true;
            this.xmlEcon.ShowRightMargin = true;
            this.xmlEcon.ShowSpaces = true;
            this.xmlEcon.ShowTabs = true;
            this.xmlEcon.Size = new System.Drawing.Size(584, 477);
            this.xmlEcon.TabIndex = 7;
            this.xmlEcon.UseAntiAliasFont = true;
            // 
            // excep
            // 
            this.excep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excep.Location = new System.Drawing.Point(15, 586);
            this.excep.Name = "excep";
            this.excep.ReadOnly = true;
            this.excep.Size = new System.Drawing.Size(584, 115);
            this.excep.TabIndex = 8;
            this.excep.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result/Exception";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "EConnect XML";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Format XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 557);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 713);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excep);
            this.Controls.Add(this.xmlEcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dbList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbServerName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dynamics GP EConnect XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dbList;
        private System.Windows.Forms.Button button2;
        private DLTextEditor.TextAreaControl xmlEcon;
        private System.Windows.Forms.RichTextBox excep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

