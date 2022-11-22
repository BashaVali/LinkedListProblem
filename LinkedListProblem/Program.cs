﻿using LinkedListProblem;
using System;
using System.Collections.Generic;

namespace LinkedListStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\nLinked List Problem " + "\n\n");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.CreateLinkedList\n" +
                                  "2.LinkedListReverseOrder" + "\n" +
                                  "3.InsertAtParticuarPosition"+"\n"+
                                  "4.RemoveFirstNode"+"\n"+
                                  "5.RemoveLastNode"+"\n"+
                                  "6.SearchNode"+"\n"+
                                  "7.SearchAndInsert"+"\n"+
                                  "8.Exit" + "\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {    
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.LinkedListReverseOrder(70);
                        linkedList.LinkedListReverseOrder(30);
                        linkedList.LinkedListReverseOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertAtParticuarPosition(1, 30);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        linkedList.Display();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Search(56);
                        break;
                    case 7:

                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Insert(30, 40);
                        linkedList.Display();
                        break;

                    case 8:
                        flag = false;
                        break;
               
                }

            }
        }
    }
}
