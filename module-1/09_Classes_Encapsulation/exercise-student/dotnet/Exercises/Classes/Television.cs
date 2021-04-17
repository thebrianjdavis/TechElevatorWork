namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }


        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
            }
        }
        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                CurrentChannel = 3;
                CurrentVolume = 2;
            }
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel >= 3 && newChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (IsOn && CurrentChannel > 17)
            {
                CurrentChannel = 3;
            }
            else if (IsOn)
            {
                CurrentChannel++;
            }
        }
        public void ChannelDown()
        {
            if (IsOn && CurrentChannel < 4)
            {
                CurrentChannel = 18;
            }
            else if (IsOn)
            {
                CurrentChannel--;
            }
        }
        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
            {
                CurrentVolume++;
            }
        }
        public void LowerVolume()
        {
            if (IsOn && CurrentVolume > 0)
            {
                CurrentVolume--;
            }
        }
    }
}
