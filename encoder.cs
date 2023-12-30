    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    namespace Encrypter
    {
        internal class Program
        {
            private static byte[] xor(byte[] shell, byte[] KeyBytes)
            {
                for (int i = 0; i < shell.Length; i++)
                {
                    shell[i] ^= KeyBytes[i % KeyBytes.Length];
                }
                return shell;
            }
            static void Main(string[] args)
            {
                string key = "testK3y!";
                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] buf = new byte[460] { X };
                byte[] encoded = xor(buf, keyBytes);
                Console.WriteLine(Convert.ToBase64String(encoded));        
            }
        }
    }