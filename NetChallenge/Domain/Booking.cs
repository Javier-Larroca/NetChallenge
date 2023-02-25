using System;

namespace NetChallenge.Domain
{
    public class Booking
    {
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}