using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sparta_Dungeon
{
    internal class Store
    {
        private static Item item = new Item();

        public static void storeUI()
        {
            Console.WriteLine("[상점] \n필요한 아이템을 구매할 수 있는 상점입니다. \n");
            Console.WriteLine("[보유 골드] \n{0} G \n", Status.gold);
            Console.WriteLine("[아이템 목록] \n");

            string itemList = "";

            for (int i = 0; i < 10; i++)
            {
                item.itemInfo(i);

                Console.WriteLine(" - " + item.itemName + "│" + item.itemStat + "│" + item.itemDescription + "│ " + ((item.itemSale == true) ? " 구매 완료" : item.itemPrice + "G"));
                
                itemList += " - " + item.itemNumber + " " + item.itemName + "│" + item.itemStat + "│" + item.itemDescription + "│ " + item.itemPrice + "G\n";
            }

            Console.WriteLine("\n[1. 아이템 구매] \n[0. 나가기] \n");

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
                    Console.Clear();
                    Title.gameTitle();
                    BuyUI(itemList);
                    validInput = true;

                }
                //else if (num1 == "2")
                //{
                //    Console.WriteLine("미구현");
                //}
                if (firstAttempt)
                {
                    Console.WriteLine("잘못 된 입력입니다.");
                    firstAttempt = false;
                }
            }
        }

        public static void BuyUI(string itemList)
        {
            Console.WriteLine("[상점] \n필요한 아이템을 구매할 수 있는 상점입니다. \n");
            Console.WriteLine("[보유 골드] \n{0} G \n", Status.gold);
            Console.WriteLine("[아이템 목록] \n");
            Console.WriteLine(itemList);
            Console.Write("구매하려는 아이템 번호를 입력해주세요. \n>> : ");

            string idx = Console.ReadLine();

            item.itemInfo(int.Parse(idx));

            if (Status.gold >= item.itemPrice) //보유 골드 >= 가격
            {
                Console.Clear();
                Title.gameTitle();
                Console.WriteLine("===========================================================================");
                Console.WriteLine("                              구매 완료");
                Console.WriteLine("                  인벤토리에 아이템이 추가되었습니다.");
                Console.WriteLine("===========================================================================\n");

                item.itemSale = true;

                Store.storeUI();
            }
            else //보유 골드 < 가격
            {
                Console.WriteLine("보유 골드가 부족합니다.");
            }

            //구매 완료 -> 이미 구매 완료 구매 X
            //아이템 번호 0~9 X -> 잘못 입력 -> 다시 입력

        }
    }
}
