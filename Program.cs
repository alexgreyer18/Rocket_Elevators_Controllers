using System;
using System.Collections;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
    public class Battery
    {
        public int numColumns;

        public List<Column> columns;

        public Battery(int numColumns, int numElevators)
        {
            this.numColumns = numColumns;

            columns = new List<Column>();
            for (int i = 0; i < numColumns; i++)
            {
                Column column = new Column(i + 1, 66, numElevators);
                columns.Add(column);
                Console.WriteLine("column" + columns[i].col_Id + "\n");
            }
        }
    }

    public class Column
    {
        public int col_Id;
        public int numElevators;
        public int numFloor;

        public List<Elevator> elevators;

        public Column(int col_Id, int numFloor, int numElevators)
        {
            this.col_Id = col_Id;
            this.numElevators = numElevators;
            this.numFloor = numFloor;

            elevators = new List<Elevator>();

            for (int i = 0; i < numElevators; i++)
            {
                Elevator elevator = new Elevator(i + 1, 1);
                elevators.Add(elevator);

                Console.WriteLine("elevator" + elevators[i].elev_Id + " on floor : " + elevators[i].currentFloor);

                // if (i <= 5)
                // {
                //     elevators.Add(new Elevator("B-Elevator" + i), 1);
                // }
                // else if (i > 5 & i <= 10)
                // {
                //     elevators.Add(new Elevator("C2-Elevator" + i), 1);
                // }
                // else if (i > 10 & i <= 15)
                // {
                //     elevators.Add(new Elevator("C3-Elevator" + i), 1);
                // }
                // else if (i > 15 & i <= 20)
                // {
                //     elevators.Add(new Elevator("C4-Elevator" + i), 1);
                // }
            }
        }

    }

    public class Elevator
    {
        public int elev_Id;
        public int currentFloor = 1;
        public string currentDirection = "idle";

        public Elevator(int elev_Id, int currentFloor)
        {
            this.elev_Id = elev_Id;
            this.currentFloor = currentFloor;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var totalFloors = 66;
            int[] floorList = new int[totalFloors];
            for (int i = 0; i < totalFloors; i++)
            {
                floorList[i] = i + 1;
                // Console.WriteLine("Floor id : " + floorList[i]);
            }
            var battery = new Battery(4, 5);
            // Console.WriteLine(battery);
            // Battery.findColumn().findElevator();

            // List<Elevator> ElevatorList = new List<Elevator>();

            // int numColumns = 4;
            // int numElevators = (numColumns * 5) + 1;

            // for (int i = 1; i < numElevators; i++)
            // {
            //     if (i <= 5)
            //     {
            //         ElevatorList.Add(new Elevator("B-Elevator" + i));
            //     }
            //     else if (i > 5 & i <= 10)
            //     {
            //         ElevatorList.Add(new Elevator("C2-Elevator" + i));
            //     }
            //     else if (i > 10 & i <= 15)
            //     {
            //         ElevatorList.Add(new Elevator("C3-Elevator" + i));
            //     }
            //     else if (i > 15 & i <= 20)
            //     {
            //         ElevatorList.Add(new Elevator("C4-Elevator" + i));
            //     }
            // }
            // Console.WriteLine("----- All elevators status -----");

            // foreach (var elevator in ElevatorList)
            // {
            //     Console.WriteLine("Elevator: {0},{1},{2}", elevator.ElevatorId, elevator.CurrentFloor, elevator.CurrentDirection);
            // }
            // Console.WriteLine("------- /All elevators status -------");

            // int[] numfloor = new int[66];
            // for (int i = 1; i < numfloor.Length; i++)
            // {
            //     numfloor[i - 1] = i;
            //     // Console.WriteLine(numfloor[i-1]);
            // }

            // int[] numColumn = new int[4];
            // for (int i = 0; i < numColumn.Length; i++)
            // {
            //     numColumn[i] = i;
            //     Console.WriteLine(numColumn[i]);
            // }

            // Console.WriteLine(numfloor.Length);
        }
    }
}
