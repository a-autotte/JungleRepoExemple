using Jungle_DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Jungle_Models.Models;

namespace Jungle.Areas.Countries.Controllers
{
    [Area("Countries")]
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
            IEnumerable<Country> countryList = await _unitOfWork.Country.GetAllAsync();
            return View(countryList);
        }
    }
}
