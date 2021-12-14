using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace lb4
{
    public class Program
    {
        Hashtable ht = new Hashtable();

        public void AddHT(string key, string value)
        {
            
            ht.Add(key,HF(value));
        }

        public bool HD(string key)
        {
            
            return true;
        }
        public string HF(string Ss)
        {
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(Ss);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            return ByteArrayToString(hash);
        }
        
        
        
        
        static void Main(string[] args)
        {
        }
        
        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i=0;i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        Dictionary<string, List> array = new Dictionary<string, List>();
    }
}