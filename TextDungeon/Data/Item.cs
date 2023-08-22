using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class Item
    {
        public enum ItemType { Useable, Equipable }
        
        protected string name;
        protected int atk, def, hp;
        protected string desc;
        protected ItemType type;

        public string Name { get { return name; } }

        public int Atk { get { return atk; } set { atk = value; } }
        public int Def { get { return def; } set { def = value; } }
        public int Hp { get { return hp; } set { hp = value; } }    

        public string Desc { get { return desc; } set { desc = value; } }

        public ItemType Type { get { return type; } set { type = value; } }

        public Item()
        {

        }

        public Item(string name, int atk, int def, int hp, string desc)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.desc = desc;
        }
    }
}
