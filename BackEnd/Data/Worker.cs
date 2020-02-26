namespace BackEnd.Data
{
    using System.Collections.Generic;

    public class Worker : WorkflowDTO.Worker
    {
        public ICollection<CurrentWorker> CurrentWorkers { get; set; }
    }
}
