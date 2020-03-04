package main

import (
	"fmt"
	"math"
	"sort"
	"strconv"
)

// STRUCTURES
type battery struct {
	columns        	  []column
	numColumns		  int
	floorNumbersTotal int
}
type column struct {
	colID         	string
	numElevators 	int
	numFloor 		int
	servicedFloors  []int
	numCagesPerCol  []string
	elevatorScores  []elevator
}

type elevator struct {
	elevID      		  string
	currentFloor 		  int
	currentDirection 	  string
	score       		  int
}

// Battery Constructor
func Battery(numColumns, numElevators int) *battery {
	b.numColumns = numColumns

  columns := []column {column[0], column[1], column[2], column[3]}

  // Initializing columns list with unique ID
  for i := 0; i <= numColumns; i++ {
	if i == 0 {
		col := column{
			colID:       	"B1_column",
			numElevators: 	numElevators,
			numFloor:		66,
		}
		columns.append(column)
	} else if i == 1 {
		col := column{
			colID:       	"C2_column",
			numElevators: 	numElevators,
			numFloor:		66,
		}
		columns.append(column)
    } else if i == 2 {
		col := column{
			colID:       	"C3_column",
			numElevators: 	numElevators,
			numFloor:		66,
		}
		columns.append(column)
    } else if i == 3 {
		col := column{
			colID:       	"C4_column",
			numElevators: 	numElevators,
			numFloor:		66,
		}
		columns.append(column)
    }
  }
}

// Column Constructor
func Column(colID string, numFloor int, numElevators int){
  this.colID = col_ID
  this.numElevators = numElevators
  this.numFloor = numFloor

  elevators := [5]elevator {elevator[0], elevator[1], elevator[2], elevator[3], elevator[4]}

   for i := 0; i <= numElevators; i++ {
	if i == 0 {
		elev := elevator{
			elevID:       	"Elevator" + (i+1),
		}
		elevators.append(elevator)
	} 
  }
}

// Elevator Constructor
func Elevator(elevID string) {
  this.elevID = elevID
}


func (b *battery) requestElevator(reqFloor int, reqDirection string) {
	fmt.Println("___________________________________________________")
  	fmt.Println(floorNumber, "is calling")
  	ReqFloor := reqFloor
  	var elevator bestColumn

  // Choosing bestColumn based on reqFloor
  for column := range columns {
    if ReqFloor == 0 {
      fmt.Println("You are on selected floor level. Please select another floor.")
	} else if ReqFloor < 0 {
      bestColumn = columns[0]
    } else if ReqFloor > 0 && ReqFloor <= 20 {
      bestColumn = columns[1]
    } else if ReqFloor >= 21 && ReqFloor <= 40 {
      bestColumn = columns[2]
    } else if ReqFloor >= 41 && ReqFloor <= 60 {
      bestColumn = columns[3]
    }
  }
  fmt.Println(bestColumn.colID, "was selected.")
  bestColumn.findElevator(reqFloor, reqDirection)
  return elevator
} 

func (b *battery) assignElevator(reqFloor int, direction string) {
	fmt.Println("___________________________________________________")
  	fmt.Println("floor " + reqFloor + " was requested")
  	ReqFloor := reqFloor
  	var elevator bestColumn
  for column := range columns {
    if ReqFloor == 0 {
      fmt.Println("You are on selected floor level. Please select another floor.")
	} else if ReqFloor < 0 {
      bestColumn = columns[0]
    } else if ReqFloor > 0 & ReqFloor <= 20 {
      bestColumn = columns[1]
    } else if ReqFloor >= 21 & ReqFloor <= 40 {
      bestColumn = columns[2]
    } else if ReqFloor >= 41 & ReqFloor <= 60 {
      bestColumn = columns[3]
    }
  }
  fmt.Println(bestColumn.colID, "was selected.")
  bestColumn.findElevator(0, direction)
  return elevator
}

