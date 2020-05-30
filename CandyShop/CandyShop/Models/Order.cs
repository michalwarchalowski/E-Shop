using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Please enter yor first name")]
        [Display(Name ="FirstName Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter yor Last name")]
        [Display(Name = "LastName Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter yor Address")]
        [Display(Name = "Street Address")]
        [StringLength(25)]
        public int Address { get; set; }


        [Required(ErrorMessage = "Please enter yor City")]
        public int City { get; set; }

        [Required(ErrorMessage = "Please enter yor state")]
        [StringLength(2,MinimumLength =2)]
        public int State { get; set; }


        [Required(ErrorMessage = "Please enter yor ZipCode")]
        [StringLength(5, MinimumLength = 5)]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter yor ZipCode")]
[DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
