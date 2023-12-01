using Frangao.Areas.Identity.Data;
using Frangao.Data.Models;
using Frangao.Data.Services.Interface;
using Frangao.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Frangao.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IGranjaService _granjaService;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, IGranjaService granjaService)
        {
            _logger = logger;
            _userManager = userManager;
            _granjaService = granjaService;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 8;
            var granjas = await _granjaService.GetPagedGranjasAsync(page, pageSize);
            ViewData["CurrentPage"] = page;
            ViewData["TotalGranjasCount"] = _granjaService.GetTotalGranjasCount();

            return View(granjas);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewFarm([FromBody] Granja NewFarm)
        {
            var newGranja = NewFarm;
            try
            {
                await _granjaService.CreateGranjaAsync(newGranja);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating new Granja");
                return StatusCode(500, "An error occured while creating a new Granja. Please try again later.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] Granja updatedGranja)
        {
            try
            {
                await _granjaService.UpdateGranjaAsync(updatedGranja);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating Granja");
                return StatusCode(500, "An error occurred while updating Granja. Please try again later.");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Invalid ID");
            }

            var success = await _granjaService.DeleteGranjaAsync(id);

            if (success)
            {
                return NoContent(); // 204 No Content 
            }
            else
            {
                return NotFound(); // 404 Not Found 
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
