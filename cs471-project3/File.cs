using System;
using System.Collections.Generic;
using System.Text;

namespace cs471_project3
{
    class File
    {
        private String content="";
        private String name = "";
        private int depth;

        public File(String _name, String _content, int _depth)
        {
            name = _name;
            content = _content;
            depth = _depth;
        }

        public File(String _name)
        {
            name = _name;
        }

        public String GetContent()
        {
            return content;
        }

        public void SetContent(String _c)
        {
            content = _c;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String _n)
        {
            name = _n;
        }
    }
}
