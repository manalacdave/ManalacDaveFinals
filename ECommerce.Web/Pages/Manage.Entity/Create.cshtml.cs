using ECommerce.Contracts.Common;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Web.Pages.Manage.Entity
{
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly IEntityService _entityService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Create(ILogger<Create> logger, IEntityService entityService)
        {
            _logger = logger;
            _entityService = entityService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid != true)
                return Page();

            return RedirectPermanent("~/manage/entity/index");
        }

        public class ViewModel
        {
            public string? Entity { get; set; }

        }
    }
}