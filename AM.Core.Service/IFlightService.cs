using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    internal interface IFlightService
    {

        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);

    }
}
