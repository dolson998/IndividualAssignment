using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Models
{
    public class FriendResponse
    {
        [Key]
        public int ResponseID { get; set; }

        [ForeignKey("AdjectiveID")]
        public int AdjectiveID { get; set; }

        [ForeignKey("ClientID")]
        public int ClientID { get; set; }

        [ForeignKey("FriendID")]
        public int FriendID { get; set; }
    }
}
