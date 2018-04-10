using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class EthnicityManager
    {
        public static List<Ethnicity> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Ethnicities.OrderBy(model => model.EthnicityName).ToList();

            }
        }

        public static Ethnicity GetById(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Ethnicities.Where(model => model.EthnicityId == id).First();
            }
        }
    }
}