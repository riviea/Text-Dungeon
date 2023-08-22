using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon.Scenes
{
    internal class Title_Scene : Scene, IDrawableScene
    {
        public string contents;

        public Title_Scene()
        {
            sceneName = string.Empty;
            sceneDesc = string.Empty;
            CreateContents();
            AddCommand();
            SetHandler();
        }

        public void CreateContents()
        {
            contents = "마을에 오신 여러분 환영합니다.\n" +
                        "이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.";
        }

        public override void AddCommand()
        {
            Commands.Add(new Command("상태보기", "status"));
            Commands.Add(new Command("인벤토리", "inventory"));
        }

        public override void SetHandler()
        {
            cHandler.Add("status", GoStatus);
            cHandler.Add("inventory", GoInventory);
        }

        public override void Draw()
        {
            DisplayHeader();
            DisplayContents();
            DisplayCommands();
        }

        public void DisplayHeader()
        {
            if ((sceneName == string.Empty) && (sceneDesc == string.Empty))
                return;

            Console.WriteLine(sceneName);
            Console.WriteLine(sceneDesc);

            Console.WriteLine();
        }

        public void DisplayContents()
        {
            Console.WriteLine(contents);
            Console.WriteLine();
        }

        public void DisplayCommands()
        {
            for (int i = 0; i < Commands.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {Commands[i].CommandName}");
            }
            Console.WriteLine();
        }

        public void GoStatus()
        {
            SceneManager.Instance.Call(new Status_Scene());
        }

        public void GoInventory()
        {
            SceneManager.Instance.Call(new Inventory_Scene()); Console.WriteLine("인벤토리 선택");
        }
    }
}
