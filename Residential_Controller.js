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
			if (elevator.currentDirection == 'idle') {
				console.log(elevator.elevatorId + ' is Idle');
				return elevator;
			}

			if (requestedFloor === elevator.currentFloor) {
				//The elevator is in the same floor of the client
				console.log('Same floor');
				return elevator;
			} else {
				//The elevator is in a diferent floor from the client

				if (requestedFloor > elevator.currentFloor) {
					//To check if the client is above floor the elevator
					console.log('Client above');

					if (
						requestDirection === 'down' &&
						elevator.currentDirection === 'down'
					) {
						//This elevator is above the client and going down so its a match
						console.log('Direction match down');
						return elevator;
					}
				} else {
					//The client is below the elevator
					console.log('Client below');

					if (
						requestDirection === 'up' &&
						elevator.currentDirection === 'up'
					) {
						//This elevator is below the client and going up so its a match
						console.log('Direction match up');
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
		bestElevator.currentDirection = direction;
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
// var bestElevator = column.findElevator();
//bestElevator.move();
column.requestElevator(3, 'down');
console.log(column.elevatorList);
