using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class EquipItem : Item
    {
        //parts
        public enum Parts { Head, Body, Legs, Shoose, Arm, Weapon }
        private Parts part;

        // Increase Status
        public EquipItem()
        {

        }

        public EquipItem(string name, int atk, int def, int hp, string desc, Parts _part)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.desc = desc;
            this.part = _part;
        }
    }
}
