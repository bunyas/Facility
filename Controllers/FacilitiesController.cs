using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using SyncfusionASPNETCoreApplication2.Models;

namespace SyncfusionASPNETCoreApplication2.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly MEDICALACCESSContext _context;

        public FacilitiesController(MEDICALACCESSContext context)
        {
            _context = context;
        }

        // GET: Facilities
        public async Task<IActionResult> Index()
        {
            var mEDICALACCESSContext = _context.AFacilities.Include(a => a.Cdcregion).Include(a => a.ClientTypeCodeNavigation).Include(a => a.ComprehensiveImplimentingPartnerCodeNavigation).Include(a => a.DeliveryZoneCodeNavigation).Include(a => a.DistrrictCodeNavigation).Include(a => a.FacilityType).Include(a => a.LevelOfCareNavigation).Include(a => a.Ownership).Include(a => a.PatientLoadCodeNavigation).Include(a => a.Village);
            return View(await mEDICALACCESSContext.ToListAsync());
        }

        // GET: Facilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aFacilities = await _context.AFacilities
                .Include(a => a.Cdcregion)
                .Include(a => a.ClientTypeCodeNavigation)
                .Include(a => a.ComprehensiveImplimentingPartnerCodeNavigation)
                .Include(a => a.DeliveryZoneCodeNavigation)
                .Include(a => a.DistrrictCodeNavigation)
                .Include(a => a.FacilityType)
                .Include(a => a.LevelOfCareNavigation)
                .Include(a => a.Ownership)
                .Include(a => a.PatientLoadCodeNavigation)
                .Include(a => a.Village)
                .FirstOrDefaultAsync(m => m.FacilityCode == id);
            if (aFacilities == null)
            {
                return NotFound();
            }

            return View(aFacilities);
        }

        // GET: Facilities/Create
        public IActionResult Create()
        {
            ViewData["CdcregionId"] = new SelectList(_context.ACdcregion, "CdcregionId", "CdcregionId");
            ViewData["ClientTypeCode"] = new SelectList(_context.AClientType, "ClientTypeCode", "ClientTypeCode");
            ViewData["ComprehensiveImplimentingPartnerCode"] = new SelectList(_context.AImplimentingPartners, "ImplimentingPartnerCode", "ImplimentingPartnerCode");
            ViewData["DeliveryZoneCode"] = new SelectList(_context.ADeliveryZone, "ZoneCode", "ZoneCode");
            ViewData["DistrrictCode"] = new SelectList(_context.ADistrict, "DistrictCode", "DistrictCode");
            ViewData["FacilityTypeId"] = new SelectList(_context.AFacilityType, "FacilityTypeId", "FacilityTypeId");
            ViewData["LevelOfCare"] = new SelectList(_context.AFacilityLevelOfCare, "LevelOfCareCode", "LevelOfCareCode");
            ViewData["OwnershipId"] = new SelectList(_context.AOwnership, "OwnershipId", "OwnershipId");
            ViewData["PatientLoadCode"] = new SelectList(_context.APatientLoad, "PatientLoadCode", "PatientLoadCode");
            ViewData["VillageId"] = new SelectList(_context.AVillage, "VillageId", "VillageId");
            return View();
        }

        // POST: Facilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacilityCode,DeliveryZoneCode,ImplimentingPartnerCode,DistrrictCode,Facility,SapCode,SupportedByMaul,IsAccredited,LevelOfCare,ClientTypeCode,RegionCode,RfsoUserName,OwnershipId,CdcregionId,FacilityTypeId,Longtitude,Latititude,VillageId,ComprehensiveImplimentingPartnerCode,PatientLoadCode,IsActive,NearestPublicHfDistance,Dsdm,ActiveArt")] AFacilities aFacilities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aFacilities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdcregionId"] = new SelectList(_context.ACdcregion, "CdcregionId", "CdcregionId", aFacilities.CdcregionId);
            ViewData["ClientTypeCode"] = new SelectList(_context.AClientType, "ClientTypeCode", "ClientTypeCode", aFacilities.ClientTypeCode);
            ViewData["ComprehensiveImplimentingPartnerCode"] = new SelectList(_context.AImplimentingPartners, "ImplimentingPartnerCode", "ImplimentingPartnerCode", aFacilities.ComprehensiveImplimentingPartnerCode);
            ViewData["DeliveryZoneCode"] = new SelectList(_context.ADeliveryZone, "ZoneCode", "ZoneCode", aFacilities.DeliveryZoneCode);
            ViewData["DistrrictCode"] = new SelectList(_context.ADistrict, "DistrictCode", "DistrictCode", aFacilities.DistrrictCode);
            ViewData["FacilityTypeId"] = new SelectList(_context.AFacilityType, "FacilityTypeId", "FacilityTypeId", aFacilities.FacilityTypeId);
            ViewData["LevelOfCare"] = new SelectList(_context.AFacilityLevelOfCare, "LevelOfCareCode", "LevelOfCareCode", aFacilities.LevelOfCare);
            ViewData["OwnershipId"] = new SelectList(_context.AOwnership, "OwnershipId", "OwnershipId", aFacilities.OwnershipId);
            ViewData["PatientLoadCode"] = new SelectList(_context.APatientLoad, "PatientLoadCode", "PatientLoadCode", aFacilities.PatientLoadCode);
            ViewData["VillageId"] = new SelectList(_context.AVillage, "VillageId", "VillageId", aFacilities.VillageId);
            return View(aFacilities);
        }

        // GET: Facilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aFacilities = await _context.AFacilities.FindAsync(id);
            if (aFacilities == null)
            {
                return NotFound();
            }
            ViewData["CdcregionId"] = new SelectList(_context.ACdcregion, "CdcregionId", "CdcregionId", aFacilities.CdcregionId);
            ViewData["ClientTypeCode"] = new SelectList(_context.AClientType, "ClientTypeCode", "ClientTypeCode", aFacilities.ClientTypeCode);
            ViewData["ComprehensiveImplimentingPartnerCode"] = new SelectList(_context.AImplimentingPartners, "ImplimentingPartnerCode", "ImplimentingPartnerCode", aFacilities.ComprehensiveImplimentingPartnerCode);
            ViewData["DeliveryZoneCode"] = new SelectList(_context.ADeliveryZone, "ZoneCode", "ZoneCode", aFacilities.DeliveryZoneCode);
            ViewData["DistrrictCode"] = new SelectList(_context.ADistrict, "DistrictCode", "DistrictCode", aFacilities.DistrrictCode);
            ViewData["FacilityTypeId"] = new SelectList(_context.AFacilityType, "FacilityTypeId", "FacilityTypeId", aFacilities.FacilityTypeId);
            ViewData["LevelOfCare"] = new SelectList(_context.AFacilityLevelOfCare, "LevelOfCareCode", "LevelOfCareCode", aFacilities.LevelOfCare);
            ViewData["OwnershipId"] = new SelectList(_context.AOwnership, "OwnershipId", "OwnershipId", aFacilities.OwnershipId);
            ViewData["PatientLoadCode"] = new SelectList(_context.APatientLoad, "PatientLoadCode", "PatientLoadCode", aFacilities.PatientLoadCode);
            ViewData["VillageId"] = new SelectList(_context.AVillage, "VillageId", "VillageId", aFacilities.VillageId);
            return View(aFacilities);
        }

        // POST: Facilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FacilityCode,DeliveryZoneCode,ImplimentingPartnerCode,DistrrictCode,Facility,SapCode,SupportedByMaul,IsAccredited,LevelOfCare,ClientTypeCode,RegionCode,RfsoUserName,OwnershipId,CdcregionId,FacilityTypeId,Longtitude,Latititude,VillageId,ComprehensiveImplimentingPartnerCode,PatientLoadCode,IsActive,NearestPublicHfDistance,Dsdm,ActiveArt")] AFacilities aFacilities)
        {
            if (id != aFacilities.FacilityCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aFacilities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AFacilitiesExists(aFacilities.FacilityCode))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdcregionId"] = new SelectList(_context.ACdcregion, "CdcregionId", "CdcregionId", aFacilities.CdcregionId);
            ViewData["ClientTypeCode"] = new SelectList(_context.AClientType, "ClientTypeCode", "ClientTypeCode", aFacilities.ClientTypeCode);
            ViewData["ComprehensiveImplimentingPartnerCode"] = new SelectList(_context.AImplimentingPartners, "ImplimentingPartnerCode", "ImplimentingPartnerCode", aFacilities.ComprehensiveImplimentingPartnerCode);
            ViewData["DeliveryZoneCode"] = new SelectList(_context.ADeliveryZone, "ZoneCode", "ZoneCode", aFacilities.DeliveryZoneCode);
            ViewData["DistrrictCode"] = new SelectList(_context.ADistrict, "DistrictCode", "DistrictCode", aFacilities.DistrrictCode);
            ViewData["FacilityTypeId"] = new SelectList(_context.AFacilityType, "FacilityTypeId", "FacilityTypeId", aFacilities.FacilityTypeId);
            ViewData["LevelOfCare"] = new SelectList(_context.AFacilityLevelOfCare, "LevelOfCareCode", "LevelOfCareCode", aFacilities.LevelOfCare);
            ViewData["OwnershipId"] = new SelectList(_context.AOwnership, "OwnershipId", "OwnershipId", aFacilities.OwnershipId);
            ViewData["PatientLoadCode"] = new SelectList(_context.APatientLoad, "PatientLoadCode", "PatientLoadCode", aFacilities.PatientLoadCode);
            ViewData["VillageId"] = new SelectList(_context.AVillage, "VillageId", "VillageId", aFacilities.VillageId);
            return View(aFacilities);
        }

        // GET: Facilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aFacilities = await _context.AFacilities
                .Include(a => a.Cdcregion)
                .Include(a => a.ClientTypeCodeNavigation)
                .Include(a => a.ComprehensiveImplimentingPartnerCodeNavigation)
                .Include(a => a.DeliveryZoneCodeNavigation)
                .Include(a => a.DistrrictCodeNavigation)
                .Include(a => a.FacilityType)
                .Include(a => a.LevelOfCareNavigation)
                .Include(a => a.Ownership)
                .Include(a => a.PatientLoadCodeNavigation)
                .Include(a => a.Village)
                .FirstOrDefaultAsync(m => m.FacilityCode == id);
            if (aFacilities == null)
            {
                return NotFound();
            }

            return View(aFacilities);
        }

        // POST: Facilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aFacilities = await _context.AFacilities.FindAsync(id);
            _context.AFacilities.Remove(aFacilities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AFacilitiesExists(int id)
        {
            return _context.AFacilities.Any(e => e.FacilityCode == id);
        }
        public ActionResult Facility()
        {
            var cdcregion = _context.ACdcregion.AsNoTracking().ToArray();
            ViewBag.CDCRegionId = cdcregion;
            var deliveryzone = _context.ADeliveryZone.AsNoTracking().ToArray();
            ViewBag.DeliveryZoneCode = deliveryzone;

            var districts = _context.ADistrict.AsNoTracking().Where(a => a.DistrictName != null).ToArray();
            ViewBag.DistrrictCode = districts;

            var level_of_Care = _context.AFacilityLevelOfCare.AsNoTracking().ToArray();
            ViewBag.level_of_care = level_of_Care;

            var FacilityTypes = _context.AFacilityType.AsNoTracking().ToArray();
            ViewBag.FacilityTypeId = FacilityTypes;

            var ImplimentingPartners = _context.AImplimentingPartners.AsNoTracking().ToArray();
            ViewBag.ComprehensiveImplimentingPartnerCode = ImplimentingPartners;

            var ownerships = _context.AOwnership.AsNoTracking().ToArray();
            ViewBag.OwnershipId = ownerships;

            var client = _context.AClientType.AsNoTracking().ToArray();
            ViewBag.client_type_code = client;

            var users = _context.AspnetUsers.AsNoTracking().ToArray();
            ViewBag.Users = users;

            var patientloads = _context.APatientLoad.AsNoTracking().ToArray();
            ViewBag.PatientLoads = patientloads;

            var scto = _context.FoSctoContactPerson.AsNoTracking().ToArray();
            ViewBag.SCTO = scto;

            var _scto = _context.FoScto.AsNoTracking().ToArray();
            ViewBag._SCTO = _scto;

            var DataSource = _context.ViewAFacility.ToList();
            ViewBag.datasource = DataSource;

            //var a_Facilities = db.A_Facilities.Include(a => a.A_CDCRegion).Include(a => a.A_DeliveryZone).Include(a => a.A_District).Include(a => a.A_Facilities1).Include(a => a.A_Facilities2).Include(a => a.A_Facility_Level_Of_Care).Include(a => a.A_FacilityType).Include(a => a.A_ImplimentingPartners).Include(a => a.A_Ownership);
            return View(/*a_Facilities.ToList()*/);
        }
        public ActionResult DataSourceFacility(DataManager dm)
        {
            IEnumerable data = _context.ViewAFacility.OrderBy(o => o.Facility).ToList();
            int count = _context.ViewAFacility.ToList().Count();

            DataOperations operation = new DataOperations();
            //Performing filtering operation
            if (dm.Where != null)
            {
                data = operation.PerformWhereFilter(data, dm.Where, "and");
                var filtered = (IEnumerable<object>)data;
                count = filtered.Count();
            }
            //Performing search operation
            if (dm.Search != null)
            {
                data = operation.PerformSearching(data, dm.Search);
                var searched = (IEnumerable<object>)data;
                count = searched.Count();
            }
            //Performing sorting operation
            if (dm.Sorted != null)
                data = operation.PerformSorting(data, dm.Sorted);

            //Performing paging operations
            if (dm.Skip != 0)
                data = operation.PerformSkip(data, dm.Skip);
            if (dm.Take != 0)
                data = operation.PerformTake(data, dm.Take);

            return Json(new { result = data, count = count });

        }
    }
}
