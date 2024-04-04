using JobSearchApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace JobSearchApiDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(new JobSearchViewModel(Occupation_Group.AllGroups));
        }

        [HttpPost]
        public async Task<IActionResult> Index(JobSearchFormViewModel searchJobViewModel)
        {
            var result = await JobSearchApi.JobSearchApiHandler.SearchJobs(searchJobViewModel.SearchPhrase,
                limit: searchJobViewModel.Limit, occupationGroupId: searchJobViewModel.SelectedOccupationGroupId);

            if (result == null)
            {
                throw new Exception("Job search failed.");
            }

            searchJobViewModel.SetOccupationGroups(Occupation_Group.AllGroups);

            return View(new JobSearchViewModel(searchJobViewModel, result));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
