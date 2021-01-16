using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pianoUpdateS0nnyhu
{
    class Music
    {
        private string _title;
        private string _origin;
        private string _duration;
        private string _completed;
        private string _link;
        private string _credit;
        private string _mid;
        private string _mp3;

        public Music(string title, string origin, string duration, string completed, string link, string credit, string mid, string mp3)
        {
            this._title = title;
            this._origin = origin;
            this._duration = duration;
            this._completed = completed;
            this._link = link;
            this._credit = credit;
            this._mid = mid;
            this._mp3 = mp3;
        }

        public string title { get { return _title; } set { _title = value; } }
        public string origin { get { return _origin; } set { _origin = value; } }
        public string duration { get { return _duration; } set { _duration = value; } }
        public string completed { get { return _completed; } set { _completed = value; } }
        public string link { get { return _link; } set { _link = value; } }
        public string credit { get { return _credit; } set { _credit = value; } }
        public string mid { get { return _mid; } set { _mid = value; } }
        public string mp3 { get { return _mp3; } set { _mp3 = value; } }

    }
}
