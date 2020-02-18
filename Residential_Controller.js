/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/

var selectedElevator = null;
var waitList = [];
var floorList = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
var RC = floor.indexOf('0');

// Elevator constructor
function Elevator(currentFloor, currentDirection, currentStatus) {
	this.currentFloor = currentFloor;
	this.currentDirection = currentDirection;
	this.currentStatus = currentStatus;
}

let currentFloor = 3;
let currentDirection = 'up';
let currentStatus = 'idle';

function makeElevators(n) {
	let elevatorList = new Array(n);
	for (var i = 0; i < n; ++i) {
		elevatorList[i] = new Elevator(
			currentFloor,
			currentDirection,
			currentStatus
		);
	}
	return elevatorList;
}

var elevatorList = makeElevators(2);

console.log(elevatorList);

function ButtonUp(floor, direction) {
	this.floor = floor;
	this.direction = direction;
}

function makeButtonUps(n) {
	let buttonUpList = new Array(n);
	for (var i = 0; i < n; ++i) {
		buttonUpList[i] = new ButtonUp(floor, direction);
	}
	return buttonUpList;
}

var buttonUpList = makeButtonUps(10);

console.log(buttonUpList);

function ButtonDown(floor, direction) {
	this.floor = floor;
	this.direction = direction;
}

function makeButtonDowns(n) {
	let buttonDownList = new Array(n);
	for (var i = 0; i < n; ++i) {
		buttonDownList[i] = new ButtonDown(floor, direction);
	}
	return buttonDownList;
}

var buttonDownList = makeButtonDowns(10);

console.log(buttonDownList);
