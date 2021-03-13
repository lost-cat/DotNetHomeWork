using System;

namespace HomeWork4_1
{
    public class GenericList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public GenericList()
        {
            _tail = _head = null;
        }

        public Node<T> Head => _head;

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (_head == null)
            {
                _head = _tail = node;
            }

            _tail.Next = node;
            _tail = node;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = _head;
            while (node != _tail && _head != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
    }
}