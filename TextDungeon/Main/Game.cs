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
        private int cursor;
        public Game ()
        {
            cursor = 0;
            SceneManager.Instance.Call(new Title_Scene());
        }

        public int Cursor { get { return cursor; } set { cursor = value; } }

        public void Update()
        {
            var scene = SceneManager.Instance.Scene;

            if (cursor > 0)
            {
                if ((scene.cHandler.ContainsKey(scene.Commands[cursor - 1].CommandKey)))
                {
                    scene.cHandler[scene.Commands[cursor - 1].CommandKey]();
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
            Console.Write(">> ");

            while (true)
            {
                string input = Console.ReadLine();
                int _cursor;

                if (int.TryParse(input, out _cursor))
                {
                    if ((_cursor > 0) && (_cursor <= SceneManager.Instance.Scene.CommandAmount()))
                    {
                        cursor = _cursor;
                        break;
                    }
                }
                else
                    Console.Write("잘못된 입력입니다.");
            }
        }
    }
}
