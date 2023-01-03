using BuildingSolution.Service;

internal class Program
{

    static readonly IBildingService bildingService = new BildingService();

    static readonly IWorkerDataLoader workerDataLoader = new WorkerDataLoader();

    static List<Worker> workers;

    static Building building;

    private static void Main(string[] args)
    {
        workers = workerDataLoader.GetWorkers();

        building = bildingService.CreateBuilding(workers);

        int threadCount = bildingService.SetUpDailyWork(building);
    }
}