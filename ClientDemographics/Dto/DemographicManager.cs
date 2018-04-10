using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientDemographics.Models;

namespace ClientDemographics.Dto
{
    public static class DemographicManager
    {
        public static List<Demographic> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Demographics.OrderBy(model => model.DemographicName).ToList();
            }
        }

        public static Demographic GetById(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Demographics.Where(model => model.DemographicId == id).First();
            }
        }

        public static List<Demographic> GetForClient(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Clients.Where(model => model.ID == id).First().Demographics.ToList();
            }
        }
    }
}