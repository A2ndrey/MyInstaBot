using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot
{
    using System;
    using System.IO;

    public class MyPost
    {
        public int count;
        public string sourcePath, destinyPath, userName, userPassword;

        private string accountDirName;

        public MyPost(string _sourcePath, string _destinyPath, string _name, string _pass, string _count)
        {
            count = Convert.ToInt32(_count);
            sourcePath = _sourcePath;
            destinyPath = _destinyPath;
            userName = _name;
            userPassword = _pass;

            accountDirName = GetNewName(destinyPath, userName);
            if (!System.IO.Directory.Exists(accountDirName))
                System.IO.Directory.CreateDirectory(accountDirName);
        }

        public bool CopyFilesIntoAccont()
        {
           
            bool res = MoveFileToDir();
            return res;
        }


        private bool MoveFileToDir()
        {
            bool res = true;
            int _cnt = 0;
            var Dir = Directory.GetFiles(sourcePath);

            foreach (string _fileInfo in Dir )
            {
                if (_cnt > count)
                    break;

                FileInfo f = new FileInfo(_fileInfo);

                string newFileName = GetNewName(accountDirName, f.Name);

                if (!System.IO.File.Exists(newFileName))
                    try
                    {

                        f.MoveTo(newFileName);
                        _cnt++;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message, "Error");
                        res = false;
                    }
            }

            return res;

        }

        private string GetNewName(string destinyPath, string name)
        {
            return destinyPath + '\\' + name;
        }
    }

}
