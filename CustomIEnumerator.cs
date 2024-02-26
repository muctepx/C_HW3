using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3
{/*
  * Реализуйте класс с поддержкой IEnumerable<int> - CustomEnumerale который в случае использования его в следующем коде 
foreach (var x in new CustomEmumerable())
        {
            Console.WriteLine(x);
        }
Выведет на экран значения от 0 до 10. 
Подумайте, возможно вам придется реализовать не только IEnumerable но и IEnumerator*/
    internal class CustomIEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = -1;

        object IEnumerator.Current => 0;

       public void Dispose()
       {
           Current = 0;
        }

        public bool MoveNext()
        {
            
            if (Current < 10)
            {
                Current++;
                return true;
            }

                return false;


        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
