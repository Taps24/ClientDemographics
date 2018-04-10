using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientDemographics.Models;

namespace ClientDemographics.Dto
{
    public static class AbuseTypeManager
    {
        public static List<AbuseType> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.AbuseTypes.OrderBy(model => model.AbuseTypeName).ToList();
            }
        }

        public static AbuseType GetById(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.AbuseTypes.Where(model => model.AbuseTypeId == id).First();
            }
        }

        public static List<AbuseType> GetForClient(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Clients.Where(model => model.ID == id).First().AbuseTypes.ToList();
            }
        }
    }
}