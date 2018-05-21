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
            string result = $"MD5:{FileMD5Hex(filePath)}";
            return result;
        }

        private string FileMD5Hex(string filePath)
        {
            MD5 md5 = MD5.Create();
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] hash = md5.ComputeHash(stream);
                return Byte2Hex(hash);
            }
        }

        public string CalcStringHash(string str)
        {
            string result = $"MD5:{StringMD5Hex(str)}";
            return result;
        }

        private string StringMD5Hex(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            return Byte2Hex(hash);
        }

        private string Byte2Hex(byte[] src)
        {
            return BitConverter.ToString(src).Replace("-", "");
        }
    }
}
