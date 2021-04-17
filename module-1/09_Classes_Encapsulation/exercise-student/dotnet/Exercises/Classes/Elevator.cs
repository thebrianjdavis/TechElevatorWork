namespace Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public Elevator (int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
            DoorIsOpen = false;
        }

        public void OpenDoor()
        {
            if (!DoorIsOpen)
            {
                DoorIsOpen = true;
            }
        }
        public void CloseDoor()
        {
            if (DoorIsOpen)
            {
                DoorIsOpen = false;
            }
        }
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor <= NumberOfLevels && desiredFloor > CurrentLevel)
            {
                CurrentLevel = desiredFloor;
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor >= 1 && desiredFloor < CurrentLevel)
            {
                CurrentLevel = desiredFloor;
            }
        }
    }
}
