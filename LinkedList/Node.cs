using System;

namespace LinkedList
{
    public class Node
    {
        public Node()
        {
            
        }

        public Node(object item)
        {
            _item = item;
        }

        private object _item;
        private Node _next;

        public object SetItem(object item)
        {
            _item = item;
            return item;
        }

        public object GetItem()
        {
            return _item;
        }

        public void SetNext(Node next)
        {
            _next = next;
        }

        public Node GetNext()
        {
            return _next;
        }

    }
}
