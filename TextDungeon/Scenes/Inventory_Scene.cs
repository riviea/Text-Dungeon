﻿using System;
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
            Commands.Add(new Command("장착 관리", "equip"));

            cursorMax = Commands.Count;
        }

        public override void SetHandler()
        {
            cHandler.Add("exit", ExitScene);
            cHandler.Add("equip", GoEquip);
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
            for (int i=0; i<items.Count; ++i)
            {
                Console.Write("- ");
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
            for (int i = 0; i < Commands.Count; ++i)
            {
                Console.WriteLine($"{i}. {Commands[i].CommandName}");
            }
            Console.WriteLine();
        }
        
        public void ExitScene()
        {
            SceneManager.Instance.Return();
        }

        public void GoEquip()
        {
            SceneManager.Instance.Call(new Equip_Scene());
        }
    }
}
