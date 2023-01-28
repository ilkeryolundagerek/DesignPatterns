using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IEngine engine = new Electricity();
            //IVehicle mobilette = new MotorCycle(engine);
            //mobilette.Drive();
            Service s1 = Service.GetService(5, 6);
            Service s2 = Service.GetService(5, 6);
            Service s3 = s1;
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            s1.a = 15;
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1.a);
            Console.WriteLine(s3.a);
        }

        public interface IVehicle
        {
            IEngine Engine { get; set; }
            void Drive();
        }

        public class Automobile : IVehicle
        {
            public IEngine Engine { get; set; }

            public Automobile(IEngine engine)
            {
                Engine = engine;
            }

            public void Drive()
            {
                Engine.Start();
                Console.WriteLine("I'm driving automobile.");
            }
        }

        public class MotorCycle : IVehicle
        {
            public IEngine Engine { get; set; }

            public MotorCycle(IEngine engine)
            {
                Engine = engine;
            }

            public void Drive()
            {
                Engine.Start();
                Console.WriteLine("I'm driving motorcycle.");
            }
        }

        public class Bus : IVehicle
        {
            public IEngine Engine { get; set; }

            public Bus(IEngine engine)
            {
                Engine = engine;
            }

            public void Drive()
            {
                Engine.Start();
                Console.WriteLine("I'm driving bus.");
            }
        }

        public interface IEngine
        {
            void Start();
        }

        public class Diesel : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Diesel engine started.");
            }
        }
        public class Gasoline : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Gasoline engine started.");
            }
        }
        public class Electricity : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Electric engine started.");
            }
        }
    }
}
