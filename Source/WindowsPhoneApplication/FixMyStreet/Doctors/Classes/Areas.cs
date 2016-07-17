using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMyStreet.Classes
{
    public class Areas
    {


        public List<string> ArealList()
        {
            var areaList = new List<string> {"Sector F", "Sector G", "Sector H"};
            return areaList;
        }

        public List<string> ArealDetailSectorF()
        {
            var areaDetail = new List<string> { "F-4", "F-5", "F-6", "F-7", "F-8" };
            return areaDetail;
        }

        public List<string> ArealDetailSectorG()
        {
            var areaDetail = new List<string> { "G-4", "G-5", "G-6", "G-7", "G-8","G-9" };
            return areaDetail;
        }



    }
}
