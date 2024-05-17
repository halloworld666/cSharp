using System;

namespace homWork_2024._5._17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While_work

            #region One

            //在控制台输出1到100之间所有整数的和(用while实现)

            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum += i;  
            //    i++;  
            //}
            //Console.WriteLine("总数和为：" + sum);

            #endregion

            #region Two

            //用while和continue实现计算1到100(包含)之间的除
            //了能被7整除之外所有整数的和

            //int a=1;
            //int sum1 = 0;
            //while (a <= 100)
            //{
            //    if (a % 7 ==0)
            //    {
            //        a++;
            //        continue;
            //    }
            //    sum1 += a;
            //    a++;
            //}
            //Console.WriteLine("除了7的倍数的总数和为："+sum1);

            #endregion

            #region Three

            //要求输入用户名和密码(admin / 8888) ，用户名或者密码错误
            //则提示“用户名或密码错误”，知道输入正确为止

            //while(true)
            //{
            //    Console.WriteLine("请输入您的用户名：");
            //    string Admin= Console.ReadLine();
            //    Console.WriteLine("请输入您的密码");
            //    string Password = Console.ReadLine();

            //    if (Admin == "admin" && Password == "8888")
            //    {
            //        Console.WriteLine("正确");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误,请重新输入");
            //        continue;
            //    }
            //}

            #endregion

            #region Four

            //定义一个整形变量sum,然后分别把1~ 100之间的数字
            //依次累加到sum中，当sum的值大于500的时候，中断操作
            //并在控制台输出累加到第几个数字就可以使sum大于500

            //int sum2 = 0;
            //int b=1;
            //while (b<=100)
            //{
            //    sum2 += b;
            //    if (sum2 > 500)
            //    {
            //        Console.WriteLine("累计加到第 {0} 个数的时候可以使sum大于500 数值为 {1}",b,sum2);
            //        break;
            //    }
            //    b++;
            //}

            #endregion

            #region Five

            //求数列1,1,2,3,5,81....的第20位数字是多少 ?
            //(从第三个数开始, 每个数都是前两个数字的和)

            //int sum3 = 0;
            //int a1 = 1;
            //int b1 = 1;
            //while (sum3<9)
            //{
            //    a1 += b1;
            //    b1 += a1;
            //    sum3++;
            //}
            //Console.WriteLine(b1);

            #endregion

            #region Six(do_While)

            //要求用户输入用户名和密码，只要不是admin和8888就
            //一直提示用户名或密码错误，请重新输入

            //Console.WriteLine("请输入您的用户名：");
            //string Name=Console.ReadLine();
            //Console.WriteLine("请输入您的密码：");
            //string Password=Console.ReadLine();
            //do
            //{
            //    if (Name == "admin" && Password == "8888")
            //    {
            //        Console.WriteLine("正确");
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //} while (false);

            #endregion

            #endregion

            #region For_work

            #region One

            //输出1到100之间的整数(包含本身，用for实现)

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Two

            //找出100~999之间的水仙花数
            //例如: 153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3
            //这个数就是水仙花数

            //for (int i1 = 100;i1<=999;i1++)
            //{
            //    int i2=i1/100;
            //    int i3=(i1/10)%10;
            //    int i4=i1%10;
            //    if (Math.Pow(i2, 3) + Math.Pow(i3, 3) + Math.Pow(i4, 3) == i1)
            //    {
            //        Console.WriteLine(i1);
            //    }
            //}

            #endregion

            #region Three

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2,-2}\t", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Four



            #endregion

            #region Five



            #endregion

            #region Six



            #endregion

            #endregion
        }
    }
}
