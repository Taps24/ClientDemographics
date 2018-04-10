using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class StateManager
    {
        public static List<State> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.States.OrderBy(model => model.StateName).ToList();

            }
        }
    }
}