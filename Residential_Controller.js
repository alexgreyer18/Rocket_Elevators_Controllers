// This program controls a set of residential elevators.
// Uncomment scenarios at the bottom of the page for testing purposes.
// The requestFloor method should have been in the Elevator class but I ran out of time to figure out how to move it there from the Column class, as I had had trouble trying earlier.

// Column class constructor
class Column {
	constructor(nbFloor, nbElevator) {
		this.floorList = [];
		// start elevator list at 1 if there's no basements
		for (let i = 1; i <= nbFloor; i++) {
			this.floorList.push([i]);
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
		let BestElevator = null;
		column.elevatorList.forEach((elevator) => {
			if (elevator.currentFloor == requestedFloor) {
				BestElevator = elevator;
			} else if (elevator.currentFloor > requestedFloor) {
				if (
					requestDirection === 'down' &&
					elevator.currentDirection === 'down'
				) {
					BestElevator = elevator;
				} else {
					BestElevator = elevator;
				}
			} else if (elevator.currentFloor < requestedFloor) {
				if (
					requestDirection === 'up' &&
					elevator.currentDirection === 'up'
				) {
					BestElevator = elevator;
				} else {
					BestElevator = elevator;
				}
			}
		});
		return BestElevator;
	}

	requestElevator(requestedFloor, requestDirection) {
		let bestElevator = column.findElevator(requestedFloor, requestDirection
		);
		bestElevator.requestList.push(requestedFloor);
		bestElevator.requestList.sort();
		console.log(
			bestElevator.elevatorId +
			' IS ON FLOOR ' +
			bestElevator.currentFloor
		);
		if (bestElevator.requestList[0] > bestElevator.currentFloor) {
			bestElevator.currentDirection = 'up';

			if (bestElevator.requestList !== null) {
				while (bestElevator.requestList > bestElevator.currentFloor) {
					bestElevator.currentFloor = bestElevator.currentFloor + 1;
					console.log(
						bestElevator.elevatorId +
						' IS ON FLOOR ' +
						bestElevator.currentFloor
					);

					if (bestElevator.currentFloor == bestElevator.requestList) {
						for (let timer = 8; timer >= 0; timer--) {
							if (timer == 0 || timer == 8) {
								bestElevator.doors = 'Doors are closed';
								console.log(bestElevator.doors);
							} else {
								console.log(
									'Doors open - ' +
									timer +
									's until doors close'
								);
							}
						}
					}
				}
				console.log('Request popped');
				bestElevator.requestList.pop();
			}
		} else {
			bestElevator.currentDirection = 'down';
			while (bestElevator.requestList < bestElevator.currentFloor) {
				bestElevator.currentFloor = bestElevator.currentFloor - 1;
				console.log(
					bestElevator.elevatorId +
					' IS ON FLOOR ' +
					bestElevator.currentFloor
				);
				if (bestElevator.currentFloor == bestElevator.requestList) {
					for (let timer = 8; timer >= 0; timer--) {
						if (timer == 0 || timer == 8) {
							bestElevator.doors = 'Doors are closed';
							console.log(bestElevator.doors);
						} else {
							console.log(
								'Doors open - ' + timer + 's until doors close'
							);
						}
					}
				}
			}
			bestElevator.requestList.pop();
		}
		console.log('----  Just a poorly made breakline  ----');
		//bestElevator.requestList.pop();  //this pop breaks everything
	}

	requestFloor(requestedFloor) {
		let elevatorList = column.elevatorList;
		let elevators = column.findElevator(requestedFloor);
		elevators.requestList.push(requestedFloor);
		elevators.requestList.sort();
		console.log(
			elevators.elevatorId + ' IS ON FLOOR ' + elevators.currentFloor
		);
		if (elevators.requestList[0] > elevators.currentFloor) {
			elevators.currentDirection = 'up';

			if (elevators.requestList !== null) {
				while (elevators.requestList > elevators.currentFloor) {
					elevators.currentFloor = elevators.currentFloor + 1;
					console.log(
						elevators.elevatorId +
						' IS ON FLOOR ' +
						elevators.currentFloor
					);

					if (elevators.currentFloor == elevators.requestList) {
						for (let timer = 8; timer >= 0; timer--) {
							if (timer == 0 || timer == 8) {
								elevators.doors = 'Doors are closed';
								console.log(elevators.doors);
							} else {
								// elevators.doors = 'Doors are open';
								console.log(
									'Doors open - ' +
									timer +
									's until doors close'
								);
							}
						}
					}
				}
				console.log('Request popped');
				elevators.requestList.pop();
			}
		} else {
			elevators.currentDirection = 'down';
			while (elevators.requestList < elevators.currentFloor) {
				elevators.currentFloor = elevators.currentFloor - 1;
				console.log(
					elevators.elevatorId +
					' IS ON FLOOR ' +
					elevators.currentFloor
				);

				if (elevators.currentFloor == elevators.requestList) {
					for (let timer = 8; timer >= 0; timer--) {
						if (timer == 0 || timer == 8) {
							elevators.doors = 'Doors are closed';
							console.log(elevators.doors);
						} else {
							// elevators.doors = 'Doors are open';
							console.log(
								'Doors open - ' + timer + 's until doors close'
							);
						}
					}
				}
			}
			// elevators.requestList.pop();
		}
		console.log('----  Just a poorly made breakline  ----');
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
		this.doors = 'Elevator doors are closed';
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
console.log('Uncomment code at bottom of the sheet to perform tests');
// Unfortunately my program falls appart when there's more than one request at a time. How it fails: elevator0 will pick up first request and carry them to destination, then pick up second request, but elevator1 will move to the requested floor instead.

//SCENARIO

// First n is numOfFloors & second n is numOfElevators
var column = new Column(10, 2);

// Test 1 -- SUCCESSFUL TEST

// Elevator 0 idle at floor 2 and elevator 1 idle at floor 6
column.elevatorList[0].currentDirection = 'idle';
column.elevatorList[0].currentFloor = 2;
column.elevatorList[1].currentDirection = 'idle';
column.elevatorList[1].currentFloor = 6;

column.requestElevator(3, 'up');
column.requestFloor(7);

// Test 2 -- SUCCESSFUL TEST

// Elevator 0 idle at floor 10 and elevator 2 idle at floor 3
// column.elevatorList[0].currentDirection = 'idle';
// column.elevatorList[0].currentFloor = 10;
// column.elevatorList[1].currentDirection = 'idle';
// column.elevatorList[1].currentFloor = 3;

// column.requestElevator(1, 'up');
// column.requestFloor(6);
// column.requestElevator(3, 'up');
// column.requestFloor(5);

// Test 3 -- ALMOST SUCCESSFUL TEST --- bug on third request and doors technically don't open for first request

// Elevator 0 idle at floor 10 and elevator 2 up at floor 6
// column.elevatorList[0].currentDirection = 'idle';
// column.elevatorList[0].currentFloor = 10;
// column.elevatorList[1].currentDirection = 'idle';
// column.elevatorList[1].currentFloor = 3;

// column.requestElevator(3, 'up');
// column.requestFloor(6);
// column.requestElevator(3, 'down');
// column.requestFloor(2);
// // column.requestElevator(10, 'down');
// // column.requestFloor(3);

// To see elevator properties
console.log(column.elevatorList);
