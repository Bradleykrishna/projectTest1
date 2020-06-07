using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace TheRedo.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }
        [Required]
        public string InventoryType { get; set; }
        [Required]
        public string InventoryName { get; set; }
        [Required]
        public string InventoryDescription { get; set; }
        [Required]
        public double InventoryAmount { get; set; }
        [Required]
        public bool InventoryStatus { get; set; }
    }
}