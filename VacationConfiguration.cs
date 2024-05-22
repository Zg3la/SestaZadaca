using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public class VacationConfiguration
    {
        private string destination;
        private List<Activity> additionalActivities;
        public VacationConfiguration(string destination, List<Activity> additionalActivities)
        {
            this.destination = destination;
            this.additionalActivities = additionalActivities;   
        }

        public string GetDestination()
        {
            return destination;
        }
        public List<Activity> GetAdditionalActivities()
        {
            return additionalActivities;
        }
    }

}
