using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.CommandPattern
{
    class EndGameCommand : ICommandPattern
    {
        public EndGameCommand(GameObject gameObject)
        {
            base._gameObject = gameObject;
        }

        public override void Execute()
        {
            Locator.GetAudioSecond().PlaySound();
//            SceneManager.LoadScene("Game");
        }

        public override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
