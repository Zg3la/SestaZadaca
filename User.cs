using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public class User : INotifiable
    {
        public void PushNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
