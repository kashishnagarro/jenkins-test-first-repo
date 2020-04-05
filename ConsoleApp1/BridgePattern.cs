using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Abstraction
    {
        public ImplementationBase Implementer { get; set; }
        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            Implementer.OperationImplementation();
        }
    }


    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            Implementer.OperationImplementation();
        }
    }


    public abstract class ImplementationBase
    {
        public abstract void OperationImplementation();
    }

    public class ConcreteImplementation1 : ImplementationBase
    {
        public override void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementation1:OperationImplementation()");
        }
    }

    public class ConcreteImplementation2 : ImplementationBase
    {
        public override void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementation2:OperationImplementation()");
        }
    }

    class BridgePattern
    {
    }
}
