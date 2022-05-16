using BE_Netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BE_Netcore.Data
{
    public class TaskRepository : ITaskRepo
    {
        private readonly TaskContext _context;

        public TaskRepository(TaskContext context)
        {
            _context = context;
        }

        public void CreateTask(Task task)
        {
            if(task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _context.Task.Add(task);
        }

        public Task GetTask(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Task> GetTasks()
        {
            return _context.Task.ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
