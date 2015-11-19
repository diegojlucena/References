using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using MrCMS.DbConfiguration.Types;
using MrCMS.Web.Apps.References.Entities;

namespace MrCMS.Web.Apps.References.DbConfiguration
{
    public class ReferenceOverride : IAutoMappingOverride<Reference>
    {
        public void Override(AutoMapping<Reference> mapping)
        {
            mapping.Map(faq => faq.UrlPath).CustomType<VarcharMax>().Length(4001);
           
        }
    }
}