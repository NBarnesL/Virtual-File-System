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
        private Directory rootDirectory = new Directory();
        LinkedListNode<Directory> rootnode;
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
            StepIntoDirectory(Convert.ToInt32(stepInto_TextBox.Text));
            DisplayCurrentDirectory();
        }
        private void stepOut_button_Click(object sender, EventArgs e)
        {
            StepOutofDirectory();
            DisplayCurrentDirectory();
        }

        private void createDirectory_Button_Click(object sender, EventArgs e)
        {
            if(depth>0 &&depth<4)
            {
                currentDirectory.AddDirectory(new Directory(directoryCount,"gamign"));
                directoryCount++;
            }
            DisplayCurrentDirectory();
        }

        private void DisplayCurrentDirectory()
        {
            CurrentDirectoryView_RichTextBox.Text = currentDirectory.DisplayContent();
        }

        private void InitializeDirectories()
        {
            rootDirectory.AddDirectory(new Directory(1, "a"));
            rootDirectory.AddDirectory(new Directory(2, "b"));
            rootDirectory.AddDirectory(new Directory(3, "c"));
            currentDirectory = rootDirectory;
        }
        private void GoToRoot()
        {
            currentDirectory = rootDirectory;
            DisplayCurrentDirectory();
        }

        private void GoToPrevious()
        {
            switch (depth)
            {
                case 0:
                    break;
                case 1:
                    currentDirectory = prevLv1;
                    break;
                case 2:
                    currentDirectory = prevLv2;
                    break;
                case 3:
                    currentDirectory = prevLv3;
                    break;
                case 4:
                    currentDirectory = prevLv4;
                    break;
                   
            }
            DisplayCurrentDirectory();

        }

        private void StepIntoDirectory(int _id)
        {
            LinkedListNode<Directory> node = currentDirectory.Directory_List.First;

            while (node != null)
            {
                if (_id == node.Value.GetDir_ID())
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
