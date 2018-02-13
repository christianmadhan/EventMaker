using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using App1.Common;
using App1.Model;

namespace App1.EventHandler
{
    class CrudEvent
    {

        EventCatalogSingleton _singleton = EventCatalogSingleton.GetInstance();

        // Method To Create and Update an Event
        public RelayCommand CreateEvent { get; set; }

        public RelayCommand UpdateEvent { get; set; }

        private readonly FrameNavigate _frameNavigate;

        public DateTimeOffset DatePickerValue { get; set; }


        public TimeSpan TimePickerValue { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }


        public CrudEvent()
        {
            CreateEvent = new RelayCommand(DoCreateEvent);
            _frameNavigate = new FrameNavigate();
        }

        public async void DoCreateEvent()
        {
            try
            {

                Dat

                Event _event = new Event();
                _event.PickerDate = DatePickerValue;
                _event.PickerTime = TimePickerValue;
                _event.Id = Id;
                _event.Name = Name;
                _event.Description = Description;
                _event.Place = Place;

                _singleton.GetEventList().Add(_event);
                var dialog = new MessageDialog("The Event is now created");
                await dialog.ShowAsync();

                Type type = typeof(MainPage);
                _frameNavigate.ActivateFrameNavigation(type);

            }
            catch (Exception e)
            {
                var message = new MessageDialog(e.Message);
                await message.ShowAsync();
            }
        }

    }
}
