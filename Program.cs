using System;
using System.Collections;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
    public class Battery
    {
        public int numColumns;

        public List<Column> columns;
            int[] servFloors1 = new int[]{-6, -5, -4, -3, -2, -1, 0};
            int[] servFloors2 = new int[5]{0, 2, 3, 4, 5};
            // servFloors2[0] = 0;
            // servFloors2[1] = 2;
            // servFloors2[2] = 3;
            // servFloors2[3] = 4;
            // servFloors2[4] = 5;
            int[] servFloors3 = new int[]{0, 2, 3, 4, 5};
            int[] servFloors4 = new int[]{0, 2, 3, 4, 5};
        public Battery(int numColumns, int numElevators)
        {
            this.numColumns = numColumns;

            columns = new List<Column>();
            for (int i = 0; i < numColumns; i++)
            {
                Column column = new Column(i + 1, 66, numElevators, servFloors2);
                columns.Add(column);
                Console.WriteLine("column" + columns[i].col_Id + " servicing floors : " +  columns[i].servicedFloors + "\n");
            }
        }
    }

    public class Column
    {
        public int col_Id;
        public int numElevators;
        public int numFloor;
        public int[] servicedFloors;
        public List<Elevator> elevators;

        public Column(int col_Id, int numFloor, int numElevators, int[] servicedFloors)
        {
            this.col_Id = col_Id;
            this.numElevators = numElevators;
            this.numFloor = numFloor;
            this.servicedFloors = servicedFloors;

            elevators = new List<Elevator>();
            
            for (int i = 0; i < numElevators; i++)
            {
                Elevator elevator = new Elevator(i + 1);
                elevators.Add(elevator);
                Console.WriteLine("Elevator{0},{1},{2}", elevator.elev_Id, " on floor" + elevator.currentFloor, " " +  elevator.currentDirection);

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

        public Elevator(int elev_Id)
        {
            this.elev_Id = elev_Id;
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
