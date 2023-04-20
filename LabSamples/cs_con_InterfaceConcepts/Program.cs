using cs_con_InterfaceConcepts.Demo04;

namespace cs_con_InterfaceConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo2 obj1 = new Demo2();
            obj1.n();
            obj1.m();                       // ------ Demo2.m();
            (obj1 as IDemo).m();            // ((IDemo)obj1).m();
            (obj1 as IAnotherDemo).m();
            Console.WriteLine();

            IDemo obj2 = new Demo2();
            obj2.m();                        // ------ IDemo.m()
            (obj2 as Demo2)?.m();            // ------ Demo.m()
            (obj2 as IAnotherDemo)?.m();
        }
    }
}