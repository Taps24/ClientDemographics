using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientDemographics.Models
{
    public class AbuseType
    {
        public AbuseType()
        {
            this.Clients = new HashSet<Client>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AbuseTypeId { get; set; }

        [Required]
        [Display(Name = "Demographics")]
        public string AbuseTypeName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}