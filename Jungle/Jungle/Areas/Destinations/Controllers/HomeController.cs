using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jungle.Areas.Destinations.Controllers
{
    [Area("Destinations")]
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
            IEnumerable<Destination> countryList = await _unitOfWork.Destination.GetAllAsync();
            return View(countryList);
        }


    }
}
