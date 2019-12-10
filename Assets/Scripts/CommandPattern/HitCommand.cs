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
            if (_gameObject.name == "SideWallB")   //bottom wall
            {   //END GAME
                Commands.Instance.AddCommand(new EndGameCommand(_gameObject));
            }
            else if (_gameObject.name != "Bumper"
                     && _gameObject.name != "SideWallR"
                     && _gameObject.name != "SideWallL"
                     && _gameObject.name != "SideWallT")   //brick
            {
                
                _gameObject.SetActive(false);  //destroy brick
                //ScoreUI.text = (++score).ToString();    //set score
                Locator.GetAudioFirst().PlaySound();
            }
        }

        public override void UnExecute()
        {
            _gameObject.SetActive(true);
        }
    }
}
