using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon.Scenes
{
    internal class Inventory_Scene : Scene, IDrawableScene
    {
        public Inventory_Scene()
        {
            sceneName = "인벤토리";
        }

        public void Create_Contents()
        {

        }

        public override void AddCommand()
        {

        }

        public override void SetHandler()
        {

        }

        public override void Draw()
        {
            DisplayHeader();
            DisplayContents();
        }

        public void DisplayHeader()
        {
            if ((sceneName == string.Empty) && (sceneDesc == string.Empty))
                return;

            // Console.WriteLine(sceneName);
            Console.WriteLine(sceneDesc);
        }

        public void DisplayContents()
        {
            Console.WriteLine();
        }

        public void DisplayCommands()
        {
            for (int i = 0; i < Commands.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {Commands[i].CommandName}");
            }
        }
    }
}
