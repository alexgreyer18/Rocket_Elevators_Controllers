def main():
  controller = Controller(2,10)
  elevator = Elevator(10,2)
  controller.move(elevator.direction,elevator.elevatorNumber[1])

class Controller():
  def __init__(self,elevator,floor):
    self.elevator = elevator
    self.floor = floor
    self.direction = "up"

    
  def move(self,direction, elevator):
    print("elevator: ", elevator)
    print("Moving :", direction)



class Elevator():
  def __init__(self,floorTotal,elevatorNumber):
    self.elevatorNumber = []
    self.floorTotal = []
    self.currentFloor = 1
    self.status = "idle"
    self.direction = "Up"  

    for i in range(floorTotal):
        self.floorTotal.append(i)
    print(self.floorTotal)  

    for i in range(elevatorNumber):
        self.elevatorNumber.append(i)
    print(self.elevatorNumber)


main()


{
    UP = 1
    DOWN = 2
    FLOOR_COUNT = 10
    Elevators = 2

        def __init__(self):
            # Feel free to add any instance variables you want.
            self.destination_floor = None
            self.callbacks = None

        def on_called(self, floor, direction):
            """
            This is called when somebody presses the up or down button to call the elevator.
            This could happen at any time, whether or not the elevator is moving.
            The elevator could be requested at any floor at any time, going in either direction.
            floor: the floor that the elevator is being called to
            direction: the direction the caller wants to go, up or down
            """
            self.destination_floor = floor

        def on_floor_selected(self, floor):
            """
            This is called when somebody on the elevator chooses a floor.
            This could happen at any time, whether or not the elevator is moving.
            Any floor could be requested at any time.
            floor: the floor that was requested
            """
            self.destination_floor = floor

        def on_floor_changed(self):
            """
            This lets you know that the elevator has moved one floor up or down.
            You should decide whether or not you want to stop the elevator.
            """
            if self.destination_floor == self.callbacks.current_floor:
                self.callbacks.motor_direction = None

        def on_ready(self):
            """
            This is called when the elevator is ready to go.
            Maybe passengers have embarked and disembarked. The doors are closed,
            time to actually move, if necessary.
            """
            if self.destination_floor > self.callbacks.current_floor:
                self.callbacks.motor_direction = UP
            elif self.destination_floor < self.callbacks.current_floor:
                self.callbacks.motor_direction = DOWN
}

Méthode 1: RequestElevator(RequestedFloor, Direction)
La méthode 1 doit obligatoirement retourner l’ascenseur choisi et faire bouger les ascenseurs dans son traitement.

Méthode 2: RequestFloor(Elevator, RequestedFloor)
La méthode 2 doit obligatoirement faire bouger les ascenseurs dans son traitement. 
