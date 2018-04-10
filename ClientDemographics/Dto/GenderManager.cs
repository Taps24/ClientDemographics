using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class GenderManager
    {
        public static List<Gender> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Genders.OrderBy(model => model.GenderName).ToList();

            }
        }

        public static Gender GetForClient(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Genders.Where(model => model.GenderId == id).First();
            }
        }

    }
}