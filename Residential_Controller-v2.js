/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/
/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/
/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/
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

	findElevator() {
		console.log('findElevator');
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
var bestElevator = column.findElevator();
console.log(column.buttonList);
console.log(column.elevatorList);
console.log(column.floorList);
//bestElevator.move();
