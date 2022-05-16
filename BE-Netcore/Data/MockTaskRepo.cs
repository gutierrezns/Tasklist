using BE_Netcore.Models;
using System.Collections.Generic;

namespace BE_Netcore.Data
{
    public class MockTaskRepo : ITaskRepo
    {
        public void CreateTask(Task task)
        {
            throw new System.NotImplementedException();
        }

        public Task GetTask(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Task> GetTasks()
        {
            var tasks = new List<Task>
            {
                new Task{ Id = 1, Title = "titulo uno"},
                new Task{ Id = 2, Title = "titulo dos"}
            };
            return tasks;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
