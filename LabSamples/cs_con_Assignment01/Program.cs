namespace cs_con_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo1();

            DemoOfBuilder();

            Demo2();
        }

        static private void DemoOfBuilder()
        {
            Console.WriteLine("---- using the Builder");
            QuadrilateralBuilder builder = new QuadrilateralBuilder();
            Demo01.Quadrilateral? objQuad = builder.GetQuadrilateral(SymbolTypes.Rectangle, 5, 2);
            Console.WriteLine("Type: {0}", objQuad?.GetType());
            Console.WriteLine("Perimeter: {0}", objQuad?.Perimeter);
            Console.WriteLine("Area: {0}", objQuad?.Area());
            Console.WriteLine(objQuad);
            Console.WriteLine();
        }

        static private void Demo1()
        {
            Console.WriteLine("--- Demo of Class Hierarchies");

            Demo01.Rectangle objRect = new Demo01.Rectangle(10, 20);
            Console.WriteLine("Type: {0}", objRect.GetType());
            Console.WriteLine("Perimeter: {0}", objRect.Perimeter);
            Console.WriteLine("Area: {0}", objRect.Area());
            Console.WriteLine(objRect);
            Console.WriteLine();

            Demo01.Quadrilateral objQuadRect = new Demo01.Rectangle(10, 20);
            Console.WriteLine("Type: {0}", objQuadRect.GetType());
            Console.WriteLine("Perimeter: {0}", objQuadRect.Perimeter);
            Console.WriteLine("Area: {0}", objQuadRect.Area());
            Console.WriteLine(objRect);
            Console.WriteLine();
        }

        static private void Demo2()
        {
            Console.WriteLine("--- Demo of Interface");

            // Demo01.Rectangle objRect = new Demo01.Rectangle(10, 20);
            Demo02.IRectangle objRect = new Demo02.Quadrilateral(10, 20);
            Console.WriteLine("Type: {0}", objRect.GetType());
            Console.WriteLine("Perimeter: {0}", objRect.Perimeter);
            Console.WriteLine("Area: {0}", objRect.Area());
            Console.WriteLine(objRect);
            Console.WriteLine();
        }
    }
}