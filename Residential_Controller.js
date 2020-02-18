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
function Elevator(floor, direction, status) {
	this.floor = floor;
	this.direction = direction;
	this.status = status;
}

let floor = 3;
let direction = 'up';
let status = 'idle';

function makeElevators(n) {
	let elevators = new Array(n);
	for (var i = 0; i < n; ++i) {
		elevators[i] = new Elevator(floor, direction, status);
	}
	return elevators;
}

var elevators = makeElevators(2);

console.log(elevators);


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

var buttonUpList = makeButtonUps(3);

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

var buttonDownList = makeButtonDowns(3);

console.log(buttonDownList);