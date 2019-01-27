using DynamicTypeExamples.Factories;
using DynamicTypeExamples.Models;
using System;
using System.Collections;
using System.Reflection;

namespace DynamicTypeExamples
{
    public static class Examples
    {
        public static void ExampleDynamicWithException()
        {
            dynamic testVariable = 5;
            Console.WriteLine(testVariable.GetType());

            testVariable = "Hello World";
            Console.WriteLine(testVariable.GetType());
            Console.WriteLine(testVariable++);
        }

        public static void ExampleMissingMethodDefinitionException()
        {
            dynamic logger = LoggerFactory.GetLogger();
            logger.LogInfo("Hi");
            logger.LogWarning("You are about to enter a time warp");
            logger.LogError("System is malfunctioning");
            logger.LogTrace("Communication lost");
        }

        public static void ExampleReflection()
        {
            EmployeeFactory employeeFactory = GetEmployeeFactory();
            object firstEmployee = employeeFactory.GetFirstEmployee();
            Type firstEmployeeType = firstEmployee.GetType();
            object workStatusObject = firstEmployeeType.InvokeMember("GetWorkStatus", BindingFlags.InvokeMethod, null, firstEmployee, null);
            WorkStatus workStatus = Enum.Parse<WorkStatus>(workStatusObject.ToString());

            Console.WriteLine(workStatus);
        }

        public static void ExampleDynamic()
        {
            EmployeeFactory employeeFactory = GetEmployeeFactory();
            dynamic firstEmployee = employeeFactory.GetFirstEmployee();
            WorkStatus workStatus = firstEmployee.GetWorkStatus();

            Console.WriteLine(workStatus);
        }

        public static void ExamplePrintCount(ICollection collection)
        {
            dynamic dynamicCollection = collection;
            Console.WriteLine("Static typing: {0}", collection.Count);
            Console.WriteLine("Dynamic typing: {0}", dynamicCollection.Count);
        }

        private static EmployeeFactory GetEmployeeFactory()
        {
            var employeeFactory = new EmployeeFactory();
            employeeFactory.Add(new Employee { Id = "1", Name = "Johnny Depp" });

            return employeeFactory;
        }
    }
}