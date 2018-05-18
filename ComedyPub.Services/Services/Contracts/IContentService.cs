
using ComedyPub.Common.Enums;
using ComedyPub.Services.Models.Content;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComedyPub.Services.Services.Contracts
{
    public interface IContentService
    {
         Task<ContentViewModel> GetNewest(int currentContentCount);

        Task<bool> Create(string title,string text,ContentType type,string username);

    }
}
