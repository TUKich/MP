using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace l4E
{
    public class Program
    {
                Hashtable ht = new Hashtable();
                
                static void Main(string[] args)
                {
                }
        
                static string Stroka(byte[] arrInput)
                {
                    int i;
                    StringBuilder sOutput = new StringBuilder(arrInput.Length);
                    for (i = 0; i < arrInput.Length; i++)
                    {
                        sOutput.Append(arrInput[i].ToString("X2"));
                    }
        
                    return sOutput.ToString();
                }
                public bool POISK(string key)
                {
                    bool d = ht.ContainsKey(key);
                    return d;
                }
                public string funk(string Ss)
                {
                    byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(Ss);
                    byte[] hash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                    return Stroka(hash);
                }
                public void Dobav(string key, string value)
                {
                    ht.Add(key, funk(value));
                }
    }
}