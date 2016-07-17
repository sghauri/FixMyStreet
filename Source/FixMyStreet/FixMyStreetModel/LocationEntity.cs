using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMyStreetModel
{
    public class LocationEntity
    {
        public int LocationId { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// <para>List of addresses that map to this location</para>
        /// <para>A single location may cover or be synonymous of multiple addresses</para>
        /// </summary>
        public List<string> Addresses { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //public Point GPSCoordinate { get; set; }
    }
}
