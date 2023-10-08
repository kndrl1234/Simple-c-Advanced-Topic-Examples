using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenericExample<T>
    {
        #region Using a non-generic ArrayList with float or string parameters will result in an error.
        public ArrayList listExample = new ArrayList();
        public GenericExample(T number)
        {
            listExample.Add(number);
            Console.WriteLine(listExample[0]);
        }
        #endregion
    }
}
