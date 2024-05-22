using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public class Creator : Channel
    {
        List<INotifiable> notifiables;
        public Creator()
        {
            notifiables = new List<INotifiable>();
        }

        public void Add(INotifiable item)
        {
            notifiables.Add(item);
        }
        public void Remove(INotifiable item)
        {
            notifiables.Remove(item);
        }
        public void Notify(string message)
        {
            foreach (INotifiable item in notifiables)
            {
                item.PushNotification(message);
            }
        }
    }
}
