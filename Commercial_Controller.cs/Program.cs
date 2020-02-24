using System;
using System.Collections.Generic;

namespace Commercial_Controller.cs
{
  public class Columns
  {
    
  }
  public class Elevator
  {
    private string elevatorId;
    private Int32 currentFloor = 1;
    private string currentDirection = "idle";

    public Elevator(string elevatorId)
    {
      this.elevatorId = elevatorId;
      this.currentFloor = currentFloor;
      this.currentDirection = currentDirection;
    }

    public string ElevatorId
    {
      get { return elevatorId;  }
      set { elevatorId = value; }
    }

    public int CurrentFloor
    {
      get { return currentFloor; }
      set { currentFloor = value; }
    }
    public string CurrentDirection
    {
      get { return currentDirection; }
      set { currentDirection = value; }
    }
  }

  class Program
  {
      static void Main(string[] args)
      {
        Console.WriteLine("Hello World!");

        Int32[] floorList = {9, 8, 7};
        for (int i = 0; i < floorList.Length; i++)
        {
          Console.WriteLine(floorList[i]);
        }


        List<Elevator> ElevatorList = new List<Elevator>();

        int numColumns = 4;
        int numElevators = (numColumns * 5) + 1;

        for(int i = 1; i < numElevators; i++)
        {
          if(i <= 5)
          {
            ElevatorList.Add(new Elevator("Basement-Elevator" + i));
          } else if (i > 5 & i <=10)
          {
            ElevatorList.Add(new Elevator("Col2-Elevator" + i));
          } else if (i > 10 & i <=15)
          {
            ElevatorList.Add(new Elevator("Col3-Elevator" + i));
          } else if (i > 15 & i <=20)
          {
            ElevatorList.Add(new Elevator("Col4-Elevator" + i));
          }
        }
        

        foreach (var elevator in ElevatorList)
        {
          Console.WriteLine("Elevator: {0},{1},{2}", elevator.ElevatorId, elevator.CurrentFloor, elevator.CurrentDirection);
        }
        
        int[] nums = new int[10];
        Console.WriteLine(nums.Length);
          // var battery = new Battery(66, 4);
          
      }
  }
}
