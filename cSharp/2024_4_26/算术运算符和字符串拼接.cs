using System;
using System.Net.NetworkInformation;

namespace 运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符");

            #region 算术运算符
            Console.WriteLine("算术运算符");

            #region 知识点一   赋值符号
            // =
            // 关键知识点：
            // 先看右侧 再看左侧 把右侧的值赋给左侧的变量
            int i = 1;
            // ==

            #endregion

            #region 知识点二   加 +
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            i = i + 2;
            Console.WriteLine(i);
            // i = 3
            // 连续运算 先算右侧结果 再赋值给左侧变量
            i = 1 + i + i;  // 1 + 3 + 3
            Console.WriteLine(i);
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量
            int i1 = 1 + i;
            #endregion

            #region 知识点三   减 -
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int jian = 5;
            jian = jian - 3;
            // 连续运算 先算右侧结果 再赋值给左侧变量
            jian = 9 - jian - jian;
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量
            int jian1 = 9 - jian;
            #endregion

            #region 知识点四   乘 * 
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int cheng = 3;
            cheng = cheng * 2;
            // 连续运算 先算右侧结果 再赋值给左侧变量
            cheng = 5 * cheng * cheng;
            // 初始化时就运算 先算右侧结果 再赋值给左侧变量

            #endregion

            #region 知识点五   除 /  ÷  
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            // 用整型进行除法运算时，会把小数全部舍掉
            float chu = 3;
            chu = 10f / 4f;
            Console.WriteLine(chu);
            // 10/4中的两个数都是整型，所以计算结果也是整型，会直接舍弃掉小数
            // 故单独看右侧计算式，10/4=2
            // 所以为了得到小数的运算结果，需要给/两侧任意一个数添加上浮点数的符号
            // 10f / 4      10 / 4f     10f / 4f
            // 连续运算 先算右侧结果 再赋值给左侧变量

            // 初始化时就运算 先算右侧结果 再赋值给左侧变量

            #endregion

            #region 知识点六   取余 %
            // 被除数 / 除数 = 商 ······ 余数
            int y = 4;
            y = y % 2;  // 4 / 2 = 2 ······ 0

            y = 20;
            y = y % 3 % 2;  // 20 / 3 = 6 ······ 2
                            // 2 / 2 = 1 ······ 0
            #endregion

            #region 知识点七   算术运算符的优先级
            // 符合数学中的四则运算
            // 优先级 是指 在混合运算时的运算顺序

            // 乘除取余 优先级高于 加减 先算乘除 后算加减

            // 括号可以改变优先级 优先计算括号内内容

            // 多组括号 先算最里层括号 依次往外算
            // 数学上括号的层级 {[()]}
            // 在代码中统一使用()
            int a = ((1 + 2) * 3) / 4 - 5 + 6 % 7;
            #endregion

            #region 知识点八   算术运算符的 复合运算符
            // 固定写法
            // += -= *= /= %=
            // 复合运算符 是用于 自己=自己进行运算
            int b = 2;
            b += 2; // b = b + 2
            b -= 2; // b = b - 2
            b *= 2; // b = b * 2
            b /= 2; // b = b / 2
            b %= 2; // b = b % 2

            // 注意：复合运算符 只能进行一种运算 不能混合运算
            // 例如 i *-+= 2;

            #endregion

            #region 知识点九   算术运算符的 自增减 每次自增减的单位是1
            int i3 = 2;
            // 先用再加减
            //i3++;   // i3 += 1 
            Console.WriteLine(i3++);
            Console.WriteLine(i3);// i3 = 3
            //i3--;   // i3 -= 1
            // 先加减再用
            //++i3;
            //--i3;
            Console.WriteLine(++i3);
            Console.WriteLine(i3);

            i3 = 2;
            int i4 = i3++ + ++i3;
            Console.WriteLine(i4);
            Console.WriteLine(i3);
            #endregion
            #endregion

            #region 字符串拼接
            Console.WriteLine("字符串拼接");

            #region 字符串拼接方式一
            // 之前的算术运算符 只是用来数值类型变量进行数学运算的
            // 而 string 不存在算术运算符不能计算 但是可以通过+号来进行字符串拼接
            string str1 = "123";
            //str1 = str1 + "456";
            //Console.WriteLine(str1);
            // 复合运算符 +=
            str1 += "789";
            //Console.WriteLine(str1);

            str1 = 1 + 2 * 3 + "4" + 5 + 6 + 7 + true;
            Console.WriteLine(str1);
            // 在进行字符串拼接时，在第一个出现的字符串之前，都是进行正常的运算
            // 在第一个出现的字符串之后，会把所有非字符串的内容强制转换为字符串，并且不再允许出现+以外的符号
            // 注意：用+号拼接 是用符号唯一方法 不能用-*/%...

            #endregion

            #region 字符串拼接方式二
            // 固定语法
            // string.Format("待拼接的内容"，内容1，内容2....)；
            // 拼接内容中的固定规则
            // 想要被拼接的内容用占位符替代{数字} 数字：0到n  依次往后
            string str2 = string.Format("我叫{0}，今年{1}岁，喜欢{2}", "小明", "18", "好好学习");
            //Console.WriteLine(str2);

            #endregion

            #region 控制台打印拼接
            Console.WriteLine("A{0}B{1}C{2}", a, true, false, 2);
            #endregion
            #endregion
        }
    }
}
