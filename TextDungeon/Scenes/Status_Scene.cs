using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon.Scenes
{
    internal class Status_Scene : Scene, IDrawableScene
    {
        public Player player = new Player();

        public Status_Scene()
        {
            sceneName = "상태 보기";
            sceneDesc = "캐릭터의 정보가 표시됩니다.";
            AddCommand();
            SetHandler();
            CreateContents();
        }

        public void CreateContents()
        {

        }

        public override void AddCommand()
        {
            Commands.Add(new Command("나가기", "exit"));
        }

        public override void SetHandler()
        {
            cHandler.Add("exit", ExitScene);
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
            Console.WriteLine("*** contents ***");
            //Console.WriteLine($"Lv. {Player.Level.ToString("D2")}");
            //Console.WriteLine($"{Game.Player.JobEng} ( {Game.Player.JobKor} ");
            //Console.WriteLine($"공격력: {Game.Player.Atk}");
            //Console.WriteLine($"방어력: {Game.Player.Def}");
            //Console.WriteLine($"체력: {Game.Player.Hp}");
            //Console.WriteLine($"Gold: {Game.Player.Gold}");
            //Console.WriteLine();
        }

        public void DisplayCommands()
        {
            for (int i = 0; i < Commands.Count; ++i)
            {
                Console.WriteLine($"{i+1}. {Commands[i].CommandName}");
            }
            Console.WriteLine();
        }

        public void ExitScene()
        {
            SceneManager.Instance.Return();
        }

    }
}
