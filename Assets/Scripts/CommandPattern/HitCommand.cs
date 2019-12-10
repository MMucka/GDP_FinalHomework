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
            var match = new Regex(@"Brick\d").Match(_gameObject.name);
            if (match.Success)      //it is brick
            {
                _gameObject.SetActive(false);                   //destroy brick
                Locator.GetAudioFirst().PlaySound();
                Commands.Instance.AddCode(ByteCodes.Codes.IncrementScore);
            }
        }

        public override void UnExecute()
        {
            _gameObject.SetActive(true);
        }
    }
}
