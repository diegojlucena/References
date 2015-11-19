using System;
using System.Collections.Generic;
using MrCMS.Entities.Documents;
using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.References.Pages;

namespace MrCMS.Web.Apps.References.Metadata
{
    public class ReferenceListMetaData : DocumentMetadataMap<ReferenceList>
    {
        public override string WebGetController
        {
            get { return "Reference"; }
        }
        public override string IconClass
        {
            get { return "glyphicon glyphicon-list"; }
        }


        public override ChildrenListType ChildrenListType
        {
            get { return ChildrenListType.WhiteList; }
        }

        public override bool AutoBlacklist
        {
            get { return true; }
        }

        public override IEnumerable<Type> ChildrenList
        {
            get { yield break; }
        }
    }
}

