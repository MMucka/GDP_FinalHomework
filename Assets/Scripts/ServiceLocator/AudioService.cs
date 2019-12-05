using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class AudioService : AudioInterface
    {
        private AudioSource _source;
        private AudioClip _sound;

        public AudioService(AudioClip clip, AudioSource source)
        {
            _sound = clip;
            _source = source;
        }

        public override void PlaySound()
        {
            _source.PlayOneShot(_sound);
        }

        public override void StopSound()
        {
            _source.Stop();
        }

    }
}
