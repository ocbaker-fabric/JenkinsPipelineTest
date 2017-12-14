using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsPipelineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a silly test application for the purpose of proving Jenkins");

            var service = new PipelineService();

            Console.WriteLine("The service says: " + service.GetGreeting());
            Console.WriteLine("Press Enter to Exit, Thanks for playing");
            Console.ReadLine();
        }
    }

    public class PipelineService
    {
        public string GetGreeting()
        {
            return "Hello";
        }

        public int AddNumbers(int i, int i1)
        {
            return i - i1;
        }
    }
}
