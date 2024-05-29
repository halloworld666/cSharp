using System;

namespace _9_枚举类型
{

    #region 知识点一 基本概念

    #region 1.枚举是什么 
    // 枚举是一个比较特别的存在
    // 它是一个被命名的整形常量的集合
    // 一般用它来表示 状态 类型 等等
    #endregion

    #region 2.声明枚举 和 声明枚举变量
    // 注意：声明枚举 和 声明枚举变量 是两个概念
    // 声明枚举：     相当于是 创建一个自定义的枚举类型
    // 声明枚举变量： 使用声明的自定义枚举类型 创建一个枚举变量
    #endregion

    #region 3.声明枚举语法
    // 枚举名 以E或者E_开头 作为我们的命名规范
    //enum E_自定义枚举名
    //{
    //    自定义枚举项名字, //枚举中包裹的 整形常量  第一个默认值是0 下面会依次累加
    //    自定义枚举项名字1,//1
    //    自定义枚举项名字2,//2
    //}

    #endregion

    #endregion

    #region 知识点二 在哪里声明枚举
    // 1.namespace语句块中（常用）
    // 2.class语句块中 struct语句块中
    // 注意：枚举不能在函数语句块中声明！！！
    #endregion


    enum E_PlayerType
    {
        Main,
        Other,
    }
    

    enum E_MonsterType
    {
        Normal,
        Boss,
        SmallBoss,
    }

    // 类
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举类型");

            #region 知识点三 枚举的使用
            //int i = 1;
            // 自定义的枚举类型 变量名 = 默认值（自定义的枚举类型.枚举项）;
            E_PlayerType playerType = E_PlayerType.Other;

            if (playerType == E_PlayerType.Main)
            {
                Console.WriteLine("主玩家逻辑");
            }
            else if (playerType == E_PlayerType.Other)
            {
                Console.WriteLine("其他玩家逻辑");
            }

            E_MonsterType monsterType = E_MonsterType.Normal;
            switch (monsterType)
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("Boss逻辑");
                    break;
                case E_MonsterType.SmallBoss:
                    Console.WriteLine("小boss逻辑");
                    break;
            }
            #endregion

            #region 知识点四 枚举的类型转换
            // 1.枚举和int互转
            // 枚举转int
            int i = (int)playerType;

            // int转枚举
            playerType = (E_PlayerType)1;

            // 2.枚举和string相互转换
            // 枚举转string
            string str1 = playerType.ToString();

            // string转枚举
            // Parse后第一个参数：你要转为的是哪个枚举变量
            // 第二个参数：用于转换的字符串变量
            // 用Parse转换完毕后，是一个通用的Enum类型
            // 再用括号强转转换为需要的枚举类型
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");

            #endregion

            #region 知识点五 枚举的作用
            // 枚举可以帮助我们 清晰地分清楚状态的含义
            #endregion
        }
    }
}
