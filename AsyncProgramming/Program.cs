using System;

namespace AsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new AsyncService();
            service.DoSomeWorkInServiceTask();

            Console.ReadLine();
        }
    }
}
