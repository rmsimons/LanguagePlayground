using System;
using System.Collections;

namespace CustomStack
{
    class MyStack
    {
        private Stack _stack = new Stack();

        public MyStack()
        {
            // Intentionally left blank
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot push null onto the stack.");
            }

            _stack.Push(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack");
            }

            return _stack.Pop();
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
