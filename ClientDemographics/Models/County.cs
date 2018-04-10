using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Models
{
    public class County
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public bool InServiceArea { get; set; }
    }
}