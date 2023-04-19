namespace cs_con_Interface
{
    // Client
    internal class Program : IAutomobile
    {

        public void Drive()
        {
            Console.WriteLine("program is being driven");
        }

        static void Main(string[] args)
        {
            //Demo1();

            //Demo2();

            Demo3();

        }

        static void Demo3()
        {
            Console.WriteLine("---- Demo of INTERFACE");

            Driver3 objDriver = new Driver3();
            Car objCar = new Car();
            Scooter objScooter = new Scooter();

            objDriver.Drive(objCar);
            Console.WriteLine();

            objDriver.Drive(objScooter);
            Console.WriteLine();

            Program p = new Program();
            objDriver.Drive(p);
        }

        static void Demo2()
        {
            Console.WriteLine("---- Demo of Inheritance");

            Driver2 objDriver = new Driver2();

            Console.WriteLine("*** Driving Base type object");

            Vehicle objVehicle = new Car();
            objDriver.Drive(objVehicle);
            Console.WriteLine();
            
            Car objCar = new Car();
            Scooter objScooter = new Scooter();

            objDriver.Drive(objCar);
            Console.WriteLine();

            // objDriver.Drive(objScooter);
            Console.WriteLine();

            objVehicle = new Lorry();
            objDriver.Drive(objVehicle);
        }

        static void Demo1()
        {
            Console.WriteLine("---- Demo of Overloaded Methods");
            Driver1 objDriver = new Driver1();
            Car objCar = new Car();
            Scooter objScooter = new Scooter();

            objDriver.Drive(objCar);
            Console.WriteLine();

            objDriver.Drive(objScooter);
            Console.WriteLine();
        }
    }
}