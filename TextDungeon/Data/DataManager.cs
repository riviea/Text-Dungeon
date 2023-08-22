using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class DataManager
    {
        private static DataManager instance = new DataManager();

        // member
        private static List<Item> items = new List<Item>();
        private static Player player = new Player();

        // property
        public List<Item> Items { get { return items; } }
        public Player Player { get { return player; } }

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    DataManager temp = new DataManager();
                    instance = temp;
                }
                return instance;
            }
            private set { instance = value; }
        }

        public DataManager()
        {
            instance = this;
        }

        public void Initialize()
        {
            items.Add(new EquipItem("무쇠갑옷", 0, 5, 0, "무쇠로 만들어져 튼튼한 갑옷입니다.", EquipItem.Parts.Body));
            items.Add(new EquipItem("낡은 검", 2, 0, 0, "쉽게 볼 수 있는 낡은 검입니다.", EquipItem.Parts.Weapon));

            player = new Player(1, new Tuple<string, string>("Chad", "전사"), 10, 5, 100, 1500);
        }

    }
}
