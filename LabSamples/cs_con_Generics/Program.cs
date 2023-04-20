namespace cs_con_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i.GetType());
            Console.WriteLine(i);
            Console.WriteLine();

            MyGenericType<int> myInt = new MyGenericType<int>();
            myInt.Value = 10;
            // myInt.Value = "10";
            Console.WriteLine(myInt.GetType());
            myInt.Display();

            MyGenericType<string> myString = new MyGenericType<string>();
            myString.Value = "hello world";
            Console.WriteLine(myString.GetType());
            myString.Display();

            MyGenericType<Employee> myEmployee = new MyGenericType<Employee>();
            myEmployee.Value = new Employee() { Id = 10, Name = "First Employee" };
            Console.WriteLine(myEmployee.GetType());
            myEmployee.Display();

            List<Employee> employees = new List<Employee>();
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"ID: {this.Id}, Name: {this.Name}\n Type: {base.ToString()}";
            }
        }
    }
}