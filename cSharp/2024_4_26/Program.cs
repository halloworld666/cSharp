
using System;

namespace _2024_4_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点六 取余%

            //被除数 / 除数 = 商 ....... 余数
            int y = 4;
            y = y % 3;  //4 / 3 =1 ......1

            y = 20;
            y = y % 3 % 2;  //20/3 =6........2

            Console.WriteLine(y);

            #endregion

            #region 知识点七

            //符合数学中的四则运算

            //优先级 是指 在混合运算时的运算顺序
            //乘除 取余 优先级高于 加减 先算乘除 后算加减
            //括号可以改变优先级

            //多组括号 先算最里层括号 依次往外算
            //数学上括号的层级{[()]}
            //在代码中统一使用()

            int a = ((1 + 2) * 3) / 4 - 5 + 6 % 7;
            Console.WriteLine(a);

            #endregion

            #region 知识点八 算术运算符的 复合运算符

            ////固定写法
            //+= -= *= /= %=
            //复合运算符 是用于 自己=自己进行运算
            int b = 2;
            b += 2; //b=b+2
            b -= 2; //b=b-2
            b *= 2; //b = b * 2;
            b /= 2;
            b %= 2;
            Console.WriteLine(b);

            //注意：复合运算符 只能进行一种运算 不能混合运算
            //例如i */+=2;

            #endregion

            #region 知识点九 算术运算符的 自增减 每次自增减的单位是1

            int i3 = 2;
            //先用再加
            //i3++;   //i3 += 1   i3 = i3 +1
            //i3--;   //i3 -= 1   i3 = i3 - 1

            //先加减再用
            //++i3;
            //--i3;

            i3 = 2;
            //int i4 = (++i3) + i3++;     // 3 + 3 = 6 
            int i5 = i3++ + ++i3;     
            //Console.WriteLine(i4);
            Console.WriteLine(i5);

            #endregion

            #region 知识点十 字符串拼接

            //string str1 = "123";
            ////str1 = str1 + "456";
            ////Console.Write(str1);

            ////复合运算符 +=
            ////str1 += "789";
            ////Console.WriteLine(str1);

            //str1 + 1 + 2 * 3 + "4" + 5 + 6 + 7 + true;
            //Console.WriteLine(str1);

            #endregion

            #region Format

            string str3 = string.Format("我叫{0}，我今年{1}岁，我喜欢{2}，", "钟俊涛", "19", "我");
            Console.WriteLine(str3);

            #endregion
        }
    }
}
