using System;

namespace _7_条件分支语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件分支语句");
            #region if语句
            #region if作用
            // 让顺序执行的代码 产生分支
            // if语句是第一个 可以让我们的程序 产生逻辑变化的语句
            #endregion

            #region if语句
            // 作用 满足条件时 多执行一些代码
            // bool类型的值：bool变量  条件运算符表达式  逻辑运算符表达式
            //if (bool类型的值)
            //{
            //    满足条件要执行的代码块
            //}

            string strName = "lyk";
            string strPassword = "8888";
            if (strName=="lyk"&&strPassword=="8888")
            {
                Console.WriteLine("进入了if代码块");
                Console.WriteLine("进入了if代码块");
                Console.WriteLine("进入了if代码块");
                Console.WriteLine("进入了if代码块");
            }

            if (strName == "lyk")
            {
                if (strPassword == "8888")
                {
                    Console.WriteLine("if的嵌套");
                }
            }
            // 可以无限嵌套
            #endregion

            #region if……else语句
            // 作用：产生两条分支，满足条件做什么，不满足条件做什么；
            //if (bool类型值)
            //{
            //    满足条件执行的代码块
            //}
            //else
            //{
            //    不满足条件执行的代码块
            //}

            if (true)
            {
                if (true)
                {

                }
            }
            else
            {
                if (true)
                {

                }
                else
                {

                }
            }
            #endregion

            #region if……else if……else语句
            //作用：产生多条分支，最先满足其中的一个条件，就做什么；
            //if (bool类型值)
            //{
            //    满足if条件执行的代码块
            //}
            //else if (bool类型值)
            //{
            //    满足else if条件执行的代码块
            //}
            //else
            //{
            //    不满足所有条件执行的代码块
            //}
            int a = 6;
            if (a >= 10)
            {
                Console.WriteLine("a大于等于10");
            }
            else if (a >= 5 && a < 10)
            {
                Console.WriteLine("a在5到10之间");
            }
            else if (a >= 0 && a < 5)
            {
                Console.WriteLine("a在0到5之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }
            // 在if……else if……else中，else是可以省略的

            // 对成绩进行转换
            // >=90 A
            // 80<=  <90 B
            // 70<=  <80 C
            // 60<=  <70 D
            // <60  E
            int chengJi = 85;
            // 写法一
            if(chengJi >= 60)
            {
                if (chengJi >= 70)
                {
                    if(chengJi >= 80)
                    {
                        if(chengJi >= 90)
                        {
                            Console.WriteLine("A");
                        }
                        else
                        {
                            Console.WriteLine("B");
                        }
                    }
                    else
                    {
                        Console.WriteLine("C");
                    }
                }
                else
                {
                    Console.WriteLine("D");
                }
            }
            else
            {
                Console.WriteLine("E");
            }

            // 写法二
            if (chengJi >= 90)
            {
                Console.WriteLine("A");
            }
            else if(chengJi >=80 && chengJi < 90)
            {
                Console.WriteLine("B");
            }
            else if (chengJi >= 70 && chengJi < 80)
            {
                Console.WriteLine("C");
            }
            else if (chengJi >= 60 && chengJi < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            #endregion
            #endregion

            #region switch语句
            #region 作用
            //让顺序执行的代码 产生分支
            #endregion

            #region 基本语法
            //switch (变量)
            //{
            //    case 常量1:
            //        满足条件1执行的代码块
            //        break;
            //    case 常量2:
            //        满足条件2执行的代码块
            //        break;
            //    case 常量3:
            //        满足条件3执行的代码块
            //        break;
            //    default:
            //        上面条件都不满足时执行的代码块
            //        break;
            //}
            // 主要配合枚举使用进行精确比较
            int b = 3;
            switch (b)
            {
                case 1:
                    Console.WriteLine("b等于1");
                    break;
                case 2:
                    Console.WriteLine("b等于2");
                    break;
                case 3:
                    Console.WriteLine("b等于3");
                    break;
            }
            #endregion

            #region default 可省略
            #endregion

            #region 贯穿
            //作用 满足某些条件时 做的事情是一样的 就可以使用贯穿
            int c = 1;
            switch (c)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("b等于3");
                    break;
            }
            #endregion
            #endregion
        }
    }
}
