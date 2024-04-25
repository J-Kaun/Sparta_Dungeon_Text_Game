using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sparta_Dungeon
{
    public class Status
    {

        public static int lv { get; set; }
        public static string name { get; set; }
        public static int atk { get; set; }
        public static int def { get; set; }
        public static int hp { get; set; }
        public static int gold { get; set; }

        public static void statusUi()
        {
            //Program.Text(name);
            //string name = Console.ReadLine();

            //int lv = 1;
            //int atk = 10;
            //int def = 5;
            //int hp = 100;
            //int gold = 1500;

            Console.WriteLine("[상태 보기] \n캐릭터의 정보가 표시됩니다. \n");
            Console.WriteLine("Lv. {0}\n{1} ( Warrior ) \nATK  : {2} \nDEF  : {3} \nHP   : {4} \nGold : {5} G \n", lv, name, atk, def, hp, gold);
            Console.WriteLine("[0. 나가기] \n");

            bool validInput = false;
            bool firstAttempt = true; // 처음 시도를 나타내는 변수

            while (!validInput)
            {
                Console.Write("원하시는 행동을 입력해주세요. \n>> : ");
                string num1 = Console.ReadLine();

                if (num1 == "0")
                {
                    Console.Clear();
                    Title.gameTitle();
                    MainMenu.mainmenuUI();
                    validInput = true;
                }
                if (firstAttempt)
                {
                    Console.WriteLine("잘못 된 입력입니다.");
                    firstAttempt = false; // 한 번 출력되어 이후에는 출력하지 않음
                }
            }
        }
    }
}
