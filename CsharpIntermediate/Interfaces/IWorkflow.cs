using System.Collections.Generic;

namespace CsharpIntermediate.Interfaces
{
    public interface IWorkflow
    {
         void Add(ITask task);
         void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}