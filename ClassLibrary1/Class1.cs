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
        /// Расчёт функции
        /// </summary>
        /// <param name="n">количество чисел</param>
        /// <param name="str"></param>
        /// <param name="str1"></param>
        public static void Proizv(int n, out string str, out int rezult)
        {
            rezult = 1;
            str = "";
            Random rnd = new Random();
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(n);
                    str =str+ x.ToString() + ";"; 
                    rezult = rezult * x;
                }
            }
        }
    }
}
