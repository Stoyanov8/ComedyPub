namespace ComedyPub.Data.Models
{
    using ComedyPub.Common.Enums;
    using System;

    public class Content
    {
        public string Id { get; set; }       

        public string Text { get; set; }

        public string Title { get; set; }

        public ContentType Type { get; set; }

        public string CreatorId { get; set; }

        public User Creator { get; set; }

        public int Claps { get; set; }

        public DateTime Date { get; set; }
    }
}
