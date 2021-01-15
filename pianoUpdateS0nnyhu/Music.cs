using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pianoUpdateS0nnyhu
{
    class Music
    {
        private String title;
        private String origin;
        private String duration;
        private String completed;
        private String link;
        private String credit;
        private String mid;
        private String mp3;

        public Music(string title, string origin, string duration, string completed, string link, string credit, string mid, string mp3)
        {
            this.title = title;
            this.origin = origin;
            this.duration = duration;
            this.completed = completed;
            this.link = link;
            this.credit = credit;
            this.mid = mid;
            this.mp3 = mp3;
        }

        public string Title { get => title; set => title = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Completed { get => completed; set => completed = value; }
        public string Link { get => link; set => link = value; }
        public string Credit { get => credit; set => credit = value; }
        public string Mid { get => mid; set => mid = value; }
        public string Mp3 { get => mp3; set => mp3 = value; }
    }
}
