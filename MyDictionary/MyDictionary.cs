using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {
        T[] key;
        K[] value;
        T[] tempKey;
        K[] tempValue;

        public MyDictionary()
        {
            key = new T[0];
            value = new K[0];
            tempKey = new T[0];
            tempValue = new K[0];
        }

        public void Add(T item, K item2)
        {
            tempKey = key;
            tempValue = value;

            key = new T[key.Length + 1];
            value = new K[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }

            key[key.Length - 1] = item;
            value[value.Length - 1] = item2;
        }

        public int Count
        {
            get { return key.Length; }
        }

    }
}
