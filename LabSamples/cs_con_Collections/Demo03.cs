using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Collections
{
    /// <summary>
    ///     Dictionary
    /// </summary>
    internal class Demo03
    {
        public static void RunThis()
        {
            System.Collections.Generic.Dictionary<short, string> myKeyValuePairs
                = new Dictionary<short, string>();

            myKeyValuePairs.Add(1, "My first variable");
            myKeyValuePairs.Add(2, "My second variable");
            myKeyValuePairs.Add(3, "My third variable");

            try
            {
                myKeyValuePairs.Add(1, "My first variable");
            }
            catch(System.ArgumentException exp)
            {
                Console.WriteLine("Type: {0}", exp.GetType());
                Console.WriteLine("Message: {0}", exp.Message);
                Console.WriteLine("Source: {0}", exp.Source);           // assembly name/module name
                Console.WriteLine("TargetSite: {0}", exp.TargetSite);   // method signature
                Console.WriteLine("StackTrace: {0}", exp.StackTrace);   // call stack
                Console.WriteLine("DATA: {0}", exp.Data);
                for(int i = 0; i < exp.Data.Count; i++)
                {
                    Console.WriteLine("{0}", exp.Data[0]);
                }
            }

            catch ( System.Exception exp )
            {
                Console.WriteLine("---- Failed!");
                Console.WriteLine("Type: {0}", exp.GetType());
                Console.WriteLine("Message: {0}", exp.Message);
                Console.WriteLine("Source: {0}", exp.Source);           // assembly name/module name
                Console.WriteLine("TargetSite: {0}", exp.TargetSite);   // method signature
                Console.WriteLine("StackTrace: {0}", exp.StackTrace);   // call stack
            }

            Console.WriteLine();

            bool success = myKeyValuePairs.TryAdd(1, "My first variable");
            if(success)
            {
                Console.WriteLine("added successfully!");
            }
            else
            {
                Console.WriteLine("could not add the new entry");
            }


            for (short i = 1; i < myKeyValuePairs.Count-1; i++)
            {
                Console.WriteLine(myKeyValuePairs[i].GetType());        // string
                Console.WriteLine(myKeyValuePairs[i]);
            }

            object oKeys = myKeyValuePairs.Keys;
            object oValues = myKeyValuePairs.Values;

            foreach(var item in myKeyValuePairs)
            {
                Console.Write("{0} : {1}", item.Key, item.Value);
            }

        }
    }
}
