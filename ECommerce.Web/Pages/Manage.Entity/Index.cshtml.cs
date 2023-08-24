using ECommerce.Contracts.Common;
using ECommerce.Contracts.Columns;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Web.Pages.Manage.Entity
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IEntityService _entityService;

        [BindProperty]
        public ViewModel Data { get; set; }
        public Index(ILogger<Index> logger, IEntityService entityService)
        {
            _logger = logger;
            _entityService = entityService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet(int? pageIndex = 1, int? pageSize = 10, string? sortBy = "", string? keyword = "")
        {
            Data.Entity = _entityService.Search(pageIndex, pageSize, sortBy, keyword);
        }

        public class ViewModel
        {
     
            public string? Entity { get; set; }
            public string? Items { get; set; }
        }
    }

    public interface IEntityService
    {
        string? Search(int? pageIndex, int? pageSize, string? sortBy, string? keyword);
    }
}
