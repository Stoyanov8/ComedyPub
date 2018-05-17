namespace ComedyPub.Services.Services.Implementations
{
    using ComedyPub.Common.Enums;
    using ComedyPub.Data;
    using ComedyPub.Services.Models.Content;
    using Contracts;
    using System;
    using System.Threading.Tasks;

    public class ContentService : IContentService
    {
        private readonly ComedyPubDbContext db;

        public ContentService(ComedyPubDbContext db)
        {
            this.db = db;
        }

        public Task<bool> Create(string title, string text, string creator, ContentType type)
        {
            throw new NotImplementedException();
        }

        public Task<ContentViewModel> GetNewest()
        {
            throw new NotImplementedException();
        }

    }
}
