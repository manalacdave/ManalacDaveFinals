using ECommerce.Contracts.Columns;
using ECommerce.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DaveManalac.Finals_.Pages;
using ECommerce.Web.Pages.Account;

namespace ECommerce.Web.Pages.Account
{
    public class Login : PageModel
    {
    private readonly ILogger<Login> _logger;
        private readonly IArticlesService _columnsService;

        [BindProperty]
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }

        public Login(ILogger<Login> logger, IArticlesService columnsService)
        {
            _logger = logger;
            _columnsService = columnsService;
        }

        public async Task SignIn(string? columnsName, Guid? columnsId)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, columnsName!),
                new Claim(ClaimTypes.NameIdentifier, columnsId.ToString()!)
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