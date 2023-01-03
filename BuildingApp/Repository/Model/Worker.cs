public class Worker
{
    public int WorkerId { get; set; }
    public string WorkerName { get; set; }

    public List<WorkerTask> WorkerTasks { get; set; }

    //public Worker(string workerName, List<WorkerTask> WorkerTasks)
    //{
    //    this.WorkerName = workerName;
    //    this.WorkerTasks = WorkerTasks;
    //}

    //public void AddTask(WorkerTask workerTask)
    //{
    //    WorkerTasks.Add(workerTask);
    //}
}