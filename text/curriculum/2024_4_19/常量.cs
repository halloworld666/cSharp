using System;

namespace 常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("常量");

            #region 知识点一 常量的声明
            // 关键字 const
            // 固定写法：
            // const 变量类型 变量名 = 初始值;

            // 变量的声明
            int i = 1;
            // 常量的声明
            const int i2 = 2;
            #endregion

            #region 知识点二 常量的特点
            // 1.必须初始化
            // 2.不能被修改

            int i3;
            i3 = 3;
            i3 = 4;

            const int i4 = 4;
            //i4 = 5;

            // 作用：声明一些常用不变的变量
            //PI = 3.1415926535;
            const float PI = 3.1415926535f;
            Console.WriteLine(PI);
            // 常量的命名一般都是全大写
            #endregion
        }
    }
}
