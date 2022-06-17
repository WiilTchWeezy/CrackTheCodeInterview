using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyHashTable
    {
        const int INITIAL_SIZE = 16;
        private HashEntry[] hashes = new HashEntry[INITIAL_SIZE];

        public void Add(string key, string value)
        {
            int hash = GetHash(key);
            HashEntry hashEntry = new HashEntry(key, value);
            if (hashes[hash] == null)
                hashes[hash] = hashEntry;
            else
            {
                HashEntry temp = hashes[hash];
                if (key.Equals(temp.Key))
                    return;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = hashEntry;
            }
        }

        public string GetValueByKey(string key)
        {
            int hash = GetHash(key);
            if (hashes[hash] != null)
            {
                HashEntry temp = hashes[hash];
                while (!temp.Key.Equals(key) && temp.Next != null)
                {
                    temp = temp.Next;
                }
                return temp.Value;
            }
            return null;
        }

        private int GetHash(string key)
        {
            int hashCode = key.GetHashCode();
            if (hashCode < 0)
                hashCode = hashCode * -1;
            return hashCode % INITIAL_SIZE;
        }
    }

    public class HashEntry
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public HashEntry Next;

        public HashEntry(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return $"[{this.Key}, {this.Value}]";
        }
    }
}
