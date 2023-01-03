using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSolution.Service
{
    internal interface IWorkerDataLoader
    {
        List<Worker> GetWorkers();
    }
}
