using System;

namespace CsharpIntermediate.Interfaces
{
    public class WorkflowEngine 
    {       
         public void Run(IWorkflow workflow){

          foreach(ITask I in workflow.GetTasks())
                {
                if (I==null)
                    throw new ArgumentException("Activities cannot be null.");
                        
                I.Execute();


                }
        }

        
    }
}