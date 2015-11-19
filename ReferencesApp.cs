using MrCMS.Apps;
using Ninject;

namespace MrCMS.Web.Apps.References
{
    public class ReferencesApp : MrCMSApp
    {
        public override string AppName
        {
            get { return "References"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        protected override void RegisterServices(IKernel kernel)
        {
            
        }

        protected override void RegisterApp(MrCMSAppRegistrationContext context)
        {
        }
    }
}