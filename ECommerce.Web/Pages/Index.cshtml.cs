using ECommerce.Contracts.Columns;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;

namespace NeilMacabulos.Finals_.Pages
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IArticlesService _categoriesService;
        public Index(ILogger<Index> logger, IArticlesService columnsService)
        {
            _logger = logger;
            _categoriesService = columnsService;
        }

        public void OnGet()
        {
            this.Categories = _columnsService.GetAll();
        }

        public List<ArticlesDto> Columns { get; set; }
        public class ViewModel
        {
            public ArticlesDto? Columns { get; set; }
        }

    }
}