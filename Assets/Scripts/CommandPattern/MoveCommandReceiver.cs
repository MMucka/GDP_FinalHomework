using UnityEngine;
namespace CommandPatternExample
{
    class MoveCommandReceiver
    {
        public void MoveOperation(GameObject gameObjectToMove, float speed)
        {
			Move(gameObjectToMove,speed);
        }

        private void Move(GameObject gameObjectToMove, float speed)
        {
            float x = Input.GetAxis($"Horizontal") * speed * Time.deltaTime;
            transform.Translate(x, 0f, 0f);
        }
    }

}
