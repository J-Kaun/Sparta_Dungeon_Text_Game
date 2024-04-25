using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sparta_Dungeon
{
    internal class Inventory
    {
        public static void inventoryUI()
        {
            Console.WriteLine("[인벤토리] \n보유 중인 아이템을 관리할 수 있습니다. \n");
            Console.WriteLine("[1. 장착 관리] \n[0. 나가기] \n");
            
            bool validInput = false;
            bool firstAttempt = true;

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
                else if (num1 == "1")
                {

                }
                if (firstAttempt)
                {
                    Console.WriteLine("잘못 된 입력입니다.");
                    firstAttempt = false;
                }
            }
        }
    }
}
