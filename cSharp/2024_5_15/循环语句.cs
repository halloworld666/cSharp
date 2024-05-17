using System;

namespace _8_循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("循环语句");

            Console.WriteLine("while");
            #region 作用
            // 让顺序执行的代码 可以不停的循环执行某一代码块的内容
            // 条件分支语句 是 让代码产生分支
            // 循环语句 是 让代码可以被重复执行

            #endregion

            #region 语法相关
            /*while (bool类型的值) 
            {
                // 每次循环做什么

                // 当满足条件时 就会执行while语句块中的内容
                // 当代码逻辑执行完 会回到while循环开头
                // 再次进行条件判断
            } */

            //while (true)
            //{
            //    Console.WriteLine("111111");
            //}

            // 死循环
            // 就不停的执行循环中的逻辑“直到死为止”
            // 1.可能因为内存问题 造成程序 崩溃闪退
            // 2.造成程序卡死

            #endregion

            #region 嵌套使用
            //while (true)
            //{
            //    Console.WriteLine("111111");
            //    if (Console.ReadKey().KeyChar == 'q')
            //    {
            //        Console.WriteLine("退出循环");
            //        break;
            //    }
            //}

            //int a = 0;
            //int b = 0;
            //while (a < 10)
            //{
            //    ++a;
            //    Console.WriteLine("a=" + a);
            //    while (b < 10)
            //    {
            //        ++b;
            //        Console.WriteLine("b=" + b);
            //        break;
            //    }
            //}
            #endregion

            #region 流程控制关键词
            // 作用：控制循环逻辑的关键词
            // break：跳出循环
            // continue ：回到循环开始 继续执行

            //while (true)
            //{
            //    Console.WriteLine("break之前的代码");
            //    break;
            //    Console.WriteLine("break之后的代码");
            //}
            //Console.WriteLine("循环外的代码");

            //while (true)
            //{
            //    Console.WriteLine("continue之前的代码");
            //    continue;
            //    Console.WriteLine("continue之后的代码");
            //}
            //Console.WriteLine("循环外的代码");

            // 注意：break 和 continue 主要是和循环配合使用的 和 if语句无关
            // break 在 switch 中的作用 和 while 循环中的作用有异曲同工之妙
            // break 和 continue 只对最近的循环起作用
            #endregion

            Console.WriteLine("do……while循环");
            #region 基本语法
            // while循环       是先判断条件再执行
            // do……while循环 是先执行一次循环语句块中的逻辑 再判断是否继续
            /*do
            {
                do while 循环语句块;
            } while (bool类型的值);*/

            #endregion

            #region 实际使用
            //while (false)
            //{
            //    Console.WriteLine("while 循环语句块");
            //}

            do
            {
                Console.WriteLine("do while 循环语句块");
            } while (false);
            #endregion

            #region 嵌套使用
            //在do……while 里面的 continue 会回到 while 里面
            do
            {
                Console.WriteLine("do while 循环语句块");
                do {
                    Console.WriteLine("1111");
                }while (false);
            } while (false);

            #endregion

            Console.WriteLine("for");
            #region 基本语法
            /*for (初始表达式; 条件表达式; 增量表达式)
            {
                循环代码逻辑;
            }*/
            // 第一个空(初始表达式):一般声明一个临时变量，用来计数
            // 第二个空(条件表达式):表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符）
            // 第三个空(增量表达式):用第一个空中变量 进行 自增减运算

            // 第一次进入循环时 才会调用 第一个空中的代码
            // 每次进入循环之前 都会判断第二个空中的条件 满足才会进入循环逻辑
            // 执行完循环语句块中的逻辑后,最后执行第三个空中的代码 

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 支持嵌套
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(j);
                }
            }
            #endregion

            #region 特殊写法
            // 三个空位 可以都空着 按需求去写
            // for循环可以写死循环
            //for(; ; )
            //{
            //    Console.WriteLine("for循环的死循环");
            //}
            #endregion

            #region 三种循环对比
            // for循环一般用来可以准确得到 一个范围中的所有数;
            // for循环：适合循环次数是已知的操作;
            // while循环：适合循环次数是未知的操作;
            // do…while…循环：适合至少执行一次的循环操作（注：while循环需要有“;”结尾);
            #endregion
        }
    }
}