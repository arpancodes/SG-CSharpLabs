namespace cs_con_ClassVsStruct
{
    partial class MyClass
    {
        public string? Greeting;

        // Default Constructor / Parameterless Constructor
        public MyClass()
        {
            this.Greeting = "hello world";
            this.ID = 20;
        }

        // Parameterized Constructor
        public MyClass(string? greeting)
        {
            this.Greeting = greeting;
            this.ID = 10;
        }
    }
}