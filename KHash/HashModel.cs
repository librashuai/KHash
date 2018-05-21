using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace KHash
{
    class HashModel
    {
        private HashModel() { }
        static private HashModel instance = null;
        static public HashModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HashModel();
                }
                return instance;
            }
        }

        public string CalcFileHash(string filePath)
        {
            string result = $"MD5:{MD5Hex(filePath)}";
            return result;
        }

        private string MD5Hex(string filePath)
        {
            MD5 md5 = MD5.Create();
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] hash = md5.ComputeHash(stream);
                return Byte2Hex(hash);
            }
        }

        private string Byte2Hex(byte[] src)
        {
            return BitConverter.ToString(src).Replace("-", "");
        }
    }
}
