namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SimpleLinkedList();
            linkedList.Add(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            linkedList.Remove(2);

            var a = linkedList.Get(1);

        }
    }
}