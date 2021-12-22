using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace lk4
{
    public class Program
    {
        Hashtable ht = new Hashtable();
        public bool HD(string key)
        {
            bool d = ht.ContainsKey(key);
            return d;
        }

        public string Hfunk(string Ss)
        {
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(Ss);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            return BATS(hash);
        }
        public void AHT(string key, string value)
        {
            ht.Add(key, Hfunk(value));
        }

        static void Main(string[] args)
        {
        }

        static string BATS(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }

            return sOutput.ToString();
        }

    }
}