using System;

namespace Commercial_Controller.cs
{
    // public class Battery
    // {
    //     columnList
    //     for (int i = 0; i < nbColumn; i++)
    //     {
            
    //     }
       
        

    //     public string CommandPanel()
    //     {
    //         string selectedColumn = bestColumn;
    //         return selectedColumn;
    //     }
        
    // }

    // public class Column
    // {
        
    //     Int32[] elevatorList = new Array[nbOfElevators];

	// 	for (let i = 0; i < nbElevator.Length; i++) 
    //     {
	// 		this.elevatorList.push(new Elevator('elevator' + i, 10));
	// 	}


    //     buttonList

    // }

    public class Elevator
    {
        public string elevatorId;
        public Int32 nbFloor;
        public Int32 currentFloor = 1;
        public string currentDirection = "idle";
        public string doors = "Elevator doors are closed";


        public Elevator(string aElevatorId, Int32 aNbFloor)
        {
            elevatorId = aElevatorId;
            nbFloor = aNbFloor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Elevator f1 = new Elevator("elevator1", 66);
            Console.WriteLine(f1.nbFloor);

            Int32[] floorList = {9, 8, 7};
            for (int i = 0; i < floorList.Length; i++)
		    {
			    Console.WriteLine(floorList[i]);
		    }
        
            // var battery = new Battery(66, 4);
            
        }
    }
}
