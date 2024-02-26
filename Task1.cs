using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3
{
    /*Используя стек инвертируйте порядок следования элементов в спиcке
Пример списка 
List<int> ints = new List<int> {1,2,3,4,5};
Пример результата
{5,4,3,2,1}*/
    internal class Task1
    {
        

        public static List<int> ReverseList (List<int> list)
        {
        Stack<int> stack = new Stack<int>();
            //  Stack<int> stack = new(); другой варинат иниициализации 
            foreach (var item in stack)
            {
                stack.Push(item);
            }
            List<int> newInts = new();
            while (stack.Count > 0)
            {
                newInts.Add(stack.Pop());
            }
            return newInts;
        }
    }
}
