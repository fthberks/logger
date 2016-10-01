using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class RandomUtils
    {
        static Random random = new Random();
        static string[] alphabet = new string[] { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e" };
        public static string GetRandomFileName(int fileNameSize)
        {
            StringBuilder sb = new StringBuilder(fileNameSize);
            for (int i = 0; i < fileNameSize; i++)
            {
                sb.Append(alphabet[random.Next(alphabet.Length)]);
            }
            return sb.ToString();
        }
    }
}
