using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon.Scenes
{
    internal class Status_Scene : Scene, IDrawableScene
    {
        public Status_Scene()
        {
            sceneName = "상태 보기";
            sceneDesc = "캐릭터의 정보가 표시됩니다.";
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

            Console.WriteLine(sceneName);
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
