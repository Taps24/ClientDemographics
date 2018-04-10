using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientDemographics.ViewModels
{
    public class CreateClientViewModel
    {
        [Required]
        [Display(Name = "Client First Name")]
        [StringLength(128, ErrorMessage = "Client Names can only have 128 characters in length.")]
        public string ClientFirstName { get; set; }

        [Required]
        [Display(Name = "Client Last Name")]
        [StringLength(128, ErrorMessage = "Client Names can only have 128 characters in length.")]
        public string ClientLastName { get; set; }

        [Display(Name = "Client Middle Initial")]
        [StringLength(1, ErrorMessage = "The Middle Initial should only be one character in length.")]
        public string ClientMiddleInitial { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }

        [Display(Name = "Date of First Contact")]
        public DateTime DateofFirstContact { get; set; }

        [Display(Name = "Address")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Client Number")]
        public string ClientNumber { get; set; }

        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        [Display(Name = "Emergency Contact Phone")]
        public string EmergencyContactPhone { get; set; }

        [Display(Name = "Demographics")]
        public List<CheckBoxListItem> Demographics { get; set;  }

        [Display(Name = "Abuse Type")]
        public List<CheckBoxListItem> AbuseTypes { get; set; }

        
        public int EthnicityId { get; set; }
        public string EthnicityName { get; set; }
        [Display(Name = "Ethnicity")]
        public List<Ethnicity> Ethnicities { get; internal set; }

        
        public int StateId { get; set; }
        public string StateName { get; set; }
        [Display(Name = "State")]
        public List<State> States { get; internal set; }

        public int CountyOfIncidentId { get; set; }
        public string CountyOfIncidentName { get; set; }

        [Display(Name = "County of Incident")]
        public List<County> CountyOfIncident { get; internal set; }

        public int CountyOfResidenceId { get; set; }
        public string CountyOfResidenceName { get; set; }

        [Display(Name = "County of Residence")]
        public List<County> CountyOfResidence { get; internal set; }

        public int GenderId { get; set; }
        public string GenderName { get; set; }
        [Display(Name = "Gender")]
        public List<Gender> Genders { get; internal set; }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        [Display(Name = "Status")]
        public List<Status> Statuses { get; internal set; }

        public int TypeId { get; set; }
        [Display(Name = "Type")]
        public string TypeName { get; set; }
        public List<Models.Type> Types { get; internal set; }

        public void ClientCreateViewModel()
        {
            Demographics = new List<CheckBoxListItem>();
            AbuseTypes = new List<CheckBoxListItem>();
            StateId = 25;
        }

    }

    public class EditClientViewModel : CreateClientViewModel
    {
        public int ID { get; set; }
    }
}