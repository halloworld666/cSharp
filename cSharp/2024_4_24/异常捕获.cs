using System;

namespace 异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 知识点一   作用
            // 可以避免当代码报错时 造成程序卡死的情况

            #endregion

            #region 知识点二   基本语法
            // 必备部分
            try
            {
                // 希望进行异常捕获的代码块
                // 放到 try 中
                // 如果 try 中的代码 报错了 不会让程序卡死
            }
            catch
            {
                // 如果 try 中的代码出错了 会执行 catch 中的代码 来捕获异常
                // catch(Exception e)具体报错跟踪 通过 e 得到 具体的错误信息
            }
            //可选部分
            finally
            {
                // 最后执行的代码 不管有没有出错 都会执行其中的代码
            }
            // 异常捕获代码基本结构中 不需要加；在里面写代码逻辑时 才加；

            #endregion

            #region 实践
            try
            {
                Console.WriteLine(byte.Parse("123"));
            }
            catch(Exception e)
            {
                Console.WriteLine("程序出错了");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("程序执行完毕");
            }
            #endregion
        }
    }
}
