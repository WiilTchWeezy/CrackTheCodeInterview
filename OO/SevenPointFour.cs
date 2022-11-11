using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public enum VehicleSize
    {
        Motorcycle,
        Compact,
        Large
    }

    public abstract class Vehicle
    {
        public VehicleSize Size { get; set; }
        public string LicensePlate { get; set; }

        public void Park(ParkingSpot parkingSpot)
        {
            parkingSpot.Vehicle = this;
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            this.Size = VehicleSize.Compact;
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            this.Size = VehicleSize.Motorcycle;
        }
    }

    public class Bus : Vehicle
    {
        public Bus()
        {
            this.Size = VehicleSize.Large;
        }
    }

    public class ParkingSpot
    {
        public VehicleSize ParkingSize { get; set; }
        public Vehicle Vehicle { get; set; }
        public int Row { get; set; }
        public int SpotNumber { get; set; }
        public Level Level { get; set; }
        public bool IsAvaliable { get { return Vehicle == null; } }
        public ParkingSpot(VehicleSize vehicleSize, int row, int number, Level level)
        {
            ParkingSize = vehicleSize;
            Row = row;
            SpotNumber = number;
            Level = level;
        }
    }

    public class Level
    {
        public List<ParkingSpot> ParkingSpots { get; set; }
        public int AvaliableSpots { get { return ParkingSpots.Where(x => x.IsAvaliable).Count(); } }
        public int LevelNumber { get; set; }

        public Level(int levelNumber)
        {
            LevelNumber = levelNumber;
        }

        public ParkingSpot FindASpot(VehicleSize vehicleSize)
        {
            return ParkingSpots.Where(x => x.ParkingSize == vehicleSize && x.IsAvaliable).OrderBy(x => x.SpotNumber).FirstOrDefault();
        }

        public bool HasSpotForSize(VehicleSize vehicleSize)
        {
            return ParkingSpots.Any(x => x.ParkingSize == vehicleSize && x.IsAvaliable);
        }
    }

    public class ParkingLot
    {
        public List<Level> Levels { get; set; }

        public void ParkAVehicle(Vehicle vehicle)
        {
            foreach (var item in Levels.Where(x => x.AvaliableSpots > 0 && x.HasSpotForSize(vehicle.Size)).ToList())
            {
                var parkingSpot = item.FindASpot(vehicle.Size);
                vehicle.Park(parkingSpot);                                                                                                                                                                                                                                                      
            }
        }
    }
}
