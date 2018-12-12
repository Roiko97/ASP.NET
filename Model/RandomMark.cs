using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    /*
     生成随机的小组组号
     */
    public class RandomMark
    {
        private int tmp =0;
        private RandomMark()
        {
            ;
        }
        public static RandomMark getRandomMarkInstance()
        {
            return new RandomMark();
        }
        public string getRandom()
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + this.tmp;
            this.tmp++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> this.tmp)));
            for (int i = 0; i < 10; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }
    }
}