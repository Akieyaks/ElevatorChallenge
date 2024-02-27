# Elevator Simulation Project

This project simulates the behavior of elevators in a building. It includes classes for representing elevators, a building, and a simple console application to interact with the elevator simulation.

## Features

- **Elevator Class**: Represents an elevator with functionalities such as moving to a target floor, loading and unloading passengers, and displaying its current status.

- **Building Class**: Manages a collection of elevators and provides methods for dispatching elevators based on user requests.

- **Console Application**: Allows users to interact with the elevator simulation by entering their current floor, the number of passengers, and the destination floor.

- **Dispatcher Logic**: The system intelligently dispatches elevators based on the number of passengers and ensures that if the capacity of a single elevator is exceeded, additional elevators are dispatched to pick up the remaining passengers.

## Usage

1. **Run the Application**: Execute the console application to initiate the elevator simulation.

2. **Follow Prompts**: Enter the required information when prompted, such as your current floor, the number of passengers, and the destination floor.

3. **Observe Simulation**: Watch the simulation as elevators move, open doors, load and unload passengers, and display their status.

## Structure

- **Elevator Class**: Contains the logic for individual elevators.

- **Building Class**: Manages a collection of elevators and dispatches them based on user requests.

- **Program Class**: Contains the main method to run the console application.

- **Test Classes**: Includes unit tests for the Elevator and Building classes.

## Dependencies

- .NET Framework (Version 8.0)

## How to Run Tests

1. Open the project in Visual Studio or your preferred IDE.

2. Locate the test classes under the "Tests" directory.

3. Run the tests using the testing framework provided by your IDE.


