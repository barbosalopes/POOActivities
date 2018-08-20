using System;
namespace POOActivities.Day_2018_08_09
{
    public class Television
    {
        private bool turnedOn;
        private int volume;
        private int channel;


        public Television(){
            turnedOn = true;
            volume = 50;
            channel = 1;
        }


        public void TurnOn(){
            turnedOn = true;
        }

        public void TurnOff(){
            turnedOn = false;
        }

        public bool ChangeChannel(int c){
            if(c < 1 || c > 83){
                throw new Exception("The channel {c} is not avaible.");
            }
            else {
                channel = c;
                return true;
            }
        }

        public bool IncreaseChannel(){
            return ChangeChannel(channel + 1);
        }

        public bool DecreaseChannel(){
            return ChangeChannel(channel - 1);
        }

        public bool ChangeVolume(int v)
        {
            if (v < 1 || v > 83)
            {
                throw new Exception("Volume {v} invalid.");
            }
            else
            {
                volume = v;
                return true;
            }
        }

        public bool IncreaseVolume(){
            return ChangeVolume(volume+ 1);
        }

        public bool DecreaseVolume()
        {
            return ChangeVolume(volume - 1);
        }
    }
}
