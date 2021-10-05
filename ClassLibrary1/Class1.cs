using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_11
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="str"></param>
        /// <param name="str1"></param>
        public static void Proizv(int n, out string str, out string str1)
        {

            int rezult = 1;
            str = "";
            str1 = "";
            Random rnd = new Random();
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(n);
                    str =str+ x.ToString() + ";"; 
                    rezult = rezult * x;
                }
                str1 = rezult.ToString();
            }
        }
    }
}
