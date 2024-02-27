using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   class Building
    {
        private List<Elevator> elevators;

        public Building(int numberOfFloors, int numberOfElevators)
        {
            elevators = new List<Elevator>();

            for (int i = 0; i < numberOfElevators; i++)
            {
                int elevatorCapacity = CalculateElevatorCapacity(numberOfFloors, numberOfElevators);
                elevators.Add(new Elevator(elevatorCapacity));
            }
        }

        private int CalculateElevatorCapacity(int numberOfFloors, int numberOfElevators)
        {
            // Calculate the elevator capacity based on the total number of floors and elevators
            // You can adjust this logic based on your requirements
            int totalCapacity = numberOfFloors * 10; // Assuming 10 people per floor as a base capacity
            int elevatorCapacity = totalCapacity / numberOfElevators;

            return elevatorCapacity;
        }

        public Elevator RequestElevator(int currentFloor)
        {
            // Logic to dispatch the nearest available elevator
            Elevator nearestElevator = elevators[0];
            int minDistance = Math.Abs(nearestElevator.CurrentFloor - currentFloor);

            for (int i = 1; i < elevators.Count; i++)
            {
                int distance = Math.Abs(elevators[i].CurrentFloor - currentFloor);

                if (distance < minDistance)
                {
                    nearestElevator = elevators[i];
                    minDistance = distance;
                }
            }

            return nearestElevator;
        }

        public List<Elevator> GetElevators()
        {
            return elevators;
        }
    }
}
