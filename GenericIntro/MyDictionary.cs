using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    public class MyDictionary<T>
    {

        T [] items;

        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] arraytemp = items;

            items = new T[items.Length + 1];
            for (int i = 0; i < arraytemp.Length; i++)
            {
                items[i] = arraytemp[i];
            }
            

        }


    }
}
