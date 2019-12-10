using Assets.Scripts.CommandPattern;
using UnityEngine;
namespace CommandPatternExample
{
    class MoveCommand : ICommandPattern
    {
        private readonly float _speed;

        public MoveCommand(GameObject gameObject, float speed)
        {
            base._gameObject = gameObject;
            this._speed = speed;
        }


        public override void Execute()
        {
            Move(_gameObject, _speed);
        }

        public override void UnExecute()
        {
            Move(_gameObject, _speed*-1);
        }

        private void Move(GameObject gameObjectToMove, float speed)
        {
            float x = Input.GetAxis($"Horizontal") * speed * Time.deltaTime;
            gameObjectToMove.transform.Translate(x, 0f, 0f);
        }

    }

}
