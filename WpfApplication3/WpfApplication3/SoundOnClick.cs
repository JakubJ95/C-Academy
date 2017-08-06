using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WpfApplication3
{
    class SoundOnClick 
    {

        public static SoundPlayer soundplayer;

        public SoundOnClick()
        {
        }

        public static void PlaySound(string name)
        {
            if (name.Equals("button") == true) soundplayer = new SoundPlayer(WpfApplication3.Properties.Resources.button);
            else if (name.Equals("yes")) soundplayer = new SoundPlayer(WpfApplication3.Properties.Resources.yes);
            else soundplayer = new SoundPlayer(WpfApplication3.Properties.Resources.no);
                if ((bool)App.Current.Properties["efekty"] == true)
                    soundplayer.Play();
        }
    }
}
