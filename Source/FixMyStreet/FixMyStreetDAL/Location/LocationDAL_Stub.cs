using FixMyStreetModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMyStreetDAL.Location
{
    /// <summary>
    /// Stub class for data access operations related to locations
    /// </summary>
    public class LocationDAL_Stub : IGenericDataReader<LocationEntity>
    {
        /// <summary>
        /// Method to get list of all locations
        /// </summary>
        /// <returns></returns>
        public List<LocationEntity> GetList()
        {
            List<LocationEntity> locations = new List<LocationEntity>();

            locations.Add(new LocationEntity { LocationId = 1, Title = "F-8 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "F-7 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "F-6 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "F-5 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "H-8 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "H-9 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "I-8 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "I-9 Sector", City = "Islamabad", Country = "Pakistan" });
            locations.Add(new LocationEntity { LocationId = 1, Title = "I-10 Sector", City = "Islamabad", Country = "Pakistan" });

            return locations;
        }
    }
}
