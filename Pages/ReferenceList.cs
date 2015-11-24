using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MrCMS.Entities.Documents.Web;

namespace MrCMS.Web.Apps.References.Pages
{
    public class ReferenceList : Webpage
    {
        [DisplayName("Page Size")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Page size must be a number")]
        [Range(1, 9999)]
        public virtual int PageSize { get; set; }

        [DisplayName("Allow Paging")]
        public virtual bool AllowPaging { get; set; }
    }
}