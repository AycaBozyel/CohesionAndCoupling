namespace Elevator{
    public class ResponsibleElevator : IElevator{ 
        private bool DoorOpen = false;
        private bool Stopped = true;
        private Floor CurrentFloor = Floor.ENTRANCE;
        private int Weight = 0;

        private static int CAPACITY = 1000;

        public void OpenDoor(){
            if(Stopped){
                DoorOpen = true;
                Console.WriteLine("Door is open");
            }else{
                DoorOpen = false;
                Console.WriteLine("Door cannot open");
            }
        }

        public void CloseDoor(){
            if(DoorOpen){
                DoorOpen = false;
                Console.WriteLine("Door is closed");
            }
            else{
                Console.WriteLine("Door already is closed");
            }
        }
        public bool CalculateCapacity(){
            if(Weight <= CAPACITY && Weight >= 0){
                return true;
            }else{
                return false;
            }
        }
        public void GoToFloor(Floor selectedFloor){
            if(DoorOpen)
            {
                Console.WriteLine("Door is open. Elevator cannot move.");
                return;
            }
            if(CalculateCapacity()){
                CurrentFloor = selectedFloor;
            }
            else{
                Console.WriteLine("Elevator weight is exceed capasity ("+Weight+" kg). It cannot move.");
            }
        }
        public void PassengersGetOn(){
            if(Stopped && DoorOpen){
                Weight += 70;
            }
            else{
                Console.WriteLine("Anyone cannot get on the elevator. Because elevator's door is not open or elevator is not stop.");
            }
        }
        public void PassengersGetOff(){
            if(Stopped && DoorOpen){
                if(Weight < 70){
                    Console.WriteLine("No passengers in the elevator. Anyone cannot get off.");
                }else{
                    Weight -= 70; 
                }
            }
            else{
                Console.WriteLine("Anyone cannot get on the elevator. Because elevator's door is not open or elevator is not stop.");
            }
        }
    }
}

