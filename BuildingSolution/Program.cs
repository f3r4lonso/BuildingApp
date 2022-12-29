using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;
using static Program;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Worker> workers = Repository.Service.LoadData.LoadDataFromJson();

        Building building = new Building(workers);

        building.SetUpDailyWork();
    }
}