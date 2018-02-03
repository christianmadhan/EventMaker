using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1.Model
{
    class EventCatalogSingleton
    {
        public static ObservableCollection<Event> EventList;

        private static EventCatalogSingleton Instance { get; set; }

        private EventCatalogSingleton()
        {
            GetStaticEventList();
        }

        public static void GetStaticEventList()
        {
            EventList = new ObservableCollection<Event>()
            {
                new Event("01-02-2018", DateTime.Now, 2,"Her sker der noget"," Køge festuge"," Køge"),
                new Event("01-02-2018", DateTime.Today, 3,"Danmark sjoveste sted","Holbæk festival","Holbæk"),
                new Event("01-02-2018", DateTime.Now, 2,"Information om rummtet","Journey out into space","Ringsted"),
                new Event("01-02-2018", DateTime.Now, 2,"Lector omkring inflationen","Økonomisk krise i 00'erne "," København H"),

            };
        }

        public static EventCatalogSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EventCatalogSingleton();
            }
            return Instance;
        }

        public void SetEventCatalog(ObservableCollection<Event> eventList)
        {
            EventList = eventList;
        }

        public ObservableCollection<Event> GetEventList()
        {
            return EventList;
        }

        public void ResetEventCatalog()
        {
            GetStaticEventList();
        }



    }
}
