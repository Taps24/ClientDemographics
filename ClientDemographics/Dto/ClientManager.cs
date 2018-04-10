using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientDemographics.Models;
using System.Data.Entity;

namespace ClientDemographics.Dto
{
    public class ClientManager
    {
        public static List<Client> GetAll()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var clients = _context.Clients.Include(x => x.Demographics)
                                    .Include(x => x.Ethnicity)
                                    .Include(x => x.AbuseTypes)
                                    .Include(x => x.Gender)
                                    .Include(x => x.State)
                                    .Include(x => x.Status)
                                    .Include(x => x.ClientType)
                                    .Include(x => x.CountyOfIncident)
                                    .Include(x => x.CountyOfResidence)
                                    .OrderBy(x => x.ClientLastName)
                                    .ToList();
                return clients;
            }
        }

        public static Client GetById(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var client = _context.Clients.Include(x => x.Demographics)
                                    .Include(x => x.Ethnicity)
                                    .Include(x => x.AbuseTypes)
                                    .Include(x => x.Gender)
                                    .Include(x => x.State)
                                    .Include(x => x.Status)
                                    .Include(x => x.ClientType)
                                    .Include(x => x.CountyOfIncident)
                                    .Include(x => x.CountyOfResidence)
                                    .Where(x => x.ID == id)
                                    .First();
                return client;
            }
        }

        public static void Add(string fname, string minitial, string lname, DateTime dob, DateTime dofc, string address_1, string address_2, string city, 
            string phone, string zipCode,  string emergencyContactName, string emergencyContactPhone, List<int> demographics, List<int> abusetypes, int ethnicityId,
            string ClientNumber, int rCountyId, int iCountyId, int state, int type, int status, int gender)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var client = new Client()
                {
                    ClientFirstName = fname,
                    ClientMiddleInitial = minitial,
                    ClientLastName = lname,
                    DateofBirth = dob,
                    DateofFirstContact = dofc,
                    Address1 = address_1,
                    Address2 = address_2,
                    Phone = phone,
                    City = city,
                    ZipCode = zipCode,
                    EmergencyContactName = emergencyContactName,
                    EmergencyContactPhone = emergencyContactPhone,
                    EthnicityId = ethnicityId,
                    ClientNumber = ClientNumber,
                    CountyOfResidenceId = rCountyId,
                    CountyOfIncidentId = iCountyId,
                    StateId = state,
                    StatusId = status,
                    TypeId = type,
                    GenderId = gender
                };

                foreach (var demographicId in demographics)
                {
                    var demographic = _context.Demographics.Find(demographicId);
                    client.Demographics.Add(demographic);
                }

                foreach (var abusetypeId in abusetypes)
                {
                    var abusetype = _context.AbuseTypes.Find(abusetypeId);
                    client.AbuseTypes.Add(abusetype);
                }

                _context.Clients.Add(client);

                _context.SaveChanges();
            }
        }
        
        public static void Edit(int id, string fname, string minitial, string lname, DateTime dob, DateTime dofc, string address_1, string address_2, string city,
            string phone, string zipCode, string emergencyContactName, string emergencyContactPhone, List<int> demographics, List<int> abuseTypes, int ethnicityId,
            string ClientNumber, int rCountyId, int iCountyId, int state, int type, int status, int gender)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var client = _context.Clients.Where(x => x.ID == id).First();

                client.ClientFirstName = fname;
                client.ClientMiddleInitial = minitial;
                client.ClientLastName = lname;
                client.DateofBirth = dob;
                client.DateofFirstContact = dofc;
                client.Address1 = address_1;
                client.Address2 = address_2;
                client.City = city;
                client.Phone = phone;
                client.ZipCode = zipCode;
                client.EmergencyContactName = emergencyContactName;
                client.EmergencyContactPhone = emergencyContactPhone;
                client.EthnicityId = ethnicityId;
                client.ClientNumber = ClientNumber;
                client.CountyOfResidenceId = rCountyId;
                client.CountyOfIncidentId = iCountyId;
                client.StateId = state;
                client.TypeId = type;
                client.StatusId = status;
                client.GenderId = gender;

                client.Demographics.Clear();
                foreach (var demographicId in demographics)
                {
                    var demographic = _context.Demographics.Find(demographicId);
                    client.Demographics.Add(demographic);
                }

                client.AbuseTypes.Clear();
                foreach (var abuseTypeId in abuseTypes)
                {
                    var abuseType = _context.AbuseTypes.Find(abuseTypeId);
                    client.AbuseTypes.Add(abuseType);
                }

                client.EthnicityId = ethnicityId;

                _context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var client = _context.Clients.Where(x => x.ID == id).First();
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}