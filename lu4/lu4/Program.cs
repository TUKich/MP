using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace lu4
{
    public class Program
    {
        
            Hashtable ht = new Hashtable();
            public bool P(string key)
            {
                bool d = ht.ContainsKey(key);
                return d;
            }

            
            public void add(string key, string value)
            {
                ht.Add(key, Hafunk(value));
            }

            static void Main(string[] args)
            {
            }

            static string String(byte[] arrInput)
            {
                int i;
                StringBuilder sOutput = new StringBuilder(arrInput.Length);
                for (i = 0; i < arrInput.Length; i++)
                {
                    sOutput.Append(arrInput[i].ToString("X2"));
                }

                return sOutput.ToString();
            }
            public string Hafunk(string Ss)
            {
                byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(Ss);
                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                return String(hash);
            }
        }
    }
