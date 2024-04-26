// 引用命名空间
using System;

// 命名空间
namespace 变量
{
    // 类
    class Program
    {
        // 主函数 程序主入口
        static void Main(string[] args)
        {
            // 语句块
            Console.WriteLine("变量");

            #region 知识点一 折叠代码
            // 主要作用 是让我们编程时，逻辑更加清晰
            // #region和#endregion是配对出现的
            // 本质 是系统提供给我们的一个预处理指令
            // 它只会在编辑时有用 发布了代码就没有用了
            #endregion

            #region 知识点二 如何声明变量
            // 变量 可变化的一个容器 实际上是保存存储数据的位置

            // 变量声明的固定写法
            // 变量类型 变量名 = 初始值;
            // int i = 1;

            // 变量类型 有14种类型

            // 1.无符号整形变量 是可以存储一定范围整数 0和正数
            // byte 0~255
            byte b = 255;
            Console.WriteLine("byte所占字节数为：" + sizeof(byte));

            // uint 0~42亿多的一个范围 u→unsigned
            uint ui = 5465;
            Console.WriteLine("uint所占字节数为：" + sizeof(uint));

            // ushort 0~65535
            ushort us = 65535;
            Console.WriteLine("ushort所占字节数为：" + sizeof(ushort));

            // ulong 0~18百万兆的一个范围
            ulong ul = 16546;
            Console.WriteLine("ulong所占字节数为：" + sizeof(ulong));

            Console.WriteLine("*****************************************");

            // 2.有符号整形变量 是可以存储一定范围整数 0和正负数
            // sbyte -128~127
            sbyte sb = 127;
            Console.WriteLine("sbyte所占字节数为：" + sizeof(sbyte));

            // int -21亿多~21亿多
            int i = 1654;
            Console.WriteLine("int所占字节数为：" + sizeof(int));

            // short -32768~32767
            short st = 1566;
            Console.WriteLine("short所占字节数为：" + sizeof(short));

            // long -9百万兆多~9百万兆多
            long l = 156456;
            Console.WriteLine("long所占字节数为：" + sizeof(long));

            Console.WriteLine("*****************************************");

            // 3.浮点数（小数）
            // float 存储7/8位有效数字 根据编译器不同，有效数字可能不一样
            // 有效数字 从左往右数第一个非0数开始计数 超出的部分四舍五入
            float f = 1.123456789f;
            //Console.WriteLine(f);
            Console.WriteLine("float所占字节数为：" + sizeof(float));

            // double 存储15~17位有效数字
            // C#中创建小数时默认为double类型
            double d = 0.123456789123456789123;
            //Console.WriteLine(d);
            Console.WriteLine("double所占字节数为：" + sizeof(double));

            // decimal 存储27~28位有效数字 不建议使用
            decimal de = 0.1321546546813m;
            Console.WriteLine("decimal所占字节数为：" + sizeof(decimal));

            Console.WriteLine("*****************************************");

            // 4.特殊类型
            // bool true false 表示真假的数据类型
            bool bl1 = true;
            bool bl2 = false;
            //Console.WriteLine(bl1);
            //Console.WriteLine(bl2);
            Console.WriteLine("bool所占字节数为：" + sizeof(bool));

            // char 是用来存储单个字符的变量类型
            // 一个数字、一个字母、一个汉字都算一个字符
            char c = '林';
            //Console.WriteLine(c);
            Console.WriteLine("char所占字节数为：" + sizeof(char));

            // string 是用来存储一串字符的变量类型
            // 没有上限的
            string str = "面向对象程序设计";
            //Console.WriteLine(str);

            // 整数用int 小数用float 字符串用string 判断用bool

            // = 不仅仅可以设定变量的初始值，还可以对变量进行修改
            str = "C#";
            //Console.WriteLine(str);
            #endregion

            #region 知识点三 多个相同类型的变量同时声明
            /*
            int i1 = 1;
            int i2 = 2;
            int i3 = 3;
            */

            int i1 = 1, i2 = 2, i3 = 3;
            #endregion

            #region 知识点四 变量初始化相关
            int i4;
            i4 = 1;
            //Console.WriteLine(i4);
            #endregion

            #region 知识点五 变量的命名规则
            // 一、必须遵守的规则
            // 1.不能重名
            // 2.不能以数字开头
            // 3.不能使用特殊符号（_除外）
            // 4.不能使用程序关键字命名

            // 二、常用命名规则
            // 1.驼峰命名法——第一个单词首字母小写，其余单词首字母大写（变量）
            string myName = "我的名字";
            string yourName = "你的名字";
            string niDeMingZi = "你的名字";

            // 2.帕斯卡命名法——所有单词首字母都大写（函数、类）
            string MyName = "你的名字";

            // C#对大小写是敏感的，是区分大小写

            // 建议的命名规则：变量名要有意义 通过变量名可以知道变量的作用
            #endregion
        }
    }
}
