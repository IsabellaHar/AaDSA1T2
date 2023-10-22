using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public class Node  //Task 2.1
    {
        public int value;
        public Node? nextNode;


        public Node(int _value)  //constructor
        {
            value = _value;
            nextNode = null;
        }

    } //end node class
}
