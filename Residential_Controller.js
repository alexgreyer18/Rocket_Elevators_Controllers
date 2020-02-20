/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/

class Column {
	constructor(nbFloor, nbElevator) {
		this.floorList = [];
		for (let i = 1; i <= nbFloor; i++) {
			this.floorList.push([ i ]);
		}

		this.elevatorList = [];
		for (let i = 0; i < nbElevator; i++) {
			this.elevatorList.push(new Elevator('elevator' + i, 10));
		}

		this.buttonList = [];
		for (let i = 1; i <= nbFloor; i++) {
			if (i != 1) {
				var callButton = new Button('down', i);
				this.buttonList.push(callButton);
			}
			if (i != nbFloor) {
				var callButton = new Button('up', i);
				this.buttonList.push(callButton);
			}
		}
	}

	findElevator(requestedFloor, requestDirection) {
		column.elevatorList.forEach((elevator) => {
			if(elevator.currentDirection == 'idle'){
			  //console.log(elevator.elevatorId + ' is Idle');
			  return elevator;
			}

			if (requestedFloor === elevator.currentFloor) {
				//The elevator is in the same floor of the user
				console.log('Same floor as user');
				return elevator;
			} else {
				//The elevator is in a diferent floor from the user
				if (requestedFloor > elevator.currentFloor) {
					//To check if the user is above the elevator
					console.log('User is above ' + elevator.elevatorId);

					if (
						requestDirection === 'down' &&
						elevator.currentDirection === 'down'
					) {
						//This elevator is above the user and going down so its a match
						console.log('Direction match down');
						return elevator;
					}
				} else {
					//The user is below the elevator
					console.log('User is below ' + elevator.elevatorId);

					if (
						requestDirection === 'up' &&
						elevator.currentDirection === 'up'
					) {
						//This elevator is below the user and going up so its a match
						console.log('Direction match up');
						return elevator;
					} 
          else if(requestDirection === 'down' && elevator.currentDirection === 'down') {
            return elevator;
          }
				}
			}
		});

		let BestElevator = null;
		column.elevatorList.forEach((elevator) => {
			if (BestElevator == null) {
				//If the comparison point has not been set yet
				BestElevator = elevator;
			} else {
				if (
					BestElevator.requestList.length >
					elevator.requestList.length
				) {
					BestElevator = elevator;
				}
			}
		});
		return BestElevator;
	}

	requestElevator(requestedFloor, direction) {
		let bestElevator = column.findElevator(requestedFloor, direction);
		bestElevator.requestList.push(requestedFloor);
		bestElevator.requestList.sort();
		//bestElevator.currentDirection = this.currentDirection;
    console.log( bestElevator.elevatorId + " IS ON FLOOR " + bestElevator.currentFloor );
    if(bestElevator.requestList[0] > bestElevator.currentFloor ){
      
      bestElevator.currentDirection = 'up'
      
      if(bestElevator.requestList !== null){
        
        if(bestElevator.requestList > bestElevator.currentFloor){
          
          bestElevator.currentFloor = bestElevator.currentFloor + 1
          console.log(bestElevator.elevatorId + " IS ON FLOOR " + bestElevator.currentFloor);
        }       
      }
    } else{
      bestElevator.currentDirection = 'down'
      bestElevator.currentFloor = bestElevator.currentFloor - 1
    }
	}
}

// Elevator constructor
class Elevator {
	constructor(elevatorId, nbFloor) {
		this.elevatorId = elevatorId;
		this.floorRequestButtons = [];
		for (let i = 1; i <= nbFloor; i++) {
			this.floorRequestButtons.push(i);
		}
		this.currentFloor = 1;
		this.currentDirection = 'idle';
		this.requestList = [];
		this.doors = 'closed';
	}
    requestFloor(bestElevator, RequestedFloor){
      //let bestElevator = column.findElevator(requestedFloor, direction));
      console.log(column.findElevator(4, 'up'));
    }
	// moveElevator(direction, floor){
	//   move numOfIndexDifference[i];
	//   bestElevator.requestList.pop(elevator.currentFloor);
	// }
}

// Button constructor
class Button {
	constructor(requestedDir, floor) {
		this.floor = floor;
		this.requestedDir = requestedDir;
		this.lightStatus = 'Off';
	}
}

//SECTION TESTS
var column = new Column(10, 2);

//bestElevator.move();

//SCENARIO 1 --- elevator 0 Idle at floor 2 and elevator 1  Idle at floor 6, someone on floor 3 requests up, elevator 0 is expected to be sent.
//Someone else on 3 requests down. Elevator 1 should be sent.

column.elevatorList[0].currentFloor = 2;
column.elevatorList[0].currentDirection = 'idle';
column.elevatorList[1].currentFloor = 6;
column.elevatorList[1].currentDirection = 'idle';

column.requestElevator(5, 'up');
column.requestElevator(4, 'up');
// // column.requestElevator(3, 'down'); leave uncommented for no errors
console.log(column.elevatorList);

//SCENARIO 2 --- elevator 0 idle at floor 10 and elevator 1 at floor 3 going up, someone is on floor 3 and requests the 2nd floor. Elevator 0 should be sent.
//Someone on the 10th floor wants to go down. Elevator 1 should be sent.

// column.elevatorList[0].currentFloor = 10;
// column.elevatorList[0].currentDirection = 'idle';
// column.elevatorList[1].currentFloor = 3;
// column.elevatorList[1].currentDirection = 'idle';

// column.requestElevator(3, 'down');
// column.requestElevator(10, 'down');
// console.log(column.elevatorList);

//SCENARIO 3 --- elevator 0 Idle at floor 2 and elevator 1 Idle at floor 6, someone on floor 3 requests up, elevator 0 is expected to be sent.
//Someone on floor 4 requests down.

// column.elevatorList[0].currentFloor = 2;
// column.elevatorList[0].currentDirection = 'idle';
// column.elevatorList[1].currentFloor = 6;
// column.elevatorList[1].currentDirection = 'idle';

// column.requestElevator(3, 'up');
// column.requestElevator(5, 'down');
// column.requestElevator(4, 'down');
// console.log(column.elevatorList);
