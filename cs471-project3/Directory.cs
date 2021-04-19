using System;
using System.Collections.Generic;
using System.Text;

namespace cs471_project3
{
    class Directory
    {
        private int Dir_ID;
        private String name;
        private int depth;

        public LinkedList<Directory> Directory_List = new LinkedList<Directory>();
        public LinkedList<File> File_List = new LinkedList<File>();

        public Directory()
        {

        }

        public Directory(int _id, String _name, int _depth)
        {
            Dir_ID = _id;
            name = _name;
            depth = _depth;
            depth++;
        }

        public int GetDir_ID()
        {
            return Dir_ID;
        }

        public String GetName()
        {
            return name;
        }

        public void setDepth(int _depth)
        {
            depth = _depth;
        }

        public void AddDirectory(Directory d)
        {
            Directory_List.AddLast(d);
        }

        public void RemoveDirectory(int _id)
        {
            LinkedListNode<Directory> node = Directory_List.First;

            while (node != null)
            {
                if (_id == node.Value.GetDir_ID())
                {

                    Directory_List.Remove(node);
                    break;
                }
                node = node.Next;
            }
        }

        public void AddFile(File _f)
        {
            File_List.AddLast(_f);
        }

        public void RemoveFile(String _name)
        {
            LinkedListNode<File> node = File_List.First;

            while (node != null)
            {
                if (_name == node.Value.GetContent())
                {

                    File_List.Remove(node);
                    break;
                }
                node = node.Next;
            }
        }

        public String DisplayContent()
        {
            LinkedListNode<Directory> dnode = Directory_List.First;
            LinkedListNode<File> fnode = File_List.First;
            String content = "Directory:" + name +"\n";

            while (dnode != null)
            {
                content += "d" + dnode.Value.GetDir_ID() + "\t" + dnode.Value.GetName() + "\n";
                dnode = dnode.Next;
            }

            while (fnode != null)
            {
                content += "f\t" + fnode.Value.GetName() + ".txt\n";
                fnode = fnode.Next;
            }


            return content;
        }
        public String DisplayAllContent()
        {
            LinkedListNode<Directory> dnode = Directory_List.First;
            LinkedListNode<File> fnode = File_List.First;
            String content = "";

            while (dnode != null)
            {
                if (depth > 0)
                {
                    for (int i = 0; i < depth; i++)
                    {
                        content += "-";
                    }
                    content += "/";

                }
                content += "d" + dnode.Value.GetDir_ID() + "\t" + dnode.Value.GetName() + "\n";
                if (dnode.Value.DisplayContent().Length > 0)
                {

                    content += dnode.Value.DisplayAllContent();

                }
                dnode = dnode.Next;
            }

            while (fnode != null)
            {
                if (depth > 0)
                {
                    for (int i = 0; i < depth; i++)
                    {
                        content += "-";
                    }
                    content += "/";

                }
                content += "f\t" + fnode.Value.GetName() + ".txt\n";
                fnode = fnode.Next;
            }

            return content;

        }
    }


}
