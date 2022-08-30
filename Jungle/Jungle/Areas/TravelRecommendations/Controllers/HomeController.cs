using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jungle.Areas.TravelRecommendations.Controllers
{
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
            IEnumerable<TravelRecommendation> countryList = await _unitOfWork.TravelRecommendation.GetAllAsync();
            return View(countryList);
        }
    }
}
