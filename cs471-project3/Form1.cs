using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs471_project3
{
    public partial class Form1 : Form
    {
        private Directory rootDirectory = new Directory(0,"root",-1);
        private Directory prevLv1 = new Directory();
        LinkedListNode<Directory> lv1node;
        private Directory prevLv2 = new Directory();
        LinkedListNode<Directory> lv2node;
        private Directory prevLv3 = new Directory();
        LinkedListNode<Directory> lv3node;
        private Directory prevLv4 = new Directory();
        LinkedListNode<Directory> lv4node;
        private Directory currentDirectory = new Directory();

        private int directoryCount = 4;
        private int depth = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeDirectories();
            DisplayCurrentDirectory();

        }

        private void stepInto_button_Click(object sender, EventArgs e)
        {
            try
            { 
                StepIntoDirectory(stepInto_TextBox.Text); 
            }
            catch
            {
                MessageBox.Show("Directory does not exist", "Wait a second!");
            }
                
           
            DisplayCurrentDirectory();
        }
        private void stepOut_button_Click(object sender, EventArgs e)
        {
            StepOutofDirectory();
            DisplayCurrentDirectory();
        }

        private void createDirectory_Button_Click(object sender, EventArgs e)
        {
            LinkedListNode<Directory> node = currentDirectory.Directory_List.First;
            bool exists = false;
            if (depth > 0 && depth < 4)
            {
                while (node != null)
                {
                    if (directoryName_textBox.Text == node.Value.GetName())
                    {
                        exists = true;
                        break;
                    }
                    node = node.Next;
                }
                if(directoryName_textBox.Text.Length>0 && exists == false)
                {
                    currentDirectory.AddDirectory(new Directory(directoryCount, directoryName_textBox.Text, depth));
                    directoryCount++;
                }
                else if(directoryName_textBox.Text.Length ==0)
                {
                    MessageBox.Show("Please Enter a Directory Name", "Wait a second!");
                }
                else
                {
                    MessageBox.Show("Directory Already Exists", "Wait a second!");
                }
                
            }
            DisplayCurrentDirectory();
        }

        private void Create_File_Button_Click(object sender, EventArgs e)
        {
            LinkedListNode<File> node = currentDirectory.File_List.First;
            bool exists = false;
            if (filename_Text_Box.Text.Length>0)
            {
                
                while (node != null)
                {
                    if (filename_Text_Box.Text == node.Value.GetName())
                    {
                        //node.Value.SetContent(filecontent_richTextBox.Text);
                        exists = true;
                        break;
                    }
                    node = node.Next;
                }

                if (depth > 0 && exists == false)
                {
                    currentDirectory.AddFile(new File(filename_Text_Box.Text, filecontent_TextBox.Text, depth));
                }
                else
                {
                    MessageBox.Show("File Already Exists", "Wait a second!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a filename", "Wait a second!");
            }
           
            DisplayCurrentDirectory();
        }

        private void openFile_Button_Click(object sender, EventArgs e)
        {
            LinkedListNode<File> node = currentDirectory.File_List.First;
            while (node != null)
            {
                if (openfile_textBox.Text == node.Value.GetName())
                {
                    filecontent_richTextBox.Text = node.Value.GetContent();
                    break;
                }
                node = node.Next;
            }
        }

        private void filecontent_richTextBox_TextChanged(object sender, EventArgs e)
        {
            LinkedListNode<File> node = currentDirectory.File_List.First;
            while (node != null)
            {
                if (openfile_textBox.Text == node.Value.GetName() && filecontent_richTextBox.Text.Length <250)
                {
                    node.Value.SetContent(filecontent_richTextBox.Text);
                    break;
                }
                node = node.Next;
            }
        }

        private void deleteFile_button_Click(object sender, EventArgs e)
        {
            LinkedListNode<File> node = currentDirectory.File_List.First;
            while (node != null)
            {
                if (openfile_textBox.Text == node.Value.GetName())
                {
                    currentDirectory.File_List.Remove(node);
                    break;
                }
                node = node.Next;
            }
            DisplayCurrentDirectory();
        }

        private void DisplayCurrentDirectory()
        {
            CurrentDirectoryView_RichTextBox.Text = currentDirectory.DisplayContent();
            UpdateAllDirectories();
            fullfilesystemview_richTextBox.Text = rootDirectory.DisplayAllContent();
        }

        private void UpdateAllDirectories()
        {

            int depthcount = depth;
            Directory tempcurrent = currentDirectory;

            while (depthcount>0)
            {
                switch (depthcount)
                {
                    case 0:
                        break;
                    case 1:
                        lv1node.Value = tempcurrent;
                        tempcurrent = prevLv1;
                        depthcount--;
                        break;
                    case 2:
                        lv2node.Value = tempcurrent;
                        tempcurrent = prevLv2;
                        depthcount--;
                        break;
                    case 3:
                        lv3node.Value = tempcurrent;
                        tempcurrent = prevLv3;
                        depthcount--;
                        break;
                    case 4:
                        lv4node.Value = tempcurrent;
                        tempcurrent = prevLv4;
                        depthcount--;
                        break;
                    default:
                        //depth exceeded, shouldnt happen
                        break;
                }
            }

        }

        private void InitializeDirectories()
        {
            rootDirectory.AddDirectory(new Directory(1, "a",depth));
            rootDirectory.AddDirectory(new Directory(2, "b",depth));
            rootDirectory.AddDirectory(new Directory(3, "c",depth));
            currentDirectory = rootDirectory;
        }


        private void StepIntoDirectory(String _name)
        {
            LinkedListNode<Directory> node = currentDirectory.Directory_List.First;

            while (node != null)
            {
                if (_name == node.Value.GetName())
                {
                    switch (depth)
                    {
                        case 0:
                            prevLv1 = currentDirectory;
                            lv1node = node;
                            depth++;
                            break;
                        case 1:
                            prevLv2 = currentDirectory;
                            lv2node = node;
                            depth++;
                            break;
                        case 2:
                            prevLv3 = currentDirectory;
                            lv3node = node;
                            depth++;
                            break;
                        case 3:
                            prevLv4 = currentDirectory;
                            lv4node = node;
                            depth++;
                            break;
                        default:
                            //depth exceeded, shouldnt happen
                            break;
                    }
                    currentDirectory = node.Value;
                    break;
                }
                node = node.Next;
            }
            DisplayCurrentDirectory();
        }

        private void StepOutofDirectory()
        {
            //update changes
            switch (depth)
            {
                case 0:
                    break;
                case 1:
                    lv1node.Value = currentDirectory;
                    currentDirectory = prevLv1;
                    depth--;
                    break;
                case 2:
                    lv2node.Value = currentDirectory;
                    currentDirectory = prevLv2;
                    depth--;
                    break;
                case 3:
                    lv3node.Value = currentDirectory;
                    currentDirectory = prevLv3;
                    depth--;
                    break;
                case 4:
                    lv4node.Value = currentDirectory;
                    currentDirectory = prevLv4;
                    depth--;
                    break;
                default:
                    //depth exceeded, shouldnt happen
                    break;
            }
            //-need to update changes to previous node
            //reduce depth
            DisplayCurrentDirectory();
        }


    }
}
