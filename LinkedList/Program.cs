using System;

namespace LinkedList
{
    class XLinkedList
    {
        public class Item
        {
            public int value;
            public Item next;

            public Item(int value)
            {
                this.value = value;
            }
        }
        private Item head;
        public Item GetHead()
        {
            return head;
        }

        public void Add(int value)
        {
            Item item = new Item(value);
            if (head == null)
            {
                head = item;
            }
            else
            {
                Item current = head;
                while (current.next!=null)
                {
                    current = current.next;
                }
                current.next = item;
            }
        }

        public Boolean Contains(int value)
        {
            Item current = head;
            while (current!= null)
            {
                if (current.value == value) return true;
                current = current.next;
            }
            return false;
        }

        public void Remove(int value)
        {
            Item curr = head;
            Item prev = null;
            while (curr!= null)
            {
                if (curr.value == value)
                {
                    if (prev == null)
                    {
                        head = head.next;
                        break;
                    }
                    prev.next = curr.next;
                    break;
                }
                prev = curr;
                curr = curr.next;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                XLinkedList ll = new XLinkedList();
                ll.Add(11);
                ll.Add(22);
                ll.Add(33);
                ll.Add(44);
                ll.Remove(33);
                bool found22 = ll.Contains(22);
                bool found33 = ll.Contains(33);
                bool found42 = ll.Contains(42);
                Console.WriteLine(found22);
                Console.WriteLine(found33); 
                Console.WriteLine(found42);
            }
        }
    }
}

