using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public interface IDoubleLinkedList<T>
    {
        DoubleLinkedNode<T> First { get; set; }
        DoubleLinkedNode<T> Last { get; set; }

        void Reverse();
        //insert new DoubleLinkedListNode with given value at the start of the list
        void AddFirst(T value);
        //insert new DoubleLinkedListNode with given value at the end of the list
        void AddLast(T value);
    }
}
