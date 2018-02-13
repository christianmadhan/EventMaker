using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using App1.Common;

namespace App1.Model
{
    class Event : NotifyChanged
    {
        private DateTimeOffset _datePicker;
        private TimeSpan _timePicker;

        private string _date;
        private DateTime _time;
        private int _id;
        private string _description;
        private string _name;
        private string _place;

        public Event(string date, DateTime time, int id, string description, string name, string place)
        {
            _date = date;
            _time = time;
            _id = id;
            _description = description;
            _name = name;
            _place = place;
        }

        public Event(DateTimeOffset datePicker, TimeSpan timePicker, int id, string description, string name, string place)
        {
            _datePicker = datePicker;
            _timePicker = timePicker;
            _id = id;
            _description = description;
            _name = name;
            _place = place;

        }

        // Empty constructer for the relay command
        public Event(){}

        // Get and set instance fields.

        public DateTimeOffset PickerDate
        {
            get => _datePicker;
            set { _datePicker = value; OnPropertyChanged(nameof(PickerDate)); }

        }

        public TimeSpan PickerTime
        {
            get => _timePicker;
            set { _timePicker = value; OnPropertyChanged(nameof(PickerTime)); }
        }

        public string Date { get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
                
            }
        }

        public DateTime Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }
        public int Id { 
           
            get => _id;
            set
            {
                _id = value; 
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Place
        {
            get => _place;
            set { _place = value; OnPropertyChanged(nameof(Place)); }
        }

        /*
         *  Tostring method that returns all the information
         *  about the Event.
         */
        public override string ToString()
        {
            return "Date: " + _date + "\n" +
                   "Time:  " + _time + "\n" +
                   "Id:  " + _id + "\n" +
                   "Name: " + _name + "\n" +
                   "Place:  " + _place + "\n" +
                   "Description:  " + Description;
        }


    }
}
