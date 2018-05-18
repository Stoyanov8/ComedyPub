namespace ComedyPub.Web.Controllers
{
    using ComedyPub.Web.Models.ContentViewModel;
    using ComedyPub.Services.Services.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using ComedyPub.Common.Constants;

    [Authorize]
    public class ContentController : Controller
    {
        private readonly IContentService service;
        public ContentController(IContentService service)
        {
            this.service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(int currentContentCount)
        {
            var model = await this.service.GetNewest(currentContentCount);
            return this.View(model);
        }      

        public IActionResult Create() => this.View();

        [HttpPost]
        public async Task<IActionResult> Create(AddContentViewModel model)
        {
            var username = this.User.Identity.Name;

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var succes = await this.service.Create(model.Title, model.Text, model.Type, username);

            if (succes)
            {
                this.ViewData[ContentConst.SUCCESS] = ContentConst.ADD_SUCCESS;
                return this.RedirectToAction(nameof(Index));
            }

            return this.View(model);
        }
    }
}
