using System;
using System.Collections.Generic;
using System.Text;
namespace HashTable
{
    class Frequency
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        public void FrequencyData(MyMapNode<int,string> data)
        {
            for (int key = 0; key < data.size; key++)
            {
                frequency.TryAdd(data.Get(key).ToLower(), 0);
                frequency[data.Get(key).ToLower()]++;
            }
            foreach (KeyValuePair<string, int> item in frequency)
            {
                Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
            }
        }
        public void Remove(MyMapNode<int, string> hash, string word)
        {
            for (int key = 0; key < hash.size; key++)
            {
                if (hash.Get(key).Equals(word))
                {
                    hash.Remove(key);
                    Console.WriteLine($"Removed {word} from paragraph");
                }
            }
        }
    }
}
