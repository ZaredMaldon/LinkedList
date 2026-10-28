using System;
using System.Collections.Generic;
using linked_list_1;

class Program
{
    static MyLinkedList list = new MyLinkedList();

    static void Main()
    {
        Console.WriteLine("Enter your choice:");
        Console.WriteLine("1. Add First");
        Console.WriteLine("2. Add Last");
        Console.WriteLine("3. Add At Position");
        Console.WriteLine("4. Remove");
        Console.WriteLine("5. Edit");
        Console.WriteLine("6. Print List");
        Console.WriteLine("7. Exit");
        string input = Console.ReadLine();
        if(!int.TryParse(input, out int choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Main();
            return;
        }

        switch(choice)
        {
            case 1:
                Console.WriteLine("Enter value to add at the beginning:");
                int val;
                if(!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                list.AddFirst(val);
                list.PrintList();
                break;
            case 2:
                Console.WriteLine("Enter value to add at the end:");
                if(!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                list.AddLast(val);
                list.PrintList();
                break;
            case 3:
                Console.WriteLine("Enter value to add:");
                if(!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                Console.WriteLine("Enter position:");
                if(!int.TryParse(Console.ReadLine(), out int position))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                list.AddAtPosition(val, position);
                list.PrintList();
                break;
            case 4:
                Console.WriteLine("Enter value to remove:");
                if(!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                list.Remove(val);
                list.PrintList();
                break;
            case 5:
                Console.WriteLine("Enter new value:");
                if(!int.TryParse(Console.ReadLine(), out int newVal))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                Console.WriteLine("Enter value to edit:");
                if(!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Main();
                    return;
                }
                list.Edit(newVal, val);
                list.PrintList(); 
                break;
            case 6:
                list.PrintList();
                break;
            case 7:
                Environment.Exit(0);
                break;
        }
        Main(); // Loop back to the menu after an action is performed
    }
    
}