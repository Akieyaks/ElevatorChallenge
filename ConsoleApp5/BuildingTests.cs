using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
class BuildingTests
    {

        [TestMethod]
        public void RequestElevator_ShouldReturnNearestElevator()
        {
            // Arrange
            Building building = new Building(10, 3);

            // Act
            Elevator elevator = building.RequestElevator(3);

            // Assert
            Assert.IsNotNull(elevator);
        }
    }
}
