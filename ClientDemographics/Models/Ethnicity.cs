using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientDemographics.Models
{
    public class Ethnicity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EthnicityId { get; set; }

        [Required]
        [Display(Name = "Ethnicities")]
        public string EthnicityName { get; set; }
    }
}