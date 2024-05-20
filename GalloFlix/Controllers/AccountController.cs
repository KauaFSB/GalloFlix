using System.Net.Mail;
using GalloFlix.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GalloFlix.Controllers;

    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(ILogger<AccountController> logger, 
        SignInManager<IdentityUser> signInManager, 
        UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            LoginVM loginVM = new()
            {
                ReturnUrl = returnUrl ?? Url.Content("~/")
            };
            return View(loginVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {

            }
            return View(login);
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
