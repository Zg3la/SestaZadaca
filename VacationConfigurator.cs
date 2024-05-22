using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public class VacationConfigurator
    {
        private decimal Price {  get; set; }
        public string Destination { get; private set; }
        private List<Activity> additionalActivities = new List<Activity>();

       

        public void AddExtra(Activity activity)
        {
            additionalActivities.Add(activity);
        }

        public void Remove(Activity activity)
        {
            additionalActivities.Remove(activity);
        }

        public void LoadPrevious(VacationConfiguration configuration)
        {
            Destination = configuration.GetDestination();
            additionalActivities.Clear();
            additionalActivities.AddRange(configuration.GetAdditionalActivities());
        }

        public VacationConfiguration Store()
        {
            return new VacationConfiguration(Destination, additionalActivities);
        }
    }
}
