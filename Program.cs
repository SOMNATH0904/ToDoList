using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List Application!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1: To add a task to the list.");
                Console.WriteLine("Enter 2: To remove a task from the list.");
                Console.WriteLine("Enter 3: To view all tasks in the list.");
                Console.WriteLine("Enter e to exit the application.");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task you want to add:");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {taskList[i]}");

                    }
                    Console.WriteLine("Please enter the number of the task you want to remove:");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber - 1);

                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list: ");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting the application. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
            Console.WriteLine("Thank you for using the To-Do List Application!");
        }
    }
}