using AnimalZoo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AnimalZoo.Services
{
    public class ZooService
    {
        private readonly string dataFilePath;

        public ZooService(string dataFilePath)
        {
            this.dataFilePath = dataFilePath;
        }

        public void SaveZoo(Zoo zoo)
        {
            string json = JsonConvert.SerializeObject(zoo, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, json);
        }

        public Zoo LoadZoo()
        {
            if (File.Exists(dataFilePath))
            {
                string json = File.ReadAllText(dataFilePath);
                return JsonConvert.DeserializeObject<Zoo>(json);
            }
            else
            {
                return new Zoo();
            }
        }
    }

}
