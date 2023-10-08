using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AsynchronousExample
    {
        public async Task Operation(string output)
        {
            Console.WriteLine(output);
        }
        public async Task MyAsyncMethod()
        {
            await Operation("Execution will be paused untill Operation() is done."); 
        }
        public async Task MyAsyncMethod1()
        {
            Task task1 = Operation("Will Execute when all of us done!");
            Task task2 = Operation("Will Execute when all of us done!");
            Task task3 = Operation("Will Execute when all of us done!");
            await Task.WhenAll(task1, task2, task3);
        }
        public void TaskRunFunction()
        {
            Task.Run(() => Operation("TaskRun"));
        }
    }
}
