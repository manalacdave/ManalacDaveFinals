using ECommerce.Contracts.Categories;
using ECommerce.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Web.Pages.Account
{
    public class Login : PageModel
    {
        private readonly ILogger<Login> _logger;
        private readonly IArticlesService _categoriesService;

        [BindProperty]
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }

        public Login(ILogger<Login> logger, IArticlesService categoriesService)
        {
            _logger = logger;
            _categoriesService = categoriesService;
        }

        public async Task SignIn(string? categoriesName, Guid? categoriesId)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, categoriesName!),
                new Claim(ClaimTypes.NameIdentifier, categoriesId.ToString()!)
            };

            ClaimsPrincipal principal = new(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));

            await HttpContext.SignInAsync(principal, new AuthenticationProperties()
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.Now.AddMinutes(30)
            });
        }

    }
}