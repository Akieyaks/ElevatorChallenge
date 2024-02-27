using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    enum Direction
    {
        Up,
        Down,
        None
    }
    class Elevator
    {

        private int currentFloor; // Change to private field

        public int CurrentFloor
        {
            get { return currentFloor; }
        }

        public Direction Direction { get; private set; }
        public bool IsMoving { get; private set; }
        public int PassengerCount { get; private set; }
        public int MaxCapacity { get; private set; }

        public Elevator(int maxCapacity)
        {
            currentFloor = 0; // Start from floor 0
            Direction = Direction.None;
            IsMoving = false;
            PassengerCount = 0;
            MaxCapacity = maxCapacity;
        }

        public void MoveToFloor(int targetFloor)
        {
            Direction = targetFloor > currentFloor ? Direction.Up : Direction.Down;
            IsMoving = true;

            while (currentFloor != targetFloor)
            {
                Thread.Sleep(1000); // Simulating movement delay
                currentFloor += Direction == Direction.Up ? 1 : -1;
                Console.WriteLine($"Elevator is moving to floor {currentFloor}");
            }

            IsMoving = false;
            OpenDoors();
        }

        public void OpenDoors()
        {
            Console.WriteLine("Elevator doors opened.");
            // Additional logic for opening doors
        }

        public void CloseDoors()
        {
            Console.WriteLine("Elevator doors closed.");
            // Additional logic for closing doors
        }

        public void LoadPassengers(int passengers)
        {
            if (PassengerCount + passengers > MaxCapacity)
            {
                Console.WriteLine("Elevator is overloaded. Unable to load passengers.");
                return;
            }

            PassengerCount += passengers;
            Console.WriteLine($"{passengers} passengers loaded. Current passenger count: {PassengerCount}");
        }

        public void UnloadPassengers(int passengers)
        {
            PassengerCount -= passengers;
            Console.WriteLine($"{passengers} passengers unloaded. Current passenger count: {PassengerCount}");
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Elevator at floor {currentFloor}, Direction: {Direction}, Moving: {IsMoving}, Passenger Count: {PassengerCount}");
        }

        public void UpdateCurrentFloor(int newFloor)
        {
            currentFloor = newFloor;
        }
    }
}
