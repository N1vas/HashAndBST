using System;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] array = paragraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(array.Length);
            int key = 0;
            foreach (string word in array)
            {
                hash.Add(key, word);
                key++;
            }
            Frequency count = new Frequency();
            count.FrequencyData(hash);
        }
    }
}
