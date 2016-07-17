using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMyStreetDAL
{
    interface IGenericDataReader<T>
    {
        List<T> GetList();
    }
}
