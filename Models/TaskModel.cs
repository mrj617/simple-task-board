using System;

namespace simple_task_website.Models
{
    public class TaskModel
    {
        public string UserTask {get; set;}
        public DateTime UserCreatedTaskDate { get; set; }
        public bool LengthOfTask { get; set; }
        public bool TaskStatus { get; set; }
    }
}