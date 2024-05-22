using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public interface Channel
    {
        public void Add(INotifiable notifiable);
        public void Remove(INotifiable notifiable);
        public void Notify(string message);
    }
}
