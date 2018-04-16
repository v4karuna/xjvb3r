using System;
using System.Collections.Generic;

namespace CleverDevices.Answers
{
    /// <summary>
    /// Stack implementation using an underlying LinkedList
    /// </summary>
    /// <typeparam name="T">Element Type</typeparam>
    public class LinkedListStack<T>
    {
        private LinkedList<T> _linkedList;

        public LinkedListStack()
        {
            _linkedList = new LinkedList<T>();
        }

        /// <summary>
        /// Adds a data element to the top of the stack
        /// </summary>
        /// <param name="element">Element</param>
        public void Push(T element)
        {
            var node = new LinkedListNode<T>(element);
            _linkedList.AddFirst(node);
        }

        /// <summary>
        /// Removes a data element from the top of the stack
        /// </summary>
        /// <returns>Removed element value</returns>
        public T Pop()
        {
            if (_linkedList.Count == 0)
                throw new InvalidOperationException("No elements to pop.");

            var value = _linkedList.First.Value;
            _linkedList.RemoveFirst();

            return value;
        }

        /// <summary>
        /// Returns the total number of elements in the stack
        /// </summary>
        /// <returns>Count value</returns>
        public int Size()
        {
            return _linkedList.Count;
        }

        /// <summary>
        /// Returns true is the stack is empty
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsEmpty()
        {
            return (_linkedList.Count == 0);
        }
    }

}
