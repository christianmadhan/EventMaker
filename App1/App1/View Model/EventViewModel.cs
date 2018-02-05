using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using App1.Common;
using App1.Model;
using App1.View;

namespace App1.View_Model
{
    class EventViewModel : NotifyChanged
    {
        // Saves the event that the user selects to this variable.
        public Event _selectedEvent;

        // Everytime the user switch pages this method handles the navigation
        private readonly FrameNavigate _frameNavigate;

        /* This is sort of a private eventlist, we have this, so we can set the 
         * Globat singleton to this list
         */
        public ObservableCollection<Event> EventList { get; set; }

        // The global variable
        private EventCatalogSingleton _singleton = EventCatalogSingleton.GetInstance();

        //--------------------------------------------------------------------
        // Handles the navigation
        public RelayCommand GoToCreateEventPage { get; set; }

        public RelayCommand DeleteEvent { get; set; }

        public Event SelectedEvent
        {
            get => _selectedEvent;
            set
            {
                _selectedEvent = value;
                OnPropertyChanged(nameof(SelectedEvent));
            }
        }
        //-------------------------------------------------------------------

        /* When the constructer is called we set the Evenlist to
         * the Global singleton list and we bind the view to the Eventlist
         * and that is why we can see all the data from the list in every page.
         */

        public EventViewModel()
        {
            try
            {
                EventList = new ObservableCollection<Event>();

                var events = _singleton.GetEventList();

                EventList = events;

            }
            catch (Exception e)
            {
                var dialog = new MessageDialog(e.Message);
            }

            SelectedEvent = new Event();

            GoToCreateEventPage = new RelayCommand(DoGoToCreatePage);
            DeleteEvent = new RelayCommand(DoDeleteEvent);

            _selectedEvent = new Event();
            _frameNavigate = new FrameNavigate();

        }


        // RelayCommand Methods
        public void DoGoToCreatePage()
        {
            Type type = typeof(CreateEventPage);
            _frameNavigate.ActivateFrameNavigation(type);
        }

        public void DoDeleteEvent()
        {
            if (SelectedEvent == null)
            {
                var dialog = new MessageDialog("You have to pick an Event to delete");
            }
            else
            {
               _singleton.GetEventList().Remove(SelectedEvent);
            }
            
        }

    }
}
