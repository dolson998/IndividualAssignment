using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Models
{
    public class Adjective
    {
        [Key]
        public int AdjectiveID { get; set; }

        [Display(Name ="Adjective Name")]
        public string AdjName { get; set; }

        [Display(Name ="Adjective Definition")]
        public string AdjDefinition { get; set; }

        [Display(Name ="Adjective Type")]
        public bool AdjType { get; set; }
    }
}
