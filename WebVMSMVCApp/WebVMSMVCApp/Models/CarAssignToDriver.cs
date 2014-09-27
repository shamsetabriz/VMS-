using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVMSMVCApp.Models
{
    public class CarAssignToDriver
    {
        public int CarAssignToDriverId { set; get; }
        public int CarId { set; get; }
        public int DriverId { set; get; }
        public virtual ICollection<Car> Cars { set; get; }
        public virtual ICollection<Driver> Drivers { set; get; } 
    }
}