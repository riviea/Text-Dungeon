using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class Item
    {
        public enum ItemType { Useable, Equipable}
        
        protected string name;
        protected int atk, def, hp;
        protected string desc;
        protected ItemType type;

        public string Name { get { return name; } }

        public int Atk { get { return atk; } }
        public int Def { get { return def; }}
        public int Hp { get { return hp; }}

        public string Desc { get { return desc; }}

        public ItemType Type { get { return type; } }

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
