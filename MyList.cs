using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectList
{
    class MyList<T> : IEnumerable
    {
        public int Length { get ; set; }

        T[] items;
        public MyList()
        {
            Length = 0;
            items = new T[100];
        }
        public MyList(int a)
        {
            Length = 0;
            items = new T[a];
        }
        public  void Add(T item)
        {
            if (Length == items.Length)
            {
                T[] b = new T[Length * 2];
                for (int k = 0; k < Length; k++)
                {
                    b[k] = items[k];
                }
                items = b;
                Console.WriteLine("Ky");
            }
            items[Length++]=item;
        }

        public void Insert(T item, int index)
        {
            if(Length==items.Length)
            {
                T[] b = new T[Length * 2];
                for(int k=0;k<Length;k++)
                {
                    b[k] = items[k];
                }
                items = b;
            }
            if (index > Length)
                throw new IndexOutOfRangeException("Индекс вне границ масссива");
            int i = Length + 1;
            for (; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = item;
            
            Length++;

        }

        public void Clear()
        {
            for(int i=0;i<items.Length;i++)
               {
                   items[i] = default(T);
               }
            
            Console.WriteLine("Коллекция очищена");
        }

        public void RemoveAt(int index)
        {
            if (index > Length)
                throw new IndexOutOfRangeException("Индекс вне границ масссива");
            int i = index;
            T b;
            for (; i <Length;i++)
            {
                b = items[i];
                items[i] = items[i + 1];
                items[i + 1] = b;
            }
            items[Length - 1] = default(T);
            Length--;
        }

        public void Remove(T item)
        {
            T b;
            for(int i=0;i<Length;i++)
            {
                if (items[i].Equals(item))
                {
                    b = items[i];
                    items[i] = items[i + 1];
                    items[i + 1] = b;

                }
            }
            items[Length - 1] = default(T);
            Length--;
        }

        public IEnumerator GetEnumerator()
        {
            T[] t = new T[Length];
            for (int i = 0; i < Length; i++)
                t[i] = items[i];
            return t.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
