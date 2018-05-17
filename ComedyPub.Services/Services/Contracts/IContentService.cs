
using ComedyPub.Common.Enums;
using ComedyPub.Services.Models.Content;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComedyPub.Services.Services.Contracts
{
    public interface IContentService
    {
        Task<ContentViewModel> GetNewest();

        Task<bool> Create(string title,string text,string creator,ContentType type);

    }
}
