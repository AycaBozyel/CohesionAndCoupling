namespace Elevator{
    public class ElevatorDataTest {
        private static ElevatorData PublicElevator = new ElevatorData();

        public static void Main(string[] args){
            ShowElevatorState();
            PublicElevator.DoorOpen = true; // passsengers get on
            PublicElevator.DoorOpen = false; 
            PublicElevator.CurrentFloor--;
            PublicElevator.CurrentFloor++;

            PublicElevator.CurrentFloor = 7;
            PublicElevator.DoorOpen = true; // passengers get on/off

            ShowElevatorState();
            PublicElevator.DoorOpen = false;
            
            PublicElevator.CurrentFloor = -15;
            ShowElevatorState();
            PublicElevator.DoorOpen = true; //passengers get on/off
            PublicElevator.CurrentFloor++; // elevator moves with door open
            ShowElevatorState(); 
            PublicElevator.DoorOpen = false;
            PublicElevator.CurrentFloor--;
            PublicElevator.CurrentFloor--;
            ShowElevatorState();
            PublicElevator.CurrentFloor--;
            ShowElevatorState();
        }

        public static void ShowElevatorState(){
            string DoorStatus = "CLOSED";
            if(PublicElevator.DoorOpen){
                DoorStatus = "OPEN";
            }

            Console.WriteLine("Elevator is at floot " + PublicElevator.CurrentFloor + " and the door is " + DoorStatus);
        }

    }
}