using System.Web.Mvc;
using MrCMS.Web.Apps.References.Entities;
using MrCMS.Web.Apps.References.Pages;
using MrCMS.Web.Apps.References.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.References.Areas.Admin.Controllers
{
    public class ReferenceController : MrCMSAppAdminController<ReferencesApp> 
    {
        private readonly IReferenceService _referenceService;
        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        [HttpGet]
        public PartialViewResult Add(ReferenceList referencePage)
        {
            return PartialView(new Reference { ReferenceList = referencePage });
        }

        [HttpPost]
        [ActionName("Add")]
        public RedirectToRouteResult Add_POST(Reference item)
        {
            _referenceService.Add(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.ReferenceList.Id });
        }

        [HttpGet]
        public PartialViewResult Edit(Reference item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        public RedirectToRouteResult Edit_POST(Reference item)
        {
            _referenceService.Update(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.ReferenceList.Id });
        }

        [HttpGet]
        public PartialViewResult Delete(Reference item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public RedirectToRouteResult Delete_POST(Reference item)
        {
            _referenceService.Delete(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.ReferenceList.Id });
        }
    }
}