//                                          *****FIND ELEVATOR*****
func (bestCol *column) findElevator(reqFloor int, reqDirection string) *elevator {
  bestScore := 999
  bestElevator := this.elevators[0]
  for elevator,_ = range this.elevatorList {
    // If floors are the same
    if elevator.currentFloor == reqFloor && reqDirection == elevator.currentDirection {
      // elevator gets set as bestElevator by default since 999 is much higher than any score
      if bestScore > 1 {
        bestElevator = elevator
        bestScore = 1
      } else if bestScore == 1 { // If more than 2 elevators can service the request, determine which is closest
          bestElevatorGap := Math.Abs(bestElevator.currentFloor - reqFloor)
          newElevatorGap := Math.Abs(elevator.currentFloor - reqFloor)

          if newElevatorGap < bestElevatorGap {
            bestElevator = elevator
          }
      } else if elevator.currentFloor > reqFloor && elevator.currentDirection == "down" && reqDirection == "up" {
          if bestScore > 2 {
            bestElevator = elevator
            bestScore = 2
          } else if bestScore == 2 {
              bestElevatorGap := Math.Abs(bestElevator.currentFloor - reqFloor)
              newElevatorGap := Math.Abs(elevator.currentFloor - reqFloor)

              if newElevatorGap < bestElevatorGap {
                bestElevator = elevator
              }
            }
      } else if elevator.currentFloor > reqFloor && elevator.currentDirection == "down" && reqDirection == "down" {
          if bestScore > 3 {
            bestElevator = elevator
            bestScore = 3
          } else if bestScore == 3 {
            bestElevatorGap := Math.Abs(bestElevator.currentFloor - reqFloor)
            newElevatorGap := Math.Abs(elevator.currentFloor - reqFloor)

            if newElevatorGap < bestElevatorGap {
              bestElevator = elevator
            }
          }
      } else if elevator.currentFloor > reqFloor && elevator.currentDirection == "up" && reqDirection == "down" {
          if bestScore > 4 {
            bestElevator = elevator
            bestScore = 4
          } else if bestScore == 4 {
            bestElevatorGap := Math.Abs(bestElevator.currentFloor - reqFloor)
            newElevatorGap := Math.Abs(elevator.currentFloor - reqFloor)

            if newElevatorGap < bestElevatorGap {
              bestElevator = elevator
            }
          }
      } else if elevator.currentFloor < reqFloor && elevator.currentDirection == "up" && reqDirection == "up" {
        if bestScore > 1 {
          bestElevator = elevator
          bestScore = 1
        } else if bestScore == 1 {
          bestElevatorGap := Math.Abs(bestElevator.currentFloor - reqFloor)
          newElevatorGap := Math.Abs(elevator.currentFloor - reqFloor)

          if newElevatorGap < bestElevatorGap {
            bestElevator = elevator
          }
      }
    }
  fmt.Println("___________________________________________________")
  return bestElevator
  }
}

func (bestElevator *elevator) operateElevator(reqFloor) {
  if this.currentFloor < 0 {
    for this.currentFloor != 0 {
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
      this.currentFloor++
    }
    fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
    fmt.Println("Doors open. \nDoors closed.")
  } else {
    if reqFloor > this.currentFloor {
      for this.currentFloor != 0 {
        fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
        this.currentFloor--
      }
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
      // Sequence when elevator has arrived to pick up the user
      fmt.Println("Doors open. \nDoors closed.")

      for reqFloor != this.currentFloor {
          fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
          this.currentFloor++
      }
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
  } else {
    for reqFloor != this.currentFloor {
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
      this.currentFloor--
    }
    fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
  }
  // Sequence when elevator has arrived to pick up the user
  fmt.Println("Doors opened." + "\n" + "Doors closed." + "\n" + "Going back to lobby.")

  // Go back to floor 0 after picking up user
  if this.currentFloor < 0 {
    for this.currentFloor != 0 {
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
      this.currentFloor++
    }
    fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
  } else {
    for (this.currentFloor > 0) {
      fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
      this.currentFloor--
    }
    fmt.Println("I am", this.elevID, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
  }
}

  // fmt.Println(floorNumber, "is calling")
	// fmt.Println(bestElev.name, "was selected.")
  
  // fmt.Println("__________________________________\n")
  //  //-----------
	// for bestElev.currentFloor < floorNumber {
	// 	bestElev.direction = "up"
	// 	bestElev.currentFloor++
	// 	fmt.Println("I am", bestElev.name, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
	// }
	// for bestElev.currentFloor > floorNumber {
	// 	bestElev.direction = "down"
	// 	bestElev.currentFloor--
	// 	fmt.Println("I am", bestElev.name, "and I'm on floor", strconv.Itoa(bestElev.currentFloor))
	// }
	// fmt.Println("Doors open. \nDoors closed.")
	// bestElev.direction = "idle"


func main() {
	// Initialize battery
	battery := Battery(4, 5)

	// Test 1 --- Someone at 1st floor requests the 20th floor; Elevator5 (B5) is expected to be sent.
	// Unfold scenario settings & description

	{
		// With second column (or column B) serving floors from 2 to 20, with elevator B1 at 20th 
		// floor going to 5th, B2 at 3rd floor going to 15th, B3 at 13th floor going to 1st, B4 at 15th floor 
		// going to 2nd, and B5 at 6th floor going to 1st, someone is at 1st floor and requests the 20th floor, 
		// Elevator5 (B5) is expected to be sent

		fmt.Println("__________________Elevator Status'_________________")
		Battery.columns[1].elevators[0].currentFloor = 20
		Battery.columns[1].elevators[0].currentDirection = "down"
		fmt.Println(Battery.columns[1].elevators[0].elevID + " on floor " + Battery.columns[1].elevators[0].currentFloor + " going " + Battery.columns[1].elevators[0].currentDirection)

		Battery.columns[1].elevators[1].currentFloor = 3
		Battery.columns[1].elevators[1].currentDirection = "up"
		fmt.Println(Battery.columns[1].elevators[1].elevID + " on floor " + Battery.columns[1].elevators[1].currentFloor + " going " + Battery.columns[1].elevators[1].currentDirection)

		Battery.columns[1].elevators[2].currentFloor = 13
		Battery.columns[1].elevators[2].currentDirection = "down"
		fmt.Println(Battery.columns[1].elevators[2].elevID + " on floor " + Battery.columns[1].elevators[2].currentFloor + " going " + Battery.columns[1].elevators[2].currentDirection)

		Battery.columns[1].elevators[3].currentFloor = 15
		Battery.columns[1].elevators[3].currentDirection = "down"
		fmt.Println(Battery.columns[1].elevators[3].elevID + " on floor " + Battery.columns[1].elevators[3].currentFloor + " going " + Battery.columns[1].elevators[3].currentDirection)

		Battery.columns[1].elevators[4].currentFloor = 6
		Battery.columns[1].elevators[4].currentDirection = "down"
		fmt.Println(Battery.columns[1].elevators[4].elevID + " on floor " + Battery.columns[1].elevators[4].currentFloor + " going " + Battery.columns[1].elevators[4].currentDirection)
	}
	Battery.assignElevator(20, "up").operateElevator(20)


	// Test 2 --- Someone at 1st floor requests the 36th floor; Elevator1 (C1) is expected to be sent.
	// Unfold scenario settings & description

	{
		// With third column (or column C) serving floors from 21 to 40, with elevator C1 at 1st 
		// floor going to 21th, C2 at 23st floor going to 28th, C3 at 33rd floor going to 1st, C4 at 40th floor
		// going to 24th, and C5 at 39nd floor going to 1st, someone is at 1st floor and requests the 36th floor,
		// Elevator1 (C1) is expected to be sent

		// Battery.columns[2].elevators[0].currentFloor = 0
		// Battery.columns[2].elevators[0].currentDirection = "up"
		// fmt.Println(Battery.columns[2].elevators[0].elevID + " on floor " + Battery.columns[2].elevators[0].currentFloor + " going " + Battery.columns[2].elevators[0].currentDirection)

		// Battery.columns[2].elevators[1].currentFloor = 23
		// Battery.columns[2].elevators[1].currentDirection = "up"
		// fmt.Println(Battery.columns[2].elevators[1].elevID + " on floor " + Battery.columns[2].elevators[1].currentFloor + " going " + Battery.columns[2].elevators[1].currentDirection)

		// Battery.columns[2].elevators[2].currentFloor = 33
		// Battery.columns[2].elevators[2].currentDirection = "down"
		// fmt.Println(Battery.columns[2].elevators[2].elevID + " on floor " + Battery.columns[2].elevators[2].currentFloor + " going " + Battery.columns[2].elevators[2].currentDirection)

		// Battery.columns[2].elevators[3].currentFloor = 40
		// Battery.columns[2].elevators[3].currentDirection = "down"
		// fmt.Println(Battery.columns[2].elevators[3].elevID + " on floor " + Battery.columns[2].elevators[3].currentFloor + " going " + Battery.columns[2].elevators[3].currentDirection)

		// Battery.columns[2].elevators[4].currentFloor = 39
		// Battery.columns[2].elevators[4].currentDirection = "down"
		// fmt.Println(Battery.columns[2].elevators[4].elevID + " on floor " + Battery.columns[2].elevators[4].currentFloor + " going " + Battery.columns[2].elevators[4].currentDirection)
	}
	// Battery.assignElevator(36, "up").operateElevator(36)


	// Test 3 --- Someone at 54th floor requests the 1st floor; Elevator1 (D1) is expected to be sent.
	// Unfold scenario settings & description

	{
		// With fourth column (or column D) serving floors from 41 to 60, with elevator D1 at 58th floor  
		// going to 1st, D2 at 50th floor going to 60th, D3 at 46th floor going to 58th, D4 at 1st floor going 
		// to 54th, and D5 at 60th floor going to 1st, someone is at 54th floor and requests the 1st floor, 
		// Elevator1 (D1) is expected to pick him up

		// Battery.columns[3].elevators[0].currentFloor = 58
		// Battery.columns[3].elevators[0].currentDirection = "down"
		// fmt.Println(Battery.columns[3].elevators[0].elevID + " on floor " + Battery.columns[3].elevators[0].currentFloor + " going " + Battery.columns[3].elevators[0].currentDirection)

		// Battery.columns[3].elevators[1].currentFloor = 50
		// Battery.columns[3].elevators[1].currentDirection = "up"
		// fmt.Println(Battery.columns[3].elevators[1].elevID + " on floor " + Battery.columns[3].elevators[1].currentFloor + " going " + Battery.columns[3].elevators[1].currentDirection)

		// Battery.columns[3].elevators[2].currentFloor = 46
		// Battery.columns[3].elevators[2].currentDirection = "up"

		// Battery.columns[3].elevators[3].currentFloor = 0
		// Battery.columns[3].elevators[3].currentDirection = "up"
		// fmt.Println(Battery.columns[3].elevators[3].elevID + " on floor " + Battery.columns[3].elevators[3].currentFloor + " going " + Battery.columns[3].elevators[3].currentDirection)

		// Battery.columns[3].elevators[4].currentFloor = 60
		// Battery.columns[3].elevators[4].currentDirection = "down"
		// fmt.Println(Battery.columns[3].elevators[4].elevID + " on floor " + Battery.columns[3].elevators[4].currentFloor + " going " + Battery.columns[3].elevators[4].currentDirection)
	}
	// battery.requestElevator(54, "down").operateElevator(54)


	// Test 4 --- Someone at 1st floor requests the 36th floor; Elevator1 (C1) is expected to be sent.
	// Unfold scenario settings & description

	{
		// With first column (or Column A) serving the basements B1 to B6, with elevator A1 idle at B4, A2 
		// idle at 1st floor, A3 at B3 and going to B5, A4 at B6 and going to 1st floor, and A5 at B1 going to
		// B6, someone is at B3 and requests the 1st floor. Elevator A4 is expected to be sent.
		// Elevator4 (A4) is expected to be sent.

		// Battery.columns[0].elevators[0].currentFloor = -4
		// Battery.columns[0].elevators[0].currentDirection = "idle"
		// fmt.Println(Battery.columns[0].elevators[0].elevID + " on floor " + Battery.columns[0].elevators[0].currentFloor + " going " + Battery.columns[0].elevators[0].currentDirection)

		// Battery.columns[0].elevators[1].currentFloor = 0
		// Battery.columns[0].elevators[1].currentDirection = "idle"
		// fmt.Println(Battery.columns[0].elevators[1].elevID + " on floor " + Battery.columns[0].elevators[1].currentFloor + " going " + Battery.columns[0].elevators[1].currentDirection)

		// Battery.columns[0].elevators[2].currentFloor = -3
		// Battery.columns[0].elevators[2].currentDirection = "down"
		// fmt.Println(Battery.columns[0].elevators[2].elevID + " on floor " + Battery.columns[0].elevators[2].currentFloor + " going " + Battery.columns[0].elevators[2].currentDirection)

		// Battery.columns[0].elevators[3].currentFloor = -6
		// Battery.columns[0].elevators[3].currentDirection = "up"
		// fmt.Println(Battery.columns[0].elevators[3].elevID + " on floor " + Battery.columns[0].elevators[3].currentFloor + " going " + Battery.columns[0].elevators[3].currentDirection)

		// Battery.columns[0].elevators[4].currentFloor = -1
		// Battery.columns[0].elevators[4].currentDirection = "down"
		// fmt.Println(Battery.columns[0].elevators[4].elevID + " on floor " + Battery.columns[0].elevators[4].currentFloor + " going " + Battery.columns[0].elevators[4].currentDirection)
	}
	// battery.requestElevator(-3, "up").operateElevator(-3)
}
