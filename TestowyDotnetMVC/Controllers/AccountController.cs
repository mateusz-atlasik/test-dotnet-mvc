using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Code omitted for brevity
        }

        return View(model);
    }
}