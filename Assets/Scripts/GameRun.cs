using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameRun : MonoBehaviour
    {
        public TMP_Text Score;

        public AudioClip HitBoxSound;
        public AudioClip EndGameSound;
        public AudioSource audioSource;

        private static int _score = 0;

        // Start is called before the first frame update
        void Start()
        {
            Locator.SetAudioFirst(new AudioService(HitBoxSound, audioSource));       //ServiceLocator
            Locator.SetAudioSecond(new AudioService(EndGameSound, audioSource));
        }

        // Update is called once per frame
        void Update()
        {
            Commands.Instance.Execute();
        }

        public void IncrementScore()
        {
            Score.text = "Score: " + (++_score);
        }
    }
}
