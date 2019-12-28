﻿using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
