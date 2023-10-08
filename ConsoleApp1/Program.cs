using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ConsoleApp1.DelegateExample;
using static ConsoleApp1.EventExample;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using delegates.
            DelegateExample example1 = new DelegateExample();
            example1.DelegateInstance();
            #endregion
            #region Using generics.
            GenericExample<int> Generic1 = new GenericExample<int>(5);
            ArrayList array1 = Generic1.listExample;
            Console.WriteLine(array1[0]);
            GenericExample<string> Generic2 = new GenericExample<string>("Second");
            ArrayList array2 = Generic2.listExample;
            Console.WriteLine(array2[0]);
            #endregion
            #region Using events
            VideoPlayer player = new VideoPlayer();
            User user = new User();
            user.Subscribe(player);
            player.PlayVideo("Sample Video");
            #endregion
            #region Using asynchronus
            AsynchronousExample Examp = new AsynchronousExample();
            Examp.MyAsyncMethod();
            Examp.MyAsyncMethod1();
            Examp.TaskRunFunction();
            #endregion
            #region 
            LinqExample linExample = new LinqExample();
            linExample.QueryFunction();
            #endregion
        }
    }
}