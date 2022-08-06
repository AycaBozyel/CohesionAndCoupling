namespace Elevator{
    public class ElevatorTest {
        public static void Main(string[] args){
            IElevator elevator = new ResponsibleElevator();
            elevator.OpenDoor();

            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();            
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn(); //10 person

            elevator.CloseDoor();
            elevator.GoToFloor(Floor.FIFTH);
            elevator.OpenDoor();

            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();

            elevator.PassengersGetOn();
            elevator.PassengersGetOn();            
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.PassengersGetOn();
            elevator.CloseDoor();

            elevator.OpenDoor();
            elevator.PassengersGetOn(); //Someone(11th person) is running to elevator :)
            elevator.CloseDoor();

            elevator.GoToFloor(Floor.ENTRANCE);
            elevator.OpenDoor();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.PassengersGetOff();
            elevator.CloseDoor();
            elevator.GoToFloor(Floor.FIRST);
            elevator.OpenDoor();
            elevator.PassengersGetOff();
            elevator.CloseDoor();
        }

    }
}