using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientDemographics.Models
{
    public class Client
    {
        public Client()
        {
            this.Demographics = new HashSet<Demographic>();
            this.AbuseTypes = new HashSet<AbuseType>();
            //StatusId = 0;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string ClientFirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public string ClientMiddleInitial { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string ClientLastName { get; set; }

        [Display(Name = "Client Number")]
        public string ClientNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateofBirth { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of First Contact")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateofFirstContact { get; set; }

        [Display(Name = "Address")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string ZipCode { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactPhone { get; set; }

        public Ethnicity Ethnicity { get; set; }

        [Display(Name = "Ethnicity")]
        public int EthnicityId { get; set; }

        public Status Status { get; set; }

        [Display(Name = "Status")]
        public int StatusId { get; set; }

        public Type ClientType { get; set; }

        [Display(Name = "Client Type")]
        public int TypeId { get; set; }

        public Gender Gender { get; set; }

        public County County { get; set; }

        public County CountyOfResidence { get; set; }
        public County CountyOfIncident { get; set; }

        [Display(Name = "County of Residence")]
        public int CountyOfResidenceId { get; set; }

        [Display(Name = "County of Incident")]
        public int CountyOfIncidentId { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }

        public State State { get; set; }

        [Display(Name = "State")]
        public int StateId { get; set; }

        public virtual ICollection<AbuseType> AbuseTypes { get; set; }

        public virtual ICollection<Demographic> Demographics { get; set; }
    }
}