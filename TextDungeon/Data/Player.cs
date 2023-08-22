using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using static TextDungeon.Item;

namespace TextDungeon
{
    public class Player
    {
        // Item
        private int level;
        private Tuple<string, string> job;
        private int atk, def, hp;
        private int gold;

        // Equip
        private Dictionary<string, Item> equips = new Dictionary<string, Item>();
        
        // Inventory
        private List<Item> items = new List<Item>();

        // Property
        public Dictionary<string, Item> Equips { get { return equips; } }
        public List<Item> Items { get { return items; } }

        public int Level { get { return level; } }

        public string JobEng { get { return job.Item1; } }
        public string JobKor { get { return job.Item2; } }

        public int Atk { get { return atk; } }
        public int Def { get { return def; } }
        public int Hp { get { return hp; } }
        public int Gold { get { return gold; } }

        public Player()
        {
            equips.Add("head", new EquipItem());
            equips.Add("body", new EquipItem());
            equips.Add("legs", new EquipItem());
            equips.Add("shoose", new EquipItem());
            equips.Add("arm", new EquipItem());
            equips.Add("weqpon", new EquipItem());
        }

        public Player(int level, Tuple<string, string> job, int atk, int def, int hp, int gold)
        {
            this.level = level;
            this.job = job;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.gold = gold;
        }
    }
}
