using System.Web.Mvc;
using MrCMS.Web.Apps.References.Services;
using MrCMS.Web.Apps.References.ModelBinders;
using MrCMS.Web.Apps.References.Models;
using MrCMS.Web.Apps.References.Pages;
using MrCMS.Website.Binders;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.References.Controllers
{
    public class ReferenceController : MrCMSAppUIController<ReferencesApp>
    {
        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public ActionResult Show(ReferenceList page, [IoCModelBinder(typeof(ReferenceModelBinder))]ReferenceSearchModel model)
        {
            ViewData["paged-references"] = _referenceService.GetPagedReferences(page,model);
            return View(page);
        }
    }
}