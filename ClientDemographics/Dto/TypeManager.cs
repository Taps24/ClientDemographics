using ClientDemographics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientDemographics.Dto
{
    public class TypeManager
    {
        public static List<Models.Type> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Types.OrderBy(model => model.TypeName).ToList();

            }
        }
    }
}