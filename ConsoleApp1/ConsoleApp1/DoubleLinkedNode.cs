namespace ConsoleApp1
{
    public class DoubleLinkedNode<T> : IDoubleLinkedList<T>, IDoubleLinkedListNode<T>
    {
        public DoubleLinkedNode<T> First { get; set; }
        public DoubleLinkedNode<T> Last { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }
        public int Count { get; set; }
        public T Value { get ; set; }

        public void AddFirst(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>();
            DoubleLinkedNode<T> temp = First;
            node.Value = value;
            First = node;
            First.Next = node;
            First.Next = temp;
            if (Count == 0)
            {
                Last = First;
            }
            else
            {
                temp.Prev = First;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>();
            node.Value = value;
            if (Count == 0)
            {
                First = node;
            }
            else
            {
                Last.Next = node;
                node.Prev = Last;
            }
            Last = node;
            Count++;
        }

        public void Reverse()
        {
            DoubleLinkedNode<T> temp;
            First = Last;
            First.Next = First.Prev;
            temp = First;
            for (int i = 0; i < Count-1; i++)
            {
                temp = temp.Next;
                First.Prev = temp.Next;
                temp.Next = temp.Prev;
                temp.Prev = First.Prev;

            }
            First.Prev = null;
            Last = temp;
        }
    }
}