using Ovning5.garage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5_Tests
{
    public class GarageTests
    {

        [Fact]
        public void CreateNewGarage()
        {
            // Arrange
            IGarage<Vehicle> garage = new Garage<Vehicle>(50);

            // Act

            // Assert
            Assert.Equal(50, garage.size());
        }


        [Fact]
        public void ParkVehicle()
        {
            // Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>(5);
            Vehicle vehicle = new Car("Volvo 740", "Red", 4, "KFZ324", 1995);
            garage.parkVehicle(vehicle);
            Vehicle parkedVehicle = null!;

            // Act
            foreach (Car car in garage) if (car.Registration.Equals("KFZ324"))
                {
                    parkedVehicle = car;
                }

            // Assert
            Assert.Equal("KFZ324", parkedVehicle!.Registration);
        }

        [Fact]
        public void RemoveVehicle()
        {
            // Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>(5);
            Vehicle vehicle = new Car("Volvo 740", "Red", 4, "KFZ324", 1995);
            garage.parkVehicle(vehicle);

            // Act
            Vehicle result = garage.removeVehicle(vehicle);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("KFZ324", result.Registration);
        }
    }
}
