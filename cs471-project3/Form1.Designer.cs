
namespace cs471_project3
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
            this.CurrentDirectoryView_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.stepInto_TextBox = new System.Windows.Forms.TextBox();
            this.stepInto_button = new System.Windows.Forms.Button();
            this.stepOut_button = new System.Windows.Forms.Button();
            this.createDirectory_Button = new System.Windows.Forms.Button();
            this.Create_File_Button = new System.Windows.Forms.Button();
            this.filename_Text_Box = new System.Windows.Forms.TextBox();
            this.filecontent_TextBox = new System.Windows.Forms.TextBox();
            this.openFile_Button = new System.Windows.Forms.Button();
            this.openfile_textBox = new System.Windows.Forms.TextBox();
            this.filecontent_richTextBox = new System.Windows.Forms.RichTextBox();
            this.deleteFile_button = new System.Windows.Forms.Button();
            this.fullfilesystemview_richTextBox = new System.Windows.Forms.RichTextBox();
            this.directoryName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentDirectoryView_RichTextBox
            // 
            this.CurrentDirectoryView_RichTextBox.Location = new System.Drawing.Point(13, 40);
            this.CurrentDirectoryView_RichTextBox.Name = "CurrentDirectoryView_RichTextBox";
            this.CurrentDirectoryView_RichTextBox.Size = new System.Drawing.Size(291, 398);
            this.CurrentDirectoryView_RichTextBox.TabIndex = 0;
            this.CurrentDirectoryView_RichTextBox.Text = "";
            // 
            // stepInto_TextBox
            // 
            this.stepInto_TextBox.Location = new System.Drawing.Point(310, 58);
            this.stepInto_TextBox.Name = "stepInto_TextBox";
            this.stepInto_TextBox.Size = new System.Drawing.Size(100, 23);
            this.stepInto_TextBox.TabIndex = 1;
            // 
            // stepInto_button
            // 
            this.stepInto_button.Location = new System.Drawing.Point(416, 59);
            this.stepInto_button.Name = "stepInto_button";
            this.stepInto_button.Size = new System.Drawing.Size(108, 23);
            this.stepInto_button.TabIndex = 2;
            this.stepInto_button.Text = "Step Into";
            this.stepInto_button.UseVisualStyleBackColor = true;
            this.stepInto_button.Click += new System.EventHandler(this.stepInto_button_Click);
            // 
            // stepOut_button
            // 
            this.stepOut_button.Location = new System.Drawing.Point(416, 88);
            this.stepOut_button.Name = "stepOut_button";
            this.stepOut_button.Size = new System.Drawing.Size(108, 23);
            this.stepOut_button.TabIndex = 3;
            this.stepOut_button.Text = "Step Out";
            this.stepOut_button.UseVisualStyleBackColor = true;
            this.stepOut_button.Click += new System.EventHandler(this.stepOut_button_Click);
            // 
            // createDirectory_Button
            // 
            this.createDirectory_Button.Location = new System.Drawing.Point(416, 126);
            this.createDirectory_Button.Name = "createDirectory_Button";
            this.createDirectory_Button.Size = new System.Drawing.Size(108, 23);
            this.createDirectory_Button.TabIndex = 4;
            this.createDirectory_Button.Text = "Create Directory";
            this.createDirectory_Button.UseVisualStyleBackColor = true;
            this.createDirectory_Button.Click += new System.EventHandler(this.createDirectory_Button_Click);
            // 
            // Create_File_Button
            // 
            this.Create_File_Button.Location = new System.Drawing.Point(416, 178);
            this.Create_File_Button.Name = "Create_File_Button";
            this.Create_File_Button.Size = new System.Drawing.Size(108, 23);
            this.Create_File_Button.TabIndex = 5;
            this.Create_File_Button.Text = "Create File";
            this.Create_File_Button.UseVisualStyleBackColor = true;
            this.Create_File_Button.Click += new System.EventHandler(this.Create_File_Button_Click);
            // 
            // filename_Text_Box
            // 
            this.filename_Text_Box.Location = new System.Drawing.Point(310, 178);
            this.filename_Text_Box.Name = "filename_Text_Box";
            this.filename_Text_Box.Size = new System.Drawing.Size(100, 23);
            this.filename_Text_Box.TabIndex = 6;
            // 
            // filecontent_TextBox
            // 
            this.filecontent_TextBox.Location = new System.Drawing.Point(310, 222);
            this.filecontent_TextBox.Name = "filecontent_TextBox";
            this.filecontent_TextBox.Size = new System.Drawing.Size(214, 23);
            this.filecontent_TextBox.TabIndex = 7;
            // 
            // openFile_Button
            // 
            this.openFile_Button.Location = new System.Drawing.Point(416, 286);
            this.openFile_Button.Name = "openFile_Button";
            this.openFile_Button.Size = new System.Drawing.Size(110, 23);
            this.openFile_Button.TabIndex = 8;
            this.openFile_Button.Text = "Open File";
            this.openFile_Button.UseVisualStyleBackColor = true;
            this.openFile_Button.Click += new System.EventHandler(this.openFile_Button_Click);
            // 
            // openfile_textBox
            // 
            this.openfile_textBox.Location = new System.Drawing.Point(310, 286);
            this.openfile_textBox.Name = "openfile_textBox";
            this.openfile_textBox.Size = new System.Drawing.Size(100, 23);
            this.openfile_textBox.TabIndex = 9;
            // 
            // filecontent_richTextBox
            // 
            this.filecontent_richTextBox.Location = new System.Drawing.Point(310, 342);
            this.filecontent_richTextBox.Name = "filecontent_richTextBox";
            this.filecontent_richTextBox.Size = new System.Drawing.Size(216, 96);
            this.filecontent_richTextBox.TabIndex = 10;
            this.filecontent_richTextBox.Text = "";
            this.filecontent_richTextBox.TextChanged += new System.EventHandler(this.filecontent_richTextBox_TextChanged);
            // 
            // deleteFile_button
            // 
            this.deleteFile_button.Location = new System.Drawing.Point(416, 313);
            this.deleteFile_button.Name = "deleteFile_button";
            this.deleteFile_button.Size = new System.Drawing.Size(110, 23);
            this.deleteFile_button.TabIndex = 11;
            this.deleteFile_button.Text = "Delete File";
            this.deleteFile_button.UseVisualStyleBackColor = true;
            this.deleteFile_button.Click += new System.EventHandler(this.deleteFile_button_Click);
            // 
            // fullfilesystemview_richTextBox
            // 
            this.fullfilesystemview_richTextBox.Location = new System.Drawing.Point(546, 40);
            this.fullfilesystemview_richTextBox.Name = "fullfilesystemview_richTextBox";
            this.fullfilesystemview_richTextBox.Size = new System.Drawing.Size(325, 398);
            this.fullfilesystemview_richTextBox.TabIndex = 12;
            this.fullfilesystemview_richTextBox.Text = "";
            // 
            // directoryName_textBox
            // 
            this.directoryName_textBox.Location = new System.Drawing.Point(310, 126);
            this.directoryName_textBox.Name = "directoryName_textBox";
            this.directoryName_textBox.Size = new System.Drawing.Size(100, 23);
            this.directoryName_textBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Directory Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "File Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Content";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Local Directory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Virtual File View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryName_textBox);
            this.Controls.Add(this.fullfilesystemview_richTextBox);
            this.Controls.Add(this.deleteFile_button);
            this.Controls.Add(this.filecontent_richTextBox);
            this.Controls.Add(this.openfile_textBox);
            this.Controls.Add(this.openFile_Button);
            this.Controls.Add(this.filecontent_TextBox);
            this.Controls.Add(this.filename_Text_Box);
            this.Controls.Add(this.Create_File_Button);
            this.Controls.Add(this.createDirectory_Button);
            this.Controls.Add(this.stepOut_button);
            this.Controls.Add(this.stepInto_button);
            this.Controls.Add(this.stepInto_TextBox);
            this.Controls.Add(this.CurrentDirectoryView_RichTextBox);
            this.Name = "Form1";
            this.Text = "Virtual File System Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CurrentDirectoryView_RichTextBox;
        private System.Windows.Forms.TextBox stepInto_TextBox;
        private System.Windows.Forms.Button stepInto_button;
        private System.Windows.Forms.Button stepOut_button;
        private System.Windows.Forms.Button createDirectory_Button;
        private System.Windows.Forms.Button Create_File_Button;
        private System.Windows.Forms.TextBox filename_Text_Box;
        private System.Windows.Forms.TextBox filecontent_TextBox;
        private System.Windows.Forms.Button openFile_Button;
        private System.Windows.Forms.TextBox openfile_textBox;
        private System.Windows.Forms.RichTextBox filecontent_richTextBox;
        private System.Windows.Forms.Button deleteFile_button;
        private System.Windows.Forms.RichTextBox fullfilesystemview_richTextBox;
        private System.Windows.Forms.TextBox directoryName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

