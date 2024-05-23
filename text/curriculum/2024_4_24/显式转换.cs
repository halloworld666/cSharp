using System;

namespace 类型转换_显式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显式转换");

            // 显式转换——>手动处理 强制转换

            #region 知识点一   括号强转
            // 作用 一般情况下 将高精度的类型强制转换为低精度
            // 语法：变量类型 变量名 =（变量类型）变量；
            // 注意：精度问题 范围问题

            // 相同大类的整型
            // 有符号整型
            sbyte sb1 = 1;
            short s1 = 1; // -25536~25535
            int i1 = 40000;
            long l1 = 1;

            // 括号强转 可能会出现范围问题造成的异常
            s1 = (short)i1;
            //Console.WriteLine(s1);

            sb1 = (sbyte)s1;
            sb1 = (sbyte)i1;
            sb1 = (sbyte)l1;

            // 无符号整型
            byte b1 = 1;
            ushort us1 = 1;
            uint ui1 = 1;
            ulong ul1 = 1;

            b1 = (byte)ul1;

            // 浮点数之间
            float f1 = 1.23456f;
            double d1 = 7.8913154623;
            decimal de1 = 123.4897445648713865m;

            f1 = (float)de1;
            //Console.WriteLine(f1);
            
            f1 = (float)d1;
            //Console.WriteLine(f1);

            // 无符号和有符号
            uint ui2 = 1;
            int i2 = -1;

            // 在强转时 一定要注意范围
            ui2 = (uint)i2;
            //Console.WriteLine(ui2);

            // 浮点和整型
            // 浮点数强转为整数时 会把小数点后面的数全部舍弃掉
            i2 = (int)1.93f;
            //Console.WriteLine(i2);

            // char和数值类型
            i2 = 65;
            char c = (char)i2;
            //Console.WriteLine(c);

            // bool和string  也不参与括号强转
            bool bo2 = false;
            string str2 = "fagagag";

            //bo2 = (bool)str2;
            //str2 = (string)bo2;

            #endregion

            #region 知识点二   Parse法
            // 作用 把字符串类型转换为对应的类型
            // 语法：变量类型.Parse("字符串")；
            // 注意：字符串必须能够转换成对应类型 同时要注意范围 否则报错

            // 有符号
            //sbyte sb3 = sbyte.Parse("123456789");
            //Console.WriteLine(sb3);

            // 无符号
            Console.WriteLine(byte.Parse("1"));
            Console.WriteLine(ushort.Parse("1"));
            Console.WriteLine(uint.Parse("1"));
            Console.WriteLine(ulong.Parse("1"));

            // 浮点数 在进行转换的时候，字符串里不要有对应的标识符
            float f2 = 1.23f;
            //Console.WriteLine(float.Parse("1.23"));
            //Console.WriteLine(decimal.Parse("1.23"));

            // 特殊类型
            // 0代表false 1代表true
            // 在Parse方法中，0、1和false、true是没办法相互替换的
            //Console.WriteLine(bool.Parse("true"));
            //Console.WriteLine(bool.Parse("false"));

            //Console.WriteLine(char.Parse("A"));

            #endregion

            #region 知识点三   Convert法
            // 作用 更准确的将 各个类型之间进行相互转换
            // 语法：Convert.To目标类型（变量或常量）
            // 注意：填写的变量或常量必须正确 否则出错

            // 转字符串
            sbyte sb = Convert.ToSByte("123");
            short s = Convert.ToInt16("123");
            int a = Convert.ToInt32("123");
            long l = Convert.ToInt64("123");

            byte b = Convert.ToByte("123");
            ushort us = Convert.ToUInt16("123");
            uint ui = Convert.ToUInt32("123");
            ulong ul = Convert.ToUInt64("123");

            // 精度更准确
            // 会对小数进行四舍五入
            a = Convert.ToInt32(1.93f);
            //Console.WriteLine(a);

            // float 单精度浮点数
            float f = Convert.ToSingle("123.456");
            // double 双精度浮点数
            double d = Convert.ToDouble("135.456");

            decimal de = Convert.ToDecimal("1523.46");

            // 特殊类型转换
            a = Convert.ToInt32(true);
            //Console.WriteLine(a);
            a = Convert.ToInt32(false);
            //Console.WriteLine(a);

            a = Convert.ToInt32('A');

            string str = Convert.ToString(132456);

            // 每一个类型都存在对应的 Convert中的方法

            // 0、1数字可以和false、true互相转换
            bool bo3 = Convert.ToBoolean(0);
            Console.WriteLine(bo3);

            #endregion

            #region 知识点四   其他类型转string
            // 作用 拼接打印
            // 语法：变量.ToString（）；
            string str4 = 1.ToString();
            str4 = true.ToString();
            str4 = 1.23.ToString();

            Console.WriteLine("123456" + 1 + true);

            #endregion
        }
    }
}
