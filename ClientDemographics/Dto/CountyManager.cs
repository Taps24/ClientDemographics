using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class CountyManager
    {
        public static List<County> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Counties.OrderBy(model => model.InServiceArea ? 0 : 1).ThenBy(model => model.CountyName).ToList();

            }
        }

        public static List<County> GetInServiceArea()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Counties.Where(model => model.InServiceArea == true).OrderBy(model => model.CountyName).ToList();

            }
        }
    }
}