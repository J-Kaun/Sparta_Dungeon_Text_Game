using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    internal class Smithy
    {
        public static void smithyUI()
        {
            Console.WriteLine("[대장간]");
            Console.WriteLine("장착하고 있는 아이템을 강화 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("\n1. 방어구 강화 \n2. 무기 강화 \n0. 나가기 \n");
            Console.Write("원하시는 행동을 입력해주세요. \n>> : ");

            string num1 = Console.ReadLine();

            if (num1 == "0")
            {
                Console.Clear();
                Title.gameTitle();
                MainMenu.mainmenuUI();
            }
        }
    }
}
