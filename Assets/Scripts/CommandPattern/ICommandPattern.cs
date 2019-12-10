using UnityEngine;

namespace Assets.Scripts.CommandPattern
{
    /*
     * The 'Command' abstract class that we will inherit from
     * Interface for all commands
     */
    abstract class ICommandPattern
    {
        protected GameObject _gameObject;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}