
namespace MrCMS.Web.Apps.References.Models
{
    public class ReferenceSearchModel
    {
        public ReferenceSearchModel()
        {
            Page = 1;
        }
        public int Page { get; set; }
        public string SearchText { get; set; }
    }
}