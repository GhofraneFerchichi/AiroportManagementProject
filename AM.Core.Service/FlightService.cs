using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using AM.Core.Domain;
namespace AM.Core.Service
{
    internal class FlightService : IFlightService
    {
        public IList<Flight> flights { get; set; }

        public List<DateTime> GetFlightDates(string destination)
               {
            // List<DateTime> dates = new List<DateTime>();
            //foreach (var flight in flights)
            //  {
            //    if (flight.Destination == destination)
            //  {
            //      dates.Add(flight.FlightDate);
            //  }

            // }
            //   return dates;
            // linq integreé //tp 2 quest6
         //   return (from flight in flights
         //          where flight.Destination == destination
         //          select flight.FlightDate).ToList();

            //2éme methode: méthode d'extension de linq
            return flights.Where(f => f.Destination == destination)
                .Select(f=>f.FlightDate).ToList();
        }

        public void GetFlights(string filterType, string filterValue)
        {
           
                if (filterType == "Destination")
                {
                    foreach (var flightt in flights)
                    {
                        if(flightt.Destination==filterType)
                        {
                            Console.WriteLine(flightt.ToString);
                        }
                    }
                }
                if (filterType == "Departure")
                {
                    foreach (var flightt in flights)
                    {
                        if (flightt.Departure == filterType)
                        {
                            Console.WriteLine(flightt.ToString);
                        }
                    }
                }
                if (filterType == "FlightDate")
                {
                    foreach (var flightt in flights)
                    {
                        if ((flightt.FlightDate).ToString() == filterType)
                        {
                            Console.WriteLine(flightt.ToString);
                        }
                    }
                }
                if (filterType == "FlightId")
                {
                    foreach (var flightt in flights)
                    {
                        if ((flightt.FlightId).ToString() == filterType)
                        {
                            Console.WriteLine(flightt.ToString);
                        }
                    }
                }
            if (filterType == "EffectiveArrival")
            {
                foreach (var flightt in flights)
                {
                    if ((flightt.EffectiveArrival).ToString() == filterType)
                        {
                        Console.WriteLine(flightt.ToString);
                    }
                }
            }
            if (filterType == "EstimatedDuration")
            {
                foreach (var flightt in flights)
                {
                    if ((flightt.EstimatedDuration).ToString() == filterType)
                    {
                        Console.WriteLine(flightt.ToString);
                    }
                }
            }
            else Console.WriteLine("Error");
        }
        }
    }


