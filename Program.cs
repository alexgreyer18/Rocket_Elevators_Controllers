using System;
using System.Collections;
using System.Collections.Generic;

namespace Rocket_Elevators_Controllers
{
    public class Battery
    {
        public int numColumns;

        public List<Column> columns;
        public static int[] servFloors1 = new int[7] { -6, -5, -4, -3, -2, -1, 0 };
        public static int[] servFloors2 = new int[20] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static int[] servFloors3 = new int[21] { 0, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
        public static int[] servFloors4 = new int[21] { 0, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };

        List<int[]> servFloorsList = new List<int[]> { servFloors1, servFloors2, servFloors3, servFloors4 };

        public Battery(int numColumns, int numElevators)
        {
            this.numColumns = numColumns;

            columns = new List<Column>();

            for (int i = 0; i < numColumns; i++)
            {
                if (i == 0)
                {
                    Column column = new Column("B1_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 1)
                {
                    Column column = new Column("C2_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 2)
                {
                    Column column = new Column("C3_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }
                else if (i == 3)
                {
                    Column column = new Column("C4_column", 66, numElevators, servFloorsList[i]);
                    columns.Add(column);
                }

                Console.WriteLine("{0},{1}", columns[i].col_Id, " servicing floors : " + String.Join(", ", columns[i].servicedFloors));
                Console.WriteLine("____________________________________________________");
                // foreach (var item in servFloors1)
                // {
                //     Console.WriteLine(item.ToString());
                // }

            }
            // foreach (var item in columns)
            // {
            //     System.Console.WriteLine(item.col_Id);
            // }
        }
        //public Column
        public void findColumn(int reqFloor)
        {
            System.Console.WriteLine("floor " + reqFloor + " was requested");
            int ReqFloor = reqFloor;
            foreach (var column in columns)
            {
                // System.Console.WriteLine(columns[1].col_Id + "hello ma honey");
                if (ReqFloor == 0)
                {
                    Column BestColumn = column;
                    // return BestColumn;
                    System.Console.WriteLine("Lobby requested");
                }
                else if (ReqFloor < 0)
                {
                    System.Console.WriteLine(columns[0].col_Id + " was selected");
                    System.Console.WriteLine("basements was selected");
                }
                else if (ReqFloor > 0 & ReqFloor <= 20)
                {
                    System.Console.WriteLine(columns[1].col_Id + " was selected");
                    System.Console.WriteLine("col1 was selected");
                }
                else if (ReqFloor >= 21 & ReqFloor <= 40)
                {
                    System.Console.WriteLine(columns[2].col_Id + " was selected");
                    System.Console.WriteLine("col2 was selected");
                }
                else if (ReqFloor >= 41 & ReqFloor <= 60)
                {
                    System.Console.WriteLine(columns[3].col_Id + " was selected");
                }
            }

            // foreach (var item in columns)
            // {
            //     System.Console.WriteLine(item.col_Id);
            // }
        }
    }


    public class Column
    {
        public string col_Id;
        public int numElevators;
        public int numFloor;
        public int[] servicedFloors;
        public List<Elevator> elevators;

        public Column(string col_Id, int numFloor, int numElevators, int[] servicedFloors)
        {
            this.col_Id = col_Id;
            this.numElevators = numElevators;
            this.numFloor = numFloor;
            this.servicedFloors = servicedFloors;
            // Console.WriteLine("----------------------------");
            // Console.WriteLine(servicedFloors[1]);
            // Console.WriteLine("----------------------------");

            elevators = new List<Elevator>();

            for (int i = 0; i < numElevators; i++)
            {
                Elevator elevator = new Elevator("Elevator" + (i + 1));
                elevators.Add(elevator);
                Console.WriteLine("{0},{1},{2}", elevator.elev_Id, " on floor" + elevator.currentFloor, " " + elevator.currentDirection);
            }
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            var battery = new Battery(4, 5);
            // Console.WriteLine(battery);
            battery.findColumn(45);
        }

        public static void findColumn()
        {
            Console.WriteLine("Hello");
        }
    }
}








// var totalFloors = 66;
// int[] floorList = new int[totalFloors];
// for (int i = 0; i < totalFloors; i++)
// {
//     floorList[i] = i + 1;
//     // Console.WriteLine("Floor id : " + floorList[i]);
// }
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