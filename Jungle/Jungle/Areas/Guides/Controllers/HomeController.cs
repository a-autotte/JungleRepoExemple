using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jungle.Areas.Guides.Controllers
{
    [Area("Guides")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Guide> countryList = await _unitOfWork.Guide.GetAllAsync();
            return View(countryList);
        }


    }
}
