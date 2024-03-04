using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYC3Opdracht3
{
    internal interface IMyList<T> : IEnumerable<T>
    {
        void Clear();
        void Add(T element);
        int IndexOf(T element);
        bool Contains(T element);
        void Insert(int index, T element);
        void Remove(T element);
        void RemoveAt(int index);
        T this[int index] { get; set; }
        int Count();
    }
}
