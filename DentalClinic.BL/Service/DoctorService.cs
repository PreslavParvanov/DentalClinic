using Microsoft.Extensions.Configuration;
using DentalClinic.BL.Contracts;
using DentalClinic.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DentalClinic.BL.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IConfiguration config;

        public  DoctorService(IConfiguration _config)
        {
            config = _config;
        }
        public async Task<IEnumerable<DoctorViewModel>> GetAll()
        {
            string dataPath = config.GetSection("DataFiles:Doctors").Value;

            string data = await File.ReadAllTextAsync(dataPath);
            return JsonConvert.DeserializeObject<IEnumerable<DoctorViewModel>>(data);
        }
    }
}
