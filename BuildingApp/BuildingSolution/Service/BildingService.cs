namespace BuildingSolution.Service
{
    internal class BildingService : IBildingService
    {
        private int threadCount;
        public Building CreateBuilding(List<Worker> Workers)
        {
            Building building = new Building(Workers);
            return building;
        }
        public int SetUpDailyWork(Building building)
        {
            List<Thread> threads = new List<Thread>();

            Console.WriteLine("Buen dia gente");

            foreach (var worker in building.Workers)
            {
                threads.Add(new Thread(() =>
                {
                    for (int i = 0; i < worker.WorkerTasks.Count; i++)
                    {
                        Console.WriteLine(worker.WorkerName + " Empezo la tarea: " + worker.WorkerTasks[i].Description + " En El piso: " + worker.WorkerTasks[i].FloorNumber + ".");

                        Thread.Sleep(worker.WorkerTasks[i].TimeInHours * 1000);

                        Console.WriteLine(worker.WorkerName + " Termino la tarea: " + worker.WorkerTasks[i].Description + " En El piso: " + worker.WorkerTasks[i].FloorNumber + " Le tomó: " + worker.WorkerTasks[i].TimeInHours + " horas.");
                    }
                }));
            }

            foreach (Thread t in threads)
            {
                t.Start();
                threadCount++;
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }

            Console.WriteLine("Hasta mañana gente, buen trabajo");
            return threadCount;
        }
    }
}
