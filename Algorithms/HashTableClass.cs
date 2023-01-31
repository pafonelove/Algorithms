using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Демонстрация работы хеш-талицы. Время поиска, вставки и удаления элементов в хеш-таблице = 0(1) - постоянное, независимо от количества элементов.
namespace Algorithms
{
    internal class HashTableClass
    {
        Hashtable ht = new Hashtable();

        public HashTableClass(Hashtable ht)
        {
            this.ht = ht;
        }

        // Вставка элеентов в хеш-таблицу.
        public void Push(string key, string value)
        {
            ht[key] = value;
        }
        
        // Проверка количества элементов в хеш-таблице.
        public int CheckCount()
        {
            return ht.Count;
        }

        // Просмотр содержимого хеш-таблицы.
        public void ShowHashTable()
        {
            ICollection c = ht.Keys;
            foreach (string key in c)
            {
                Console.WriteLine($"{key}: {ht[key]}");
            }
        }
    }
}
