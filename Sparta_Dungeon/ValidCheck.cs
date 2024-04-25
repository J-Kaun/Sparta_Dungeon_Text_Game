using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    public class ValidCheck
    {
        public static int Check(int minValue, int maxValue)
        {
            while (true)
            {
                //Console.WriteLine(" ");
                Console.Write("\n 원하시는 행동을 입력해주세요. >>");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int selectedAction))
                {
                    if (selectedAction >= minValue && selectedAction <= maxValue)
                    {
                        return selectedAction;
                    }
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }

    }


}
