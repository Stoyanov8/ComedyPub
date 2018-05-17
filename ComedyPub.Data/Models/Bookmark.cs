namespace ComedyPub.Data.Models
{
    using ComedyPub.Common.Enums;
    using System;

    public class Bookmark
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public Content Content { get; set; }

        public string ContentId { get; set; }

        public DateTime Date { get; set; }
    }
}
