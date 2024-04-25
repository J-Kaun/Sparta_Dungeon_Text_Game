using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    public class Item
    {
        public string itemName { get; set; }
        public string itemStat {  get; set; }
        public string itemDescription { get; set; }
        public string itemNumber { get; set; }
        public int itemPrice { get; set; }
        public bool itemSale { get; set; }

        public void itemInfo(int idx)
        {
            switch (idx)
            {
                case 0:
                    itemName = "가죽 갑옷       ";
                    itemStat = " DEF + 5  ";
                    itemDescription = " 가죽으로 만들어진 갑옷입니다.  ";
                    itemPrice = 1000;
                    itemNumber = "[0]";
                    break;
                case 1:
                    itemName = "청동 갑옷       ";
                    itemStat = " DEF + 9  ";
                    itemDescription = " 청동으로 만들어진 갑옷입니다.  ";
                    itemPrice = 2000;
                    itemNumber = "[1]";
                    break;
                case 2:
                    itemName = "철 갑옷         ";
                    itemStat = " DEF + 15 ";
                    itemDescription = " 철로 만들어진 갑옷입니다.      ";
                    itemPrice = 4500;
                    itemNumber = "[2]";
                    break;
                case 3:
                    itemName = "미스릴 갑옷     ";
                    itemStat = " DEF + 25 ";
                    itemDescription = " 미스릴로 만들어진 갑옷입니다.  ";
                    itemPrice = 10000;
                    itemNumber = "[3]";
                    break;
                case 4:
                    itemName = "마법 부여 갑옷  ";
                    itemStat = " DEF + 40 ";
                    itemDescription = " 보호 마법이 부여된 갑옷입니다. ";
                    itemPrice = 21000;
                    itemNumber = "[4]";
                    break;
                case 5:
                    itemName = "낡은 검         ";
                    itemStat = " ATK + 2  ";
                    itemDescription = " 쉽게 볼 수 있는 낡은 검입니다. ";
                    itemPrice = 600;
                    itemNumber = "[5]";
                    break;
                case 6:
                    itemName = "청동 검         ";
                    itemStat = " ATK + 5  ";
                    itemDescription = " 청동으로 만들어진 검입니다.    ";
                    itemPrice = 1500;
                    itemNumber = "[6]";
                    break;
                case 7:
                    itemName = "철 검           ";
                    itemStat = " ATK + 9  ";
                    itemDescription = " 철로 만들어진 검입니다.        ";
                    itemPrice = 4000;
                    itemNumber = "[7]";
                    break;
                case 8:
                    itemName = "미스릴 검       ";
                    itemStat = " ATK + 15 ";
                    itemDescription = " 미스릴로 만들어진 갑옷입니다.  ";
                    itemPrice = 9000;
                    itemNumber = "[8]";
                    break;
                case 9:
                    itemName = "마법 부여 검    ";
                    itemStat = " ATK + 25 ";
                    itemDescription = " 절삭 마법이 부여된 검입니다.   ";
                    itemPrice = 20000;
                    itemNumber = "[9]";
                    break;
                default:
                    throw new ArgumentException("잘못된 아이템 이름입니다.");
            }
        }
    }
}
