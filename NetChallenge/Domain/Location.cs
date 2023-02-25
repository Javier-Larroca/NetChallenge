using System.Collections.Generic;

namespace NetChallenge.Domain
{
    public class Location
    {
        public string Name { get; set; }
        public string Neighborhood { get; set; }
        public IEnumerable<Office> Office { get; set; }
    }
}