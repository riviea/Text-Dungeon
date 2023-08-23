using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon.Scenes
{
    public class Equip_Scene : Scene, IDrawableScene
    {
        public int commandCount;

        public int CommandCount { get { return commandCount; } }

        public Equip_Scene()
        {
            sceneName = "인벤토리 - 장착 관리";
            sceneDesc = "보유 중인 아이템을 관리할 수 있습니다.";
            
            AddCommand();
            SetHandler();
            Create_Contents();
        }

        public void Create_Contents()
        {

        }

        public override void AddCommand()
        {
            Commands.Add(new Command("나가기", "exit"));

            commandCount = Commands.Count;

            var items = DataManager.Instance.Items;
            for(int i=0; i<items.Count; ++i)
            {
                Commands.Add(new Command("item" + i.ToString(), "item" + i.ToString().ToString()));
            }

            cursorMax = Commands.Count;
        }

        public override void SetHandler()
        {
            cHandler.Add("exit", ExitScene);

            foreach(var command in Commands)
            {
                if(command.CommandName.Contains("item"))
                {
                    cHandler.Add(command.CommandName, EquipItemProcess);
                }
            }
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
            var items = DataManager.Instance.Items;

            Console.WriteLine("[아이템 목록]");
            for (int i = 0, j=commandCount; i < items.Count; ++i, ++j)
            {
                Console.Write($"- {j} ");
                if (DataManager.Instance.Player.Equips.ContainsValue(items[i]))
                    Console.Write("[E]");
                Console.Write($"{items[i].Name}  |  ");
                if (items[i].Atk != 0)
                    Console.Write($"공격력 +{items[i].Atk} ");
                if (items[i].Def != 0)
                    Console.Write($"방어력 +{items[i].Def} ");
                if (items[i].Hp != 0)
                    Console.Write($"방어력 +{items[i].Hp}");
                Console.Write($"  |  {items[i].Desc} \n");
            }
            Console.WriteLine();
        }

        public void DisplayCommands()
        {
            for (int i = 0; !Commands[i].CommandName.Contains("item"); ++i)
            {
                Console.WriteLine($"{i}. {Commands[i].CommandName}");
            }
        }

        public void ExitScene()
        {
            SceneManager.Instance.Return();
        }

        public void EquipItemProcess()
        {
            var items = DataManager.Instance.Items;
            var player = DataManager.Instance.Player;
            EquipItem temp = items[sceneCursor-commandCount] as EquipItem;

            if (player.Equips.ContainsValue(items[sceneCursor-commandCount]))
            {
                if (temp != null)
                    player.Equips.Remove(temp.Part);
            }
            else
            {
                player.Equips.Add(temp.Part, temp);
            }
        }
    }
}
