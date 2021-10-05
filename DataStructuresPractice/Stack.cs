﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top != null)
            {
                node.nextNode = this.top;
            }
            else
            {
                node.nextNode = null;
            }
            this.top = node;
        }
        public void DisplayStack()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextNode;
            }
        }
    }
}
