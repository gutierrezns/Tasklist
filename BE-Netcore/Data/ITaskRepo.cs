using BE_Netcore.Models;
using System.Collections.Generic;

namespace BE_Netcore.Data
{
    public interface ITaskRepo
    {
        bool SaveChanges();
        void CreateTask(Task task);
        Task GetTask(int id);
        IEnumerable<Task> GetTasks();
        void UpdateTask(Task task);
    }
}
    