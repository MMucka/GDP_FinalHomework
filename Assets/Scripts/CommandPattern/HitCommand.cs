using System.Text.RegularExpressions;
using UnityEngine;

namespace Assets.Scripts.CommandPattern
{
    class HitCommand : ICommandPattern
    {
        public HitCommand(GameObject gameObject)
        {
            base._gameObject = gameObject;
        } 

        public override void Execute()
        {
            Regex regex = new Regex(@"Brick \(\d\)");
            Match match = regex.Match(_gameObject.name);
            if (match.Success)      //it is brick
            {
                _gameObject.SetActive(false);                   //destroy brick
                //GameObject.Find("Canvas").GetComponent<GameRun>().IncrementScore();
                Locator.GetAudioFirst().PlaySound();
            }

            else if (_gameObject.name == "SideWallB")   //bottom wall
            {                                           //END GAME
                Commands.Instance.AddCommand(new EndGameCommand(_gameObject));
            }
        }

        public override void UnExecute()
        {
            _gameObject.SetActive(true);
        }
    }
}
