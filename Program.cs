using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;


//replit AaDSA1T2
//https://replit.com/@isabellaebbitt/AaDSA1T2#main.cs

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int numOfNumbers = 50000; //put the number of random numbers needed in a constant
            Console.WriteLine();
            Console.WriteLine("WORKING WITH LINKED LISTS");
            Console.WriteLine();

            //Task 2.3
            MyLinkedlist linkedList1 = new MyLinkedlist();
            MyLinkedlist linkedList2 = new MyLinkedlist();

            //Task 2.4
            //First generate the random numbers and store them
            //It may seem odd to put them in a List before putting them in a Linked List
            //This is so when we measure the time to put the numbers in the Linked List
            //we are not also measuring the time to generate the numbers.

            Random rand = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < numOfNumbers; i++)
            {
                randomNumbers.Add(rand.Next(0, numOfNumbers));
            }

            //Set up the stop watch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Put the random numbers in the linkedlist by adding nodes at the start of the linked list
            linkedList1.addAllFirst(randomNumbers);  


            //Check the time it took
            stopwatch.Stop();
            double addFirstTime = stopwatch.ElapsedMilliseconds;
            string formattedAddFirstTime = addFirstTime.ToString("#,##0");
            Console.WriteLine("Inserting 50,000 random numbers at the start of a linked list took " + formattedAddFirstTime + " milliseconds.");
            Console.WriteLine();


            //Task 2.5
            //Using the same list of random numbers
            //Reset and start the stop watch
            stopwatch.Reset();
            stopwatch.Start();

            //Put the random numbers in the linkedlist by adding nodes at the end of the linked list
            linkedList2.addAllLast(randomNumbers);  


            //Check the time it took
            stopwatch.Stop();
            double addLastTime = stopwatch.ElapsedMilliseconds;
            string formattedTime = addLastTime.ToString("#,##0");
            Console.WriteLine("Inserting 50,000 random numbers at the end of a linked list took " + formattedTime + " milliseconds.");
            Console.WriteLine();

            //Task 2.6 - Which is more efficient for adding numbers?
            if (addFirstTime < addLastTime)
            {
                double timeSaved = addLastTime - addFirstTime;
                string formattedTimeSaved = timeSaved.ToString("#,##0");
                double timeRatio = addLastTime / addFirstTime;
                string formattedTimeRatio = timeRatio.ToString("N2");
                Console.WriteLine("Adding nodes to the start of the linked list:");
                Console.WriteLine("* took " + formattedTimeSaved + " milliseconds less; or");
                Console.WriteLine("* was " + formattedTimeRatio + " times faster;");
                Console.WriteLine("than adding the node at the end of the linked list");
                Console.WriteLine("Adding nodes to the start of a linked list is more efficient than adding them to the end.");
                Console.WriteLine();
            }
            else //just in case, as this may come up if you have a very small number of nodes
            {
                double timeSaved = addFirstTime - addLastTime;
                string formattedTimeSaved = timeSaved.ToString("#,##0");
                double timeRatio = addFirstTime / addLastTime;
                string formattedTimeRatio = timeRatio.ToString("N2");
                Console.WriteLine("Adding nodes to the end of the linked list:");
                Console.WriteLine("* took " + formattedTimeSaved + " milliseconds less; or");
                Console.WriteLine("* was " + formattedTimeRatio + " times faster;");
                Console.WriteLine("than adding the node at the start of the linked list");
                Console.WriteLine("Adding nodes to the end of a linked list is more efficient than adding them to the end, in this case.");
                Console.WriteLine();

            }


            //Task 2.7 Delete all Nodes starting from the front of linkedList1

            //Set up the stop watch
            
            stopwatch.Reset();
            stopwatch.Start();

            //Delete the nodes in the list from first to last
            linkedList1.removeAllFirst(); 


            //Check the time it took
            stopwatch.Stop();
            double removeFirstTimeMic = stopwatch.ElapsedTicks;  //don't know why it gives 0 if I use ElapsedMilliseconds
            double removeFirstTimeMil = removeFirstTimeMic / 1000;   
            string formattedRemoveFirstTimeMil = removeFirstTimeMil.ToString("#,##0");
            Console.WriteLine("Deleting 50,000 random numbers, each from the start of a linked list took " + formattedRemoveFirstTimeMil + " milliseconds.");
            Console.WriteLine();

            
            //Task 2.8 Delete all Nodes in linkedList2 starting from the end

            //Set up the stop watch

            stopwatch.Reset();
            stopwatch.Start();

            //Delete the nodes in the list from last to first
            linkedList2.removeAllLast(); 


            //Check the time it took
            stopwatch.Stop();
            double removeLastTime = stopwatch.ElapsedMilliseconds;
            string formattedRemoveLastTime = removeLastTime.ToString("#,##0");
            Console.WriteLine("Deleting 50,000 random numbers, each from the end of a linked list took " + formattedRemoveLastTime + " milliseconds.");



            //Task 2.9 Compare which is more efficient to delete nodes
            if (removeFirstTimeMil < removeLastTime)
            {
                double timeSaved = removeLastTime - removeFirstTimeMil;
                string formattedTimeSaved = timeSaved.ToString("#,##0");
                double timeRatio =  removeLastTime / removeFirstTimeMil;
                 string formattedTimeRatio = timeRatio.ToString("N2");
                Console.WriteLine("Deleting nodes from the start of the linked list:");
                Console.WriteLine("* took " + formattedTimeSaved + " milliseconds less; or");
                Console.WriteLine("* was " + formattedTimeRatio + " times faster;");
                Console.WriteLine("than deleting the nodes from the end of the linked list");
                Console.WriteLine("Deleting nodes to the start of a linked list is more efficient than deleting them from the end.");
                Console.WriteLine();
            }
            else //just in case, as this may come up if you have a small number of nodes
            {
                double timeSaved =  removeFirstTimeMil - removeLastTime;
                string formattedTimeSaved = timeSaved.ToString("#,##0");
                double timeRatio =   removeFirstTimeMil / removeLastTime;
                string formattedTimeRatio = timeRatio.ToString("N2");
                Console.WriteLine("Deleting nodes from the end of the linked list:");
                Console.WriteLine("* took " + formattedTimeSaved + " milliseconds less; or");
                Console.WriteLine("* was " + formattedTimeRatio + " times faster;");
                Console.WriteLine("than deleting the node from the start of the linked list");
                Console.WriteLine("Deleting nodes to the end of a linked list is more efficient than adding them to the end, in this case.");
                Console.WriteLine();

            }



        } //end Main
    } //end Program
} //end namespace