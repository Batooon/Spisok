using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisok
{
    class SList
    {
        Node head;
        Node tail;
        int Length;
        public SList()
        {
            Length = 0;
            head = null;
            tail = head;
        }
        public void Push(int value)
        {
            if (head == null)
            {
                head = new Node();
                head.data = value;
                tail = head;
                head.SetNextNode(null);
            }
            else
            {
                Node newNode = new Node();
                tail.SetNextNode(newNode);
                tail = newNode;
                tail.data = value;
                tail.SetNextNode(null);
            }
            Length++;
        }
        public void Pop()
        {

        }
        public int Spisoklength()
        {
            return Length;
        }
    }
}
