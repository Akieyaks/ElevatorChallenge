using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   class ElevatorTests
    {

        [TestMethod]
        public void MoveToFloor_ShouldUpdateCurrentFloor()
        {
            // Arrange
            Elevator elevator = new Elevator(10);

            // Act
            elevator.MoveToFloor(5);

            // Assert
            Assert.AreEqual(5, elevator.CurrentFloor);
        }

        [TestMethod]
        public void LoadPassengers_ShouldUpdatePassengerCount()
        {
            // Arrange
            Elevator elevator = new Elevator(10);

            // Act
            elevator.LoadPassengers(3);

            // Assert
            Assert.AreEqual(3, elevator.PassengerCount);
        }
    }
}
