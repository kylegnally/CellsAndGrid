using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsAndGrid
{
    class GenericQueue<T> : IGenericQueue<T>
    {
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        /// <summary>
        /// Internal class that provides two nodes to the linked list in the GenericQueue class. 
        /// </summary>
        protected Node head;
        protected Node tail;
        protected int size = 0;

        // return null if the queue is empty
        public bool IsEmpty => head == null;

        // size property
        public int Size => size;

        /// <summary>
        /// Method to enqueue an item of generic type Data onto the queue
        /// </summary>
        /// <param name="Data"></param>
        public void Enqueue(T Data)
        {

            // give Node oldTail the same data as the tail of the queue
            Node oldTail = tail;

            // make a new Node called tail
            tail = new Node();

            // set the Data property of the new tail node equal to the Data passed into Enqueue()
            tail.Data = Data;

            // set the Next property of the tail of the queue to null
            tail.Next = null;

            // if the queue is empty, set head equal to tail
            if (IsEmpty)
            {
                head = tail;
            }

            // otherwise set the Next property of oldTail equal to tail
            else
            {
                oldTail.Next = tail;
            }

            size++;
        }

        /// <summary>
        /// Method to dequeue an item of generic type off of queue
        /// </summary>
        /// <returns>T</returns>
        public T Dequeue()
        {
            // if the queue is empty, burp
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            // set the generic returnData equal to the Data property of the head of the queue
            T returnData = head.Data;

            // set the head equal to the next item in the queue
            head = head.Next;

            // size down!
            size--;

            // if it's empty, set the tail equal to null
            if (IsEmpty)
            {
                tail = null;
            }

            // give us the data we just dequeued
            return returnData;
        }
    }
}
