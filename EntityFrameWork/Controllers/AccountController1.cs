using EntityFrameWork.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork.Controllers
{
    public class AccountController1 : Controller
    {
      [HttpGet]
      public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model) 
        {

            if (!ModelState.IsValid) 
            {
                return View(model);
            }



            return View(model);
        }

    }
}
