using System;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作业

            #region 第一题

            Console.WriteLine("\n----------第一题----------\n");

            Console.WriteLine("请输入一个整数：");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Your input is even");
            }
            else
            {
                Console.WriteLine("Your input is odd");
            }

            #endregion

            #region 第二题

            Console.WriteLine("\n----------第二题----------\n");

            Console.WriteLine("请输入第一个值");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个值");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三个值");
            int number3 = int.Parse(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("最大数为：" + number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("最大数为：" + number2);
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine("最大数为：" + number3);
            }
            else
            {
                Console.WriteLine("相等");
            }
            #endregion

            #region 第三题

            Console.WriteLine("\n----------第三题----------\n");

            Console.Write("请输入一个字符：\n");
            char c = Console.ReadKey().KeyChar;
            if (c >= 48 && c < 57)
            {
                Console.WriteLine("\n您输入了一个数字");
            }
            else
            {
                Console.WriteLine("您输入的不是一个数字");
            }
            #endregion

            #region 第四题

            Console.WriteLine("\n----------第四题----------\n");

            Console.WriteLine("请输入用户名");
            string strAdmin = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string strPassword = Console.ReadLine();
            if (strAdmin == "admin" && strPassword == "8888")
            {
                Console.WriteLine("正确");
            }
            else
            {
                if (strAdmin != "admin")
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }

            #endregion

            #region 第五题

            Console.WriteLine("\n----------第五题----------\n");

            Console.WriteLine("请输入您的年龄：");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age < 13)
            {
                Console.WriteLine("不允许查看");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("是否继续查看(yes/no)");
                string yn = Console.ReadLine();
                if (yn == "yes")
                {
                    Console.WriteLine("可以继续查看");
                }
                else if (yn == "no")
                {
                    Console.WriteLine("退出");
                }
                else
                {
                    Console.WriteLine("输入错误请重新再试");
                }
            }

            #endregion

            #region 第六题

            //  Console.WriteLine("\n----------第六题----------\n");

            //  首先定义了一个整型变量a = 5
            //  然后if(a大于3）则运行if里面的语句
            //  在语句内定义了一个整型变量b
            //  然后自增b，算出b = b + a的值
            //  然后输出b的值
            //  但是负责输出的Console.WriteLine(b)语句不在if（a > 3）语句内
            //  所以可以知道输出错误，输出的内容为空

            #endregion

            #region 第七题

            Console.WriteLine("\n----------第七题----------\n");

            Console.WriteLine("请输入您的成绩：");
            int cj = int.Parse(Console.ReadLine());

            if (cj > 100 || cj < 0)
            {
                Console.WriteLine("成绩输入错误，请稍后再试");
                Environment.Exit(0);
            }
            switch (cj / 10)
            {
                case 10:
                    Console.WriteLine("您的考试等级为:A+");
                    break;
                case 9:
                    Console.WriteLine("您的考试等级为:A");
                    break;
                case 8:
                    Console.WriteLine("您的考试等级为:B");
                    break;
                case 7:
                    Console.WriteLine("您的考试等级为:C");
                    break;
                case 6:
                    Console.WriteLine("您的考试等级为:D");
                    break;
                default:
                    Console.WriteLine("您的考试等级为:E");
                    break;
            }

            #endregion

            #region 第八题

            Console.WriteLine("\n----------第八题----------\n");

            Console.WriteLine("请输入一个（0~9）的数：");
            int sz = int.Parse(Console.ReadLine());
            if (sz == 0)
            {
                Console.WriteLine("转换后的数为：零");
            }
            else if (sz == 1)
            {
                Console.WriteLine("转换后的数为：一");
            }
            else if (sz == 2)
            {
                Console.WriteLine("转换后的数为：二");
            }
            else if (sz == 3)
            {
                Console.WriteLine("转换后的数为：三");
            }
            else if (sz == 4)
            {
                Console.WriteLine("转换后的数为：四");
            }
            else if (sz == 5)
            {
                Console.WriteLine("转换后的数为：五");
            }
            else if (sz == 6)
            {
                Console.WriteLine("转换后的数为：六");
            }
            else if (sz == 7)
            {
                Console.WriteLine("转换后的数为：七");
            }
            else if (sz == 8)
            {
                Console.WriteLine("转换后的数为：八");
            }
            else if (sz == 9)
            {
                Console.WriteLine("转换后的数为：九");
            }
            else
            {
                Console.WriteLine("错误");
            }
            #endregion

            #endregion
        }
    }
}
