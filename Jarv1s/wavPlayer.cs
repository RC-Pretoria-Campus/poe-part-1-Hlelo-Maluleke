using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Speech;

namespace Jarv1s
{
    public class wavPlayer
    {
        public static void PlayWav(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }
    }
}
