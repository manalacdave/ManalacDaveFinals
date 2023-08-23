using ECommerce.Contracts.Common;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Web.Pages.Manage.Entity
{
    public class Delete : PageModel
    {
        private readonly ILogger<Delete> _logger;
        private readonly IEntityService _entityService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Delete(ILogger<Delete> logger, IEntityService entityService)
        {
            _logger = logger;
            _entityService = entityService;

            Data = Data ?? new ViewModel();
        }

        public IActionResult OnGet(Guid? id = null)
        {
            if (id == null)
            {
                return RedirectPermanent("~/manage/entity/create");
            }

            else
            {
                return RedirectPermanent("~/manage/entity/create");
            }

        }

        public IActionResult OnPost()
        {
            return RedirectPermanent("~/manage/entity/index");
        }

        public class ViewModel
        {
            public string? Entity { get; set; }
        }
    }
}