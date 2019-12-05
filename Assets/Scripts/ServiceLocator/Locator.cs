using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public sealed class Locator
    {
        private static AudioInterface _firstSound;
        private static AudioInterface _secondSound;

        public Locator() { }

        public static void SetAudioFirst(AudioInterface firstSound) { _firstSound = firstSound; }
        public static void SetAudioSecond(AudioInterface secondSound) { _secondSound = secondSound; }

        public static AudioInterface GetAudioFirst() { return _firstSound; }
        public static AudioInterface GetAudioSecond() { return _secondSound; }

    };
}
