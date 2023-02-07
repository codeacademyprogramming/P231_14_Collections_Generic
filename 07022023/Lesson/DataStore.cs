using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class DataStore<TKey,TValue>
    {
        public KeyValuePair<TKey,TValue>[] Items = new KeyValuePair<TKey, TValue>[0];

        public void Add(TKey key, TValue value)
        {
            var pair = new KeyValuePair<TKey, TValue> { Key = key, Value = value };
            Array.Resize(ref Items, Items.Length + 1);
            Items[Items.Length - 1] = pair;
        }

        public TValue GetValue(TKey key)
        {
            foreach (var item in Items)
            {
                if(item.Key.Equals(key))
                    return item.Value;
            }
            throw new Exception("Item not found");
        }
    }
}
