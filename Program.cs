using System;
using System.Diagnostics;

namespace Zadaca6
{
    public class Client
    {
        public static void Main(string[] args)
        {
            //ZADATAK 1
            INotifiable notifiable = new User();
            INotifiable notifiable1 = new User();
            Channel channel = new Creator();
            channel.Add(notifiable);
            channel.Add(notifiable1);
            channel.Notify("NEW SHOW TONIGHT!");

            //ZADATAK2
            Activity activity = new Activity("RUNNING");
            ConfigurationManager configurationManager = new ConfigurationManager();
            VacationConfigurator vacation = new VacationConfigurator();
            VacationConfiguration vacationConfiguration = vacation.Store();
            configurationManager.AddConfiguration(vacationConfiguration);
            vacation.AddExtra(activity);
            configurationManager.GetConfiguration(0);
            

            //ZADATAK 3

            Handler Five00handler = new FiveHundredHandler();
            Handler Two00handler = new TwoHundredHandler();
            Handler handler = new HundredHandler();
            Five00handler.SetNextHandler(Two00handler);
            Two00handler.SetNextHandler(handler);

            Five00handler.DispatchNote(1800);
            



        }
    }
}
