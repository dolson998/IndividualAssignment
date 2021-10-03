using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        [ForeignKey("ASPNETUserID")]
        public int ASPNETUserID { get; set; }
    }
}
