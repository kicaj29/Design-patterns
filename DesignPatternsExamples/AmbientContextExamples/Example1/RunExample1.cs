using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmbientContextExamples.Example1
{
    public class RunExample1
    {
        public static void Run()
        {
            DisplayDebugInfo();
            Credentials.Instance = new SuperCredentials();
            DisplayDebugInfo();

            var t = new Task(() =>
                {
                    DisplayDebugInfo();
                }
            );
            t.Start();
            t.Wait();
        }

        private static void DisplayDebugInfo()
        {
            Console.WriteLine("Task {0} running on thread {1}",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Instance of ambient context {0}", Credentials.Instance.GetHashCode());
        }
    }
}
