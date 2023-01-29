using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class InterfaceSegregatation
    {
    }

    //Bad way...
    public interface IEmployeeBad
    {
        void Produce();
        void Drive();
        void Manage();
        void Record();
    }

    public class EmployeeBad : IEmployeeBad
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Manage()
        {
            Console.WriteLine("Managing");
        }

        public void Produce()
        {
            Console.WriteLine("Producing...");
        }

        public void Record()
        {
            Console.WriteLine("Recording...");
        }
    }

    //Good way...
    public interface IDriver { void Drive(); }
    public interface IProducer { void Produce(); }
    public interface IManager { void Manage(); }
    public interface IRecorder { void Record(); }

    public class CompanyDriver : IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }

    public class ExecutiveManager : IManager, IRecorder
    {
        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }
    }

    public class ProduceManager : IProducer, IManager
    {
        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Produce()
        {
            throw new NotImplementedException();
        }
    }
}
