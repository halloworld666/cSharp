using System;

namespace _10_数组类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数组类型");

            #region 一维数组

            #region 知识点一 基本概念
            // 数组是存储一组相同类型数据的集合
            // 数组分为 一维、多维、交错数组
            // 一般情况 一维数组 就简称为 数组
            #endregion

            #region 知识点二 数组的声明
            // 变量类型[] 数组名;
            // 变量类型可以是我们学过的所有变量类型
            int[] arrayOne;

            // 变量类型[] 数组名 = new 变量类型[数组的长度]
            // 内容此时全为0
            int[] arrayOne1 = new int[5];
            Console.WriteLine(arrayOne1);

            // 变量类型[] 数组名 = new 变量类型[数组的长度]{内容1,内容2,...,内容n}
            int[] arrayOne2 = new int[5] { 1, 2, 3, 4, 5 };

            // 变量类型[] 数组名 = new 变量类型[]{内容1,内容2,...,内容n}
            int[] arrayOne3 = new int[] { 1, 2, 3, 4, 5 };

            // 变量类型[] 数组名 = {内容1,内容2,...,内容n}
            int[] arrayOne4 = { 1, 2, 3, 4, 5 };

            // C语言写法 在C#中会报错
            //int arr5[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // 数组初始化之后，是不能够进行长度相关的修改的
            #endregion

            #region 知识点三 数组的使用
            int[] arrayOneUse = { 1, 2, 3, 4, 5 };
            // 1.数组的长度
            Console.WriteLine(arrayOneUse.Length);

            // 2.获取数组中的元素
            // 数组元素是有顺序的，即数组中的内容都有自己的序号（下标/索引）
            // 下标/索引是从0开始的
            // 下标/索引不能越界 范围是0~Length-1
            Console.WriteLine(arrayOneUse[4]);

            // 3.修改数组中的元素
            arrayOneUse[4] = 99;
            Console.WriteLine(arrayOneUse[4]);
            Console.WriteLine("**************************");

            // 4.遍历数组 通过循环 快速获取数组中的每一个元素
            for (int i = 0; i < arrayOneUse.Length; i++)
            {
                Console.Write(arrayOneUse[i]+" ");
            }
            Console.WriteLine();

            // 5.增加数组的元素
            // 数组初始化之后，是不能够直接进行增加元素的操作的
            // 创建一个大的数组，用大数组保存小数组，最后把要添加的元素放在大数组的最后一个位置
            // 搬家的原理
            // 先找到一个大房子
            int[] arrayOneUseBig = new int[6];
            // 把旧的家具搬到新家
            for (int i = 0; i < arrayOneUse.Length; i++)
            {
                arrayOneUseBig[i] = arrayOneUse[i];
            }
            Console.WriteLine("刚搬完家");
            for (int i = 0; i < arrayOneUseBig.Length; i++)
            {
                Console.Write(arrayOneUseBig[i] + " ");
            }
            Console.WriteLine();
            // 修改一下房产归属
            arrayOneUse = arrayOneUseBig;
            // 添置新家具
            arrayOneUse[5] = 666;
            Console.WriteLine("搬完后的新家");
            for (int i = 0; i < arrayOneUse.Length; i++)
            {
                Console.Write(arrayOneUse[i] + " ");
            }
            Console.WriteLine();

            // 6.删除数组的元素
            // 数组初始化之后，是不能够直接进行删除元素的操作的
            // 搬家的原理
            int[] arrayOneUseSmall = new int[4];
            for (int i = 0; i < arrayOneUseSmall.Length; i++)
            {
                arrayOneUseSmall[i] = arrayOneUse[i];
            }
            arrayOneUse = arrayOneUseSmall;
            for (int i = 0; i < arrayOneUse.Length; i++)
            {
                Console.Write(arrayOneUse[i] + " ");
            }
            Console.WriteLine();

            // 7.查找数组中的元素
            // 遍历数组和判断相结合
            int a = 3;
            for (int i = 0; i < arrayOneUse.Length; i++)
            {
                if (a == arrayOneUse[i])
                {
                    Console.Write("和a相同的元素在{0}索引位置",i);
                }
            }
            #endregion

            #endregion

        }
    }
}
