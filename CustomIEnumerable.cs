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
    internal class CustomIEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CustomIEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CustomIEnumerator();
        }
    }
}
