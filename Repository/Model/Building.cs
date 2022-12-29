public class Building
{
    public List<Worker> Workers { get; set; }

    public Building(List<Worker> workers)
    {
        this.Workers = workers;
    }

    public void SetUpDailyWork()
    {
        List<Thread> threads = new List<Thread>();

        Console.WriteLine("buen dia gente");

        foreach (var worker in Workers)
        {
            threads.Add(new Thread(() =>
            {
                for (int i = 0; i < worker.WorkerTasks.Count; i++)
                {
                    Console.WriteLine(worker.WorkerName + " Empezo la tarea: " + worker.WorkerTasks[i].Description + " En El piso: " + worker.WorkerTasks[i].FloorNumber);

                    Thread.Sleep(worker.WorkerTasks[i].TimeInHours * 1000);

                    Console.WriteLine(worker.WorkerName + " Termino la tarea: " + worker.WorkerTasks[i].Description + " En El piso: " + worker.WorkerTasks[i].FloorNumber + " Le tomó: " + worker.WorkerTasks[i].TimeInHours + " horas.");
                }
            }));
        }

        foreach (Thread t in threads)
        {
            t.Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine("Hasta mañana");
    }
}
