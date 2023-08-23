using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TextDungeon.Scenes;

namespace TextDungeon
{
    internal class Game
    {
        Player player;

        private int cursor;
        public int Cursor { get { return cursor; } set { cursor = value; } }
        public Player Player { get { return player; } }

        public Game ()
        {
            cursor = -1;
            SceneManager.Instance.Call(new Title_Scene());
            DataManager.Instance.Initialize();
            player = new Player();
        }

        public void Update()
        {
            var scene = SceneManager.Instance.Scene;

            if ((cursor >= scene.CursorMin) && (cursor < scene.CursorMax))
            {
                if ((scene.cHandler.ContainsKey(scene.Commands[cursor].CommandKey)))
                {
                    scene.SetSceneCursor(cursor);
                    scene.cHandler[scene.Commands[cursor].CommandKey]();
                    return;
                }
            }
        }

        public void Render()
        {
            SceneManager.Instance.Scene.Draw();
        }

        public void InputAct()
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            
            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();
                int _cursor;

                if (int.TryParse(input, out _cursor))
                {
                    if ((_cursor >= SceneManager.Instance.Scene.CursorMin) && (_cursor < SceneManager.Instance.Scene.CursorMax))
                    {
                        cursor = _cursor;
                        break;
                    }
                }
                else
                    Console.WriteLine(">> 잘못된 입력입니다.");
            }
        }
    }
}
