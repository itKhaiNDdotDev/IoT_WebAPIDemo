using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IoT_WebAPIDemo.Models
{
    public class IoT_WebAPIDemoContext : DbContext
    {
        public IoT_WebAPIDemoContext (DbContextOptions<IoT_WebAPIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<IoT_WebAPIDemo.Models.SensorData> SensorData { get; set; }
    }
}
