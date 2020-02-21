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
        for elevator in column.elevatorList:
            # print('list',self.elevatorList)
            if elevator.currentDirection == 'idle':
                return elevator

            if requestedFloor == elevator.currentFloor:
                return elevator

            else:

                if requestedFloor > elevator.currentFloor:
                    if requestDirection == 'down' and elevator.currentDirection == 'down':
                        return elevator

                else:
                    if requestDirection == 'up' and elevator.currentDirection == 'up':
                        return elevator

                    elif requestDirection == 'down' and elevator.currentDirection == 'down':
                        return elevator

        BestElevator = None
        for i in elevatorList:

            if BestElevator == None:
                BestElevator = elevator

            else:

                if BestElevator.requestList.length > elevator.requestList.length:
                    BestElevator = elevator
        return BestElevator

    def requestElevator(self, requestedFloor, direction):
        bestElevator = self.findElevator(requestedFloor, direction)
        # print(bestElevator)
        bestElevator.requestList.append(requestedFloor)
        bestElevator.requestList.sort()
        print(str(bestElevator.elevatorId) +
              ' IS ON FLOOR ' + str(bestElevator.currentFloor))

        if bestElevator.requestList[0] > bestElevator.currentFloor:
            bestElevator.currentDirection = 'up'

            if bestElevator.requestList != None:
                while bestElevator.requestList[0] > bestElevator.currentFloor:
                    bestElevator.currentFloor = bestElevator.currentFloor + 1
                    print(str(bestElevator.elevatorId) +
                          ' IS ON FLOOR ' + str(bestElevator.currentFloor))

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
            while bestElevator.requestList < bestElevator.currentFloor:
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
            while elevators.requestList < elevators.currentFloor:
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
print('Uncomment to perform tests')
# Unfortunately my program falls appart when there's more than one request at a time. How it fails: elevator0 will pick up first request and carry them to destination, then pick up second request, but elevator1 will move to the requested floor instead.

# SCENARIO

# # First n is numOfFloors & second n is numOfElevators
column = Column(10, 2)

# # Elevator 0 Idle at floor 2 and elevator 1  Idle at floor 6
# column.elevatorList[0].currentDirection = 'idle'
# column.elevatorList[0].currentFloor = 2
# column.elevatorList[1].currentDirection = 'idle'
# column.elevatorList[1].currentFloor = 6

# Test 1

column.requestElevator(3, 'up')
column.requestFloor(7, 'up')
# # column.requestElevator(3, 'down')
# # column.requestFloor(1)

# Test 2

# column.requestElevator(7, 'up')
# column.requestFloor(10)
# # column.requestElevator(7, 'down')
# # column.requestFloor(4)
