
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
            this.SuspendLayout();
            // 
            // CurrentDirectoryView_RichTextBox
            // 
            this.CurrentDirectoryView_RichTextBox.Location = new System.Drawing.Point(13, 13);
            this.CurrentDirectoryView_RichTextBox.Name = "CurrentDirectoryView_RichTextBox";
            this.CurrentDirectoryView_RichTextBox.Size = new System.Drawing.Size(291, 425);
            this.CurrentDirectoryView_RichTextBox.TabIndex = 0;
            this.CurrentDirectoryView_RichTextBox.Text = "";
            // 
            // stepInto_TextBox
            // 
            this.stepInto_TextBox.Location = new System.Drawing.Point(330, 12);
            this.stepInto_TextBox.Name = "stepInto_TextBox";
            this.stepInto_TextBox.Size = new System.Drawing.Size(100, 23);
            this.stepInto_TextBox.TabIndex = 1;
            // 
            // stepInto_button
            // 
            this.stepInto_button.Location = new System.Drawing.Point(436, 13);
            this.stepInto_button.Name = "stepInto_button";
            this.stepInto_button.Size = new System.Drawing.Size(75, 23);
            this.stepInto_button.TabIndex = 2;
            this.stepInto_button.Text = "Step Into";
            this.stepInto_button.UseVisualStyleBackColor = true;
            this.stepInto_button.Click += new System.EventHandler(this.stepInto_button_Click);
            // 
            // stepOut_button
            // 
            this.stepOut_button.Location = new System.Drawing.Point(436, 42);
            this.stepOut_button.Name = "stepOut_button";
            this.stepOut_button.Size = new System.Drawing.Size(75, 23);
            this.stepOut_button.TabIndex = 3;
            this.stepOut_button.Text = "Step Out";
            this.stepOut_button.UseVisualStyleBackColor = true;
            this.stepOut_button.Click += new System.EventHandler(this.stepOut_button_Click);
            // 
            // createDirectory_Button
            // 
            this.createDirectory_Button.Location = new System.Drawing.Point(330, 105);
            this.createDirectory_Button.Name = "createDirectory_Button";
            this.createDirectory_Button.Size = new System.Drawing.Size(75, 59);
            this.createDirectory_Button.TabIndex = 4;
            this.createDirectory_Button.Text = "Create Directory";
            this.createDirectory_Button.UseVisualStyleBackColor = true;
            this.createDirectory_Button.Click += new System.EventHandler(this.createDirectory_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createDirectory_Button);
            this.Controls.Add(this.stepOut_button);
            this.Controls.Add(this.stepInto_button);
            this.Controls.Add(this.stepInto_TextBox);
            this.Controls.Add(this.CurrentDirectoryView_RichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CurrentDirectoryView_RichTextBox;
        private System.Windows.Forms.TextBox stepInto_TextBox;
        private System.Windows.Forms.Button stepInto_button;
        private System.Windows.Forms.Button stepOut_button;
        private System.Windows.Forms.Button createDirectory_Button;
    }
}

