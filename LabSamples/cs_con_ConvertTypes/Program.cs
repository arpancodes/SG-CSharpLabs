namespace cs_con_ConvertTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo01();
        }

        static void Demo01()
        {
            int i = 10;
            long l = i;             // implicit typecasting

            long m = 40;
            int j = (int)m;         // explicit typecasting

            int k = int.MaxValue;
            Console.WriteLine("Maximum Value of integer = {0}", k);
            unchecked
            {
                k++;
            }
            checked
            {
                k++;
            }
            Console.WriteLine("Adding one to it, we have: {0}", k);
        }
    }
}