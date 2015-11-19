using MrCMS.Paging;
using MrCMS.Web.Apps.References.Entities;

namespace MrCMS.Web.Apps.References.Services
{
    public interface IReferenceService
    {
        void Add(Reference reference);
        void Update(Reference reference);
        void Delete(Reference reference);

        IPagedList<Reference> GetPagedReferences(Pages.ReferenceList page, Models.ReferenceSearchModel model);
    }
}