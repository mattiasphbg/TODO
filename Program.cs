using System;
using static System.Console;
using TODO.Domin;

namespace TODO
{
    class Program
    {
        static Task[] taskList = new Task[100];


        static void Main(string[] args)
        {
            bool shouldExitTodo = false;
            int taskIdCounter = 1;


            while (!shouldExitTodo)
            {

                Console.WriteLine("1. Add todo");
                Console.WriteLine("2. List todo");
                Console.WriteLine("3. Exit");

                ConsoleKeyInfo pressedKey = ReadKey(true);

                Clear();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                        Write("Title: ");
                        string todoTitle = ReadLine();

                        Write("Due date: (yyyy-mm-dd hh:mm):");

                        DateTime dueDate = DateTime.Parse(ReadLine());

                        Task taskUser = new Task(taskIdCounter++, todoTitle, dueDate);

                        taskList[GetIndexPosition()] = taskUser;
                        
                        break;

                    case ConsoleKey.D2:

                        WriteLine("ID  Title   Due date      Completed ");
                        WriteLine("------------------------------------");

                        foreach (var task in taskList)
                        {
                            if (task == null) continue;
                            WriteLine($"{task.Id} {task.Title} {task.DueDate.ToString().PadLeft(25, ' ')}");
                        }


                        break;
                    case ConsoleKey.D3:
                        shouldExitTodo = true;
                        break;
                }


            }



        }

        static int GetIndexPosition()
        {
            int result = -1;
            for (int i = 0; i < taskList.Length; i++)
            {
                if (taskList[i] != null)
                {
                    continue;
                }
                if (taskList[i] == null)
                {
                    result = i;
                    break;
                }
                if (result == -1)
                {
                    throw new Exception("No avalible position");
                }
            }
            return result;
        }


    }
}
