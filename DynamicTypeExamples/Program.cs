using Microsoft.CSharp.RuntimeBinder;
using System;

namespace DynamicTypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Comment out examples to try each one separately and see the result
                Examples.ExampleDynamicWithException();
                Examples.ExampleMissingMethodDefinitionException();
                Examples.ExampleReflection();
                Examples.ExampleDynamic();
                Examples.ExamplePrintCount(new int[20]);
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
