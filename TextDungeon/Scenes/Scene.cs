﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public abstract class Scene
    {
        //delegate
        public delegate void IsSelected();

        //member
        protected string sceneName;
        protected string sceneDesc;
        protected int sceneCursor = 0;
        protected int cursorMin=0, cursorMax;

        //command handelr
        private Dictionary<string, IsSelected> handler = new Dictionary<string, IsSelected>();
        private List<Command> commands = new List<Command>();

        public string SceneName { get { return sceneName; } }
        public string SceneDesc { get { return sceneDesc; } }
        public int CursorMin { get { return cursorMin; } }
        public int CursorMax { get { return cursorMax; } }


        public Dictionary<string, IsSelected> cHandler { get { return handler; } }
        public List<Command> Commands { get { return commands; } }

        public abstract void AddCommand();
        public abstract void SetHandler();

        public abstract void Draw();


        public void SetSceneCursor(int cursor)
        {
            sceneCursor = cursor; 
        }

        public int CommandAmount()
        {
            return commands.Count;
        }
    }

    public interface IDrawableScene
    {
        void DisplayHeader();
        void DisplayContents();
        void DisplayCommands();
    }
}