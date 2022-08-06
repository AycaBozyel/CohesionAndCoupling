namespace Elevator;

public interface IElevator{
    public void GoToFloor(Floor SelectedFloor);

    public void OpenDoor();
    public void CloseDoor();
    public void PassengersGetOn();
    public void PassengersGetOff();
}
