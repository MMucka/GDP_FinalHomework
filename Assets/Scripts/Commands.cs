using System;
using System.Collections.Generic;
using Assets.Scripts.CommandPattern;

namespace Assets.Scripts
{
    class Commands : ICommandPattern
    {
        public static Commands Instance { get; } = new Commands();      //Singleton init
        private Queue<ICommandPattern> _commandsQueue;                  //FIFO queue

        private Commands()
        {   //init new queue
            _commandsQueue = new Queue<ICommandPattern>();
        }

        /*
         * Add new command
         * @command - new command with interface ICommandPattern
         */
        public void AddCommand(ICommandPattern command)
        {
            _commandsQueue.Enqueue(command);
        }

        /*
         * Execute command
         */
        public override void Execute()
        {
            if(_commandsQueue.Count != 0)
                _commandsQueue.Dequeue().Execute();
        }

        /*
         * Undo command
         */
        public override void UnExecute()
        {
            if (_commandsQueue.Count != 0)
                _commandsQueue.Dequeue().UnExecute();
        }
    }
}
