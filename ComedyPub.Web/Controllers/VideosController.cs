namespace ComedyPub.Web.Controllers
{
    using ComedyPub.Services.Services.Contracts;
    using Microsoft.AspNetCore.Mvc;

    public class VideosController : Controller
    {
        private readonly IVideosService service;

        public VideosController(IVideosService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {            
            return this.View();
        }       
        
    }
}
