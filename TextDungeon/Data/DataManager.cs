using System;
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
        private List<Item> items = new List<Item>();
        private Player player = new Player();

        // property
        public Player Player { get { return player; } }
        public List<Item> Items { get { return items; } }

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

        public void LoadItems()
        {
            // ...
        } 
    }
}
