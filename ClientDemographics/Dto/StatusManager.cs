using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class StatusManager
    {
        public static List<Status> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Statuses.OrderBy(model => model.StatusName).ToList();

            }
        }
    }
}