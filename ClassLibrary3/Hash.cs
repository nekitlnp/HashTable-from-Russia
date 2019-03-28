using System;

namespace Hash
{
    public class Element
    {
        public object Key { get; private set; }
        public object Value { get; private set; }

        public Element (object key, object value)
        {
            Key = key;
            Value = value;
            if (Key is null)
            {
                throw new ArgumentNullException (nameof (key));
            }

            if (Value is null)
            {
                throw new ArgumentNullException (nameof (value));
            }
        }
    }
    class HashTable
    {
        readonly int Size;
        readonly Element[] array;
       
        public HashTable (int size)
        {
            array = new Element[size];
            Size = size;
        }

        public void PutPair (object key, object value)
        {
            var hash = Math.Abs(key.GetHashCode());
            var indexof = hash % Size;  
            for (; array[indexof] != null; indexof = (indexof + 1) % Size)
                if (array[indexof].Key.Equals(key))
                    break;
            array[indexof] = new Element(key, value);
        }

        public object GetValueByKey (object key)
        {
            foreach (var e in array)
            {
                if (e.Key.Equals(key))
                    return e.Value;
            }
            return null;
        }
    }
}