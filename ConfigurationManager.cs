using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public class ConfigurationManager
    {
        private List<VacationConfiguration> configurations = new List<VacationConfiguration>();

        public void AddConfiguration(VacationConfiguration configuration)
        {
            configurations.Add(configuration);
        }

        public void DeleteConfiguration(VacationConfiguration configuration)
        {
            configurations.Remove(configuration);
        }

        public VacationConfiguration GetConfiguration(int index)
        {
            return configurations[index];
        }
    }
}
