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
            Game gameManager = new Game();
            
            while(true)
            {
                gameManager.Update();
                gameManager.Render();
                gameManager.InputAct();
                Console.Clear();
            }
        }
    }
}