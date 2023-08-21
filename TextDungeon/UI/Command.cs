using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDungeon
{
    public class Command
    {
        //member
        private string commandName;
        private string commandKey;

        // property
        public string CommandName { get { return commandName; } }
        public string CommandKey { get {  return commandKey; } }

        public Command()
        {
            commandName = string.Empty;
            commandKey = string.Empty;
        }

        public Command(string commandName, string commandKey)
        {
            this.commandName = commandName;
            this.commandKey = commandKey;
        }
    }
}
