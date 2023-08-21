using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class Player
    {

        private int level;
        private Tuple<string, string> job;
        private int atk, def, hp;
        private int gold;

        public int Level { get { return level; } }

        public string JobEng { get { return job.Item1; } }
        public string JobKor { get { return job.Item2; } }

        public int Atk { get { return atk; } }
        public int Def { get { return def; } }
        public int Hp { get { return hp; } }
        public int Gold { get { return gold; } }

        public Player()
        {

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
