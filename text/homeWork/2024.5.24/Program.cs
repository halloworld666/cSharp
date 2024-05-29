using System;

namespace _2024_5_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
        //Two();
        static void Two()
        {
            int[] a = { 2, 4, 6, 8 };
            int[] b = new int[a.Length];
            Console.WriteLine("数组中的值翻倍后为");
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i] * 2;
                Console.WriteLine(b[i]);
            }
            Console.WriteLine();
        }
        //Three();
        static void Three()
        {
            int[] a = new int[10];
            Random rnd = new Random();
            Console.WriteLine("随机生成的十个数字为");
            for (int i = 0; i < 10; i++)
            {
                a[i] = rnd.Next(0, 101);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
        //four();
        static void four()
        {
            int[] a = new int[10];
            Random rnd2 = new Random();
            int max = 0, min = 0;
            float ave = 0, sum = 0;
            for (int i = 0; i < 10; i++)
            {
                a[i] = rnd2.Next(1, 101);
                sum += a[i];
                Console.WriteLine(a[i]);
            }
            max = a[0]; min = a[0];
            ave = sum / 10;
            for (int j = 0; j < 9; j++)
            {

                if (a[j + 1] < min)
                {
                    min = a[j + 1];
                }
                if (a[j + 1] > max)
                {
                    max = a[j + 1];
                }
            }
            Console.WriteLine($"这个数组最大值为{max},最小值为{min}，总和{sum},平均值为{ave}");
        }
        //five();
        static void five()
        {
            int[] a = { 1, 2, 3, 4, 5, };
            int b = 0, c = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                b = a[i];
                a[i] = a[c];
                a[c] = b;
                c--;
            }
            Console.WriteLine("交换后的值为");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
        //six();
        static void six()
        {
            int[] a = { 1, -1, 0 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    a[i]++;
                }
                else if (a[i] < 0)
                {
                    a[i]--;
                }
            }
            Console.WriteLine("处理后的值为");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
        //seven();
        static void seven()
        {
            int[] a = new int[10];
            int ave = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"请输入第{i + 1}个同学的数学成绩");
                a[i] = int.Parse(Console.ReadLine());
                ave += a[i];
            }
            int max = a[0], min = a[0];
            ave = ave / a.Length;
            for (int i = 0; i < 9; i++)
            {
                if (a[i + 1] < min)
                {
                    min = a[i + 1];
                }
                if (a[i + 1] > max)
                {
                    max = a[i + 1];
                }
            }
            Console.WriteLine($"十名同学中最高分为{max},最低分为{min},平均成绩为{ave}");
        }
        //eight();
        static void eight()
        {
            string[] a = new string[25];
            int b = 0, c = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (c % 2 == 0)
                {
                    Console.Write("□");
                }
                else
                {
                    Console.Write("■");
                }
                c++;
                b++;
                if (b == 5)
                {
                    Console.WriteLine();
                    b = 0;
                }
            }
        }
    }
}
