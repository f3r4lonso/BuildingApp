using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public static class LoadData
    {
        public static List<Worker> LoadDataFromJson()
        {
            string jsonString;

            List<Worker> workers = new List<Worker>();

            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string jsonPath = Path.Combine(rootPath,"Data", "Data.json");

            using (StreamReader reader = new StreamReader(jsonPath))
            {
                jsonString = reader.ReadToEnd();

                workers = JsonConvert.DeserializeObject<List<Worker>>(jsonString);
            }

            return workers;
        }
    }
}
