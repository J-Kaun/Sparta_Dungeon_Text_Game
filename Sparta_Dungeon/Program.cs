using System;
using System.Reflection;
using System.Text;

namespace Sparta_Dungeon
{
    public class Program
    {   
        
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            Title.gameTitle();
            Login();
            Text();
        }

        public static void Login()
        {
            Console.WriteLine("스파르타 던전에 오신 것을 환영합니다.");
            Console.Write("당신의 이름을 입력해 주세요 : ");

            string name = Console.ReadLine();

            Status.name = name;
            Status.lv = 1;
            Status.atk = 10;
            Status.def = 5;
            Status.hp = 100;
            Status.gold = 1500;



        }
        
        public static void Text()
        {
            Console.Clear();
            Title.gameTitle();
            MainMenu.mainmenuUI();
        }
    }
}
