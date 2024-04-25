using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    internal class MainMenu
    {
        public static void mainmenuUI()
        {
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다. \n");
            Console.WriteLine("[1. 상태 보기] \n[2. 인벤토리] \n[3. 상점] \n"); //[4. 대장간] \n[5. 던전] \n[6. 여관] \n");
            
            bool validInput = false;
            bool firstAttempt = true;

            while (!validInput)
            {
                Console.Write("원하시는 행동을 입력해주세요. \n>> : ");
                string num1 = Console.ReadLine();

                if (num1 == "1")
                {
                    Console.Clear();
                    Title.gameTitle();
                    Status.statusUi();
                    validInput = true;
                }
                else if (num1 == "2")
                {
                    Console.Clear();
                    Title.gameTitle();
                    Inventory.inventoryUI();
                    validInput = true;
                }
                else if (num1 == "3")
                {
                    Console.Clear();
                    Title.gameTitle();
                    Store.storeUI();
                    validInput = true;
                }
                //else if (num1 == "4")
                //{
                //    Console.Clear();
                //    Title.gameTitle();
                //    Smithy.smithyUI();
                //    validInput = true;
                //}
                //else if (num1 == "5")
                //{
                //    Console.Clear();
                //    Title.gameTitle();
                //    Dungeon.dungeonUI();
                //    validInput = true;
                //}
                //else if (num1 == "6")
                //{
                //    Console.Clear();
                //    Title.gameTitle();
                //    Motel.motelUI();
                //    validInput = true;
                //}
                if (firstAttempt)
                {
                    Console.WriteLine("잘못 된 입력입니다.");
                    firstAttempt = false;
                }
            }
        }
    }
}
