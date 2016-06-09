using MrCMS.Helpers;
using MrCMS.Paging;
using MrCMS.Web.Apps.References.Entities;
using MrCMS.Web.Apps.References.Models;
using MrCMS.Web.Apps.References.Pages;
using NHibernate;
using NHibernate.Criterion;

namespace MrCMS.Web.Apps.References.Services
{
    public class ReferenceService : IReferenceService
    {
        private readonly ISession _session;

        public ReferenceService(ISession session)
        {
            _session = session;
        }

        public void Add(Reference reference)
        {
            _session.Transact(session => session.Save(reference));
        }

        public void Update(Reference reference)
        {
            _session.Transact(session => session.Update(reference));
        }

        public void Delete(Reference reference)
        {
            _session.Transact(session => session.Delete(reference));
        }

        public IPagedList<Reference> GetPagedReferences(ReferenceList page, ReferenceSearchModel model)
        {
            var query = _session.QueryOver<Reference>()
                               .Where(a => a.ReferenceList == page);

            if(string.IsNullOrEmpty(model.SearchText) == false)
            {
                query = query.Where(r => r.Title.IsInsensitiveLike(model.SearchText, MatchMode.Anywhere) || r.Subject.IsInsensitiveLike(model.SearchText, MatchMode.Anywhere));
            }

            return query.OrderBy(x => x.Date).Desc.Paged(model.Page, page.PageSize);
        }
    }
}