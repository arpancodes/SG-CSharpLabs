namespace cs_con_DelegatesMultiCast
{
    internal class Program
    {
        delegate void StepHandler();

        static void Main(string[] args)
        {
            Demo1();
            Console.WriteLine();

            Demo2();
            Console.WriteLine();
        }

        private static void Demo1()
        {
            Process p = new Process();
            Console.WriteLine("----- first time");
            p.Step1();
            p.Step3();
            p.Step7();
            p.Step10();

            Console.WriteLine("--- second time");
            p.Step1();
            p.Step3();
            p.Step7();
            p.Step10();
        }

        private static void Demo2()
        {
            Process p = new Process();

            StepHandler objD = new StepHandler(p.Step1);    // subscribing using "=" (SINGLE-CAST)
            objD += new StepHandler(p.Step2);               // subscribing using "+=" (MULTI-CAST)
            objD += new StepHandler(p.Step5);
            objD += new StepHandler(p.Step3);
            objD += new StepHandler(p.Step3);
            objD += new StepHandler(p.Step9);
            objD += new StepHandler(p.Step10);
            objD += new StepHandler(p.Step5);

            Console.WriteLine("----- first time (using delegate)");
            objD();

            Console.WriteLine("----- second time (using delegate)");
            objD();

            Console.WriteLine("----- third time (using delegate)");
            if (objD != null)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                objD -= new StepHandler(p.Step5);           // unsubscribe using LIFO pattern
#pragma warning restore CS8601 // Possible null reference assignment.
            }
            objD?.Invoke();
        }
    }
}