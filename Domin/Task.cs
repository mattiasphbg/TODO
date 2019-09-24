using System;

namespace TODO.Domin
{
    class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        

        public DateTime? DueDate { get; set; }


        public DateTime? Completed { get; set; }

        public bool IsCompleted { get; set; }


        public Task(int id , string title, DateTime dueDate)
        {

            id = id;
            Title = title;
            DueDate = dueDate;

        }

        

    }
}
