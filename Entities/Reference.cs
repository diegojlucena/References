using System;
using System.ComponentModel.DataAnnotations;
using MrCMS.Entities;
using MrCMS.Web.Apps.References.Pages;

namespace MrCMS.Web.Apps.References.Entities
{
    public class Reference : SiteEntity
    {
        public Reference()
        {
            Date = DateTime.Today;
        }
        [Required]
        [MaxLength(500)]
        public virtual string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public virtual string Subject { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime Date { get; set; }

        [Required]
        public virtual string UrlPath { get; set; }

        public virtual ReferenceList ReferenceList { get; set; }
    }
}