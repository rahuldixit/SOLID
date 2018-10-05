using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Car : IVehicle
    {

        #region IVehicle Members

        public void Accelerate()
        {
            Console.WriteLine("Car accelerates...");
        }

        public void Brake()
        {
            Console.WriteLine("Car stopped.");
        }

        #endregion
    }

    public class Truck : IVehicle
    {
        #region IVehicle Members

        public void Accelerate()
        {
            Console.WriteLine("Truck accelerates...");
        }

        public void Brake()
        {
            Console.WriteLine("Truck stopped.");
        }

        #endregion
    }

    public interface IVehicle
    {
        void Accelerate();
        void Brake();
    }

    public class VehicleController
    {
        IVehicle m_Vehicle;

        public VehicleController(IVehicle vehicle)
        {
            this.m_Vehicle = vehicle;
        }

        public void Accelerate()
        {
            m_Vehicle.Accelerate();
        }

        public void Brake()
        {
            m_Vehicle.Brake();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Car();
            //IVehicle vehicle = new Truck();

            VehicleController vehicleController = new VehicleController(vehicle);
            vehicle.Accelerate();
            vehicle.Brake();

            Console.Read();
        }
    }
}
