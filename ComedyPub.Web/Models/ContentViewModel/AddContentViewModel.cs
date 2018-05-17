using ComedyPub.Common.Constants;
using ComedyPub.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace ComedyPub.Web.Models.ContentViewModel
{
    public class AddContentViewModel
    {
        [Required(ErrorMessage = ContentConst.TITLE_REQUIRED)]
        [MinLength(1)]
        public string Title { get; set; }

        [Required(ErrorMessage = ContentConst.TEXT_REQUIRED)]
        [MinLength(1)]
        [Display(Name = ContentConst.CONTENT_DISPLAY_NAME)]
        public string Text { get; set; }

        
        [Display(Name = ContentConst.TYPE_DISPLAY_NAME)]
        public ContentType Type { get; set; }
    }
}
