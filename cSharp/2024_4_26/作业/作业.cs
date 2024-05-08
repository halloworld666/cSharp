using System;

namespace 作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 第一题  
            
            //请说明number1和number2和number3的结果

            #region number1
            int a = 10, b = 20;
            int number1 = ++a + b;
            
            //number1 = 11 + 20 = 31;
            Console.WriteLine("number1的值为："+number1);
            
            #endregion

            #region number2

            a = 10;
            b = 20;
            int number2 = a + b++;
            //number2 = 10 + 20 = 30
            Console.WriteLine("number2的值为："+number2);

            #endregion

            #region number3

            a = 10;
            b = 20;
            int number3 = a++ + ++b + a++;
            //number3= 11 + 21 + 10 = 42
            Console.WriteLine("number3的值为："+number3);

            #endregion

            #endregion

            #region 第二题



            #endregion
        }
    }
}
