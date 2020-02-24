# This program controls a set of residential elevators.
# Uncomment scenarios at the bottom of the page for testing purposes.
# The requestFloor method should have been in the Elevator class but I ran out of time to figure out how to move it there from the Column class, as I had had trouble trying earlier and the requestFloor method does not work


class Column():
    def __init__(self, nbFloor, nbElevator):
        self.floorList = []
        for i in range(nbFloor):
            self.floorList.append(i)
        print(self.floorList)

        self.elevatorList = []
        for i in range(nbElevator):
            elevatorStr = "elevator" + str(i)
            self.elevatorList.append(Elevator(elevatorStr, 10))
        # print(self.elevatorList)

    def findElevator(self, requestedFloor, requestDirection):
        BestElevator = None
        for elevator in column.elevatorList:
            # if elevator.currentDirection == 'idle':
            #     BestElevator = elevator

            if requestedFloor == elevator.currentFloor:
                BestElevator = elevator

            elif elevator.currentFloor > requestedFloor:
                if requestDirection == 'down' and elevator.currentDirection == 'down':
                    BestElevator = elevator
                else:
                    BestElevator = elevator

            elif requestedFloor > elevator.currentFloor:
                    if requestDirection == 'up' and elevator.currentDirection == 'up':
                        BestElevator = elevator
                    else:
                        BestElevator = elevator
        return BestElevator

    def requestElevator(self, requestedFloor, direction):
        bestElevator = self.findElevator(requestedFloor, direction)
        bestElevator.requestList.append(requestedFloor)
        bestElevator.requestList.sort()
        print(str(bestElevator.elevatorId) + ' IS ON FLOOR ' + str(bestElevator.currentFloor))

        if bestElevator.requestList[0] > bestElevator.currentFloor:
            bestElevator.currentDirection = 'up'

            if bestElevator.requestList != None:
                while bestElevator.requestList[0] > bestElevator.currentFloor:
                    bestElevator.currentFloor = bestElevator.currentFloor + 1
                    print(str(bestElevator.elevatorId) + ' IS ON FLOOR ' + str(bestElevator.currentFloor))

                    if bestElevator.currentFloor == bestElevator.requestList:
                        for timer in range(7, 0, -1):
                            if timer == 0 or timer == 8:
                                bestElevator.doors = 'Doors are closed'
                                print(bestElevator.doors)
                            else:
                                print('Doors open - ' + str(timer) +
                                      's until doors close')
            print('Request popped')
            bestElevator.requestList.pop()
        else:
            bestElevator.currentDirection = 'down'
            while bestElevator.requestList[0] < bestElevator.currentFloor:
                bestElevator.currentFloor = bestElevator.currentFloor - 1
                print(str(bestElevator.elevatorId) +
                      ' IS ON FLOOR ' + str(bestElevator.currentFloor))

                if bestElevator.currentFloor == bestElevator.requestList:
                    for timer in range(7, 0, -1):
                        if timer == 0 or timer == 8:
                            bestElevator.doors = 'Doors are closed'
                            print(bestElevator.doors)
                        else:
                            print('Doors open - ' + timer +
                                  's until doors close')
        print('----  Just a poorly made breakline  ----')

    def requestFloor(self, requestedFloor, direction):
        elevatorList = self.elevatorList
        elevators = self.findElevator(requestedFloor, direction)
        elevators.requestList.append(requestedFloor)
        elevators.requestList.sort()
        print(str(elevators.elevatorId) +
              ' IS ON FLOOR ' + str(elevators.currentFloor))

        if elevators.requestList[0] > elevators.currentFloor:
            elevators.currentDirection = 'up'
            if elevators.requestList != None:
                while elevators.requestList[0] > elevators.currentFloor:
                    elevators.currentFloor = elevators.currentFloor + 1
                    print(str(elevators.elevatorId) +
                          ' IS ON FLOOR ' + str(elevators.currentFloor))

                    if elevators.currentFloor == elevators.requestList:
                        for timer in range(7, 0, -1):
                            if timer == 0 or timer == 8:
                                bestElevator.doors = 'Doors are closed'
                                print(bestElevator.doors)
                            else:
                                print('Doors open - ' + timer +
                                      's until doors close')
                print('Request popped')
                elevators.requestList.pop()
        else:
            elevators.currentDirection = 'down'
            while elevators.requestList[0] < elevators.currentFloor:
                elevators.currentFloor = elevators.currentFloor - 1
                print(elevators.elevatorId +
                      ' IS ON FLOOR ' + elevators.currentFloor)

                if elevators.currentFloor == elevators.requestList:
                    for timer in range(7, 0, -1):
                        if timer == 0 or timer == 8:
                            bestElevator.doors = 'Doors are closed'
                            print(bestElevator.doors)
                        else:
                            print('Doors open - ' + timer +
                                  's until doors close')
        print('----  Just a poorly made breakline  ----')

class Elevator():
    def __init__(self, elevatorId, nbFloor):
        self.elevatorId = elevatorId
        self.currentFloor = 1
        self.currentDirection = 'idle'
        self.requestList = []
        self.doors = 'Elevator doors are closed'


# SECTION TESTS
print('Uncomment code at bottom of the sheet to perform tests')
# Unfortunately my requestFloor function does not work. Transcribing from JS to Python, it forced me to pass an argument (direction) I wasn't passing in JS and I believe that"s what ruined my code
# SCENARIO

# First n is numOfFloors & second n is numOfElevators
column = Column(10, 2)
 

# Test 1 

# Elevator 0 idle at floor 2 and elevator 1 idle at floor 6
# column.elevatorList[0].currentDirection = 'idle'
# column.elevatorList[0].currentFloor = 2
# column.elevatorList[1].currentDirection = 'idle'
# column.elevatorList[1].currentFloor = 6

# column.requestElevator(3, 'up')
# column.requestFloor(7, 'up')


# Test 2 

#   Elevator 0 idle at floor 10 and elevator 2 idle at floor 3
# column.elevatorList[0].currentDirection = 'idle';
# column.elevatorList[0].currentFloor = 10;
# column.elevatorList[1].currentDirection = 'idle';
# column.elevatorList[1].currentFloor = 3;

# column.requestElevator(1, 'up');
# column.requestFloor(6, 'up');
#   column.requestElevator(3, 'up');
#   column.requestFloor(5);

# Test 3 

#   Elevator 0 idle at floor 10 and elevator 2 up at floor 6
#   column.elevatorList[0].currentDirection = 'idle';
#   column.elevatorList[0].currentFloor = 10;
#   column.elevatorList[1].currentDirection = 'idle';
#   column.elevatorList[1].currentFloor = 3;

#   column.requestElevator(3, 'up');
#   column.requestFloor(6);
#   column.requestElevator(3, 'down');
#   column.requestFloor(2);
#   column.requestElevator(10, 'down');
#   column.requestFloor(3);