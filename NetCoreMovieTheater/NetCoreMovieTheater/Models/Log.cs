using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMovieTheater.Models
{
    public class Log
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime LogDate { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Description { get; set; }
    }
}
