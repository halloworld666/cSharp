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

            #region 条件运算符
            Console.WriteLine("条件运算符");

            #region 知识点一   条件运算符
            // 作用：用于比较两个变量或常量
            // 是否大于 >
            // 是否小于 <
            // 是否等于 ==
            // 是否不等于 !=
            // 是否大于等于 >=
            // 是否小于等于 <=

            // 条件运算符 一定存在左右两边的内容
            // 左边内容 条件运算符 右边内容
            int a3 = 5;
            int b3 = 10;

            // a3 >= b3;

            // 条件运算符 不能直接这么用
            // 纯比较不用结果 那么对于我们来说 没有任何的意义
            bool result = a3 > b3;
            Console.WriteLine(result);

            result = a3 < b3;
            Console.WriteLine(result);

            result = a3 == b3;
            Console.WriteLine(result);

            result = a3 != b3;
            Console.WriteLine(result);

            result = a3 <= b3;
            Console.WriteLine(result);

            result = a3 >= b3;
            Console.WriteLine(result);
            #endregion

            #region 知识点二    各种应用写法
            // 变量和变量比较

            // 变量和数值(常量)比较
            result = a3 > 3.5f;
            // 数值和数值比较
            result = 1 < 2;
            // 计算结果比较
            // 条件运算符 优先级 低于算术运算符
            result = a3 + 3 > b3 + 2 - 6;
            #endregion

            #region 知识点三   不能进行范围比较
            a3 = 5;
            // result = 1 < a3 < 6;
            #endregion

            #region 知识点四   不同类型之间的比较
            // 不同数值类型之间 可以随意进行条件运算符比较
            // 只要是数值 就能够进行条件运算符比较 比较大于小于等于等等

            // 特殊类型 string bool 只能同类型进行 == 和 != 比较
            string str3 = "123";
            bool bo3 = true;
            result = str3 == "123.1";
            Console.WriteLine(result);
            result = bo3 == true;
            // char 不仅可以和自己类型进行 == != 还可以和数值类型进行比较
            // 还可以和 字符类型 进行大小比较
            char c3 = 'a';
            result = c3 > 'a';
            result = c3 > 123;
            #endregion
            #endregion

            #region 逻辑运算符
            Console.WriteLine("逻辑运算符");
            // 对bool类型 进行逻辑运算

            #region 知识点一    逻辑与
            // 符号 && shift+7
            // 规则  对两个bool值进行逻辑运算 有假则假 全真为真
            result = true && true;
            result = true && false;
            result = false && true;
            result = false && false;
            // 逻辑运算符 优先级 低于 条件运算符 算数运算符
            result = 3 > 1 + 5 && 1 < 2 * 3;
            // 多个逻辑与 组合运用
            int i6 = 5;
            result = i6 > 1 && i6 < 5 && i > 4 && i < 9;
            #endregion

            #region 知识点二     逻辑或
            // 符号 || shift+\(Enter键上面)
            // 规则  对两个bool值进行逻辑运算 有真则真 全假为假
            result = true || true;
            result = true || false;
            result = false || true;
            result = false || false;

            result = 3 > 1 + 5 || 1 < 2 * 3;
            result = i6 > 1 || i6 < 5 || i > 4 || i < 9;
            #endregion

            #region 知识点三    逻辑非
            // 符号  !
            // 规则 对两个bool值进行取反  真变假 假变真
            result = !true;
            result = !false;
            // 逻辑非的优先级较高
            result = !(3 > 2);
            #endregion

            #region 知识点四     混合使用优先级问题
            // 规则  !（逻辑非）优先级最高 &&（逻辑与）优先级高于 ||（逻辑或）
            // 逻辑运算符 优先级低于 算数运算符  条件运算符
            result = !(i6 > 1) || (i6 < 5 && i > 4) || i < 9;
            Console.WriteLine(result);
            #endregion

            #region 知识点五    逻辑运算符短路规则
            // 长逻辑或判断中，只要有一个为真，整个式子都为真
            result = i6 > 1 || i6 < 5 || i > 4 || i < 9;
            // 长逻辑与判断中，只要有一个为假，整个式子都为假
            result = i6 > 1 && i6 < 5 && i > 4 && i < 9;
            #endregion
            #endregion

            #region 位运算符
            Console.WriteLine("位运算符");
            // 位运算符 主要用于数值类型进行计算的
            // 将数值转换为2进制 再进行位运算

            #region 位与 &
            // 规则 连接两个数值进行位运算 将数值转换为2进制
            // 对位运算 有0则0
            int m = 1;//1
            int n = 5;//101
            //  001
            // &101
            //  001
            int r = m & n;
            // false == 0,true == 1
            #endregion

            #region 位或 |
            // 规则 连接两个数值进行位运算 将数值转换为2进制
            // 对位运算 有1则1
            r = m | n;
            //  001
            // |101
            //  101
            #endregion

            #region 异或 ^
            // shift+6
            // 规则 连接两个数值进行位运算 将数值转换为2进制
            // 对位运算 相同为0 不同为1
            r = m ^ n;
            //  001
            // ^101
            //  100
            #endregion

            #region 位取反 ~
            // 规则 连接两个数值进行位运算 将数值转换为2进制
            // 对位运算 0变1 1变0
            int i7 = 5;// 0000 0000 0000 0000 0000 0000 0000 0101
            r = ~i7;   // 1111 1111 1111 1111 1111 1111 1111 1010
                       // 1111 1111 1111 1111 1111 1111 1111 1001
                       // 1000 0000 0000 0000 0000 0000 0000 0110
            // 原码，反码，补码 计算机组成原理
            // 反码 = ~原码
            // 补码 = 反码 + 1
            Console.WriteLine(r);
            #endregion

            #region 左移<< 和 右移 >>
            // 规则 让一个数的2进制进行左移和右移
            // 左移几位 右侧加几个0
            n = 5;// 101
            n = n << 5;// 1010000
            // 右移几位 右侧去掉几个数
            n = n >> 2;// 1
            // 计算机组成原理中的加法器
            #endregion
            #endregion

            #region 三目运算符
            Console.WriteLine("三目运算符");

            #region 基本语法
            // 套路 3个空位 2个符号!!!
            // 固定语法 空位 ? 空位 : 空位；
            // 关键信息 bool类型 ? bool类型为真返回内容 : bool内容为假返回内容；
            // 三目运算符 会有返回值，这个返回值类型必须一致，并且必须使用！
            string str4 = false ? "条件为真" : "条件为假";
            Console.WriteLine(str4);
            // 第一个空位 只能是bool类型（bool变量、条件表达式、逻辑表达式）
            // 第二、三个空位 什么表达式都可以，但是这两个空位的类型要一致 根据等号左侧的值确定的
            bool bo4 = m < 3 ? n > 6 : !false;
            #endregion

            #region 具体使用
            // 第一个空位 始终是结果为bool类型的表达式 bool变量 条件表达式 逻辑运算符表达式
            // 第二三个空位 什么表达式都可以 只要保证他们的结果类型是一致的

            #endregion
            #endregion
        }
    }
}
