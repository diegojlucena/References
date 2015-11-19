using System.Web.Mvc;
using MrCMS.Web.Apps.References.Models;
using MrCMS.Website.Binders;
using Ninject;

namespace MrCMS.Web.Apps.References.ModelBinders
{
    public class ReferenceModelBinder : MrCMSDefaultModelBinder
    {
        public ReferenceModelBinder(IKernel kernel)
            : base(kernel)
        {
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int page;
            int.TryParse(GetValueFromContext(controllerContext, "page"), out page);

            return new ReferenceSearchModel
                       {
                           Page = page,
                       };
        }
    }
}