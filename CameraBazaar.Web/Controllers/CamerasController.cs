
namespace CameraBazaar.Web.Controllers
{
    using CameraBazaar.Web.Models.Cameras;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class CamerasController : Controller
    {
        [Authorize]
        public IActionResult Add() => this.View();

        public IActionResult Add(AddCameraViewModel cameraModel)
        {
            if (!ModelState.IsValid)
            {
                return View(cameraModel);
            }
            return RedirectToAction(nameof(HomeController), "Home");
        }
    }
}
