using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataService.Entities
{
    public class Outlet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OutletId { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Name must be 15 characters or less")]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Landmark { get; set; }
        [Required]
        public int AvailableFoodPackets { get; set; }
        [Required]
        public string FoodType { get; set; }
        [Required]
        public int RequiredVolunteers { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }


    }
}
    
    


