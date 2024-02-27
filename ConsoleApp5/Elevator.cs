using System;
using System.Threading;

namespace ConsoleApp5
{
    // Enum to represent the possible directions of the elevator
    enum Direction
    {
        Up,
        Down,
        None
    }

    class Elevator
    {
        private int currentFloor; // Private field to store the current floor of the elevator

        // Public property to get the current floor
        public int CurrentFloor
        {
            get { return currentFloor; }
        }

        // Public properties to get the direction, movement status, passenger count, and maximum capacity
        public Direction Direction { get; private set; }
        public bool IsMoving { get; private set; }
        public int PassengerCount { get; private set; }
        public int MaxCapacity { get; private set; }

        // Constructor to initialize an elevator with a given maximum capacity
        public Elevator(int maxCapacity)
        {
            currentFloor = 0; // Start from floor 0
            Direction = Direction.None; // Initialize direction as None
            IsMoving = false; // Initialize as not moving
            PassengerCount = 0; // Initialize with no passengers
            MaxCapacity = maxCapacity; // Set the maximum capacity
        }

        // Method to move the elevator to a target floor
        public void MoveToFloor(int targetFloor)
        {
            // Determine the direction based on the target floor
            Direction = targetFloor > currentFloor ? Direction.Up : Direction.Down;
            IsMoving = true; // Set moving status to true

            // Simulate movement until the elevator reaches the target floor
            while (currentFloor != targetFloor)
            {
                Thread.Sleep(1000); // Simulating movement delay (1 second)
                currentFloor += Direction == Direction.Up ? 1 : -1; // Update current floor based on direction
                Console.WriteLine($"Elevator is moving to floor {currentFloor}");
            }

            IsMoving = false; // Set moving status to false when the target floor is reached
            OpenDoors(); // Open the doors upon reaching the target floor
        }

        // Method to simulate opening doors
        public void OpenDoors()
        {
            Console.WriteLine("Elevator doors opened.");
            // Additional logic for opening doors can be added here
        }

        // Method to simulate closing doors
        public void CloseDoors()
        {
            Console.WriteLine("Elevator doors closed.");
            // Additional logic for closing doors can be added here
        }

        // Method to load passengers into the elevator
        public void LoadPassengers(int passengers)
        {
            // Check if loading passengers would exceed the maximum capacity
            if (PassengerCount + passengers > MaxCapacity)
            {
                Console.WriteLine("Elevator is overloaded. Unable to load passengers.");
                return;
            }

            // Load passengers and display the current passenger count
            PassengerCount += passengers;
            Console.WriteLine($"{passengers} passengers loaded. Current passenger count: {PassengerCount}");
        }

        // Method to unload passengers from the elevator
        public void UnloadPassengers(int passengers)
        {
            // Unload passengers and display the current passenger count
            PassengerCount -= passengers;
            Console.WriteLine($"{passengers} passengers unloaded. Current passenger count: {PassengerCount}");
        }

        // Method to display the current status of the elevator
        public void DisplayStatus()
        {
            Console.WriteLine($"Elevator at floor {currentFloor}, Direction: {Direction}, Moving: {IsMoving}, Passenger Count: {PassengerCount}");
        }

        // Method to manually update the current floor of the elevator
        public void UpdateCurrentFloor(int newFloor)
        {
            currentFloor = newFloor;
        }
    }
}
