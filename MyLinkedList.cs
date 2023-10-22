using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    //Task 2.2
    //"MyLinkedList" to differenitate from C# Standard Library LinkedList class
  

    public class MyLinkedlist   
    {
        Node? head;
        int count { get; set; }

        public MyLinkedlist() //constructor
        {
            head = null;
            count = 0;
        } //end constructor



        //METHOD TO WORK WITH THE START OF THE LINKED LIST


        public void addFirst(int value)
        //method to add a node at the start of the linked list
        {
            Node newNode = new Node(value);
            newNode.nextNode = head;   //the new node points to the current head node
            head = newNode; //the new node becomes the new head node
            count++;
        } //end addFirst method


        public void addAllFirst(List<int> numberList)   
        //This method takes the numbers from the supplied list and puts them in the linked list
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                addFirst(numberList[i]);  //uses the above method to add nodes at the start
            }
        } //end addAllFirst

        public void removeFirst()
        //This method removes a node from the start of the list
        {
            if (head != null)
            {
                head = head.nextNode; //2nd nodes becomes the head node
            }
            count--;
            //relies on C# garbage collector to make the previous node's memory space avaiable again

        } //end removeFirst method


        public void removeAllFirst()
        //This method deleted all nodes in the linked list from first to last
        {
            for (int i = 0; i < count; i++)  //for the number of nodes in the list
            {
                removeFirst();  //uses above method to delete the first node
            }
        } //end removeAllFirst



        //METHODS TO WORK WITH THE END OF THE LINKED LIST

        public void addLast(int value)
        //This method puts the supplied value in a node at the end of the linked list 
        {
            Node newNode = new Node(value);  //put the value in a node

            if (head == null)  //if the linked list is empty
            {
                head = newNode;  //then the new node becomes the head node
            }
            else
            {
                Node? current = head;  //point of the head of the list

                while (current.nextNode != null)  //if there are more nodes
                {
                    current = current.nextNode; //point to the next node
                }
                //if here, then current points to the last node
                current.nextNode = newNode; //have the last node point to the new node
                //the new node is now the last node in the linked list.
            }
            count++;
        } //end addLast method


        public void addAllLast(List<int> numberList)
        //This method takes the numbers from a supplied list and put them in the linked list
        //Nodes are added at the end of the linked list
        {
            for (int i = 0; i < numberList.Count; i++)  //cycles through each number in the list
            {
                addLast(numberList[i]);  //uses the above method to add the number at the end
            }
        } //end addAllLast


        public void removeLast()
        //This method removes the last node of a linked list
        {

            if (head != null)  //check there are nodes in the list
            {
                Node? current = head;  //current points to the first node
                Node? previous = null; //previous will keep track of the node before the current node
                for (int i = 0; i < count; i++)
                {
                    previous = current;  //the current node becomes the previous node
                    current = current.nextNode; //the next node becomes the current node
                }
                //when we get here, current points to the last node in the list and previous points to the 2nd last node
                previous.nextNode = null; //2nd last node is now the last node as it points to nothing
                count--;
            }

        } //end addAllLst method


        public void removeAllLast()
        //This method removes all nodes in the linked list from last to first
        {
            for (int i = 0; i < count; i++)  //for the number of nodes in the list
            {
                removeLast();  //use the above method to remove the last node
            }
        } //end removeAllLast method



    } //end linkedlist class
}
