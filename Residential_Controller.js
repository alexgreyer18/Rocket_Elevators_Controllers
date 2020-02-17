/* Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
*/
//repl.it/repls/WorstVigorousCad

https: var selectedElevator = null;
var waitList = [];
var floorList = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
var RC = floors.indexOf('0');

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

// function findElevator(floor, direction) { // return selectedElevator

//     INIT BestElevator TO NULL;
//     INIT BestElevatorCase TO NULL;

//     if (selectedElevator == null) {

//         elevatorList.forEach(elevators => {
//             OBTAIN currentElevatorFloor
//             OBTAIN currentElevatorDirection
//             OBTAIN currentElevatorState

//         });
//     }
//             IF requestedFloor EQUAL currentElevatorFloor AND currentElevatorState EQUAL idle OR requestedFloor EQUAL currentElevatorFloor AND currentElevatorDirection EQUAL direction THEN
//                 IF BestElevator IS NULL OR BestElevatorCase > 1
//                     SET Elevator TO BestElevator
//                     SET BestElevatorCase as 1
//                 END IF

//             ELSE IF requestedFloor ABOVE OR BELOW currentElevatorFloor AND currentElevatorDirection EQUAL TO direction THEN
//                 IF BestElevator IS NULL OR BestElevatorCase > 2
//                     FOR EACH Elevator in ElevatorList
//                         COMPUTE indexDifference RETURNING BestElevator
//                         SET BestElevatorCase as 2
//                     END FOR
//                 END IF

//             ELSE IF requestedFloor ABOVE OR BELOW currentElevatorFloor AND currentElevatorDirection NOT EQUAL TO direction THEN
//                 IF BestElevator IS NULL OR BestElevatorCase > 3
//                     FOR EACH Elevator in ElevatorList
//                         COMPUTE indexDifference RETURNING BestElevator
//                         SET BestElevatorCase as 3
//                     END FOR
//                 END IF
//             END IF
//         END FOR
//     END IF
//     SET BestElevator TO selectedElevator
//     RETURN selectedElevator
// END SEQUENCE
