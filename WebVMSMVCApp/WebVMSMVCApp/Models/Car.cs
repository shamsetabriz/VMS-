using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVMSMVCApp.Models
{
    public class Car
    {
        public enum  CarType
        {
            Ac,
            NonAc
        }
        public enum CurrentStatus
        {
         InUse,
         NotInUse   
        }
        [Key]
        public int CarId { set; get; }
        [Required]
        [Display(Name = "Car Name")]
        public string CarName { get; set; }
        [Required]
        [Display(Name = "Select Car Type")]
        public  CarType  TypeOfCar { get; set; }
        [Required]
        [Display(Name = "Car Number")]
        public string CarNumber { set; get; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Purchaching Date")]
        public DateTime PurchachingDate { set; get; }
       
        [Display(Name = "Car Chassis No")]
        public string ChassisNo { set; get; }
        
        public CurrentStatus Status { set; get; }
        public int DriverId { set; get; }
        public virtual ICollection<Driver> Drivers { set; get; }
    }
}