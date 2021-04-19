using System;
using System.Collections.Generic;
using System.Text;

namespace cs471_project3
{
    class File
    {
        private String content="";

        public String GetContent()
        {
            return content;
        }

        public void SetContent(String _c)
        {
            content = _c;
        }
    }
}
