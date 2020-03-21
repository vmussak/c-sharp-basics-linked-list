using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SimpleLinkedList
    {
        private Node _head;
        public SimpleLinkedList()
        {
            _head = new Node();
        }

        public bool IsEmpty()
        {
            return _head.GetItem() == null;
        }

        public int Size()
        {
            if (IsEmpty()) return 0;
            
            Node currentNode = _head;
            int size = 1;

            while (currentNode.GetNext() != null)
            {
                currentNode = currentNode.GetNext();
                size++;
            }

            return size;
        }

        public void Add(object item)
        {
            if (IsEmpty())
            {
                _head.SetItem(item);
                return;
            }

            Node last = _head;
            while (last.GetNext() != null)
                last = last.GetNext();

            last.SetNext(new Node(item));
        }

        public void Remove(object item)
        {
            if (IsEmpty())
                throw new Exception("A lista está vazia");

            if (_head.GetItem().Equals(item))
            {
                _head = _head.GetNext();
                return;
            }

            Node prev = null;
            Node temp = _head;
            while (temp.GetNext() != null && !temp.GetItem().Equals(item))
            {
                prev = temp;
                temp = temp.GetNext();
            }

            if(temp == null)
                throw new Exception("Item não existe na lista");

            prev.SetNext(temp.GetNext());
        }

        public Node Get(object item)
        {
            return Find(item);
        }

        public void RemoveAll()
        {
            _head = new Node();
        }

        private Node Find(object item)
        {
            Node nodeItem = null;
            Node last = _head;
            while (last.GetNext() != null)
            {
                if (last.GetItem().Equals(item))
                {
                    nodeItem = last;
                    break;
                }

                last = last.GetNext();
            }

            if(nodeItem == null)
                throw new Exception("O item informado não existe na lista");

            return nodeItem;
        }
    }
}
