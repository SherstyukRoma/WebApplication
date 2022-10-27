using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class Repository //Хранилище - выртуальная бд
    {
        private static List<Service> _services = new List<Service>();

        public static void AddService(Service service)
        {
            _services.Add(service);
        }

        public static IEnumerable<Service> Services
        {
            get { return _services; }
        }
    }
}
