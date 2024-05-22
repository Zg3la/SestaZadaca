using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    //prvi primjer je primjer Promatrača koji pripada skupini obrazaca ponašanja.
    public interface INotifiable
    {
        public void PushNotification(string message);
    }
}
