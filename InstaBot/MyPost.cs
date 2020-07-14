using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot
{
    using System;

    public class MyPost
    {
        public int count;
        public string sourcePath, destinyPath, userName, userPassword;

        public MyPost(string _sourcePath, string _destinyPath, string _name, string _pass, string _count)
        {
            count = Convert.ToInt32(_count);
            sourcePath = _sourcePath;
            destinyPath = _destinyPath;
            userName = _name;
            userPassword = _pass;

        }

        public bool CopyFilesIntoAccont()
        {
            bool res = true;
            return res;
        }

    }

}
