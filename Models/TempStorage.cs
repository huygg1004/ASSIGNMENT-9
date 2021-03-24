using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_Movie.Models
{
    public static class TempStorage
    {
        private static List<Movies> applications = new List<Movies>();
        public static IEnumerable<Movies> Applications => applications;
        public static void AddApplication(Movies application)
        {
            applications.Add(application);
        }

       
    }
}
