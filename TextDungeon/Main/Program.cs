using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    internal class Program
    {

        static void Main()
        {
            Game textDungeon = new Game();
            
            while(true)
            {
                textDungeon.Update();
                textDungeon.Render();
                textDungeon.InputAct();
                Console.Clear();
            }
        }
    }
}