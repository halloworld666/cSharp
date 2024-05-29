using System;
using System.Reflection.PortableExecutable;

namespace _2024_5_23
{
    enum E_QQ
    {
        
        lixian,
        zaixian,

    }

    enum E_Coffeesize
    {
        middle, //中
        big,    //大
        bigbig, //超大
    }

    enum E_Gender     //性别
    {
        man,
        girl,
    }

    enum E_Occupation   //职业
    {
        zhanshi,
        lieren,
        fashi,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region One

            //定义QQ状态的枚举，并提示用户选择一个在线状态,我
            //们接受输入的数字，并将其转换成枚举类型

            //Console.WriteLine("请输入一个数字(0为离线，1为在线)：");

            //if (int.TryParse(Console.ReadLine(), out int input))
            //{
            //    E_QQ qq;

            //    if (input == 0)
            //    {
            //        qq = E_QQ.lixian;
            //    }
            //    else if (input == 1)
            //    {
            //        qq = E_QQ.zaixian;
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入的数字不是有效的QQ状态");
            //        return;
            //    }

            //    switch (qq)
            //    {
            //        case E_QQ.lixian:
            //            Console.WriteLine("离线");
            //            break;
            //        case E_QQ.zaixian:
            //            Console.WriteLine("在线");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("输入的不是一个有效的数字");
            //}

            #endregion

            #region Two

            //用户去星巴克买咖啡，分为中杯(35元)，大杯(40
            //元)，超大杯(43元)，请用户选择要购买的类型，用
            //户选择后，打印: 您购买了xxx咖啡，花费了xx元
            //例如:你购买了中杯咖啡，花费了35元

            //Console.WriteLine("欢迎来到星巴克");
            //Console.WriteLine("请选择你要购买的咖啡类型(middle(0)/big(1)/bigbig(2))：");
            //string xbk =Console.ReadLine();
            //E_Coffeesize coffeeSize;
            //if(Enum.TryParse(xbk, true, out coffeeSize))
            //{
            //    switch (coffeeSize)
            //    {
            //        case E_Coffeesize.middle:
            //            Console.WriteLine("你购买了中杯咖啡，花费了35元");
            //            break;
            //        case E_Coffeesize.big:
            //            Console.WriteLine("你购买了大杯咖啡，花费了40元");
            //            break;
            //        case E_Coffeesize.bigbig:
            //            Console.WriteLine("你购买了超大杯咖啡，花费了43元");
            //            break;
            //        default:
            //            Console.WriteLine("选择错误，无此型号咖啡");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("选择错误，请重新尝试");
            //}

            #endregion


            #region Three

            //请用户选择英雄性别与英雄职业，最后打印英雄的基本属
            //性(攻击力，防御力, 技能)
            //性别:
            //男(攻击力 + 50，防御力 + 100)
            //女(攻击力 + 150，防御力 + 20)
            //职业:
            //战士(攻击力 + 20，防御力 + 100，技能: 冲锋)
            //猎人(攻击力 + 120，防御力 + 30，技能: 假死)
            //法师(攻击力 + 200, 防御力 + 10, 技能: 奥术冲击)
            //举例打印: 


                Console.WriteLine("请选择你的英雄性别(男0 女1)：");
                E_Gender gender =(E_Gender)int.Parse(Console.ReadLine());
                string genders = "";
                int gongjili = 0;
                int fangyuli = 0;
                switch (gender)
                    {
                        case E_Gender.man:
                            Console.WriteLine("你选择了男性");
                            gongjili += 50;
                            fangyuli += 100;
                            break;
                        case E_Gender.girl:
                            Console.WriteLine("你选择了女性");
                            gongjili += 150;
                            fangyuli += 20;
                            break;
                        default:
                            Console.WriteLine("性别选择无效");
                            break;

                    }
                Console.WriteLine("请选择职业（战士1 猎人0 法师2）");
                E_Occupation occupation = (E_Occupation)int.Parse(Console.ReadLine());
                string skill = "";
                string occupation = "";
                    switch (occupation)
                    {
                    case E_Occupation.zhanshi:
                        gongjili += 20;
                        fangyuli += 100;
                        skill = "冲锋";
                        occupation = "战士";
                        break;
                    case E_Occupation.lieren:
                        gongjili += 120;
                        fangyuli += 30;
                        skill = "假死";
                        occupation = "猎人";
                        break;
                    case E_Occupation.fashi:
                        gongjili += 200;
                        fangyuli += 10;
                        skill = "奥术冲击";
                        occupation = "法师";
                        break;
                    default:
                        break;
                    }
                Console.WriteLine("你选了\"{0}{1}\",攻击力{2},防御力{3},职业技能{4}", E_Gender, occupation, gongjili, fangyuli, skill);

            #endregion

        }
    }
}
           
