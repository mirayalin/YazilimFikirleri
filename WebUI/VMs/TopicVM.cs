using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.VMs
{
    public class TopicVM:BaseEntity
    {
        [AllowHtml]
        [UIHint("tinymce_jquery_full")]
        public string Body { get; set; }
    }
}