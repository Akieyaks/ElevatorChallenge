using ConsoleApp5;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of floors in the building: ");
        int numberOfFloors = GetValidInput();

        Console.WriteLine("Enter the number of elevators: ");
        int numberOfElevators = GetValidInput();

        Building building = new Building(numberOfFloors, numberOfElevators);

        Console.WriteLine("Elevator Limits:");
        foreach (Elevator elevator in building.GetElevators())
        {
            Console.WriteLine($"Elevator: {elevator}, Limit: {elevator.MaxCapacity}");
        }

        while (true)
        {
            Console.WriteLine("Enter your current floor: ");
            int currentFloor = GetValidInput();

            // Validate if the current floor is within the valid range
            if (currentFloor < 1 || currentFloor > numberOfFloors)
            {
                Console.WriteLine($"Invalid current floor. Please enter a floor between 1 and {numberOfFloors}.");
                continue; // Restart the loop
            }

            Console.WriteLine("Enter the number of people waiting for the elevator: ");
            int peopleCount = GetValidInput();

            Console.WriteLine("Enter the destination floor: ");
            int targetFloor = GetValidInput();

            // Validate if the target floor is within the valid range
            if (targetFloor < 1 || targetFloor > numberOfFloors)
            {
                Console.WriteLine($"Invalid target floor. Please enter a floor between 1 and {numberOfFloors}.");
                continue; // Restart the loop
            }

            Elevator selectedElevator = building.RequestElevator(currentFloor);

            Console.WriteLine($"Elevator {selectedElevator} dispatched to floor {currentFloor}");

            // Show the movement of the elevator to the called floor
            ShowElevatorMovement(selectedElevator, currentFloor);

            selectedElevator.LoadPassengers(peopleCount);

            // Show the movement of the elevator to the destination floor
            ShowElevatorMovement(selectedElevator, targetFloor);

            selectedElevator.MoveToFloor(targetFloor);
            selectedElevator.UnloadPassengers(peopleCount);

            // Display the status of all elevators after each trip
            Console.WriteLine("Elevator Status:");
            foreach (Elevator elevator in building.GetElevators())
            {
                elevator.DisplayStatus();
            }
        }
    }

    static void ShowElevatorMovement(Elevator elevator, int targetFloor)
    {
        Console.WriteLine($"Elevator {elevator} is moving to floor {targetFloor}");
        // Simulate movement delay
        Thread.Sleep(1000);
        // Update the elevator's current floor using the public method
        elevator.UpdateCurrentFloor(targetFloor);
        Console.WriteLine($"Elevator {elevator} has arrived at floor {targetFloor}");
    }

    static int GetValidInput()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
        return input;
    }
}
