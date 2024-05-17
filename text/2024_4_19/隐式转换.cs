using System;
using System.Runtime.Intrinsics.X86;

namespace 类型转换_隐式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——隐式转换");
            // 什么是类型转换

            // 类型转换 就是不同变量类型之间的相互转换

            // 隐式转换的基本规则——>不同类型之间自动转换
            // 大范围装小范围

            #region 知识点一 相同大类型之间的转换

            // 有符号  long ——> int ——> short ——> sbyte
            long l1 = 1;
            int i1 = 1;
            short s1 = 1;
            sbyte sb1 = 1;

            // 隐式转换 int隐式转换成了long
            // 可以用大范围去装小范围（隐式）
            l1 = i1;

            l1 = s1;
            l1 = sb1;
            // 不能用小范围去装大范围
            //i1 = l1;
            //s1 = i1;
            //sb1 = l1;

            // 无符号  ulong ——> uint ——> ushort ——> byte
            ulong ul1 = 1;
            uint ui1 = 1;
            ushort us1 = 1;
            byte b1 = 1;

            ul1 = ui1;

            //ui1 = ul1;

            // 浮点数  decimal   double ——> float
            decimal de1 = 1.1m;
            double d1 = 1.1;
            float f1 = 1.1f;
            // decimal 是没有办法用隐式转换的形式，去存储double和float的
            //de1 = d1;
            //de1 = f1;

            // float是可以隐式转换为double
            d1 = f1;

            // 特殊类型  bool char string
            // 它们之间 不存在隐式转换
            bool bo1 = true;
            char c1 = 'a';
            string str1 = "1565115";

            //bo1 = c1;
            //bo1 = str1;
            //c1 = bo1;
            //str1 = bo1;
            //str1 = c1;
            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间
            // 无符号装有符号 转不过去
            // 无符号数是不能装负数
            byte b2 = 1;
            ushort u2 = 65535;// 0~65535
            uint ui2 = 1;
            ulong ul2 = 1;

            sbyte sb2 = 1;
            short s2= 1;
            int i2= 1;  // -21亿~21亿
            long l2 = 1;

            //ui2 = sb2;

            // 有符号装无符号 注意范围 范围一定是要涵盖的
            i2 = u2;
            Console.WriteLine(i2);

            #endregion

            #region 浮点数和整数（有、无符号）之间
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;

            // 浮点数装整数 浮点数可以装所有的整数
            l2 = 123456789123456789;

            f2 = l2;

            Console.WriteLine(f2);


            // 整数装浮点数 整数是不能隐式转换为浮点数的 因为整数是存不了小数的
            //l2 = f2;
            #endregion

            #region 特殊类型和其它类型之间
            bool bo2 = true;
            char c2 = 'A';
            string str2 = "123456";
            // bool 没有办法和其他类型相互隐式转换
            //bo2 = l2;
            //l2 = bo2;


            // char 其他变量没有办法隐式转换为char
            //c2 = i2;
            //c2 = ul2;

            // char可以隐式转换为其他变量
            // char的本质是16位无符号整数 用于表示Unicode编码值 取值范围是0~65535
            // 所以char就可以转换成比它范围更大的变量
            i2 = c2;
            Console.WriteLine(i2);
            l2 = c2;
            Console.WriteLine(l2);
            u2 = c2;

            de2 = c2;
            Console.WriteLine(de2);
            // string   无法和其他类型进行隐式转换
            //l2 = str2;
            //str2 = i2;

            #endregion

            #endregion

            // 总结 隐式转换的规则
            // 高精度（大范围）装低精度（小范围）
            // double——>float——>整数（无符号、有符号）——>char
            // decimal——>整数（无符号、有符号）——>char
            // string 和 bool不参与隐式转换规则
        }
    }
}
