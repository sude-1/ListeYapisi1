using System;
using System.Collections.Generic;
using System.Text;

namespace ListeYapisi1
{
    class MyDictionary<MyKey,MyValue>
    {
        (MyKey, MyValue)[] list;
        public MyDictionary()
        {
            list = new (MyKey, MyValue)[0];
        }

        public void Add(MyKey CustomerNo,MyValue CustomerName)
        {
            (MyKey, MyValue)[] tempList = list;
            list = new (MyKey, MyValue)[list.Length + 1];
            for (int i = 0; i <tempList.Length; i++)
            {
                list[i] = tempList[i];
            }

            list[list.Length - 1] = (CustomerNo,CustomerName);
        }

        public int Count
        {
            get { return list.Length; }
        }

        public void Listing()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Müşteri numarası ve Müşteri adı:" + list[i]);
            }
        }
    }
}
