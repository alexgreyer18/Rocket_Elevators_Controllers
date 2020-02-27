using System;
using System.Collections;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
    public class Battery
    {
        public int numColumns;

        public static List<Column> columns;
        public static int[] servFloors1 = new int[7] { -6, -5, -4, -3, -2, -1, 0 };
        public static int[] servFloors2 = new int[20] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static int[] servFloors3 = new int[21] { 0, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
        public static int[] servFloors4 = new int[21] { 0, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

        List<int[]> servFloorsList = new List<int[]> { servFloors1, servFloors2, servFloors3, servFloors4 };
        // public static string[] numCagesPerCol = new string[5] { "elev_1", "elev_2", "elev_3", "elev_4", "elev_5" };
        public Battery(int numColumns, int numElevators)
        {
            this.numColumns = numColumns;

            columns = new List<Column>();

            // Initializing columns list with unique ID
            for (int i = 0; i < numColumns; i++)
            {
                if (i == 0)
                {
                    Column column = new Column("B1_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 1)
                {
                    Column column = new Column("C1_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 2)
                {
                    Column column = new Column("C2_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 3)
                {
                    Column column = new Column("C3_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                Console.WriteLine(columns[i].col_Id + "\n" + "Servicing floors : " + String.Join(", ", columns[i].servicedFloors));
                Console.WriteLine("____________________________________________________");
                // foreach (var item in servFloors1)
                // {
                //     Console.WriteLine(item.ToString());
                // }

            }
        }
        public Elevator requestElevator(int reqFloor, string reqDirection)
        {
            // Column selectedColumn = bestColumn;
            System.Console.WriteLine("floor " + reqFloor + " was requested");
            int ReqFloor = reqFloor;
            Column bestColumn = null;
            foreach (var column in columns)
            {
                if (ReqFloor == 0)
                {
                    System.Console.WriteLine("You are on selected floor level. Please select another floor.");
                    break;
                }
                else if (ReqFloor < 0)
                {
                    bestColumn = columns[0];
                }
                else if (ReqFloor > 0 & ReqFloor <= 20)
                {
                    bestColumn = columns[1];
                }
                else if (ReqFloor >= 21 & ReqFloor <= 40)
                {
                    bestColumn = columns[2];
                }
                else if (ReqFloor >= 41 & ReqFloor <= 60)
                {
                    bestColumn = columns[3];
                }
            }
            System.Console.WriteLine(bestColumn.col_Id + " was selected");
            var elevator = bestColumn.findElevator(reqFloor, reqDirection);

            return elevator;
        }
    }


    public class Column
    {
        // Column attributes
        public string col_Id;
        public int numElevators;
        public int numFloor;
        public int[] servicedFloors;
        public string[] numCagesPerCol;
        public List<Elevator> elevators;
        // public Column selectedColumn = bestColumn;

        // Column constructor
        public Column(string col_Id, int numFloor, int numElevators, int[] servicedFloors)
        {
            this.col_Id = col_Id;
            this.numElevators = numElevators;
            this.numFloor = numFloor;
            this.servicedFloors = servicedFloors;

            elevators = new List<Elevator>();

            for (int i = 0; i < numElevators; i++)
            {
                Elevator elevator = new Elevator("Elevator" + (i + 1));
                elevators.Add(elevator);
                Console.WriteLine("{0},{1},{2}", elevator.elev_Id, " on floor" + elevator.currentFloor, " " + elevator.currentDirection);
            }
        }

        // Methods
        public Elevator findElevator(int reqFloor, string reqDirection)
        {
            Elevator bestElevator = null;
            // Determine elevator position
            foreach (var elevator in this.elevators)
            {
                // If floors are the same
                if (elevator.currentFloor == reqFloor)
                {
                    bestElevator = elevator;
                }
                // If elevator is above floor requesting elevator
                else if (elevator.currentFloor > reqFloor) // & elevator.currentDirection == "down")
                {
                    bestElevator = elevator;
                }
                // If elevator is below floor requesting elevator
                else if (elevator.currentFloor < reqFloor) // & elevator.currentDirection == "up")
                {
                    bestElevator = elevator;
                }
                else
                {
                    System.Console.WriteLine("Loop conditions need more work");
                }

                // System.Console.WriteLine(reqFloor);
                // System.Console.WriteLine(bestElevator + "test");

            }
            System.Console.WriteLine(bestElevator.elev_Id);
            // var elevator = bestElevator.operateElevator(reqFloor);
            return bestElevator;
        }
    }

    public class Elevator
    {
        public string elev_Id;
        public int currentFloor = 1;
        public string currentDirection = "idle";
        public Elevator(string elev_Id)
        {
            this.elev_Id = elev_Id;
        }

        // Make the elevator go pick up the user after finding the bestElevator
        public void operateElevator(int reqFloor)
        {
            // Determine where user is & go pick him up
            if (reqFloor > this.currentFloor)
            {
                while (reqFloor != this.currentFloor)
                {
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    this.currentFloor++;
                }
                System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);

            }
            else
            {
                while (reqFloor != this.currentFloor)
                {
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    this.currentFloor--;
                }
                System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);

            }
            // Doors opening & closing when it has arrived to pick up the user
            System.Console.WriteLine("Doors opened." + "\n" + "Doors closed.");

            // Go back to floor 0 after picking up user
            if (this.currentFloor < 0)
            {
                while (this.currentFloor != 0)
                {
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    this.currentFloor++;
                }
                System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
            }
            else
            {
                while (this.currentFloor != 0)
                {
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    this.currentFloor--;
                }
                System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);

            }



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var battery = new Battery(4, 5);
            // Test 1 --- Floor 7 requesting an elevator going to floor 0
            // var bestColumn = battery.requestElevator(7, "down");
            // bestColumn.operateElevator(7);

            // Test 2 --- Basement 2 requesting an elevator going to floor 0
            var bestColumn = battery.requestElevator(-2, "up");
            bestColumn.operateElevator(-2);

            // bestColumn.findElevator(bestColumn, bestColumn.requestElevator);
            // var elevator = bestColumn.findElevator();

            // elevator.moveElevator
            // elevator.openDoors
            // elevator.closeDoors



        }
    }
}
