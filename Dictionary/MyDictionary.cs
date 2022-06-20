using System;

namespace MakeDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            if (CheckIfKeyExit(key))
            {
                //Aynı key var ise hata verdikdik
                throw new Exception(key + " already exists.");
            }

            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        //Dictionary key benzersiz olduğu için aynı key girilip girilmediğini check ettik
        public bool CheckIfKeyExit(TKey key)
        {
            foreach (TKey item in keys)
            {
                if (item.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowDictionary()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
        }
    }

}
