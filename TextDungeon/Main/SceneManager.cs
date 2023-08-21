using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class SceneManager
    {
        //member
        private static SceneManager instance = null;

        private Stack<Scene> scenes = new Stack<Scene>();
        private Scene scene;

        //property
        public Scene Scene { get { return scene; } }
        public static SceneManager Instance
        {
            get
            {
                if (instance == null)
                {
                    SceneManager temp = new SceneManager();
                    instance = temp;
                }
                return instance;
            }
            private set { instance = value; }
        }

        public SceneManager()
        {
            instance = this;
        }

        public void Call(Scene _scene)
        {
            scenes.Push(_scene);
            scene = scenes.Peek();
        }

        public void Return()
        {
            scenes.Pop();
            scene = scenes.Peek();
        }
    }
}
