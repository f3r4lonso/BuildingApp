using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSolution.Service
{
    internal class WorkerDataLoader : IWorkerDataLoader
    {
        public List<Worker> GetWorkers() 
        {
            List<Worker> workers = Repository.Service.LoadData.LoadDataFromJson();

            return workers;
        }
    }
}
