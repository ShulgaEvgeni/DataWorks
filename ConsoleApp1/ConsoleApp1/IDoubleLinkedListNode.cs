using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        DoubleLinkedNode<T> Next { get; set; }
        DoubleLinkedNode<T> Prev { get; set; }

    }
}
