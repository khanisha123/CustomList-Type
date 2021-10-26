using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyListAddition myListAddition = new MyListAddition();
            //myListAddition.Id = 1;
            //myListAddition.Name = "Xemse";
            //MyList myList = new MyList(1000);
            //myList[100] = myListAddition;
            //Console.WriteLine(myList[100]);
            #region Count
            //List<int> list = new List<int>() {5,10,15,20,25,30};
            //int count = 0;
            //foreach (var item in list)
            //{
            //    for (int i = 0; i < item; i++)
            //    {
            //        if (item>0)
            //        {
            //            count++;

            //        }
            //        break;

            //    }
            //    Console.WriteLine(count);
            //}
            Count counter = new Count();
            Console.WriteLine("Numbers of Elements:{0}",counter.NuberOfElements);
            //Console.WriteLine(counter.ValidEntries());
            #endregion
            













        }
    }
}
