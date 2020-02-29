using System;
using System.Linq;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize battery
            var battery = new Battery(4, 5);

            // Test 1 --- Someone at 1st floor requests the 20th floor; Elevator5 (B5) is expected to be sent.
            // Unfold scenario settings & description

            {
                // With second column (or column B) serving floors from 2 to 20, with elevator B1 at 20th 
                // floor going to 5th, B2 at 3rd floor going to 15th, B3 at 13th floor going to 1st, B4 at 15th floor 
                // going to 2nd, and B5 at 6th floor going to 1st, someone is at 1st floor and requests the 20th floor, 
                // Elevator5 (B5) is expected to be sent

                // System.Console.WriteLine("__________________Elevator Status'_________________");
                // Battery.columns[1].elevators[0].currentFloor = 20;
                // Battery.columns[1].elevators[0].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[1].elevators[0].elev_Id + " on floor " + Battery.columns[1].elevators[0].currentFloor + " going " + Battery.columns[1].elevators[0].currentDirection);

                // Battery.columns[1].elevators[1].currentFloor = 3;
                // Battery.columns[1].elevators[1].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[1].elevators[1].elev_Id + " on floor " + Battery.columns[1].elevators[1].currentFloor + " going " + Battery.columns[1].elevators[1].currentDirection);

                // Battery.columns[1].elevators[2].currentFloor = 13;
                // Battery.columns[1].elevators[2].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[1].elevators[2].elev_Id + " on floor " + Battery.columns[1].elevators[2].currentFloor + " going " + Battery.columns[1].elevators[2].currentDirection);

                // Battery.columns[1].elevators[3].currentFloor = 15;
                // Battery.columns[1].elevators[3].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[1].elevators[3].elev_Id + " on floor " + Battery.columns[1].elevators[3].currentFloor + " going " + Battery.columns[1].elevators[3].currentDirection);

                // Battery.columns[1].elevators[4].currentFloor = 6;
                // Battery.columns[1].elevators[4].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[1].elevators[4].elev_Id + " on floor " + Battery.columns[1].elevators[4].currentFloor + " going " + Battery.columns[1].elevators[4].currentDirection);
            }
            // Battery.assignElevator(20, "up").operateElevator(20);


            // Test 2 --- Someone at 1st floor requests the 36th floor; Elevator1 (C1) is expected to be sent.
            // Unfold scenario settings & description

            {
                // With third column (or column C) serving floors from 21 to 40, with elevator C1 at 1st 
                // floor going to 21th, C2 at 23st floor going to 28th, C3 at 33rd floor going to 1st, C4 at 40th floor
                // going to 24th, and C5 at 39nd floor going to 1st, someone is at 1st floor and requests the 36th floor,
                // Elevator1 (C1) is expected to be sent

                // Battery.columns[2].elevators[0].currentFloor = 0;
                // Battery.columns[2].elevators[0].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[2].elevators[0].elev_Id + " on floor " + Battery.columns[2].elevators[0].currentFloor + " going " + Battery.columns[2].elevators[0].currentDirection);

                // Battery.columns[2].elevators[1].currentFloor = 23;
                // Battery.columns[2].elevators[1].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[2].elevators[1].elev_Id + " on floor " + Battery.columns[2].elevators[1].currentFloor + " going " + Battery.columns[2].elevators[1].currentDirection);

                // Battery.columns[2].elevators[2].currentFloor = 33;
                // Battery.columns[2].elevators[2].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[2].elevators[2].elev_Id + " on floor " + Battery.columns[2].elevators[2].currentFloor + " going " + Battery.columns[2].elevators[2].currentDirection);

                // Battery.columns[2].elevators[3].currentFloor = 40;
                // Battery.columns[2].elevators[3].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[2].elevators[3].elev_Id + " on floor " + Battery.columns[2].elevators[3].currentFloor + " going " + Battery.columns[2].elevators[3].currentDirection);

                // Battery.columns[2].elevators[4].currentFloor = 39;
                // Battery.columns[2].elevators[4].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[2].elevators[4].elev_Id + " on floor " + Battery.columns[2].elevators[4].currentFloor + " going " + Battery.columns[2].elevators[4].currentDirection);
            }
            // Battery.assignElevator(36, "up").operateElevator(36);


            // Test 3 --- Someone at 54th floor requests the 1st floor; Elevator1 (D1) is expected to be sent.
            // Unfold scenario settings & description

            {
                // With fourth column (or column D) serving floors from 41 to 60, with elevator D1 at 58th floor  
                // going to 1st, D2 at 50th floor going to 60th, D3 at 46th floor going to 58th, D4 at 1st floor going 
                // to 54th, and D5 at 60th floor going to 1st, someone is at 54th floor and requests the 1st floor, 
                // Elevator1 (D1) is expected to pick him up

                // Battery.columns[3].elevators[0].currentFloor = 58;
                // Battery.columns[3].elevators[0].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[3].elevators[0].elev_Id + " on floor " + Battery.columns[3].elevators[0].currentFloor + " going " + Battery.columns[3].elevators[0].currentDirection);

                // Battery.columns[3].elevators[1].currentFloor = 50;
                // Battery.columns[3].elevators[1].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[3].elevators[1].elev_Id + " on floor " + Battery.columns[3].elevators[1].currentFloor + " going " + Battery.columns[3].elevators[1].currentDirection);

                // Battery.columns[3].elevators[2].currentFloor = 46;
                // Battery.columns[3].elevators[2].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[3].elevators[2].elev_Id + " on floor " + Battery.columns[3].elevators[2].currentFloor + " going " + Battery.columns[3].elevators[2].currentDirection);

                // Battery.columns[3].elevators[3].currentFloor = 0;
                // Battery.columns[3].elevators[3].currentDirection = "up";
                // System.Console.WriteLine(Battery.columns[3].elevators[3].elev_Id + " on floor " + Battery.columns[3].elevators[3].currentFloor + " going " + Battery.columns[3].elevators[3].currentDirection);

                // Battery.columns[3].elevators[4].currentFloor = 60;
                // Battery.columns[3].elevators[4].currentDirection = "down";
                // System.Console.WriteLine(Battery.columns[3].elevators[4].elev_Id + " on floor " + Battery.columns[3].elevators[4].currentFloor + " going " + Battery.columns[3].elevators[4].currentDirection);
            }
            // battery.requestElevator(54, "down").operateElevator(54);


            // Test 4 --- Someone at 1st floor requests the 36th floor; Elevator1 (C1) is expected to be sent.
            // Unfold scenario settings & description

            {
                // With first column (or Column A) serving the basements B1 to B6, with elevator A1 idle at B4, A2 
                // idle at 1st floor, A3 at B3 and going to B5, A4 at B6 and going to 1st floor, and A5 at B1 going to
                // B6, someone is at B3 and requests the 1st floor. Elevator A4 is expected to be sent.
                // Elevator4 (A4) is expected to be sent.

                Battery.columns[0].elevators[0].currentFloor = -4;
                Battery.columns[0].elevators[0].currentDirection = "idle";
                System.Console.WriteLine(Battery.columns[0].elevators[0].elev_Id + " on floor " + Battery.columns[0].elevators[0].currentFloor + " going " + Battery.columns[0].elevators[0].currentDirection);

                Battery.columns[0].elevators[1].currentFloor = 0;
                Battery.columns[0].elevators[1].currentDirection = "idle";
                System.Console.WriteLine(Battery.columns[0].elevators[1].elev_Id + " on floor " + Battery.columns[0].elevators[1].currentFloor + " going " + Battery.columns[0].elevators[1].currentDirection);

                Battery.columns[0].elevators[2].currentFloor = -3;
                Battery.columns[0].elevators[2].currentDirection = "down";
                System.Console.WriteLine(Battery.columns[0].elevators[2].elev_Id + " on floor " + Battery.columns[0].elevators[2].currentFloor + " going " + Battery.columns[0].elevators[2].currentDirection);

                Battery.columns[0].elevators[3].currentFloor = -6;
                Battery.columns[0].elevators[3].currentDirection = "up";
                System.Console.WriteLine(Battery.columns[0].elevators[3].elev_Id + " on floor " + Battery.columns[0].elevators[3].currentFloor + " going " + Battery.columns[0].elevators[3].currentDirection);

                Battery.columns[0].elevators[4].currentFloor = -1;
                Battery.columns[0].elevators[4].currentDirection = "down";
                System.Console.WriteLine(Battery.columns[0].elevators[4].elev_Id + " on floor " + Battery.columns[0].elevators[4].currentFloor + " going " + Battery.columns[0].elevators[4].currentDirection);
            }
            battery.requestElevator(-3, "up").operateElevator(-3);
        }
    }
    public class Battery
    {
        // Battery attributes
        public int numColumns;
        public static List<Column> columns;
        //List of serviced floors unique to each column
        public static int[] servFloors1 = new int[7] { -6, -5, -4, -3, -2, -1, 0 }; // basements + lobby
        public static int[] servFloors2 = new int[20] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static int[] servFloors3 = new int[21] { 0, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
        public static int[] servFloors4 = new int[21] { 0, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

        List<int[]> servFloorsList = new List<int[]> { servFloors1, servFloors2, servFloors3, servFloors4 };

        // Battery constructor
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
                // Console.WriteLine(columns[i].col_Id + "\n" + "Servicing floors : " + String.Join(", ", columns[i].servicedFloors));
            }
        }

        // Battery methods
        // First finds a column (bestColumn) & then finds an elevator within the elevators list of the selected column
        public Elevator requestElevator(int reqFloor, string reqDirection)
        {
            Console.WriteLine("___________________________________________________");
            System.Console.WriteLine("floor " + reqFloor + " is calling");
            int ReqFloor = reqFloor;
            Column bestColumn = null;

            // Choosing bestColumn based on reqFloor
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


        // First finds a column (bestColumn) & then finds an elevator within the elevators list of the selected column
        public static Elevator assignElevator(int reqFloor, string direction)
        {
            Console.WriteLine("___________________________________________________");
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
            var elevator = bestColumn.findElevator(0, direction);
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
        public List<Elevator> elevatorScores;
        public List<Elevator> elevators;

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
                // Console.WriteLine("{0},{1},{2}", elevator.elev_Id, " on floor" + elevator.currentFloor, " " + elevator.currentDirection);
            }
        }

        // Column Methods
        public Elevator findElevator(int reqFloor, string reqDirection)
        {
            int bestScore = 999;
            Elevator bestElevator = this.elevators[0];

            // Determine elevator position
            foreach (var elevator in this.elevators)
            {
                // If floors are the same
                if (elevator.currentFloor == reqFloor & reqDirection == elevator.currentDirection)
                {
                    if (bestScore > 1)
                    {
                        bestElevator = elevator;
                        bestScore = 1;
                    }
                    else if (bestScore == 1)
                    {
                        int bestElevatorGap = Math.Abs(bestElevator.currentFloor - reqFloor);
                        int newElevatorGap = Math.Abs(elevator.currentFloor - reqFloor);

                        if (newElevatorGap < bestElevatorGap)
                        {
                            bestElevator = elevator;
                        }
                    }
                }
                // If elevator is above floor requesting elevator & going down
                else if (elevator.currentFloor > reqFloor & elevator.currentDirection == "down" & reqDirection == "up")
                {
                    if (bestScore > 2)
                    {
                        bestElevator = elevator;
                        bestScore = 2;
                    }
                    else if (bestScore == 2)
                    {
                        int bestElevatorGap = Math.Abs(bestElevator.currentFloor - reqFloor);
                        int newElevatorGap = Math.Abs(elevator.currentFloor - reqFloor);

                        if (newElevatorGap < bestElevatorGap)
                        {
                            bestElevator = elevator;
                        }
                    }
                }
                // If elevator is above floor requesting elevator & going down
                else if (elevator.currentFloor > reqFloor & elevator.currentDirection == "down" & reqDirection == "down")
                {
                    if (bestScore > 3)
                    {
                        bestElevator = elevator;
                        bestScore = 3;
                    }
                    else if (bestScore == 3)
                    {
                        int bestElevatorGap = Math.Abs(bestElevator.currentFloor - reqFloor);
                        int newElevatorGap = Math.Abs(elevator.currentFloor - reqFloor);

                        if (newElevatorGap < bestElevatorGap)
                        {
                            bestElevator = elevator;
                        }
                    }
                }
                // If elevator is above floor requested elevator & going up
                else if (elevator.currentFloor > reqFloor & elevator.currentDirection == "up" & reqDirection == "down")
                {
                    if (bestScore > 4)
                    {
                        bestElevator = elevator;
                        bestScore = 4;
                    }
                    else if (bestScore == 4)
                    {
                        int bestElevatorGap = Math.Abs(bestElevator.currentFloor - reqFloor);
                        int newElevatorGap = Math.Abs(elevator.currentFloor - reqFloor);

                        if (newElevatorGap < bestElevatorGap)
                        {
                            bestElevator = elevator;
                        }
                    }
                }
                // If elevator is below floor requested & going up

                // If elevator is below floor requested elevator & going down
                else if (elevator.currentFloor < reqFloor & elevator.currentDirection == "up" & reqDirection == "up")
                {
                    if (bestScore > 1)
                    {
                        bestElevator = elevator;
                        bestScore = 1;
                    }
                    else if (bestScore == 1)
                    {
                        int bestElevatorGap = Math.Abs(bestElevator.currentFloor - reqFloor);
                        int newElevatorGap = Math.Abs(elevator.currentFloor - reqFloor);

                        if (newElevatorGap < bestElevatorGap)
                        {
                            bestElevator = elevator;
                        }
                    }
                }
            }
            Console.WriteLine("___________________________________________________");
            return bestElevator;
        }
    }

    public class Elevator
    {
        // Elevator attributes
        public string elev_Id;
        public int currentFloor = 1;
        public string currentDirection = "idle";
        public int score;

        // Elevator constructor
        public Elevator(string elev_Id)
        {
            this.elev_Id = elev_Id;
        }

        // Elevator methods
        // Make the elevator go pick up the user after finding the bestElevator
        public void operateElevator(int reqFloor)
        {
            if (this.currentFloor < 0)
            {
                while (this.currentFloor != 0)
                {
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    this.currentFloor++;
                }
            }
            else
            {
                if (reqFloor > this.currentFloor)
                {
                    while (this.currentFloor != 0)
                    {
                        System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                        this.currentFloor--;
                    }
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                    // Sequence when elevator has arrived to pick up the user
                    System.Console.WriteLine("Doors opened." + "\n" + "Doors closed.");

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

                // Sequence when elevator has arrived to pick up the user
                System.Console.WriteLine("Doors opened." + "\n" + "Doors closed." + "\n" + "Going back to lobby.");

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
                    while (this.currentFloor > 0)
                    {
                        System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                        this.currentFloor--;
                    }
                    System.Console.WriteLine("I am " + this.elev_Id + " and I'm on floor " + this.currentFloor);
                }
            }
        }
    }
}
