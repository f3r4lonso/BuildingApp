public class Building
{
    
    public List<Worker> Workers { get; set; }


    public Building(List<Worker> workers)
    {
        this.Workers = workers;
    }

    
}
