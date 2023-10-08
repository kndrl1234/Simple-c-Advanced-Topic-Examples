using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class DelegateExample
    {
        // Delegate field
        public delegate void LogDel();
        // Create delegate instance taking ShowIt function
        public LogDel DelegateInstance = new LogDel(ShowIt);
        // Simple function 
        public static void ShowIt()
        {
            Console.WriteLine("Please enter your name:");
            string text = Console.ReadLine();
            Console.WriteLine(text);
        }
        #region
        public delegate T Transformer<T>(T arg);

        int[] values = { 1, 2, 3 };
        #endregion
    }

}
