using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryProject
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] dictionaryKey;
        TValue[] dictionaryValue;

        public MyDictionary()
        {
            dictionaryKey = new TKey[0];
            dictionaryValue = new TValue[0];
        }

        public int Count { get { return dictionaryKey.Length; } }

        public void Print(MyDictionary<TKey, TValue> myDictionary)
        {
            if (CheckIfDictionaryNull(myDictionary))
            {
                for (int i = 0; i < myDictionary.Count; i++)
                {
                    Console.WriteLine("Key: {0} , Value: {1} ",
                        myDictionary.dictionaryKey[i], myDictionary.dictionaryValue[i]);
                }
            }
        }

        public void Add(TKey key, TValue value)
        {

            if (CheckIfKeyExists(key) && CheckIfKeyNull(key))
            {
                TKey[] tempKey = dictionaryKey;
                TValue[] tempValue = dictionaryValue;

                dictionaryKey = new TKey[dictionaryKey.Length + 1];
                dictionaryValue = new TValue[dictionaryValue.Length + 1];

                for (int i = 0; i < tempKey.Length; i++)
                {
                    dictionaryKey[i] = tempKey[i];
                    dictionaryValue[i] = tempValue[i];
                }

                dictionaryKey[dictionaryKey.Length - 1] = key;
                dictionaryValue[dictionaryKey.Length - 1] = value;
            }
        }


        //Business Rules
        public bool CheckIfKeyExists(TKey key)
        {
            for (int i = 0; i < dictionaryKey.Length; i++)
            {
                if (dictionaryKey[i].ToString() == key.ToString())
                {
                    Console.WriteLine("Key is already exist.");
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfKeyNull(TKey key)
        {
            string keyString = key.ToString();

            if (keyString.Length == 0)
            {
                Console.WriteLine("Key can't be empty");
                return false;
            }
            return true;
        }

        public bool CheckIfDictionaryNull(MyDictionary<TKey, TValue> myDictionary)
        {
            if (myDictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty");
                return false;
            }
            return true;
        }


    }
}
