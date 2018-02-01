using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1.Model
{
    class Event
    {
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

        // Empty constructer for the relay command
        public Event(){}

        // Get and set instance fields.

        public string Date { get => _date; set => _date = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public string Name { get => _name; set => _name = value; }
        public string Place { get => _place; set => _place = value; }

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
