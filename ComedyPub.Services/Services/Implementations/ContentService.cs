namespace ComedyPub.Services.Services.Implementations
{
    using ComedyPub.Common.Enums;
    using ComedyPub.Data;
    using ComedyPub.Data.Models;
    using ComedyPub.Services.Models.Content;
    using Contracts;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ContentService : IContentService
    {
        private readonly ComedyPubDbContext db;

        public ContentService(ComedyPubDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> Create(string title, string text, ContentType type, string username)
        {
            try
            {
                var user = await this.db
               .Users
               .SingleOrDefaultAsync(u => u.UserName == username);

                if (type == ContentType.Video)
                {
                    text = text.Replace("watch?v=", "embed/");
                }

                await db.Content.AddAsync(new Content
                {
                    Title = title,
                    Text = text,
                    Creator = user,
                    CreatorId = user.Id,
                    Claps = 0,
                    Date = DateTime.Now,
                    Type = type
                });
                await this.db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public async Task<ContentViewModel> GetNewest(int currentContentCount)
        {
            var content = await this.db.Content
                    .Skip(currentContentCount)
                    .Select(c => new ContentModel
                    {
                        Id = c.Id,
                        Title = c.Title,
                        Text = c.Text,
                        Claps = c.Claps,
                        Creator = c.Creator.UserName,
                        Type = c.Type.ToString()

                    })
                    .Take(30).ToListAsync();

            content.Reverse();
            var contentToReturn = new ContentViewModel
            {
                AllContent = content,
                currentContentCount = currentContentCount + content.Count
            };

            return contentToReturn;
        }
    }
}
