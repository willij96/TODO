using System;
using System.Collections.Generic;
using System.Text;

namespace TODO.Domain
{
    class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime? dueDate { get; set; }

        public DateTime? Completed { get; set; }

        public bool isCompleted
        {
            get
            {
                return Completed != null;
            }
        }
      

        public Task(int id, string title, DateTime dueDate)
        {
            Id = id;
            Title = title;
            this.dueDate = dueDate;
        }
    }
}
