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
        
                static string Stroka(byte[] arrInput) //Делает из массива баутов в строку
                {
                    int i;
                    StringBuilder sOutput = new StringBuilder(arrInput.Length);
                    for (i = 0; i < arrInput.Length; i++)
                    {
                        sOutput.Append(arrInput[i].ToString("X2"));
                    }
        
                    return sOutput.ToString();
                }
                public bool POISK(string key)// Проверяет существует ли ключ в этой таблице или нет
                {
                    bool d = ht.ContainsKey(key);
                    return d;
                }
                public string funk(string Ss)// Хэщ-функция
                {
                    byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(Ss);// Превращает из строки в массив байтов
                    byte[] hash = new MD5CryptoServiceProvider().ComputeHash(tmpSource); //Кодирует ака проходит массив байтов через хэщ-функци
                    return Stroka(hash);
                }
                public void Dobav(string key, string value)// добавляет ключ+значение в хэш-таблицу
                {
                    ht.Add(key, funk(value));
                }
    }
}
