using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] key;
        TValue[] value;

        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }

        public void Add(TKey item1,TValue item2)
        {
            TKey[] temparrakey = key;
            TValue[] temparrayvalue = value;

            key = new TKey[key.Length + 1];
            value = new TValue[value.Length + 1];

            for (int i = 0; i < temparrakey.Length; i++)
            {
                key[i] = temparrakey[i];
                value[i] = temparrayvalue[i];
            }

            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;

            Console.WriteLine(item1 + " numaralı " + item2 + " adlı kullanıcı sisteme eklendi.");

        }


    }
}
