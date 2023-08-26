using ECommerce.Contracts.Columns;
using ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;

namespace DaveManalac.Finals_.Pages
{
    internal interface IArticlesService
    {
        List<ArticlesDto> GetAll();
    }
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IArticlesService _articlesService;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public void OnGet()
        {
            this.Columns = _articlesService.GetAll();
        }
        public List<ArticlesDto> Columns { get; set; }
    }
}