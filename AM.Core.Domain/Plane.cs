using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AM.Core.Domain
{ 
  
    public enum PlaneType
    {
        Boeing=1,
        Airbus=2
    }
    public class Plane
    {  
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }

        public List<Flight> flights { get; set; }

        public Plane()
        {

        }
        /// <summary>
        /// 
        ///Constructeur parametrée
        /// </summary>
        /// <param name="planeType"></param>
        /// <param name="capacity"></param>
        /// <param name="Date"></param>
        public Plane(PlaneType planeType, int capacity, DateTime Date)
        {
            MyPlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = Date;
        }



        public override string ToString()
        {
            return "Capacity: " + Capacity + " ;ManufactureDate: " + ManufactureDate + " ;PlaneId: " + PlaneId + " ;MyPlaneType:" + MyPlaneType;
        }
    }
}
