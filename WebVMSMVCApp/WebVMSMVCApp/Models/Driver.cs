using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVMSMVCApp.Models
{
    public class Driver
    {
        public enum CurrentStatus
        {
            InJob,
            NotInJob
        }
        public int  DriverId{ get; set; }
        public string DriverName { set; get; }
        public string ContactNo { set; get; }
        public string LiscenceNo { set; get; }
        public string Address { set; get; }
        public double Experience { set; get; }
        public DateTime JoiningDate { set; get; }
        public CurrentStatus Status { set; get; }
        public int CarId { set; get; }
        public virtual  ICollection<Car>  Cars{ set; get; }

       
    }
}