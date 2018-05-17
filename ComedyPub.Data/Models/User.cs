namespace ComedyPub.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using ComedyPub.Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        //[Required(ErrorMessage = UserConst.FIRST_NAME)]
        //[Display(Name = UserConst.FIRST_NAME_DISPLAY)]
        //public string UserName { get; set; }
        //
        //[Required(ErrorMessage = UserConst.LAST_NAME)]
        //[Display(Name = UserConst.LAST_NAME_DISPLAY)]
        //public string LastName { get; set; }
        //
        //[Required(ErrorMessage = UserConst.AGE)]
        //public int Age { get; set; }       

        //public IList<Bookmark> FavoriteBookmarks { get; set; }
        //= new List<Bookmark>();

        
        public IList<Content> Posts { get; set; } = new List<Content>();
    }
}
