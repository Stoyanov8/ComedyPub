using System.Collections.Generic;

namespace ComedyPub.Services.Models.Content
{
    public class ContentViewModel
    {
        public List<ContentModel> AllContent { get; set; }

        public int currentContentCount { get; set; }
    }
}
