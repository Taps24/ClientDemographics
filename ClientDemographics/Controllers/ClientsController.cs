using ClientDemographics.Models;
using ClientDemographics.ViewModels;
using ClientDemographics.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClientDemographics.Controllers
{
    public class ClientsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        
        // GET: Clients
        [HttpGet]
        public ActionResult Index()
        {
            ClientIndexViewModel model = new ClientIndexViewModel();
            model.Clients = ClientManager.GetAll();
            return View(model);
        }

        // GET: Clients/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var client = ClientManager.GetById(id);
            var model = new EditClientViewModel()
            {
                ID = client.ID,
                ClientFirstName = client.ClientFirstName,
                ClientMiddleInitial = client.ClientMiddleInitial,
                ClientLastName = client.ClientLastName,
                DateofBirth = client.DateofBirth,
                DateofFirstContact = client.DateofFirstContact,
                Address1 = client.Address1,
                Address2 = client.Address2,
                City = client.City,
                Phone = client.Phone,
                ZipCode = client.ZipCode,
                EmergencyContactName = client.EmergencyContactName,
                EmergencyContactPhone = client.EmergencyContactPhone,
                EthnicityId = client.EthnicityId,
                ClientNumber = client.ClientNumber,
                CountyOfResidenceId = client.CountyOfResidenceId,
                CountyOfIncidentId = client.CountyOfIncidentId,
                StateId = client.StateId,
                GenderId = client.GenderId
            };

            var ethnicityName = EthnicityManager.GetById(client.EthnicityId);

            model.EthnicityName = ethnicityName.EthnicityName;

            var clientDemographics = DemographicManager.GetForClient(id);
            var checkBoxListItems = new List<CheckBoxListItem>();

            foreach (var demographic in clientDemographics)
            {
                checkBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = demographic.DemographicId,
                    Display = demographic.DemographicName,
                    IsChecked = clientDemographics.Where(x => x.DemographicId == demographic.DemographicId).Any()
                });
            };

            model.Demographics = checkBoxListItems;

            var clientAbuseType = AbuseTypeManager.GetForClient(id);
            var abuseTypeCheckBoxListItems = new List<CheckBoxListItem>();

            foreach (var abuseType in clientAbuseType)
            {
                abuseTypeCheckBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = abuseType.AbuseTypeId,
                    Display = abuseType.AbuseTypeName,
                    IsChecked = clientAbuseType.Where(x => x.AbuseTypeId == abuseType.AbuseTypeId).Any()
                });
            };

            model.AbuseTypes = abuseTypeCheckBoxListItems;       

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateClientViewModel model = new CreateClientViewModel();
            var allEthnicities = EthnicityManager.GetAll();
            var allDemographics = DemographicManager.GetAll();
            var allAbuseTypes = AbuseTypeManager.GetAll();
            var allCounties = CountyManager.GetAll();
            var allServiceCounties = CountyManager.GetInServiceArea();
            var allTypes = TypeManager.GetAll();
            var allStates = StateManager.GetAll();
            var allGenders = GenderManager.GetAll();
            var allStatuses = StatusManager.GetAll();

            var checkBoxListItems = new List<CheckBoxListItem>();
            var abuseTypeCheckBoxListItems = new List<CheckBoxListItem>();

            model.Ethnicities = allEthnicities;
            model.CountyOfResidence = allCounties;
            model.CountyOfIncident = allServiceCounties;
            model.Genders = allGenders;
            model.Types = allTypes;
            model.States = allStates;
            model.Statuses = allStatuses;

            foreach (var demographic in allDemographics)
            {
                checkBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = demographic.DemographicId,
                    Display = demographic.DemographicName,
                    IsChecked = false //On the add view, no genres will be selected by default
                });
            }

            model.Demographics = checkBoxListItems;

            foreach (var abuseType in allAbuseTypes)
            {
                abuseTypeCheckBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = abuseType.AbuseTypeId,
                    Display = abuseType.AbuseTypeName,
                    IsChecked = false //On the add view, no genres will be selected by default
                });
            }

            model.AbuseTypes = abuseTypeCheckBoxListItems;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateClientViewModel model)
        {
            var selectedDemographics = model.Demographics.Where(x => x.IsChecked).Select(x => x.ID).ToList();
            var selectedAbuseTypes = model.AbuseTypes.Where(x => x.IsChecked).Select(x => x.ID).ToList();

            if (model.StateId == 0)
            {
                model.StateId = 25;
            }

            ClientManager.Add(model.ClientFirstName, model.ClientMiddleInitial, model.ClientLastName, model.DateofBirth, model.DateofFirstContact, model.Address1, model.Address2, 
                model.City, model.Phone, model.ZipCode, model.EmergencyContactName, model.EmergencyContactPhone, selectedDemographics, selectedAbuseTypes, model.EthnicityId, 
                model.ClientNumber, model.CountyOfResidenceId, model.CountyOfIncidentId, model.StateId, model.TypeId, model.StatusId, model.GenderId);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var client = ClientManager.GetById(id);
            var model = new EditClientViewModel()
            {
                ID = client.ID,
                ClientFirstName = client.ClientFirstName,
                ClientMiddleInitial = client.ClientMiddleInitial,
                ClientLastName = client.ClientLastName,
                DateofBirth = client.DateofBirth,
                DateofFirstContact = client.DateofFirstContact,
                Address1 = client.Address1,
                Address2 = client.Address2,
                City = client.City,
                Phone = client.Phone,
                ZipCode = client.ZipCode,
                EmergencyContactName = client.EmergencyContactName,
                EmergencyContactPhone = client.EmergencyContactPhone,
                EthnicityId = client.EthnicityId,
                ClientNumber = client.ClientNumber,
                CountyOfResidenceId = client.CountyOfResidenceId,
                CountyOfIncidentId = client.CountyOfIncidentId,
                StateId = client.StateId,
                GenderId = client.GenderId,
                TypeId = client.TypeId,
                StatusId = client.StatusId
            };


            var allGenders = GenderManager.GetAll();
            var allEthnicities = EthnicityManager.GetAll();
            var allCounties = CountyManager.GetAll();
            var allStates = StateManager.GetAll();
            var allTypes = TypeManager.GetAll();
            var allStatuses = StatusManager.GetAll();


            model.Genders = allGenders;
            model.Ethnicities = allEthnicities;
            model.CountyOfIncident = allCounties;
            model.CountyOfResidence = allCounties;
            model.States = allStates;
            model.Types = allTypes;
            model.Statuses = allStatuses;

            var clientDemographics = DemographicManager.GetForClient(id);
            var allDemographics = DemographicManager.GetAll();
            var checkBoxListItems = new List<CheckBoxListItem>();
            
            foreach (var demographic in allDemographics)
            {
                checkBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = demographic.DemographicId,
                    Display = demographic.DemographicName,
                    IsChecked = clientDemographics.Where(x => x.DemographicId == demographic.DemographicId).Any()
                });
            };

            model.Demographics = checkBoxListItems;

            var clientAbuseTypes = AbuseTypeManager.GetForClient(id);
            var allAbuseTypes = AbuseTypeManager.GetAll();
            var abuseTypeCheckBoxListItems = new List<CheckBoxListItem>();

            foreach (var abuseType in allAbuseTypes)
            {
                abuseTypeCheckBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = abuseType.AbuseTypeId,
                    Display = abuseType.AbuseTypeName,
                    IsChecked = clientAbuseTypes.Where(x => x.AbuseTypeId == abuseType.AbuseTypeId).Any()
                });
            };

            model.AbuseTypes = abuseTypeCheckBoxListItems;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditClientViewModel model)
        {
            var selectedDemographics = model.Demographics.Where(x => x.IsChecked).Select(x => x.ID).ToList();
            var selectedAbuseTypes = model.AbuseTypes.Where(x => x.IsChecked).Select(x => x.ID).ToList();
            ClientManager.Edit(model.ID, model.ClientFirstName, model.ClientMiddleInitial, model.ClientLastName, model.DateofBirth, model.DateofFirstContact, model.Address1, 
                model.Address2, model.City, model.Phone, model.ZipCode, model.EmergencyContactName, model.EmergencyContactPhone, selectedDemographics, selectedAbuseTypes,
                model.EthnicityId, model.ClientNumber, model.CountyOfResidenceId, model.CountyOfIncidentId, model.StateId, model.TypeId, model.StatusId, model.GenderId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var client = ClientManager.GetById(id);
            var model = new EditClientViewModel()
            {
                ID = client.ID,
                ClientFirstName = client.ClientFirstName,
                ClientLastName = client.ClientLastName
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EditClientViewModel model)
        {
            ClientManager.Delete(model.ID);
            return RedirectToAction("Index");
        }

    }
}