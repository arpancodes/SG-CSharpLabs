using System.Security.Cryptography.X509Certificates;

namespace cs_con_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            x = 10;
            PassByValue(x);
            Console.WriteLine(x);

            x = 10;
            PassByReference(ref x);
            Console.WriteLine(x);

            x = 10;
            PassByOutput(out x);
            Console.WriteLine(x);

            Add(10, 20);
            Add(10);

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int sum = AddArray(arr);
            sum = AddArray(new int[] { 5, 11, 23, 35 });

            AddArray2(3, 22, 18, 24, 47);
            AddArray2(18);
            AddArray2(18, 94);
            AddArray2();
        }

        static void PassByValue(int i)
        {
            i = 300;
        }

        static void PassByReference(ref int i)
        {
            i = 500;
        }

        static void PassByOutput(out int i)
        {
            // Console.WriteLine(i);
            i = 30000;
        }

        /// <summary>
        ///     Optional Parameters example.
        ///     Provide a default fall-back value for the parameter.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b">(optional) second number (DEFAULT: 0)</param>
        /// <returns></returns>
        static int Add(int a, int b = 0, int? c = default)
        {
            int result;

            if(c != null)
            {
                result = a + b + c.Value;
            }

            if(c.HasValue)
            {
                result = a + b + c.Value;
            }

            result = a + b + (c.HasValue ? c.Value : 0);

            result = a + b + c ?? 0;            // NULL DEFAULT OPERATOR
                                                //  if c == null, return 0
                                                //  if c != null, return c.Value

            return result;
        }

        static int AddArray(int[] arr)
        {
            int result = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }

        /// <summary>
        ///     Optional Parameter List (0 or more parameters)
        ///     NOTE: PASS BY VALUE only!!!!
        /// </summary>
        /// <param name="intArr"></param>
        /// <returns></returns>
        static int AddArray2(params int[] arr)
        {
            int result = 0;

            //if(arr != null )
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        result += arr[i];
            //    }
            //}

            for (int i = 0; i < arr?.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }
    }
}